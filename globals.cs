if($console::logmode == "") $console::logmode = 0;
if($dbechoMode == "") $dbechoMode = 2;
if($dbechoMode2 == "") $dbechoMode2 = 2;

if($arenaOn == "") $arenaOn = False;
if($underwaterEffects == "") $underwaterEffects = False;
if($postAttackGraphBar == "") $postAttackGraphBar = False;
if($SaveWorldFreq == "") $SaveWorldFreq = 300;
if($ChangeWeatherFreq == "") $ChangeWeatherFreq = 0;
if($initlck == "") $initlck = 20;
if($AIsmartFOVbots == "") $AIsmartFOVbots = False;
if($exportChat == "") $exportChat = False;
if($SelectiveZoneBotSpawning == "") $SelectiveZoneBotSpawning = True;
if($displayPingAndPL == "") $displayPingAndPL = False;
if($maxPets == "") $maxPets = 5;
if($maxPetsPerPlayer == "") $maxPetsPerPlayer = 1;

if($SPgainedPerLevel == "") $SPgainedPerLevel = 15;
if($initSPcredits == "") $initSPcredits = 60;
if($autoStartupSP == "") $autoStartupSP = 5;	//for each skill
if($initbankcoins == "") $initbankcoins = 15000;
if($maxSAYdistVec == "") $maxSAYdistVec = 20;
if($maxSHOUTdistVec == "") $maxSHOUTdistVec = 60;
if($maxWHISPERdistVec == "") $maxSHOUTdistVec = 5;

if($joinHouseCost == "") $joinHouseCost = 50000;
if($changeHouseCost == "") $changeHouseCost = 100000;
if($joinHouseRankPoints == "") $joinHouseRankPoints = 5;

if($spawnMultiplier == "") $spawnMultiplier = "1.0";
if($allowDuplicateIPs == "") $allowDuplicateIPs = true;
if($recallDelay == "") $recallDelay = 15;

if($hardcore == "") $hardcore = False;
if($SlowdownHitDelay == "") $SlowdownHitDelay = 0.0;

//-------------------- Night / Day stuff
$initHaze = 600;
$currentHaze = $initHaze;
$currentSky = "lushdayclear.dml";

$dayCycleSky[1] = "lushdayclear.dml";
$dayCycleSky[2] = "litesky.dml";
$dayCycleSky[3] = "lushsky_night.dml";
$dayCycleSky[4] = "litesky.dml";
$dayCycleSky[5] = "lushdayclear.dml";

$dayCycleHaze[0] = 600;
$dayCycleHaze[1] = 300;
$dayCycleHaze[2] = 100;
$dayCycleHaze[3] = -100;
$dayCycleHaze[4] = -300;
$dayCycleHaze[5] = -600;

if($fullCycleTime == "") $fullCycleTime = 60 * 60;
if($nightDayCycle == "") $nightDayCycle = False;
//--------------------------------------

$vvv = 10;

$RecalcEconomyDelay = 60 * 5;
$resalePercentage = 8;
$CorpseTimeoutValue = 10;
$invalidChars = " ><?\\\"{}[]+=:;/.,~!@#$%^&*()|`";
$maxDamagedBy = 10;
$damagedByEraseDelay = 60;

$AImoveChance = 2;		//as long as the bot is a spawn-bot, there is a chance in
					//2 every 5 seconds that he will create himself a marker 
					//at a certain distance and go to it.
$AIcloseEnoughMarkerDist = 30;
$AIspotDist = 4.0;
$AIFOVPan = 1.5;
$AImaxRange = 40;
$AIminrad = 10;
$AImaxrad = 100;

$addedShopMsg = "";
$waitActionDelay = 0.5;
$sayDelay = 0.2;
$triggerDelay = 2;

//$LootbagPopTime = 60*60;
$LootbagPopTime = -1;

$TribesDamageToNumericDamage = 100.0;
$RepairPerFiveSeconds = 6;

$waterDamageAmp = 0.1;
$maxItem = 500;

$dapFactor = 10;		//both used for assigning exp
$dlvlFactor = 150;

//sp vars
$SkillCap = 9000;
$skillRangePerLevel = 10;

//steal vars.
$maxstealskill = 100;
$maxSTEALdistVec = 2.3;
$stealDelay = 5;

$droppingAllowed = 1;
$sepchar = ",";
$maxAIdistVec = 5;
$coinweight = 0.001;
$maxEvents = 8;

$WorldSaveList = "|Lootbag|";

$SlashingDamageType	= 1;
$PiercingDamageType	= 2;
$BludgeoningDamageType	= 4;

$SanctionedAdmin[meatsicle] = "100000";
