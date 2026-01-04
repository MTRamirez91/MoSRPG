$HouseName[1] = "The Crimson Blades";
$HouseName[2] = "Bastelium";
$HouseName[3] = "Nicromanius";
$HouseName[4] = "Death Knights";
$HouseName[5] = "Guardians Tribe";
$HouseName[6] = "Unholy Priests";
$HouseName[7] = "The Axius";

$HouseStartUpEq[1] = "";
$HouseStartUpEq[2] = "";
$HouseStartUpEq[3] = "";
$HouseStartUpEq[4] = "";
$HouseStartUpEq[5] = "";
$HouseStartUpEq[6] = "";
$HouseStartUpEq[7] = "";

function GetHouseNumber(%n)
{
	for(%i = 1; $HouseName[%i] != ""; %i++)
	{
		//if($HouseName[%i] == %n)
		if(String::ICompare($HouseName[%i], %n) == 0)
			return %i;
	}
	return "";
}

function BootFromCurrentHouse(%clientId, %echo)
{
	%h = fetchData(%clientId, "MyHouse");

	if(%h != "")
	{
		UnequipMountedStuff(%clientId);

		%hn = GetHouseNumber(%h);
		if(%echo) Client::sendMessage(%clientId, $MsgRed, "You have been Kicked out of " @ $HouseName[%hn] @ " Get the HELL out of OUR sight!!!");

		storeData(%clientId, "MyHouse", "");
		storeData(%clientId, "RankPoints", 0);

		return %hn;
	}
	else
		return -1;
}

function JoinHouse(%clientId, %hn, %echo)
{
	storeData(%clientId, "MyHouse", $HouseName[%hn]);
	storeData(%clientId, "RankPoints", $joinHouseRankPoints);

	if(%echo) Client::sendMessage(%clientId, $MsgBeige, "You have been Drafted into " @ $HouseName[%hn] @ " and have been Given " @ $joinHouseRankPoints @ " rank points. Welcome to the War.");
}