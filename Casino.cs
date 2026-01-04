// ---------------------------------------
// Tribes RPG Casino!!!
//
// Created by Carling
// 23/10/04
// ---------------------------------------
// Make sure to add Casino.cs to server.cs
// list of files to exec or it will crash 
// server when you try to spawn casino.
// ---------------------------------------
// Casino zone added to map file.
// Extra code added to comchat.cs to
// prevent casting in casino and to send
// bottalk to casino.cs
// ---------------------------------------

// ---------------------------------------
// Variables
// ---------------------------------------
$casino::cost = 20000;		// Cost to play casino per game!

%i=0;	// Don't change this line.

//Changes these to add new posible rewards to the casino!
$casino::reward[%i++] = "COINS 200000";
$casino::reward[%i++] = "COINS -100000";
$casino::reward[%i++] = "SP 40";
$casino::reward[%i++] = "SP -10";
$casino::reward[%i++] = "BrigandineArmor 1";
$casino::reward[%i++] = "ChainMail 1";
$casino::reward[%i++] = "RingMail 1";
$casino::reward[%i++] = "BandedMail 1";
$casino::reward[%i++] = "SplintMail 1";
$casino::reward[%i++] = "BronzePlateMail 1";
$casino::reward[%i++] = "LightRobe 1";
$casino::reward[%i++] = "BloodRobe 1";
$casino::reward[%i++] = "AdvisorRobe 1";
$casino::reward[%i++] = "BootsOfGliding 1";
$casino::reward[%i++] = "WindWalkers 1";
$casino::reward[%i++] = "BroadSword 1";
$casino::reward[%i++] = "WarAxe 1";
$casino::reward[%i++] = "LongSword 1";
$casino::reward[%i++] = "BattleAxe 1";
$casino::reward[%i++] = "MorningStar 1";
$casino::reward[%i++] = "Claymore 1";
$casino::reward[%i++] = "SpikedClub 1";
$casino::reward[%i++] = "Mace 1";
$casino::reward[%i++] = "HammerPick 1";
$casino::reward[%i++] = "WarHammer 1";
$casino::reward[%i++] = "Knife 1";
$casino::reward[%i++] = "ShortSword 1";
$casino::reward[%i++] = "Spear 1";
$casino::reward[%i++] = "Gladius 1";
$casino::reward[%i++] = "Trident 1";
$casino::reward[%i++] = "Rapier 1";
$casino::reward[%i++] = "AwlPike 1";
$casino::reward[%i++] = "LongBow 1";
$casino::reward[%i++] = "LightCrossbow 1";
$casino::reward[%i++] = "HeavyCrossbow 1";
$casino::reward[%i++] = "RepeatingCrossbow 1";
$casino::reward[%i++] = "Tent 1";
$casino::reward[%i++] = "OrbOfLuminance 5";
$casino::reward[%i++] = "OrbOfBreath 5";
$casino::reward[%i++] = "COINS 20000";
$casino::reward[%i++] = "COINS 20000";
$casino::reward[%i++] = "COINS 20000";
$casino::reward[%i++] = "COINS 20000";
$casino::reward[%i++] = "EXP 1000";
$casino::reward[%i++] = "COINS 10";
$casino::reward[%i++] = "COINS 10";
$casino::reward[%i++] = "COINS 10";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "COINS 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "SP 1";
$casino::reward[%i++] = "minotaursteak 2";
$casino::reward[%i++] = "minotaurrib 2";
$casino::reward[%i++] = "dracostooth 2";
$casino::reward[%i++] = "dracosclaw 2";
$casino::reward[%i++] = "dracostooth 2";
$casino::reward[%i++] = "_RareItemDrop";		// Add a few of these to increase the
$casino::reward[%i++] = "_RareItemDrop";
$casino::reward[%i++] = "_RareItemDrop";
$casino::reward[%i++] = "_RareItemDrop";
$casino::reward[%i++] = "_RareItemDrop";
$casino::reward[%i++] = "_RareItemDrop";
$casino::reward[%i++] = "_RareItemDrop";
$casino::reward[%i++] = "_RareItemDrop";
$casino::reward[%i++] = "_RareItemDrop";
$casino::reward[%i++] = "_RareItemDrop";
$casino::reward[%i++] = "_RareItemDrop";




%i=0; //DO NOT CHANGE this line
//These items are dropped less often that above list.
$casino::rare::reward[%i++] = "PhensRobe 1";
$casino::rare::reward[%i++] = "FullPlateArmor 1";
$casino::rare::reward[%i++] = "WarMaul 1";
$casino::rare::reward[%i++] = "ElvenBow 1";
$casino::rare::reward[%i++] = "EXP 5000";
$casino::rare::reward[%i++] = "COINS 500000";
$casino::rare::reward[%i++] = "EXP -2500";
$casino::rare::reward[%i++] = "Jade 300";
$casino::rare::reward[%i++] = "Turquoise 200";
$casino::rare::reward[%i++] = "Ruby 100";
$casino::rare::reward[%i++] = "Topaz 50";
$casino::rare::reward[%i++] = "Keldrinite 1";
$casino::rare::reward[%i++] = "Dragonscale 2";
$casino::rare::reward[%i++] = "BlackRing 1";
$casino::rare::reward[%i++] = "ManaRing 1";
$casino::rare::reward[%i++] = "TalismanMregen 1";
$casino::rare::reward[%i++] = "Mithrilshard 1";
$casino::rare::reward[%i++] = "OrbofXion 5";
$casino::rare::reward[%i++] = "DracosEye 2";
$casino::rare::reward[%i++] = "HeavenlyShield 1";
$casino::rare::reward[%i++] = "HeavenlyWings 1";
$casino::rare::reward[%i++] = "HellsEdge 1";
$casino::rare::reward[%i++] = "Katana 1";
$casino::rare::reward[%i++] = "GnarledStaff 1";
$casino::rare::reward[%i++] = "WizardStaff 1";
$casino::rare::reward[%i++] = "ElvenBlade 1";
$casino::rare::reward[%i++] = "DragonHammer 1";
$casino::rare::reward[%i++] = "DracosBow 1";
$casino::rare::reward[%i++] = "FireBreath 1";
$casino::rare::reward[%i++] = "ArkemnsRobe 1";
$casino::rare::reward[%i++] = "silverbrooch 1";

%i=0;	// Dont change this section, it definds the cards!!
$HiLow::Card[%i++] = "Ace";
$HiLow::Card[%i++] = "2";
$HiLow::Card[%i++] = "3";
$HiLow::Card[%i++] = "4";
$HiLow::Card[%i++] = "5";
$HiLow::Card[%i++] = "6";
$HiLow::Card[%i++] = "7";
$HiLow::Card[%i++] = "8";
$HiLow::Card[%i++] = "9";
$HiLow::Card[%i++] = "10";
$HiLow::Card[%i++] = "Jack";
$HiLow::Card[%i++] = "Queen";
$HiLow::Card[%i++] = "King";

%i=0;
$HiLow::Suit[%i++] = "Hearts";
$HiLow::Suit[%i++] = "Spades";
$HiLow::Suit[%i++] = "Diamonds";
$HiLow::Suit[%i++] = "Clubs";

%i=0;
$HiLow::Colour[%i++] = "Red";
$HiLow::Colour[%i++] = "Black";
$HiLow::Colour[%i++] = "Red";
$HiLow::Colour[%i++] = "Black";

//Change these to how you like
$HiLow::MaxBid = 500000;
$HiLow::MinBid = 50000;
$HiLow::Odds = 3;	// Win returns money bid + money bid / this variable
// eg, if Odds are 4 and they bid 1mill and they win they will get
// 1mill back + 250k if they lose, they lose the 1mill and get nothing.
// ---------------------------------------

function Casino::StateControler()
{
	schedule("Casino::Open(true);",1800);
	schedule("Casino::Close(true);",3600);
	schedule("Casino::StateControler();",3600);
}

function Casino::Open(%check)
{
	if(%check != true)
		return;

	if($CasinoBotList == "")
	{
		if($CasinoDisList == "")
		{
			//Casino 
			$CasinoDisList = $CasinoDisList @ item::add("","gdsdrop","0 0 -4000","0 0 0","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","magicbarrier","2.5 12 -3992","0 -1.2 1.57","static") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","magicbarrier","-2.5 12 -3992","0 -1.2 1.57","static") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","aflagcolumn","0 11 -3995.4","-0.32 0 0","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","roundtable","0 -4 -3969","0 3.139 0","dis") @ " ";

			//Pub Casino
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","0 -5 -3986","0 0 0","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","1.9 -5 -3986","0 0 0","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","-1.9 -5 -3986","0 0 0","dis") @ " ";

			//Casino Room #1
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","-16 -4 -3986","0 0 1.57","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","-16 -2.1 -3986","0 0 1.57","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","-16 -5.9 -3986","0 0 1.57","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("CasinoR 1","magicbarrier","-8.6 -2 -3984","0 1.57 0","static") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("CasinoR 1","magicbarrier","-8.6 -6 -3984","0 1.57 0","static") @ " ";

			//Casino Room #2
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","16 -4 -3986","0 0 1.57","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","16 -2.1 -3986","0 0 1.57","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","16 -5.9 -3986","0 0 1.57","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("CasinoR 2","magicbarrier","8.4 -2 -3984","0 1.57 0","static") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("CasinoR 2","magicbarrier","8.4 -6 -3984","0 1.57 0","static") @ " ";

			//Casino Room #3
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","17.36 9 -3985","0 0 0","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","15.46 9 -3985","0 0 0","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","13.56 9 -3985","0 0 0","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("","bescargo1","11.66 9 -3985","0 0 0","dis") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("CasinoR 3","magicbarrier","8.9 13 -3983","0 1.57 0","static") @ " ";
			$CasinoDisList = $CasinoDisList @ item::add("CasinoR 3","magicbarrier","8.9 16.99 -3983","0 1.57 0","static") @ " ";
		}

		//General Casino Bots
		Casino::BotAdd("Carling","-203.602 1664.99 66.928","0 -0 -1.92058","MaleHuman");
		Casino::BotAdd("Ashley","-0.599124 -23.4909 -3987","0 -0 0.0214731","FemaleHuman");
		Casino::BotAdd("Hawk","-0.04 10.3787 -3993.35","0 -0 -3.13045","MaleHuman");

		//Dealers
		Casino::BotAdd("Roxanne","-17.8996 -3.99949 -3985.99","0 -0 -1.5673","FemaleHuman");
		Casino::BotAdd("Salmon","17.8996 -3.99949 -3985.99","0 -0 1.57503","MaleHuman");
		Casino::BotAdd("Tanya","14.5 6 -3985","0 -0 0.0423818","FemaleHuman");
		Casino::BotAdd("Paul","-0 -3.02 -3986","0 -0 3.13246","MaleHuman");

		//Hi Low Game
		Casino::BotAdd("Karne","0.0343492 -4.23399 -3980.24","0 -0 -0.000208679","MaleHuman");

		//Keep these. they stop people talking to the dealers outside of the room!
		Casino::BotAdd("Bouncer","6.97522 17.325 -3984.99","0 -0 1.85025","MaleHuman");
		Casino::BotAdd("Bouncer","13.8773 4.74319 -3992.49","0 -0 2.26","MaleHuman");
		Casino::BotAdd("Bouncer","-13.6903 4.7446 -3992.49","0 -0 -2.37411","MaleHuman");
		Casino::BotAdd("Bouncer","-13.7587 -16.5615 -3987.26","0 -0 -0.410219","MaleHuman");
		Casino::BotAdd("Bouncer","13.8811 -17.325 -3987","0 -0 0.399316","MaleHuman");
		Casino::BotAdd("Bouncer","8.8694 -7.05873 -3990.51","0 -0 -0.975917","MaleHuman");
		Casino::BotAdd("Bouncer","-8.70415 -9.02188 -3989.8","0 -0 0.47825","MaleHuman");
		Casino::BotAdd("Bouncer","-14.9968 3.64858 -3979.24","0 -0 -0.688431","MaleHuman");
		Casino::BotAdd("Bouncer","11.6949 2.18887 -3984.99","0 -0 -0.35826","MaleHuman");

		Messageall(3,"*** The casino is now open! *** ~wActivateTR.wav");
	}
}

function Casino::Close(%check)
{
	if(%check != true)
		return;

	%list = $CasinoBotList;
	%tlist = $TownBotList;

	deletevariables("casino::priv*");

	if(%list != "")
	{
		for(%i=0;getword(%list,%i)!=-1;%i++)
		{
			%bot = getword(%list,%i);

			if(isobject(%bot))
			{
				DeleteObject(%bot);
				$BotInfo[%bot.name, NAME] = "";
				$CasinoBotList = Casino::RFL($CasinoBotList, %bot);
				$TownBotList = Casino::RFL($TownBotList, %bot);
			}
		}
	}

	Messageall(1,"*** The casino is now closed! ***");
}

function Casino::Bots(%clientid,%id,%message,%initTalk)
{
	if(Casino::ICL($CasinoBotList, %id))
	{
		if(%id.name == "Bouncer")
		{
			if(%initTalk)
			{
				%num = floor(getrandom() * 3) + 1;

				if(%num == 1)		AI::sayLater(%clientId, %id, "Am watching you...", True);
				else if(%num == 2)	AI::sayLater(%clientId, %id, "Keep your noise clean!", True);
				else				AI::sayLater(%clientId, %id, "Any trouble and ill throw you in the brig.", True);
			}
		}
		if(%id.name == "Hawk")
		{
			if($state[%id, %clientId] == "")
			{
				if(%initTalk)
				{
					playSound("SoundMaleHumanHey", GameBase::getPosition(%id));
					AI::sayLater(%clientId, %id, "Hail friend, are you ready to LEAVE the casino?", True);
					$state[%id, %clientId] = 1;
				}
			}
			else if($state[%id, %clientId] == 1)
			{
				if(String::findSubStr(%message, "leave") != -1)
				{
					Item::SetVelocity(%clientid,"0 0 0");

					%pos = "-2412.48 -300.002 66";
					%extra = RandomPositionXY(0.2,3);
					%pos = Vector::Add(%pos,%extra@" 0");
					GameBase::SetPosition(%clientid,%pos);

					AI::sayLater(%clientId, %id, "Come back soon "@client::getname(%clientid)@"!", True);
				}
				$state[%id, %clientId] = "";
			}
		}
		if(%id.name == "Karne")
		{
			if(%initTalk)
			{
				playSound("SoundMaleHumanHey", GameBase::getPosition(%id));
				AI::sayLater(%clientId, %id, "Hail friend, Would you care to PLAY a quick card game?", True);
			}
			else if(String::findSubStr(%message, "play") != -1)
			{
				AI::sayLater(%clientId, %id, "How much would you like to BID?", True);
				AI::sayLater(%clientId, %id, "You can bid between "@$HiLow::MinBid@" and "@$HiLow::MaxBid@" coins.", True);
			}
			if($state[%id, %clientId] != 1)
			{
				if(getword(%message,1) == "bid")
				{
					%name = client::getname(%clientid);
					if(%name != $hilow::player && $hilow::player != "")
					{
						%id = NEWgetClientByName($hilow::player);
						if(%id > 0)
						{
							%dist = round(Vector::getDistance("0.0343492 -4.23399 -3980.24",gamebase::getposition(%id)));
							if(%dist > 50)
							{
								HiLow::End();
							}
							else
							{
								AI::sayLater(%clientId, %id, "Am currently dealing with "@$hilow::player@" come back later.", True);
								return;
							}
						}
						else
							HiLow::End();
					}

					%amnt = floor(getword(%message,2));
					%winamnt = floor(%amnt + %amnt / $HiLow::Odds);
					%coins = fetchdata(%clientid,"COINS");

					if(%coins >= %amnt)
					{
						if(%amnt >= $HiLow::MinBid && %amnt <= $HiLow::MaxBid)
						{
							%card = HiLow::Card();
							%n1 = getword($hilow::last,0);
							%n2 = getword($hilow::last,1);

							if(%n1 > 0)
								%last = $HiLow::Card[%n1]@" of "@$HiLow::Suit[%n2];
							else
								%last = "none";

							centerPrint(%clientId,"\n<JC><F2>-= Hi-Low Game =-<F0><JL>\n\n Bid: <F2>"@%amnt@"\n<F0> Stake: <F2>"@%winamnt@"\n <F0>Card: <F2>"@%card@"<F0>\n Last: <F2>"@%last@"<F0>\n\n",30);
							AI::sayLater(%clientId, %id, "Do you think my next card will be higher or lower than the "@%card@" [HIGH] [LOW]", True);
							$state[%id, %clientId] = 1;

							$hilow::player = %name;
							$hilow::bid = %amnt;
							$hilow::stake = %winamnt;


							%cash = %coins - $hilow::bid;
							storedata(%clientid,"COINS",%cash);
							Client::SendMessage(%clientid,0,"The dealer takes "@$hilow::bid@" coins and draws a card.");
						}
						else
							AI::sayLater(%clientId, %id, "Am sorry, you cannot bid that much.", True);
					}
					else
						AI::sayLater(%clientId, %id, "You dont have that much! Get the fuck out of my sight!!!", True);
				}
			}
			else if($state[%id, %clientId] == 1)
			{
				if(getword(%message,1) == "high")
				{
					%card = HiLow::Card();
					%n1 = getword($hilow::last,0);
					%n2 = getword($hilow::last,1);
					%old = $HiLow::Card[%n1]@" of "@$HiLow::Suit[%n2];

					%new = getword($hilow::card,0);
					%last = getword($HiLow::last,0);

					centerPrint(%clientId,"\n<JC><F2>-= Hi-Low Game =-<F0><JL>\n\n Bid: <F2>"@$hilow::bid@"\n<F0> Stake: <F2>"@$hilow::stake@"\n <F0>Card: <F2>"@%card@"<F0>\n Last: <F2>"@%old@"<F0>\n\n",30);

					if(%new > %last)
					{
						AI::sayLater(%clientId, %id, "You win!", True);
						%coins = fetchdata(%clientid,"COINS");	
						%cash = %coins + $hilow::stake;
						storedata(%clientid,"COINS",%cash);
						Client::SendMessage(%clientid,0,"You received "@$hilow::stake@" coins.");
					}
					else
					{
						Casino::TakensLog($hilow::bid);
						AI::sayLater(%clientId, %id, "You lose!", True);
					}

					$state[%id, %clientId] = 0;
					HiLow::End();
				}
				else if(getword(%message,1) == "low")
				{
					%card = HiLow::Card();
					%n1 = getword($hilow::last,0);
					%n2 = getword($hilow::last,1);
					%old = $HiLow::Card[%n1]@" of "@$HiLow::Suit[%n2];

					%new = getword($hilow::card,0);
					%last = getword($HiLow::last,0);

					centerPrint(%clientId,"\n<JC><F2>-= Hi-Low Game =-<F0><JL>\n\n Bid: <F2>"@$hilow::bid@"\n<F0> Stake: <F2>"@$hilow::stake@"\n <F0>Card: <F2>"@%card@"<F0>\n Last: <F2>"@%old@"<F0>\n\n",30);

					if(%new < %last)
					{
						AI::sayLater(%clientId, %id, "You win!", True);
						%coins = fetchdata(%clientid,"COINS");
						%cash = %coins + $hilow::stake;
						storedata(%clientid,"COINS",%cash);
						Client::SendMessage(%clientid,0,"You received "@$hilow::stake@" coins.");
					}
					else
					{
						AI::sayLater(%clientId, %id, "You lose!", True);
						Casino::TakensLog($hilow::bid);
					}

					$state[%id, %clientId] = 0;
					HiLow::End();
				}
			}
		}
		if(%id.name == "Tanya")
		{
			if($casino::Priv[3])
					$casino::Priv::Tick[3] = 300;

			if($state[%id, %clientId] == "")
			{
				if(%initTalk)
				{
					playSound("SoundFemaleHumanHey", GameBase::getPosition(%id));
					AI::sayLater(%clientId, %id, "You want to PLAY? ("@$casino::cost@" coins) or would you like more INFO?", True);
				}
				else if(String::findSubStr(%message, "unlock") != -1)
				{
					if($Casino::Priv[3])
					{
						AI::sayLater(%clientId, %id, "I have unlocked the room.", True);
						$casino::Priv::Tick[3] = "";
						$casino::Priv[3] = "";
					}
					else
					{
						AI::sayLater(%clientId, %id, "The room is not locked...", True);
					}
				}
				else if(String::findSubStr(%message, "lock") != -1)
				{
					if(!$Casino::Priv[3])
					{
						AI::sayLater(%clientId, %id, "I have locked the room.", True);
						$casino::priv[3] = true;
						$casino::Priv::Tick[3] = 300;
						Casino::PrivLock(3);
					}
					else
					{
						AI::sayLater(%clientId, %id, "The room is locked...", True);
					}
				}
				else if(String::findSubStr(%message, "play") != -1)
				{
					%coins = fetchdata(%clientid,"COINS");
					if(%coins >= $casino::cost)
					{
						for(%i=13;%i<=16;%i++)
						{
							if(IsInCommaList($SpawnPackList, "CasinoPack"@%i))
							{
								AI::sayLater(%clientId, %id, "There game is still in play!", True);
								$state[%id, %clientId] = "";
								return;
							}
						}

						AI::sayLater(%clientId, %id, "There ya go! Grab the packs and see what you get!", True);
						%cash = %coins - $casino::cost;
						storedata(%clientid,"COINS",%cash);
						Casino::TakensLog($casino::cost);
						Casino::Game4(%clientid);
					}
					else
						AI::sayLater(%clientId, %id, "You dont have enough coins to play.", True);

					$state[%id, %clientId] = "";
				}
				else if(String::findSubStr(%message, "info") != -1)
				{
					Casino::Info(%clientid);
					$state[%id, %clientId] = "";
				}
			}
		}
		if(%id.name == "DerajGod")
		{
			if($casino::Priv[2])
				$casino::Priv::Tick[2] = 300;

			if($state[%id, %clientId] == "")
			{
				if(%initTalk)
				{
					playSound("SoundMaleHumanHey", GameBase::getPosition(%id));
					AI::sayLater(%clientId, %id, "You want to PLAY? ("@$casino::cost@" coins) or would you like more INFO?", True);
				}
				else if(String::findSubStr(%message, "unlock") != -1)
				{
					if($Casino::Priv[2])
					{
						AI::sayLater(%clientId, %id, "I have unlocked the room.", True);
						$casino::Priv::Tick[2] = "";
						$casino::Priv[2] = "";
					}
					else
					{
						AI::sayLater(%clientId, %id, "The room is not locked...", True);
					}
				}
				else if(String::findSubStr(%message, "lock") != -1)
				{
					if(!$Casino::Priv[2])
					{
						AI::sayLater(%clientId, %id, "I have locked the room.", True);
						$casino::priv[2] = true;
						$casino::Priv::Tick[2] = 300;
						Casino::PrivLock(2);
					}
					else
					{
						AI::sayLater(%clientId, %id, "The room is locked...", True);
					}
				}
				else if(String::findSubStr(%message, "play") != -1)
				{
					%coins = fetchdata(%clientid,"COINS");
					if(%coins >= $casino::cost)
					{
						for(%i=9;%i<=12;%i++)
						{
							if(IsInCommaList($SpawnPackList, "CasinoPack"@%i))
							{
								AI::sayLater(%clientId, %id, "There game is still in play!", True);
								$state[%id, %clientId] = "";
								return;
							}
						}

						AI::sayLater(%clientId, %id, "There ya go! Grab the packs and see what you get!", True);
						%cash = %coins - $casino::cost;
						storedata(%clientid,"COINS",%cash);
						Casino::TakensLog($casino::cost);
						Casino::Game3(%clientid);
					}
					else
						AI::sayLater(%clientId, %id, "You dont have enough coins to play.", True);

					$state[%id, %clientId] = "";
				}
				else if(String::findSubStr(%message, "info") != -1)
				{
					Casino::Info(%clientid);
					$state[%id, %clientId] = "";
				}
			}
		}
		if(%id.name == "Roxanne")
		{
			if($casino::Priv[1])
				$casino::Priv::Tick[1] = 300;

			if($state[%id, %clientId] == "")
			{
				if(%initTalk)
				{
					playSound("SoundFemaleHumanHey", GameBase::getPosition(%id));
					AI::sayLater(%clientId, %id, "You want to PLAY? ("@$casino::cost@" coins) or would you like more INFO?", True);
				}
				else if(String::findSubStr(%message, "unlock") != -1)
				{
					if($Casino::Priv[1])
					{
						AI::sayLater(%clientId, %id, "I have unlocked the room.", True);
						$casino::Priv::Tick[1] = "";
						$casino::Priv[1] = "";
					}
					else
					{
						AI::sayLater(%clientId, %id, "The room is not locked...", True);
					}
				}
				else if(String::findSubStr(%message, "lock") != -1)
				{
					if(!$Casino::Priv[1])
					{
						AI::sayLater(%clientId, %id, "I have locked the room.", True);
						$casino::priv[1] = true;
						$casino::Priv::Tick[1] = 300;
						Casino::PrivLock(1);
					}
					else
					{
						AI::sayLater(%clientId, %id, "The room is locked...", True);
					}
				}
				else if(String::findSubStr(%message, "play") != -1)
				{
					%coins = fetchdata(%clientid,"COINS");
					if(%coins >= $casino::cost)
					{
						for(%i=5;%i<=8;%i++)
						{
							if(IsInCommaList($SpawnPackList, "CasinoPack"@%i))
							{
								AI::sayLater(%clientId, %id, "There game is still in play!", True);
								$state[%id, %clientId] = "";
								return;
							}
						}

						AI::sayLater(%clientId, %id, "There ya go! Grab the packs and see what you get!", True);
						%cash = %coins - $casino::cost;
						storedata(%clientid,"COINS",%cash);
						Casino::TakensLog($casino::cost);
						Casino::Game2(%clientid);
					}
					else
						AI::sayLater(%clientId, %id, "You dont have enough coins to play.", True);

					$state[%id, %clientId] = "";
				}
				else if(String::findSubStr(%message, "info") != -1)
				{
					Casino::Info(%clientid);
					$state[%id, %clientId] = "";
				}
			}
		}
		if(%id.name == "Paul")
		{
			if($state[%id, %clientId] == "")
			{
				if(%initTalk)
				{
					playSound("SoundMaleHumanHey", GameBase::getPosition(%id));
					AI::sayLater(%clientId, %id, "You want to PLAY? ("@$casino::cost@" coins)", True);
				}
				else if(String::findSubStr(%message, "play") != -1)
				{
					%coins = fetchdata(%clientid,"COINS");
					if(%coins >= $casino::cost)
					{
						for(%i=1;%i<=4;%i++)
						{
							if(IsInCommaList($SpawnPackList, "CasinoPack"@%i))
							{
								AI::sayLater(%clientId, %id, "There game is still in play!", True);
								$state[%id, %clientId] = "";
								return;
							}
						}

						AI::sayLater(%clientId, %id, "There ya go! Grab the packs and see what you get!", True);
						%cash = %coins - $casino::cost;
						storedata(%clientid,"COINS",%cash);
						Casino::TakensLog($casino::cost);
						Casino::Game1(%clientid);
					}
					else
						AI::sayLater(%clientId, %id, "You dont have enough coins to play.", True);

					$state[%id, %clientId] = "";
				}
			}
		}
		if(%id.name == "Ashley")
		{
			if($state[%id, %clientId] == "")
			{
				if(%initTalk)
				{
					playSound("SoundFemaleHumanHey", GameBase::getPosition(%id));
					AI::sayLater(%clientId, %id, "Hail friend, Welcome to the casino. You here to GAMBEL?", True);
					$state[%id, %clientId] = 1;
				}
			}
			else if($state[%id, %clientId] == 1)
			{
				if(String::findSubStr(%message, "gambel") != -1)
				{
					AI::sayLater(%clientId, %id, "If you want to gambel you can ethier talk to my friend in the next room or go some where more PRIVATE.", True);
					$state[%id, %clientId] = 2;
				}
				else
				{
					AI::sayLater(%clientId, %id, "No? Ok then "@client::getname(%clientid)@" maby later!", True);
					$state[%id, %clientId] = "";
				}
			}
			else if($state[%id, %clientid] == 2)
			{
				if(String::findSubStr(%message, "private") != -1)
				{
					AI::sayLater(%clientId, %id, "In the private gamberling rooms you can gambel away from thoes who may try to steal your rewards!!", True);
				}				
				$state[%id, %clientId] = "";
			}
		}
		if(%id.name == "Carling")
		{
			if($state[%id, %clientId] == "")
			{
				if(%initTalk)
				{
					playSound("SoundMaleHumanHey", GameBase::getPosition(%id));
					AI::sayLater(%clientId, %id, "Hail friend, are you here to ENTER my casino?", True);
					$state[%id, %clientId] = 1;
				}
			}
			else if($state[%id, %clientId] == 1)
			{
				if(String::findSubStr(%message, "enter") != -1)
				{
					Item::SetVelocity(%clientid,"0 0 0");

					%pos = "-0.3 2.13618 -3992.5";
					%extra = RandomPositionXY(0.2,3);
					%pos = Vector::Add(%pos,%extra@" 0");
					GameBase::SetPosition(%clientid,%pos);

					AI::sayLater(%clientId, %id, "Great!! Come on in my friend! But beware, if you have to many items on you, your char will DIE!", True);
					$state[%id, %clientId] = "";
				}
				else if(String::findSubStr(%message, "credits") != -1)
				{
					CenterPrint(%clientid,"<jc><f1>\n-= <f0>Casino Credits<f1> =-<jl><f0>\n\n Author: <f2>Carling<f0>\n Date: <f2>23/10/04<f0>\n\n Takens: <f2>"@$CasinoTakens@"\n <f1>Since 07/17/05",10);
					$state[%id, %clientId] = "";
				}
				else
				{
					AI::sayLater(%clientId, %id, "No? Ok then "@client::getname(%clientid)@" maby later!", True);
					$state[%id, %clientId] = "";
				}
			}
		}
	}
}

function Casino::BotAdd(%name,%pos,%rot,%type)
{
	%townbot = newObject("", "Item", %type @ "TownBot", 1, false);
	addToSet("MissionCleanup", %townbot);

	GameBase::setMapName(%townbot, %name);
	GameBase::setPosition(%townbot, %pos);
	GameBase::setRotation(%townbot, %rot);
	GameBase::setTeam(%townbot, 0);
	GameBase::playSequence(%townbot, 0, "root");
	%townbot.name = %name;

	$BotInfo[%townbot.name, NAME] = %name;
	$TownBotList = $TownBotList @ %townbot @ " ";
	$CasinoBotList = $CasinoBotList @ %townbot @ " ";
}

function Casino::RFL(%list, %item)
{
	%a = " " @ %list;
	%a = String::replace(%a, %item @ " ", "");
	%list = String::NEWgetSubStr(%a, 1, 99999);

	return %list;
}

function Casino::ICL(%list, %item)
{
	%a = " " @ %list;
	if(String::findSubStr(%a, %item @ " ") != -1)
		return True;
	else
		return False;
}

function item::add(%tag,%item,%pos,%rot,%type)
{
	%switch = true;

	if(%type == "dis") {
		%type = "InteriorShape";
		%item = %item@".dis";
	}
	else if(%type == "static")
	{
		%type = "StaticShape";
	}
	else 
		return;

	%object = newObject(%tag,%type,%item,%switch);
	addToSet("MissionCleanup", %object);
	GameBase::setPosition(%object,%pos);
	GameBase::setRotation(%object,%rot);

	return %object;
}

function Casino::Pack(%num,%pos)
{
	if(!IsInCommaList($SpawnPackList, "CasinoPack"@%num))
	{
		%reward = Casino::Rewards();
		%pack = "* * "@%reward;
		%pid = DeployLootbag(%pos, "0 0 0", %pack);
		$SpawnPackList = AddToCommaList($SpawnPackList, "CasinoPack"@%num);
		$tagToObjectId["CasinoPack"@%num] = %pid;
		%pid.tag = "CasinoPack"@%num;
	}
}

function Casino::Rewards()
{
	for(%i=1;$casino::reward[%i]!="";%i++){}
	%num = %i--;
	%reward = floor(getrandom() * %num) + 1;
	%reward = $casino::reward[%reward];

	if(%reward == "_RareItemDrop")	//Special to make rare item drops even more rare!
	{
		for(%i=1;$casino::rare::reward[%i]!="";%i++){}
		%num = %i--;
		%reward = floor(getrandom() * %num) + 1;
		%reward = $casino::rare::reward[%reward];
	}		

	return %reward;
}

StaticShapeData MagicBarrier
{
	shapefile = "PLASMAWALL";
	debrisId = defaultDebrisSmall;
	maxDamage = 4;
	visibleToSensor = false;
	isTranslucent = true;
	description = "Magic Barrier";
};

function MagicBarrier::onDamage(%this,%type,%value,%pos,%vec,%mom,%object)
{
	return;
}

function MagicBarrier::onCollision(%this, %object)
{
	%clientId = Player::getClient(%object);	
	%oname = object::getname(%this);

	if(getWord(%oname,0) == "CasinoR")
	{
		%door = getword(%oname,1);

		if(!$casino::priv[%door])
		{
			%pos = Gamebase::getPosition(%this);

			//Door Open
			playSound(ForceFieldClose, %pos);
			gamebase::startfadeout(%this);
			schedule("gamebase::setposition("@%this@",\"8000 8000 -8000\");",1);

			//Door Close
			schedule("playSound(ForceFieldOpen,\""@%pos@"\");",5);
			schedule("gamebase::setposition("@%this@",\""@%pos@"\");",5);
			schedule("gamebase::startfadein("@%this@");",5);
		}
		else
			Client::sendmessage(%clientid,0,"This room is locked. ("@$Casino::Priv::Tick[%door]@")");
	}
}

function Casino::Game1(%clientid)
{
	// Paul
	%pos = "1.83165 -5.02 -3985";			Casino::Pack(1,%pos);
	%pos = vector::add(%pos,"-1.2 0 0");	Casino::Pack(2,%pos);
	%pos = vector::add(%pos,"-1.2 0 0");	Casino::Pack(3,%pos);
	%pos = vector::add(%pos,"-1.2 0 0");	Casino::Pack(4,%pos);
}

function Casino::Game2(%clientid)
{
	// Roxanne
	%pos = "-16 -5.96364 -3985";			Casino::Pack(5,%pos);
	%pos = vector::add(%pos,"0 1.2 0");		Casino::Pack(6,%pos);
	%pos = vector::add(%pos,"0 1.2 0");		Casino::Pack(7,%pos);
	%pos = vector::add(%pos,"0 1.2 0");		Casino::Pack(8,%pos);
}

function Casino::Game3(%clientid)
{
	// DerajGod
	%pos = "16 -5.96364 -3985";			Casino::Pack(9,%pos);
	%pos = vector::add(%pos,"0 1.2 0");		Casino::Pack(10,%pos);
	%pos = vector::add(%pos,"0 1.2 0");		Casino::Pack(11,%pos);
	%pos = vector::add(%pos,"0 1.2 0");		Casino::Pack(12,%pos);
}

function Casino::Game4(%clientid)
{
	// Tanya
	%pos = "16.511 8.95966 -3984";		Casino::Pack(13,%pos);
	%pos = vector::add(%pos,"-1.3 0 0");	Casino::Pack(14,%pos);
	%pos = vector::add(%pos,"-1.3 0 0");	Casino::Pack(15,%pos);
	%pos = vector::add(%pos,"-1.3 0 0");	Casino::Pack(16,%pos);
}

function Casino::Info(%clientid)
{
	Client::Sendmessage(%clientid,0,"Play - Using this command will spawn packs on the bench in front of me. Each pack Will contain a random reward. Warning: not every reward is good!");
	Client::Sendmessage(%clientid,0,"Lock - This will lock the private room you are in so that no one can come in.");
	Client::Sendmessage(%clientid,0,"Unlock - This will unlock the private room you are in.");
	Client::Sendmessage(%clientid,1,"Note: The private room will auto unlock its self after 5mins of inactivity.");
}

function Casino::PrivLock(%room)
{
	if($Casino::Priv[%room] != "")
	{
		if($Casino::Priv::Tick[%room] > 0)
		{
			$Casino::Priv::Tick[%room]--;
			schedule("Casino::PrivLock("@%room@");",1);
		}
		else
			$Casino::Priv[%room] = "";
	}
}

function a(%msg)
{
	messageall(0,%msg);
	messageall(1,%msg);
	messageall(2,%msg);
	messageall(3,%msg);
}

function HiLow::Card()
{
	%flag = true;
	while(%flag)
	{
		%num1 = floor(getrandom() * 13) + 1;
		%card = $HiLow::Card[%num1]; 
		%num2 = floor(getrandom() * 4) + 1;
		%suit = $HiLow::Suit[%num2];

		if(%card != $hilow::last)
			%flag = flase;
	}

	$hilow::last = $hilow::card;
	$hilow::card = %num1 @ " " @ %num2;

	return %card@" of "@%suit;
}

function HiLow::End()
{
	$hilow::player = "";
	$hilow::card = "";
	$hilow::bid = "";
	$hilow::last = "";
	$hilow::bid = "";
	$hilow::Stake = "";
}

function Casino::TakensLoad()
{
	$ConsoleWorld::DefaultSearchPath = $ConsoleWorld::DefaultSearchPath;	//thanks Presto
	if(isFile("temp\\_Casino[LOG].cs"))
		exec("_Casino[LOG]");
}

function Casino::TakensLog(%amnt)
{
	$CasinoTakens = $CasinoTakens + %amnt;
	export("CasinoTakens", "temp\\_Casino[LOG].cs", false);
}

Casino::TakensLoad();