// putting a global variable in the argument list means:
// if an argument is passed for that parameter it gets
// assigned to the global scope, not the scope of the function

function createTrainingServer()
{
	dbecho($dbechoMode, "createTrainingServer()");

	$SinglePlayer = true;
	createServer($pref::lastTrainingMission, false);
}

function remoteSetCLInfo(%clientId, %skin, %name, %email, %tribe, %url, %info, %autowp, %enterInv, %msgMask)
{
	dbecho($dbechoMode, "remoteSetCLInfo(" @ %clientId @ ", " @ %skin @ ", " @ %name @ ", " @ %email @ ", " @ %tribe @ ", " @ %url @ ", " @ %info @ ", " @ %autowp @ ", " @ %enterInv @ ", " @ %msgMask @ ")");

   $Client::info[%clientId, 0] = %skin;
   $Client::info[%clientId, 1] = %name;
   $Client::info[%clientId, 2] = %email;
   $Client::info[%clientId, 3] = %tribe;
   $Client::info[%clientId, 4] = %url;
   $Client::info[%clientId, 5] = %info;
   if(%autowp)
      %clientId.autoWaypoint = true;
   if(%enterInv)
      %clientId.noEnterInventory = true;
   if(%msgMask != "")
      %clientId.messageFilter = %msgMask;
}

function Server::storeData()
{
	dbecho($dbechoMode, "Server::storeData()");

   $ServerDataFile = "serverTempData" @ $Server::Port @ ".cs";

   export("Server::*", "temp\\" @ $ServerDataFile, False);
   export("pref::lastMission", "temp\\" @ $ServerDataFile, true);
   EvalSearchPath();
}

function Server::refreshData()
{
	dbecho($dbechoMode, "Server::refreshData()");

   exec($ServerDataFile);  // reload prefs.
   checkMasterTranslation();
   Server::loadMission($pref::lastMission, false);
}

function KickDaJackal(%clientId)
{
	dbecho($dbechoMode, "KickDaJackal(" @ %clientId @ ")");

//   Net::kick(%clientId, "The FBI has been notified.  You better buy a legit copy before they get to your house.");
}

function createServer(%mission, %dedicated)
{
	dbecho($dbechoMode2, "createServer(" @ %mission @ ", " @ %dedicated @ ")");

	deleteVariables("tmpBotGroup*");
	deleteVariables("aidirectiveTable*");
	deleteVariables("aiNumTable*");
	deleteVariables("tmpbotn*");
	deleteVariables("funk*");
	deleteVariables("Skill*");
	deleteVariables("world*");
	deleteVariables("Quest*");
	deleteVariables("loot*");
	deleteVariables("BotInfo*");
	deleteVariables("Merchant*");
	deleteVariables("NameForRace*");
	deleteVariables("BlockData*");
	deleteVariables("EventCommand*");
	deleteVariables("LoadOut*");
	$PetList = "";
	$DISlist = "";
	$SpawnPackList = "";
	$LoadOutList = "";
	$isRaining = "";

	$loadingMission = false;
	$ME::Loaded = false;
	if(%mission == "")
		%mission = $pref::lastMission;

	if(%mission == "")
	{
		echo("Error: no mission provided.");
		return "False";
	}

	if(!$SinglePlayer)
		$pref::lastMission = %mission;

	cursorOn(MainWindow);
	GuiLoadContentCtrl(MainWindow, "gui\\Loading.gui");
	renderCanvas(MainWindow);

	if(!%dedicated)
	{
		deleteServer();
	      purgeResources();
	      newServer();
      	focusServer();
	}
	if($SinglePlayer)
		newObject(serverDelegate, FearCSDelegate, true, "LOOPBACK", $Server::Port);
	else
		newObject(serverDelegate, FearCSDelegate, true, "IP", $Server::Port, "IPX", 	$Server::Port, "LOOPBACK", $Server::Port);
   
	exec(Globals);
	exec(RpgFunk);
	exec(Skills);
	exec(House);
	exec(Sleep);
	exec(Game);
	exec(Admin);
	exec(Marker);
	exec(Trigger);
	exec(Zone);
	exec(Spells);
	exec(Classes);
	exec(Party);
	exec(Jail);
	exec(NSound);
	exec(BaseExpData);
	exec(BaseDebrisData);
	exec(BaseProjData);
	exec(ArmorData);
	exec(Mission);
	exec(Item);
	exec(Accessory);
	exec(Chopping);
	exec(Weapons);
	exec(NewArmors);
	exec(Crystal);
	exec(Spawn);
	exec(Connectivity);
	exec(GameEvents);
	exec(Shopping);
	exec(Weight);
	exec(Mana);
	exec(HP);
	exec(RpgStats);
	exec(PlayerDamage);
	exec(PlayerSpawn);
	exec(ItemEvents);
	exec(Economy);
	exec(Remote);
	exec(WeaponHandling);
	exec(BonusState);
	exec(Player);
	exec(Turret);
	exec(Beacon);
	exec(StaticShape);
	exec(Station);
	exec(Moveable);
	exec(Sensor);
	exec(Mine);
	exec(AI);
	exec(InteriorLight);
	exec(Comchat);
	exec(Version);
	exec(MinoMods);
	exec(RPGArena);
	exec(zoneregen);
	exec(casino);
	exec(linebreak);
	exec(extra);
	exec(CrashGuard);
	exec(carling1);
	exec(belt);
	exec(guns);
	exec(spawnflyer);

	$Server::Info = "<jc>Running RPG Mod w/ Salmon's MoS\n<f1>Heroes of Keldrina\n\n<f2>Website: <f1>None.\nNotice: No active moderation/admins.\n ";

	Server::storeData();
	preloadServerDataBlocks();
	Server::loadMission( ($missionName = %mission), true );
	CreateWeaponCyclingTables();

	LoadWorld();
	InitCrystals();
	InitTrees();
	InitZones();
	InitTownBots();
	if(!$NoSpawn)
		InitSpawnPoints();

	if($arenaOn)
	{
		if(!$NoSpawn)
			InitArena();
	}

	GenerateAllWeaponCosts();
	GenerateAllShieldCosts();
	GenerateAllArmorCosts();

	InitObjectives();

	BanList::addAbsolute("IP:24.218.18.88", 972512322);
	BanList::addAbsolute("IP:24.163.162.288", 972512322);
	BanList::addAbsolute("IP:24.191.107.40", 972512322);
	BanList::addAbsolute("IP:24.218.20.155", 972512322);
	BanList::addAbsolute("IP:24.64.220.75", 972512322);
	BanList::addAbsolute("IP:65.185.196.28", 972512322);
	BanList::addAbsolute("IP:4.152.72.223", 972512322);
	BanList::addAbsolute("IP:69.69.38.181", 972512322);
	BanList::addAbsolute("IP:67.180.150.*", 972512322);

	if(!%dedicated)
	{
		focusClient();

		if($IRC::DisconnectInSim == "")
		{
			$IRC::DisconnectInSim = true;
		}
		if($IRC::DisconnectInSim == true)
		{
			ircDisconnect();
			$IRCConnected = FALSE;
			$IRCJoinedRoom = FALSE;
		}
		$Server::Address = "LOOPBACK:" @ $Server::Port;
		$Server::JoinPassword = $Server::Password;
      		connect($Server::Address);
	}

	return "True";
}

function Server::nextMission(%replay)
{
	dbecho($dbechoMode, "Server::nextMission(" @ %replay @ ")");
	//THERE! now it won't change mission!!!
}

function remoteCycleMission(%clientId)
{
	dbecho($dbechoMode, "remoteCycleMission(" @ %clientId @ ")");

   if(%clientId.adminLevel >= 50)
   {
      messageAll(0, Client::getName(%playerId) @ " cycled the mission.");
      Server::nextMission();
   }
}

function remoteDataFinished(%clientId)
{
	dbecho($dbechoMode, "remoteDataFinished(" @ %clientId @ ")");

   if(%clientId.dataFinished)
      return;
   %clientId.dataFinished = true;
   Client::setDataFinished(%clientId);
   %clientId.svNoGhost = ""; // clear the data flag
   if($ghosting)
   {
      %clientId.ghostDoneFlag = true; // allow a CGA done from this dude
      startGhosting(%clientId);  // let the ghosting begin!
   }
}

function remoteCGADone(%playerId)
{
	dbecho($dbechoMode, "remoteCGADone(" @ %playerId @ ")");

   if(!%playerId.ghostDoneFlag || !$ghosting)
      return;
   %playerId.ghostDoneFlag = "";

   Game::initialMissionDrop(%playerid);

	if ($cdTrack != "")
		remoteEval (%playerId, setMusic, $cdTrack, $cdPlayMode);
   remoteEval(%playerId, MInfo, $missionName);
}

function Server::loadMission(%missionName, %immed)
{
	dbecho($dbechoMode, "Server::loadMission(" @ %missionName @ ", " @ %immed @ ")");

   if($loadingMission)
      return;

   %missionFile = "missions\\" $+ %missionName $+ ".mis";
   if(File::FindFirst(%missionFile) == "")
   {
      %missionName = $firstMission;
      %missionFile = "missions\\" $+ %missionName $+ ".mis";
      if(File::FindFirst(%missionFile) == "")
      {
         echo("invalid nextMission and firstMission...");
         echo("aborting mission load.");
         return;
      }
   }
   echo("Notfifying players of mission change: ", getNumClients(), " in game");
   for(%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
   {
      Client::setGuiMode(%cl, $GuiModeVictory);
      %cl.guiLock = true;
      %cl.nospawn = true;
      remoteEval(%cl, missionChangeNotify, %missionName);
   }

   $loadingMission = true;
   $missionName = %missionName;
   $missionFile = %missionFile;
   $prevNumTeams = getNumTeams();

   deleteObject("MissionGroup");
   deleteObject("MissionCleanup");
   deleteObject("ConsoleScheduler");
   resetPlayerManager();
   resetGhostManagers();
   $matchStarted = false;
   $countdownStarted = false;
   $ghosting = false;

   resetSimTime(); // deal with time imprecision

   newObject(ConsoleScheduler, SimConsoleScheduler);
   if(!%immed)
      schedule("Server::finishMissionLoad();", 18);
   else
      Server::finishMissionLoad();      
}

function Server::finishMissionLoad()
{
	dbecho($dbechoMode, "Server::finishMissionLoad()");

   $loadingMission = false;
	$TestMissionType = "";
   // instant off of the manager
   setInstantGroup(0);
   newObject(MissionCleanup, SimGroup);

   exec($missionFile);
   Mission::init();
   if($prevNumTeams != getNumTeams())
   {
      // loop thru clients and setTeam to -1;
      messageAll(0, "New teamcount - resetting teams.");
      for(%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
         GameBase::setTeam(%cl, -1);
   }

   $ghosting = true;
   for(%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
   {
      if(!%cl.svNoGhost)
      {
         %cl.ghostDoneFlag = true;
         startGhosting(%cl);
      }
   }
   if($SinglePlayer)
      Game::startMatch();
   else if($Server::warmupTime && !$Server::TourneyMode)
      Server::Countdown($Server::warmupTime);
   else if(!$Server::TourneyMode)
      Game::startMatch();

   $teamplay = (getNumTeams() != 1);
   purgeResources(true);

   // make sure the match happens within 5-10 hours.
   schedule("Server::CheckMatchStarted();", 3600);
   schedule("Server::nextMission();", 18000);
   
   return "True";
}

function Server::CheckMatchStarted()
{
	dbecho($dbechoMode, "Server::CheckMatchStarted()");

   // if the match hasn't started yet, just reset the map
   // timing issue.
   if(!$matchStarted)
      Server::nextMission(true);
}

function Server::Countdown(%time)
{
	dbecho($dbechoMode, "Server::Countdown(" @ %time @ ")");

   $countdownStarted = true;
   schedule("Game::startMatch();", %time);
   Game::notifyMatchStart(%time);
   if(%time > 30)
      schedule("Game::notifyMatchStart(30);", %time - 30);
   if(%time > 15)
      schedule("Game::notifyMatchStart(15);", %time - 15);
   if(%time > 10)
      schedule("Game::notifyMatchStart(10);", %time - 10);
   if(%time > 5)
      schedule("Game::notifyMatchStart(5);", %time - 5);
}

function Client::setInventoryText(%clientId, %txt)
{
	dbecho($dbechoMode, "Client::setInventoryText(" @ %clientId @ ", " @ %txt @ ")");

	remoteEval(%clientId, "ITXT", %txt);
}

function centerprint(%clientId, %msg, %timeout)
{
	dbecho($dbechoMode, "centerprint(" @ %clientId @ ", " @ %msg @ ", " @ %timeout @ ")");

   if(%timeout == "")
      %timeout = 5;
   if(%timeout == -1)
        %timeout = "";
   remoteEval(%clientId, "CP", %msg, %timeout);
}

function bottomprint(%clientId, %msg, %timeout)
{
	dbecho($dbechoMode, "bottomprint(" @ %clientId @ ", " @ %msg @ ", " @ %timeout @ ")");

   if(%timeout == "")
      %timeout = 5;
   if(%timeout == -1)
        %timeout = "";
   remoteEval(%clientId, "BP", %msg, %timeout);
}

function topprint(%clientId, %msg, %timeout)
{
	dbecho($dbechoMode, "topprint(" @ %clientId @ ", " @ %msg @ ", " @ %timeout @ ")");

   if(%timeout == "")
      %timeout = 5;
   if(%timeout == -1)
        %timeout = "";
   remoteEval(%clientId, "TP", %msg, %timeout);
}

function centerprintall(%msg, %timeout)
{
	dbecho($dbechoMode, "centerprintall(" @ %msg @ ", " @ %timeout @ ")");

   if(%timeout == "")
      %timeout = 5;
   if(%timeout == -1)
        %timeout = "";
   for(%clientId = Client::getFirst(); %clientId != -1; %clientId = Client::getNext(%clientId))
      remoteEval(%clientId, "CP", %msg, %timeout);
}

function bottomprintall(%msg, %timeout)
{
	dbecho($dbechoMode, "bottomprintall(" @ %msg @ ", " @ %timeout @ ")");

   if(%timeout == "")
      %timeout = 5;
   if(%timeout == -1)
        %timeout = "";
   for(%clientId = Client::getFirst(); %clientId != -1; %clientId = Client::getNext(%clientId))
      remoteEval(%clientId, "BP", %msg, %timeout);
}

function topprintall(%msg, %timeout)
{
	dbecho($dbechoMode, "topprintall(" @ %msg @ ", " @ %timeout @ ")");

   if(%timeout == "")
      %timeout = 5;
   if(%timeout == -1)
        %timeout = "";
   for(%clientId = Client::getFirst(); %clientId != -1; %clientId = Client::getNext(%clientId))
      remoteEval(%clientId, "TP", %msg, %timeout);
}

function talk(%msg, %timeout)
{
	dbecho($dbechoMode, "talk(" @ %msg @ ", " @ %timeout @ ")");

   if(%timeout == "")
      %timeout = 5;
   if(%timeout == -1)
        %timeout = "";
   for(%clientId = Client::getFirst(); %clientId != -1; %clientId = Client::getNext(%clientId))
      remoteEval(%clientId, "CP", %msg, %timeout);
}

function t(%mtype, %message, %filter)
{
	dbecho($dbechoMode, "messageAll(" @ %mtype @ ", " @ %message @ ", " @ %filter @ ")");

	if(%filter == "")
		for(%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
			Client::sendMessage(%cl, %mtype, %message);
	else
	{
		for(%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
		{
			if(%cl.messageFilter & %filter)
			Client::sendMessage(%cl, %mtype, %message);
		}
	}
}