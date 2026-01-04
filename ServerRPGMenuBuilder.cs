//Server Use
//When you update ur stuff, update this and the players will update
$ItemsVerions = "1.0";
$rpgmb:menuitem = "321"; //this is just until next update, use sum random thing



$RPGMenuBuilderVersion = "1.0";
$CurrentSlot[RPGMBWIM] = 1;
$CurrentSlot[RPGMBSIM] = 1;
$CurrentSlot[RPGMBCIM] = 1;
$CurrentSlot[RPGMBAIM] = 1;
$CurrentSlot[RPGMBOIM] = 1;
$MenuItems = "Slashing Piercing Bludgeoning OffensiveCasting DefensiveCasting NeutralCasting Armor Robes Rings Feet Quests";

$ItemsForList[Slashing] = "Hatchet Broadsword WarAxe LongSword BattleAxe Claymore ElvenBlade Katana IronsMight DracosWrath DracoSword HeavensGlory SoulSlicer";
$ItemsForList[Piercing] = "PickAxe Dagger ShortSword Spear Gladius Trident Rapier Longstaff AwlPike QuarterStaff HellsEdge SkeletalStaff DevilsClaw MithrilSword";
$ItemsForList[Bludgeoning] = "Club SpikedClub Mace SpikedBoneclub HammerPick MorningStar Warhammer WarMaul GnarledStaff TitaniumHammer DragonHammer";
$ItemsForList[OffensiveCasting] = "thorn fireball firebomb icespike icestorm ironfist cloud melt powercloud hellstorm beam tornado hurricane";
$ItemsForList[DefensiveCasting] = "heal advheal1 advheal2 advheal3 advheal4 advheal5 advheal6 shield advshield1 advshield2 advshield3 advshield4 advshield5 godlyheal heavenlyheal fullheal massheal massfullheal massshield";
$ItemsForList[NeutralCasting] = "teleport transport advtransport masstransport mimic";
$ItemsForList[Armor] = "SpikedLeather ScaleMail BrigandineArmor ChainMail RingMail BandedMail SplintMail BronzePlateMail FullPlateArmor KeldrinArmor MithrilMail";
$ItemsForList[Robes] = "LightRobe BloodRobe AdvisorRobe ElvenRobe RobeOfVengeance PhensRobe ArkemnsRobe";
$ItemsForList[Rings] = "ArkemnsRing PhensRing BlackRing Manaring TalismanMregen TalismanHregen";
$ItemsForList[Feet] = "cheetaurspaws bootsofgliding windwalkers heavenlywings";
$ItemsForList[Quests] = "MinotaurRib MinotaurSteak DracoTeeth DracoClaw FishScale DragonScale HolyGrail VialOfGoo";

$PlaceForList[Slashing] = RPGMBWIM1;
$PlaceForList[Piercing] = RPGMBWIM1;
$PlaceForList[Bludgeoning] = RPGMBWIM1;
$PlaceForList[OffensiveCasting] = RPGMBSIM1;
$PlaceForList[DefensiveCasting] = RPGMBSIM1;
$PlaceForList[NeutralCasting] = RPGMBSIM1;
$PlaceForList[Armor] = RPGMBAIM1;
$PlaceForList[Robes] = RPGMBAIM1;
$PlaceForList[Rings] = RPGMBOIM1;
$PlaceForList[Feet] = RPGMBOIM1;
$PlaceForList[Quests] = RPGMBOIM1;

$ItemNumberList[1] = "Slashing";
$ItemNumberList[2] = "Piercing";
$ItemNumberList[3] = "Bludgeoning";
$ItemNumberList[4] = "OffensiveCasting";
$ItemNumberList[5] = "DefensiveCasting";
$ItemNumberList[6] = "NeutralCasting";
$ItemNumberList[7] = "Armor";
$ItemNumberList[8] = "Robes";
$ItemNumberList[9] = "Rings";
$ItemNumberList[10] = "Feet";
$ItemNumberList[11] = "Quests";



function remoteIsAMenuBuilderUser(%clientID, %ver, %send)
{
	if(%ver != $RPGMenuBuilderVersion)
	centerPrint(%clientId, "<JC>We reccommend that you use the version we are using.  Our version is <f2>" @$RPGMenuBuilderVersion @ "<f1>.", 10);
	if(%send == "yes")
	SendMenuNames(%clientID);
}


function remoteWhatIs(%clientID, %item)
{
%msg = WhatIs(%item);
bottomprint(%ClientId, %msg, floor(String::len(%msg) / 20));
}

function SendMenuNames(%clientID)
{
for(%i=0; (%list = getword($MenuItems, %i)) != -1; %i++)
	{
	%place = %list @ "1";
	remoteeval(%clientID, MenuNames, %place, $placeforlist[%list], %list);
	}
senditeminfo(%clientID);
}


function SendItemInfo(%clientID)
{
for(%i=1; (%list = $ItemNumberList[%i]) != ""; %i++)
	{
	senditeminfo2(%clientID, %list);
	}
}

function senditeminfo2(%clientID, %list)
{
for(%i=0; (%item = getword($ItemsForList[%list], %i)) != -1; %i++)
	remoteeval(%clientID, RecieveInfo, %list, %item);
}