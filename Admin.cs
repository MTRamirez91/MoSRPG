//exec(atmos);
//exec(atmos_item);
//exec(admingun);
//exec(ghost);

//rpg admin
function Game::menuRequest(%clientId)
{
	if(%clientId.IsInvalid)
		return;

	if(%clientId.choosingGroup)
	{
		MenuGroup(%clientId);
		return;
	}
	else if(%clientId.choosingClass)
	{
		MenuClass(%clientId);
		return;
	}

	%curItem = 0;
	Client::buildMenu(%clientId, "::Main Menu::", "options", true);
		if(%clientId.selClient)
		{
			%sel = %clientId.selClient;
			%selname = Client::getName(%sel);

			if(%clientId != %sel && fetchData(%sel, "HasLoadedAndSpawned"))
			{
                        if(IsInCommaList(fetchData(%clientId, "grouplist"), %selname))
					Client::addMenuItem(%clientId, %curItem++ @ "Remove from group-list", "remgroup " @ %sel);
				else
					Client::addMenuItem(%clientId, %curItem++ @ "Add to group-list", "addgroup " @ %sel);

        if(IsInCommaList(fetchData(%clientId, "targetlist"), %selname))
	Client::addMenuItem(%clientId, %curItem++ @ "Remove from target-list", "remtarget " @ %sel);
	else
	//Client::addMenuItem(%clientId, %curItem++ @ "Add to target-list", "addtarget " @ %sel);

				if(fetchData(%clientId, "partyOwned"))
				{
					if(IsInCommaList(fetchData(%clientId, "partylist"), %selname))
						Client::addMenuItem(%clientId, %curItem++ @ "Remove from your party", "remparty " @ %sel);
					else
					{
						if(CountObjInCommaList(fetchData(%clientId, "partylist")) < $maxpartymembers)
						{
							%p = IsInWhichParty(Client::getName(%sel));
							if(%p == -1)
								Client::addMenuItem(%clientId, %curItem++ @ "Invite to your party", "addparty " @ %sel);
							else if(GetWord(%p, 1) == "i")
								Client::addMenuItem(%clientId, %curItem++ @ "Cancel invitation", "cancelinv " @ %sel);
							else
								Client::addMenuItem(%clientId, %curItem++ @ "(Can't invite, already in a party)", "");
						}
						else
							Client::addMenuItem(%clientId, %curItem++ @ "(Can't invite, too many members)", "");
					}
				}

				if(%clientId.muted[%sel])
					Client::addMenuItem(%clientId, %curItem++ @ "Unmute", "unmute " @ %sel);
				else
					Client::addMenuItem(%clientId, %curItem++ @ "Mute", "mute " @ %sel);

			}
		}
		else
		{
			if(!IsDead(%clientId))
				Client::addMenuItem(%clientId, %curItem++ @ "View your stats" , "viewstats");

			if(GetAccessoryList(%clientId, 9, -1) != "")
				Client::addMenuItem(%clientId, %curItem++ @ "Ranged weapons..." , "rweapons");

			if(!IsDead(%clientId))
				Client::addMenuItem(%clientId, %curItem++ @ "Skill Points..." , "sp");

			if(fetchData(%clientId, "ignoreGlobal"))
				Client::addMenuItem(%clientId, %curItem++ @ "Turn ignore global OFF" , "gignoreoff");
			else
				Client::addMenuItem(%clientId, %curItem++ @ "Turn ignore global ON" , "gignoreon");

			if(fetchData(%clientId, "LCKconsequence") == "miss")
				Client::addMenuItem(%clientId, %curItem++ @ "Set LCK mode = death" , "lckdeath");
			else if(fetchData(%clientId, "LCKconsequence") == "death")
				Client::addMenuItem(%clientId, %curItem++ @ "Set LCK mode = miss" , "lckmiss");

			Client::addMenuItem(%clientId, %curItem++ @ "Party options..." , "partyoptions");

			if(!IsDead(%clientId))	//See belt.cs for the belt code its self
				Client::addMenuItem(%clientId, %curItem++ @ "Belt","viewbelt");

			Client::addMenuItem(%clientId, "nNext >>", "Next");
		}
}
function processMenuOptions(%clientId, %option)
{
	dbecho($dbechoMode, "processMenuOptions(" @ %clientId @ ", " @ %option @ ")");

	%opt = getWord(%option, 0);
	%cl = getWord(%option, 1);

	if(%opt == "Other")
	{
		%sel = %clientId.selClient;
		if(%sel == "") %sel = %clientId;
		%name = Client::getName(%sel);

		Messageall(1,Client::getName(%clientid)@" has been caught trying to get admin....silly noob!");		//ADDED by Carling
		return;
	}
	//**RPG
	else if(%opt == "viewstats")
	{
		%a[%tmp++] = "<f1>" @ Client::getName(%clientId) @ "\nLevel " @ fetchData(%clientId, "LVL") @ " " @ fetchData(%clientId, "RACE") @ " " @ fetchData(%clientId, "CLASS") @ "\nRemort Level " @ fetchData(%clientid, "remortstep") @ "\n\n";

		%a[%tmp++] = "<f0>DEF: " @ fetchData(%clientId, "DEF") @ "\n";
		%a[%tmp++] = "MDEF: " @ fetchData(%clientId, "MDEF") @ "\n";
		%a[%tmp++] = "Hit Pts: " @ fetchData(%clientId, "HP") @ " / " @ fetchData(%clientId, "MaxHP") @ "\n";
		%a[%tmp++] = "LCK: " @ fetchData(%clientId, "LCK") @ "\n";

		if(fetchData(%clientId, "MyHouse") != "")
		{
			%a[%tmp++] = "Member of <f1>" @ fetchData(%clientId, "MyHouse") @ " <f0>with<f1> " @ fetchData(%clientId, "RankPoints") @ " <f0>RP\n";
		}

		%a[%tmp++] = "Experience: " @ fetchData(%clientId, "EXP") @ "\n";
            %a[%tmp++] = "Exp needed: " @ (GetExp(GetLevel(fetchData(%clientId, "EXP"), %clientId)+1, %clientId) - fetchData(%clientId, "EXP") @ "\n\n");

		%a[%tmp++] = "Coins: " @ fetchData(%clientId, "COINS") @ " - Bank: " @ fetchData(%clientId, "BANK") @ "\n";

		%a[%tmp++] = "Weight: " @ fetchData(%clientId, "Weight") @ " / " @ fetchData(%clientId, "MaxWeight") @ "\n";
		%a[%tmp++] = "Mana: " @ fetchData(%clientId, "MANA") @ " / " @ fetchData(%clientId, "MaxMANA") @ "\n";

		for(%i = 1; %a[%i] != ""; %i++)
			%f = %f @ %a[%i];

		bottomprint(%clientId, %f, floor(String::len(%f) / 20));

		return;
	}
	else if(%opt == "addgroup")
	{
		if(countObjInCommaList(fetchData(%clientId, "grouplist")) <= 30)
		{
			%name = Client::getName(%cl);
			storeData(%clientId, "grouplist", AddToCommaList(fetchData(%clientId, "grouplist"), %name));

			Client::sendMessage(%cl, $MsgBeige, Client::getName(%clientId) @ " has added you to his/her group-list.");
			Client::sendMessage(%clientId, $MsgBeige, %name @ " is now on your group-list.");
		}
		else
			Client::sendMessage(%clientId, $MsgRed, "You have too many people on your group-list.");
	}
	else if(%opt == "remgroup")
	{
		%name = Client::getName(%cl);
		storeData(%clientId, "grouplist", RemoveFromCommaList(fetchData(%clientId, "grouplist"), %name));

		Client::sendMessage(%cl, $MsgBeige, Client::getName(%clientId) @ " has removed you from his/her group-list.");
		Client::sendMessage(%clientId, $MsgBeige, %name @ " is no longer on your group-list.");
	}
	

else if(%opt == "addtarget")
{
if(countObjInCommaList(fetchData(%clientId, "targetlist")) <= 30)
{
%delay = 20;
%name = Client::getName(%cl);
Client::sendMessage(%clientId, $MsgRed, %name @ " will be added to your target-list in " @ %delay @ " seconds.");
Client::sendMessage(%cl, $MsgRed, Client::getName(%clientId) @ " is thinking about killing you.");
schedule("AddToTargetList(" @ %clientId @ ", " @ %cl @ ");", %delay, %cl);
}
else
Client::sendMessage(%clientId, $MsgRed, "You have too many people on your target-list.");
}
else if(%opt == "remtarget")
{
%name = Client::getName(%cl);
storeData(%clientId, "targetlist", RemoveFromCommaList(fetchData(%clientId, "targetlist"), %name));
Client::sendMessage(%cl, $MsgBeige, Client::getName(%clientId) @ " has declared a truce.");
Client::sendMessage(%clientId, $MsgBeige, %name @ " is no longer on your target-list.");
}
	else if(%opt == "addparty")
	{
		%clientId.invitee[%cl] = True;
		Client::sendMessage(%cl, $MsgBeige, Client::getName(%clientId) @ " has invited you to join his/her party.");
		Client::sendMessage(%clientId, $MsgBeige, "You have invited " @ Client::getName(%cl) @ " to join your party.");
	}
	else if(%opt == "remparty")
	{
		%name = Client::getName(%cl);
		RemoveFromParty(%clientId, %name);
	}
	else if(%opt == "cancelinv")
	{
		%clientId.invitee[%cl] = "";
		Client::sendMessage(%cl, $MsgRed, Client::getName(%clientId) @ " has cancelled his invitation.");
		Client::sendMessage(%clientId, $MsgBeige, "You cancelled your invitation to " @ Client::getName(%cl) @ ".");
	}
	else if(%opt == "mute")
	      %clientId.muted[%cl] = True;
	else if(%opt == "unmute")
		%clientId.muted[%cl] = "";
	else if(%opt == "gignoreon")
	{
		storeData(%clientId, "ignoreGlobal", True);
	}
	else if(%opt == "gignoreoff")
	{
		storeData(%clientId, "ignoreGlobal", "");
	}
	else if(%opt == "lckmiss")
	{
		storeData(%clientId, "LCKconsequence", "miss");
	}
	else if(%opt == "lckdeath")
	{
		storeData(%clientId, "LCKconsequence", "death");
	}
	else if(%opt == "sp")
	{
		MenuSP(%clientId, 1);
		return;
	}
	else if(%opt == "partyoptions")
	{
		Client::buildMenu(%clientId, "Party options", "partyopt", true);
		if(fetchData(%clientId, "partyOwned"))
			Client::addMenuItem(%clientId, "xDisband party", "disbandparty");
		else
			Client::addMenuItem(%clientId, "cCreate party", "createparty");
		%name = Client::getName(%clientId);
		if( (%p = IsInWhichParty(%name)) != -1)
		{
			%id = GetWord(%p, 0);
			%inv = GetWord(%p, 1);
			if(%inv == -1)
			{
				//this player is in the party
				Client::addMenuItem(%clientId, "pLeave current party", "leaveparty " @ %id);
			}
			else if(%inv == "i")
			{
				//this player is being invited
				Client::addMenuItem(%clientId, "pAccept " @ Client::getName(%id) @ "'s party invitation", "acceptinv " @ %id);
			}
		}

		%list = fetchData(%clientId, "partylist");
		for(%p = String::findSubStr(%list, ","); (%p = String::findSubStr(%list, ",")) != -1; %list = String::NEWgetSubStr(%list, %p+1, 99999))
		{
			%w = String::NEWgetSubStr(%list, 0, %p);
			Client::addMenuItem(%clientId, %curitem++ @ "Remove " @ %w, "remparty " @ %w);
		}
	}
	else if(%opt == "viewbelt")
	{
		MenuViewBelt(%clientid, 1);
		return;
	}
	else if(%opt == "Next")	//added this line to make a 2nd page in the menus.
	{
		MenuPg2(%clientId);	// see line 263
		return;
			// the following was removed from this function and sent to MenuPg2 //line 263
			//Client::addMenuItem(%clientId, %curItem++ @ "Party options..." , "partyoptions");
			//if(!IsDead(%clientId))
			//	Client::addMenuItem(%clientId, %curItem++ @ "Smith List." , "smith");
			//
			//if($BattleMessage[%clientId] != 1)
			//	Client::addMenuItem(%clientId, %curItem++ @ "Battle Messages On." , "battleon");
			//else
			//	Client::addMenuItem(%clientId, %curItem++ @ "Battle Messages Off." , "battleoff");

	}
	else if(%opt == "rweapons")
	{
		%list = GetAccessoryList(%clientId, 9, -1);

		Client::buildMenu(%clientId, "Ranged weapons:", "selectrweapon", true);
		for(%i = 0; GetWord(%list, %i) != -1; %i++)
		{
			%item = GetWord(%list, %i);

			Client::addMenuItem(%clientId, %curitem++ @ %item.description, %item);
		}
		return;
	}
	//**
}

function MenuPG2(%clientId)		//Created to make up for the 8 menu item limit.
{
	Client::buildMenu(%clientId, "Options Page 2", "pg2", true);

	if(fetchData(%clientId, "defaultTalk") == "#say")
		Client::addMenuItem(%clientId, %curItem++ @ "Set default talk: #global" , "defglobal");
	else
		Client::addMenuItem(%clientId, %curItem++ @ "Set default talk: #say" , "defsay");

	if($BattleMessage[%clientId] != "off")
		Client::addMenuItem(%clientId, %curItem++ @ "Battle Messages Off." , "battleoff");
	else
		Client::addMenuItem(%clientId, %curItem++ @ "Battle Messages On." , "battleon");

	Client::addMenuItem(%clientId, "p<< Prev", "Previous");
}
// the above stuff is just a straight cut and paste of the original.
//See line 237

function processMenupg2(%clientId, %opt) //this just processes input from the pg2 of the menu
{
	if(%opt == "defglobal")
	{
		storeData(%clientId, "defaultTalk", "#global");
	}
	else if(%opt == "defsay")
	{
		storeData(%clientId, "defaultTalk", "#say");
	}
	else if(%opt == "battleon")
		$BattleMessage[%clientId] = "on";	//This is the Variable to search out in Playerdamage.cs
	else if(%opt == "battleoff")
		$BattleMessage[%clientId] = "off";
	else
	{
		Game::menuRequest(%clientId);
		return;
	}
}
function processMenupartyopt(%clientId, %option)
{
	dbecho($dbechoMode, "processMenupartyopt(" @ %clientId @ ", " @ %option @ ")");

	%opt = getWord(%option, 0);
	%cl = getWord(%option, 1);

	if(%opt == "disbandparty")
	{
		DisbandParty(%clientId);
	}
	else if(%opt == "createparty")
	{
		CreateParty(%clientId);
	}
	else if(%opt == "remparty")
	{
		RemoveFromParty(%clientId, %cl);
	}
	else if(%opt == "acceptinv")
	{
		%name = Client::getName(%clientId);
		if( (%p = IsInWhichParty(%name)) != -1)
		{
			%id = GetWord(%p, 0);
			%inv = GetWord(%p, 1);
			if(%inv == "i")
				AddToParty(%id, %name);
		}
	}
	else if(%opt == "leaveparty")
	{
		RemoveFromParty(%cl, Client::getName(%clientId));
	}

	return;
}

function processMenuselectspell(%clientId, %option)
{
	dbecho($dbechoMode, "processMenuselectspell(" @ %clientId @ ", " @ %option @ ")");

	%name = Client::getName(%clientId);

	$playerCurrentSpell[%clientId] = $spellShell[%option];
}
function processMenuselectrweapon(%clientId, %item)
{
	%list = GetAccessoryList(%clientId, 10, -1);

	Client::buildMenu(%clientId, "Projectiles:", "selectproj", true);
	for(%i = 0; GetWord(%list, %i) != -1; %i++)
	{
		%proj = GetWord(%list, %i);

		if(String::findSubStr($ProjRestrictions[%proj], "," @ %item @ ",") != -1)
			Client::addMenuItem(%clientId, %curitem++ @ %proj.description, %item @ " " @ %proj);
	}
	return;
}
function processMenuselectproj(%clientId, %itemandproj)
{
	%item = GetWord(%itemandproj, 0);
	%proj = GetWord(%itemandproj, 1);

	storeData(%clientId, "LoadedProjectile " @ %item, %proj);
}

function processMenuOtheropt(%clientId, %option)
{
return;
}

function remoteSelectClient(%clientId, %selId)
{
	dbecho($dbechoMode, "remoteSelectClient(" @ %clientId @ ", " @ %selId @ ")");

   if(%clientId.selClient != %selId)
   {
      %clientId.selClient = %selId;
      if(%clientId.menuMode == "options")
         Game::menuRequest(%clientId);
      remoteEval(%clientId, "setInfoLine", 1, "Player Info for " @ Client::getName(%selId) @ ":");
      remoteEval(%clientId, "setInfoLine", 2, "Real Name: " @ $Client::info[%selId, 1]);
      remoteEval(%clientId, "setInfoLine", 3, "Email Addr: " @ $Client::info[%selId, 2]);
      remoteEval(%clientId, "setInfoLine", 4, "Tribe: " @ $Client::info[%selId, 3]);
      remoteEval(%clientId, "setInfoLine", 5, "URL: " @ $Client::info[%selId, 4]);
   }
}


function processMenuPickTeam(%clientId, %team, %adminClient)
{
return;
}
