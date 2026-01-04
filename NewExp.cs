function DistributeExpForKilling(%damagedClient)
{
	dbecho($dbechoMode2, "DistributeExpForKilling(" @ %damagedClient @ ")");

	%dname = Client::getName(%damagedClient);
	%dlvl = fetchData(%damagedClient, "LVL");

	%count = 0;

	//parse $damagedBy and create %finalDamagedBy
	%nameCount = 0;
	%listCount = 0;
	%total = 0;
	for(%i = 1; %i <= $maxDamagedBy; %i++)
	{
		if($damagedBy[%dname, %i] != "")
		{
			%listCount++;

			%n = GetWord($damagedBy[%dname, %i], 0);
			%d = GetWord($damagedBy[%dname, %i], 1);

			%flag = 0;
			for(%z = 1; %z <= %nameCount; %z++)
			{
				if(%finalDamagedBy[%z] == %n)
				{
					%flag = 1;
					%dCounter[%n] += %d;
				}
			}
			if(%flag == 0)
			{
				%nameCount++;
				%finalDamagedBy[%nameCount] = %n;
				%dCounter[%n] = %d;

				%p = IsInWhichParty(%n);
				if(%p != -1)
				{
					%id = GetWord(%p, 0);
					%inv = GetWord(%p, 1);
					if(%inv == -1)
					{
						%tmppartylist[%id] = %tmppartylist[%id] @ %n @ " ";
						if(String::findSubStr(%tmpl, %id @ " ") == -1)
							%tmpl = %tmpl @ %id @ " ";
					}
				}
			}
			%total += %d;
		}
	}

	//clear $damagedBy
	for(%i = 1; %i <= $maxDamagedBy; %i++)
		$damagedBy[%dname, %i] = "";

	//parse thru all tmppartylists and determine the number of same party members involved in exp split
	for(%w = 0; (%a = GetWord(%tmpl, %w)) != -1; %w++)
	{
		%n = CountObjInList(%tmppartylist[%a]);
		for(%ww = 0; (%aa = GetWord(%tmppartylist[%a], %ww)) != -1; %ww++)
			%partyFactor[%aa] = %n;
	}

	//distribute exp
	for(%i = 1; %i <= %nameCount; %i++)
	{
		if(%finalDamagedBy[%i] != "")
		{
			%listClientId = NEWgetClientByName(%finalDamagedBy[%i]);

			%slvl = fetchData(%listClientId, "LVL");

			if(RPG::isAiControlled(%damagedClient))
			{
				if(%slvl > 149)
					%value = 0;
				else
				{
					%f = (149 - %slvl) / 10;
					if(%f < 1) %f = 1;

					%a = (%dlvl - %slvl) + 8;
					%b = %a * %f;
					if(%b < 1) %b = 1;

					%z = %b * 0.10;
					%y = getRandom() * %z;
					%r = %y - (%z / 2);

					%c = %b + %r;

					%value = %c;
				}
			}
			else
			{
				%value = 0;
			}

			//rank point bonus
			if(fetchData(%listClientId, "MyHouse") != "")
			{
				%ph = Cap(GetRankBonus(%listClientId), 1.00, 3.00);
				%value = %value * %ph;
			}

			%perc = %dCounter[%finalDamagedBy[%i]] / %total;
			%final = Cap(round( %value * %perc ), "inf", 1000);

			//determine party exp
			%pf = %partyFactor[%finalDamagedBy[%i]];
			if(%pf != "" && %pf >= 2)
				%pvalue = round(%final * (1.0 + (%pf * 0.1)));
			else
				%pvalue = 0;

			%exp = ReduceExp(%listClientId, %final);			

			storeData(%listClientId, "EXP", %exp, "inc");
			if(%final > 0)
				Client::sendMessage(%listClientId, 0, %dname @ " has died and you gained " @ %exp @ " experience!");
			else if(%exp < 0)
				Client::sendMessage(%listClientId, 0, %dname @ " has died and you lost " @ -%exp @ " experience.");
			else if(%exp == 0)
				Client::sendMessage(%listClientId, 0, %dname @ " has died.");


			if(%pvalue != 0)
			{
				%nval = ReduceExp(%listClientId, %pvalue);
				storeData(%listClientId, "EXP", %nval, "inc");
				Client::sendMessage(%listClientId, $MsgWhite, "You have gained " @ %nval @ " party experience!");
			}

			Game::refreshClientScore(%listClientId);
		}
	}
}


function ReduceExp(%clientId, %final)
{
			%rl =(fetchdata(%clientId, "RemortStep") - 1);
			%redfinal = ((%final * 0.005) * %rl);
			%newfinal = floor(%final - %redfinal);
			if (%newfinal <= 0)
					%newfinal = 0;
			return %newfinal;
}