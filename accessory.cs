//When adding a new accessory, follow these steps:
//-(if it has a new accessory type, fill in the stuff here)
//-add the actual itemdata here

//current item method involves having two ItemData's for each item, where one differs from the
//other by category.  One is Accessory, the other is Equipped.

//=========================
//  $SpecialVar list:
//=========================
//1:
//2:
//3: MDEF
//4: HP
//5: Mana
//6: ATK
//7: DEF
//8: Internal armor switching variable
//9:
//10: HP regen
//11: Mana regen	

$SpecialVarDesc[1] = "";
$SpecialVarDesc[2] = "";
$SpecialVarDesc[3] = "MDEF (Magical)";
$SpecialVarDesc[4] = "HP";
$SpecialVarDesc[5] = "Mana";
$SpecialVarDesc[6] = "ATK";
$SpecialVarDesc[7] = "DEF";
$SpecialVarDesc[8] = "[Internal]";
$SpecialVarDesc[9] = "";
$SpecialVarDesc[10] = "HP regen";
$SpecialVarDesc[11] = "Mana regen";
$SpecialVarDesc[12] = "";
$SpecialVarDesc[13] = "Weight Capacity";

$RingAccessoryType = 1;
$BodyAccessoryType = 2;
$BootsAccessoryType = 3;
$BackAccessoryType = 4;
$ShieldAccessoryType = 5;
$TalismanAccessoryType = 6;
$SwordAccessoryType = 7;
$AxeAccessoryType = 8;
$PolearmAccessoryType = 9;
$BludgeonAccessoryType = 10;
$RangedAccessoryType = 11;
$ProjectileAccessoryType = 12;
$LeftArmAccessoryType = 13;
$OrbAccessoryType = 14;

$LocationDesc[$RingAccessoryType] = "Ring";
$LocationDesc[$BodyAccessoryType] = "Body";
$LocationDesc[$BootsAccessoryType] = "Feet";
$LocationDesc[$BackAccessoryType] = "Back";
$LocationDesc[$ShieldAccessoryType] = "Shield";
$LocationDesc[$TalismanAccessoryType] = "Talisman";
$LocationDesc[$SwordAccessoryType] = "Sword";
$LocationDesc[$AxeAccessoryType] = "Axe";
$LocationDesc[$PolearmAccessoryType] = "Polearm";
$LocationDesc[$BludgeonAccessoryType] = "Bludgeon";
$LocationDesc[$RangedAccessoryType] = "Ranged";
$LocationDesc[$ProjectileAccessoryType] = "Projectile";
$LocationDesc[$LeftArmAccessoryType] = "Left_Arm";
$LocationDesc[$OrbAccessoryType] = "Orb";

$maxAccessory[$RingAccessoryType] = 2;
$maxAccessory[$BodyAccessoryType] = 1;
$maxAccessory[$BootsAccessoryType] = 1;
$maxAccessory[$BackAccessoryType] = 1;
$maxAccessory[$ShieldAccessoryType] = 1;
$maxAccessory[$TalismanAccessoryType] = 1;
$maxAccessory[$LeftArmAccessoryType] = 1;
$maxAccessory[$OrbAccessoryType] = 1;

//these are used for $AccessoryVar
$AccessoryType = 1;			//(used in item.cs)
$SpecialVar = 2;				//(used in player.cs)
$Weight = 3;				//(used in rpgfunk.cs)
$ShopIndex = 4;
$MiscInfo = 5;

$HardcodedItemCost[SmallRock] = 1;
$HardcodedItemCost[ReplenishVial] = 15;

$HardcodedItemCost[Tent] = 4000;
$HardcodedItemCost[OrbOfLuminance] = 25;
$HardcodedItemCost[OrbOfBreath] = 1000;
$HardcodedItemCost[OrbOfXion] = 100000;
$HardcodedItemCost[DracosEye] = 350000;
$HardcodedItemCost[CheetaursPaws] = 3500;
$HardcodedItemCost[BootsOfGliding] = 8000;
$HardcodedItemCost[WindWalkers] = 45000;

$HardcodedItemCost[BlackStatue] = 180;
$HardcodedItemCost[EnchantedStone] = 2450;
$HardcodedItemCost[DarkStone] = 10000;
$HardcodedItemCost[SkeletonBone] = 5860;
$HardcodedItemCost[Parchment] = 1000000;
$HardcodedItemCost[MagicDust] = 1000000;
$HardcodedItemCost[DragonScale] = 245310;

function GenerateAllShieldCosts()
{
	dbecho($dbechoMode, "GenerateAllShieldCosts()");

	$ItemCost[KnightShield] = GenerateItemCost(KnightShield);
	$ItemCost[HeavenlyShield] = GenerateItemCost(HeavenlyShield);
	$ItemCost[DragonShield] = GenerateItemCost(DragonShield);
	$ItemCost[Saraka] = 15000000;
}

//=====================
// ACCESSORY FUNCTIONS
//=====================

function GetAccessoryVar(%item, %type)
{
	dbecho($dbechoMode, "GetAccessoryVar(" @ %item @ ", " @ %type @ ")");

	%nitem = getCroppedItem(%item);

	return $AccessoryVar[%nitem, %type];
}

function getCroppedItem(%item)
{
	dbecho($dbechoMode, "getCroppedItem(" @ %item @ ")");

	%zitem = %item @ "xx";
	%p = String::findSubStr(%zitem, "0xx");
	if(%p != -1)
		%nitem = String::getSubStr(%item, 0, %p);
	else
		%nitem = %item;

	return %nitem;
}

function GetAccessoryList(%clientId, %type, %filter)
{
	dbecho($dbechoMode, "GetAccessoryList(" @ %clientId @ ", " @ %type @ ", " @ %filter @ ")");

	if(IsDead(%clientId) || !fetchData(%clientId, "HasLoadedAndSpawned") || %clientId.IsInvalid || %clientId.choosingGroup || %clientId.choosingClass)
		return "";

	%list = "";
	%max = getNumItems();
	for(%i = 0; %i < %max; %i++)
	{
		%count = Player::getItemCount(%clientId, %i);

		if(%count)
		{
			%item = getItemData(%i);

			%flag = "";
			if(%type == 1)
			{
				if(%item.className == "Accessory")
					%flag = True;
			}
			else if(%type == 2)
			{
				if(%item.className == "Equipped")
					%flag = True;
			}
			else if(%type == 3)
			{
				if(%item.className == "Accessory" || %item.className == "Equipped")
					%flag = True;
			}
			else if(%type == 4)
			{
				if(%item == fetchData(%clientId, "EQUIPPED") || %item.className == "Equipped" || %item.className == "Weapon" || %item.className == "Backpack")
				{
					if(%item.className == "Weapon")
					{
						if(Player::getMountedItem(%clientId, $WeaponSlot) == %item)
							%flag = True;
					}
					else if(%item.className == "Backpack")
					{
						if(Player::getMountedItem(%clientId, $BackpackSlot) == %item)
							%flag = True;
					}
					else
						%flag = True;
				}
			}
			else if(%type == 5)
			{
				if($AccessoryVar[%item, $AccessoryType] == $SwordAccessoryType)
					%flag = True;
			}
			else if(%type == 6)
			{
				if($AccessoryVar[%item, $AccessoryType] == $AxeAccessoryType)
					%flag = True;
			}
			else if(%type == 7)
			{
				if($AccessoryVar[%item, $AccessoryType] == $PolearmAccessoryType)
					%flag = True;
			}
			else if(%type == 8)
			{
				if($AccessoryVar[%item, $AccessoryType] == $BludgeonAccessoryType)
					%flag = True;
			}
			else if(%type == 9)
			{
				if($AccessoryVar[%item, $AccessoryType] == $RangedAccessoryType)
					%flag = True;
			}
			else if(%type == 10)
			{
				if($AccessoryVar[%item, $AccessoryType] == $ProjectileAccessoryType)
					%flag = True;
			}
			else if(%type == -1)
				%flag = True;

			if(%flag)
			{
				if(%filter != -1)
				{
					%flag2 = "";
					%av = GetAccessoryVar(%item, $SpecialVar);
					for(%j = 0; GetWord(%av, %j) != -1; %j+=2)
					{
						%w = GetWord(%av, %j);
						if(String::findSubStr(%filter, %w) != -1)
							%flag2 = True;
					}
				}
				if(%filter == -1 || %flag2)
					%list = %list @ %item @ " ";
			}
		}
	}
	return %list;
}

function AddPoints(%clientId, %char)
{
	dbecho($dbechoMode, "AddPoints(" @ %clientId @ ", " @ %char @ ")");

	%add = 0;
	%list = GetAccessoryList(%clientId, 4, %char);
	for(%i = 0; GetWord(%list, %i) != -1; %i++)
	{
		%w = GetWord(%list, %i);

		%slot = "";
		if(%w.className == Weapon)
			%slot = $WeaponSlot;
		else if(%w.className == Backpack)
			%slot = $BackpackSlot;

		if(%slot != "")
		{
			if(Player::getMountedItem(%clientId, %slot) == %w)
				%count = 1;
			else
				%count = 0;
		}
		else
			%count = Player::getItemCount(%clientId, %w);
		
		if(%w == fetchdata(%clientid, "EQUIPPED"))
			%count = 1;

		%tmp = GetAccessoryVar(%w, $SpecialVar);

		for(%j = 0; GetWord(%tmp, %j) != -1; %j+=2)
		{
			%e = GetWord(%tmp, %j);
			if(%e == %char)
				%add += GetWord(%tmp, %j+1) * %count;
		}
	
	}
	return %add;
}


function AddItemSpecificPoints(%item, %char)
{
	dbecho($dbechoMode, "AddItemSpecificPoints(" @ %item @ ", " @ %char @ ")");

	%tmp = GetAccessoryVar(%item, $SpecialVar);

	for(%j = 0; GetWord(%tmp, %j) != -1; %j+=2)
	{
		%e = GetWord(%tmp, %j);
		if(%e == %char || %e == fetchData(%clientId, "EQUIPPED"))
		{
			%info = GetWord(%tmp, %j+1);
			break;
		}

	}
	return %info;
}

function WhatSpecialVars(%thing)
{
	dbecho($dbechoMode, "WhatSpecialVars(" @ %thing @ ")");

	%tmp = GetAccessoryVar(%thing, $SpecialVar);

	%t = "";
	for(%i = 0; GetWord(%tmp, %i) != -1; %i+=2)
	{
		%s = GetWord(%tmp, %i);
		%n = GetWord(%tmp, %i+1);

		%t = %t @ $SpecialVarDesc[%s] @ ": " @ %n @ ", ";
	}
	if(%t == "")
		%t = "None";
	else
		%t = String::getSubStr(%t, 0, String::len(%t)-2);
	
	return %t;
}

function NullItemList(%clientId, %type, %msgcolor, %msg)
{
	dbecho($dbechoMode, "NullItemList(" @ %clientId @ ", " @ %type @ ", " @ %msgcolor @ ", " @ %msg @ ")");

	for(%z = 1; $ItemList[%type, %z] != ""; %z++)
	{
		%item = $ItemList[%type, %z];

		if(isBeltItem(%item))
		{
			%amnt = Belt::HasThisStuff(%clientid,%item);
			if(%amnt > 0)
			{
				%item = $beltitem[%item, "Item"];
				%name = $beltitem[%item, "Name"];
				%newmsg = nsprintf(%msg, %name);
				Client::sendMessage(%clientId, %msgcolor, %newmsg);
				Belt::TakeThisStuff(%clientid,%item,%amnt);
			}
		}
		if(Player::getItemCount(%clientId, %item))
		{
			Player::setItemCount(%clientId, %item, 0);

			%newmsg = nsprintf(%msg, %item.description);
			Client::sendMessage(%clientId, %msgcolor, %newmsg);
		}
	}
}

function GetCurrentlyWearingArmor(%clientId)
{
	dbecho($dbechoMode, "GetCurrentlyWearingArmor(" @ %clientId @ ")");

	//the $ArmorList is present only for this function so far, in order to speed things up and not have to cycle thru
	//each and every item in the game

	for(%i = 1; $ArmorList[%i] != ""; %i++)
	{      
		%item = getItemData($ArmorList[%i]);
		if(fetchdata(%clientid,"EQUIPPED") == %item)
			return $ArmorList[%i];
	}
	return "";
}

//=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
//   POTIONS
//=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

$AccessoryVar[ReplenishVial, $Weight] = 1;
$AccessoryVar[ReplenishVial, $MiscInfo] = "<f2>A potion that heals <f1>100% <f2>FUCK YA!";
ItemData ReplenishVial
{
	description = "Replenish Vial";
	shapeFile = "armorKit";
	heading = "eMiscellany";
	className = "Accessory";
	shadowDetailMask = 4;
	price = 0;
};
function ReplenishVial::onUse(%player,%item)
{
	%clientId = Player::getClient(%player);

	Player::decItemCount(%player,%item);
	%hp = fetchData(%clientId, "HP");
	refreshHP(%clientId, -80);
	refreshMANA(%clientId, -80);
	refreshAll(%clientId);

	if(fetchData(%clientId, "HP") != %hp)
		UseSkill(%clientId, $SkillHealing, True, True);
}

//=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
//   ARMOR MODIFYING ACCESSORIES
//=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

$AccessoryVar[CheetaursPaws, $AccessoryType] = $BootsAccessoryType;
$AccessoryVar[CheetaursPaws, $SpecialVar] = "8 1";
$AccessoryVar[CheetaursPaws, $Weight] = 3;
$AccessoryVar[CheetaursPaws, $MiscInfo] = "Cheetaur's Paws increase speed and jump power";

ItemData CheetaursPaws
{
	description = "Cheetaur's Paws";
	className = "Accessory";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};
ItemData CheetaursPaws0
{
	description = "Cheetaur's Paws";
	className = "Equipped";
	shapeFile = "discammo";

	heading = "aArmor";
};

$AccessoryVar[BootsOfGliding, $AccessoryType] = $BootsAccessoryType;
$AccessoryVar[BootsOfGliding, $SpecialVar] = "8 2";
$AccessoryVar[BootsOfGliding, $Weight] = 3;
$AccessoryVar[BootsOfGliding, $MiscInfo] = "Boots Of Gliding let you glide";

ItemData BootsOfGliding
{
	description = "Boots Of Gliding";
	className = "Accessory";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};
ItemData BootsOfGliding0
{
	description = "Boots Of Gliding";
	className = "Equipped";
	shapeFile = "discammo";

	heading = "aArmor";
};

$AccessoryVar[WindWalkers, $AccessoryType] = $BootsAccessoryType;
$AccessoryVar[WindWalkers, $SpecialVar] = "8 3";
$AccessoryVar[WindWalkers, $Weight] = 3;
$AccessoryVar[WindWalkers, $MiscInfo] = "Wind Walkers let you fly!";

ItemData WindWalkers
{
	description = "Wind Walkers";
	className = "Accessory";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};
ItemData WindWalkers0
{
	description = "Wind Walkers";
	className = "Equipped";
	shapeFile = "discammo";

	heading = "aArmor";
};

//============================================================================

$AccessoryVar[KnightShield, $AccessoryType] = $ShieldAccessoryType;
$AccessoryVar[KnightShield, $SpecialVar] = "7 250";
$AccessoryVar[KnightShield, $Weight] = 16;
$AccessoryVar[KnightShield, $MiscInfo] = "The Knight's Shield is a unique item that provides great defense.";

ItemImageData KnightShieldImage
{
	shapeFile = "shield3";
	mountPoint = 2;
	mountOffset = {0.18, -0.1, -0.7};
	mountRotation = {0, 0, 0.5};
};
ItemData KnightShield
{
	description = "Knight's Shield";
	className = "Accessory";
	shapeFile = "shield3";
	imageType = KnightShieldImage;

	heading = "eMiscellany";
	price = 0;
};
ItemData KnightShield0
{
	description = "Knight's Shield";
	className = "Equipped";
	shapeFile = "shield3";

	heading = "aArmor";
};

$AccessoryVar[HeavenlyShield, $AccessoryType] = $ShieldAccessoryType;
$AccessoryVar[HeavenlyShield, $SpecialVar] = "7 315 3 635";
$AccessoryVar[HeavenlyShield, $Weight] = 14;
$AccessoryVar[HeavenlyShield, $MiscInfo] = "The Heavenly Shield is a unique item that provides Excellent Magical and Physical defense.";

ItemImageData HeavenlyShieldImage
{
	shapeFile = "shield3";
	mountPoint = 2;
	mountOffset = {0.18, -0.1, -0.7};
	mountRotation = {0, 0, 0.5};
};
ItemData HeavenlyShield
{
	description = "Heavenly Shield";
	className = "Accessory";
	shapeFile = "shield3";
	imageType = HeavenlyShieldImage;

	heading = "eMiscellany";
	price = 0;
};
ItemData HeavenlyShield0
{
	description = "Heavenly Shield";
	className = "Equipped";
	shapeFile = "shield3";

	heading = "aArmor";
};

$AccessoryVar[DragonShield, $AccessoryType] = $ShieldAccessoryType;
$AccessoryVar[DragonShield, $SpecialVar] = "7 540 4 210";
$AccessoryVar[DragonShield, $Weight] = 15;
$AccessoryVar[DragonShield, $MiscInfo] = "A shield made from the scales of a dragon";

ItemImageData DragonShieldImage
{
	shapeFile = "shield3";
	mountPoint = 2;
	mountOffset = {0.18, -0.1, -0.7};
	mountRotation = {0, 0, 0.5};
};
ItemData DragonShield
{
	description = "Dragon Shield";
	className = "Accessory";
	shapeFile = "shield3";
	imageType = DragonShieldImage;

	heading = "eMiscellany";
	price = 0;
};
ItemData DragonShield0
{
	description = "Dragon Shield";
	className = "Equipped";
	shapeFile = "shield3";

	heading = "aArmor";
};

//mino shield//
ItemImageData MinotaurShieldImage
{
	shapeFile = "shield3";
	mountPoint = 2;
	mountOffset = {0.18, -0.1, -0.7};
	mountRotation = {0, 0, 0.5};
};
ItemData MinotaurShield
{
	description = "Minotaur Shield";
	className = "Accessory";
	shapeFile = "shield3";
	imageType = MinotaurShieldImage;

	heading = "eMiscellany";
	price = 0;
};
ItemData MinotaurShield0
{
	description = "Minotaur Shield";
	className = "Equipped";
	shapeFile = "shield3";

	heading = "aArmor";
};

$AccessoryVar[Saraka, $AccessoryType] = $ShieldAccessoryType;
$AccessoryVar[Saraka, $SpecialVar] = "7 1000";
$AccessoryVar[Saraka, $Weight] = 50;
$AccessoryVar[Saraka, $MiscInfo] = "The Saraka is the greatest item for defense in the world of Keldrenia!";

ItemImageData SarakaImage
{
	shapeFile = "katana";
	mountPoint = 3;
	mountOffset = {0.18, 0.12, 0.5};
	mountRotation = {0.0, 10.5, 0.5};
};
ItemData Saraka
{
	description = "Saraka";
	className = "Accessory";
	shapeFile = "katana";
	imageType = SarakaImage;

	heading = "eMiscellany";
	price = 0;
};
ItemData Saraka0
{
	description = "Saraka";
	className = "Equipped";
	shapeFile = "katana";

	heading = "aArmor";
};

$SkillRestriction[ThievesGlove] = $MinClass @ " Thief";
$AccessoryVar[ThievesGlove, $AccessoryType] = $ShieldAccessoryType;
$AccessoryVar[ThievesGlove, $Weight] = 1;
$AccessoryVar[ThievesGlove, $SpecialVar] = "1 Stealing";
$AccessoryVar[ThievesGlove, $MiscInfo] = "A Thieves Glove increases your stealing skills greatly.";
$StealProtectedItem[ThievesGlove0] = True;

ItemImageData ThievesGloveImage
{
	shapeFile = "invisable";
	mountPoint = 2;
	mountOffset = {0.18, -0.1, -0.2};
	mountRotation = {0, 0, 0.5};
};
ItemData ThievesGlove
{
	description = "Thieves Glove";
	className = "Accessory";
	shapeFile = "shield3";
	imageType = ThievesGloveImage;

	heading = "eMiscellany";
	price = 0;
};
ItemData ThievesGlove0
{
	description = "Thieves Glove";
	className = "Equipped";
	shapeFile = "invisable";
	heading = "aArmor";
};
function ThievesGlove::onuse(%player, %item)
{		
		%clientId = Player::getClient(%player);
		Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
		Player::setItemCount(%player, %item @ "0", Player::getItemCount(%player, %item @ "0")+1);
		$PlayerSkill[%clientId, $SkillStealing] += 500;
	
}
function ThievesGlove0::onUse(%player, %item)
{		
		%clientId = Player::getClient(%player);
		%o = String::getSubStr(%item, 0, String::len(%item)-1);
		Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
		Player::setItemCount(%player, %o, Player::getItemCount(%player, %o)+1);
		$PlayerSkill[%clientId, $SkillStealing] -= 500;

}

$SkillRestriction[AerinShield] = $MinClass @ " Paladin";
$AccessoryVar[AerinShield, $AccessoryType] = $ShieldAccessoryType;
$AccessoryVar[AerinShield, $Weight] = 1;
$AccessoryVar[AerinShield, $SpecialVar] = "1 Healing 1 DefensiveCasting";
$AccessoryVar[AerinShield, $MiscInfo] = "A Paladins Shield that increases there Healing and Defensive Casting.";
$StealProtectedItem[AerinShield0] = True;

ItemImageData AerinShieldImage
{
	shapeFile = "shield3";
	mountPoint = 2;
	mountOffset = {0.18, -0.1, -0.7};
	mountRotation = {0, 0, 0.5};
};
ItemData AerinShield
{
	description = "Aerin Shield";
	className = "Accessory";
	shapeFile = "shield3";
	imageType = AerinShieldImage;

	heading = "eMiscellany";
	price = 0;
};
ItemData AerinShield0
{
	description = "Aerin Shield";
	className = "Equipped";
	shapeFile = "shield3";
	heading = "aArmor";
};
function AerinShield::onmount(%player, %item)
{		
		%clientId = Player::getClient(%player);
		Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
		Player::setItemCount(%player, %item @ "0", Player::getItemCount(%player, %item @ "0")+1);
		$PlayerSkill[%clientId, $SkillHealing] += 250;
		$PlayerSkill[%clientId, $SkillDefensiveCasting] += 250;
	
}
function AerinShield0::onmount(%player, %item)
{		
		%clientId = Player::getClient(%player);
		%o = String::getSubStr(%item, 0, String::len(%item)-1);
		Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
		Player::setItemCount(%player, %o, Player::getItemCount(%player, %o)+1);
		$PlayerSkill[%clientId, $SkillHealing] -= 250;
		$PlayerSkill[%clientId, $SkillDefensiveCasting] -= 250;

}
//============================================================================

ItemData MaleHumanTownBot
{
	description = "Male Town Bot";
	className = "TownBot";
	shapeFile = "rpgmalehuman";
	visibleToSensor = true;
	mapFilter = 1;
};

ItemData FemaleHumanTownBot
{
	description = "Female Town Bot";
	className = "TownBot";
	shapeFile = "lfemalehuman";
	visibleToSensor = true;
	mapFilter = 1;
};

ItemData UberTownBot
{
	description = "Uber Town Bot";
	className = "TownBot";
	shapeFile = "fedmonster";
	visibleToSensor = true;
	mapFilter = 1;
};

ItemData GoblinTownBot
{
	description = "Goblin Town Bot";
	className = "TownBot";
	shapeFile = "Goblin";
	visibleToSensor = true;
	mapFilter = 1;
};

ItemData GnollTownBot
{
	description = "Gnoll Town Bot";
	className = "TownBot";
	shapeFile = "marmorgnoll";
	visibleToSensor = true;
	mapFilter = 1;
};

ItemData SkelTownBot
{
	description = "Skel Town Bot";
	className = "TownBot";
	shapeFile = "Skel";
	visibleToSensor = true;
	mapFilter = 1;
};

ItemData ZombieTownBot
{
	description = "Zombie Town Bot";
	className = "TownBot";
	shapeFile = "Zombie";
	visibleToSensor = true;
	mapFilter = 1;
};

ItemData MinotaurTownBot
{
	description = "Minotaur Town Bot";
	className = "TownBot";
	shapeFile = "Min";
	visibleToSensor = true;
	mapFilter = 1;
};

ItemData OgreTBTownBot
{
	description = "Ogre Town Bot";
	className = "TownBot";
	shapeFile = "harmor";
	visibleToSensor = true;
	mapFilter = 1;
};

ItemData TreeTownBot
{
	description = "Tree Town Bot";
	className = "TownBot";
	shapeFile = "tree1";
	visibleToSensor = true;
	mapFilter = 1;
};

//===== MISC STUFF =====//

$AccessoryVar[Tent, $Weight] = 40;
$AccessoryVar[Tent, $MiscInfo] = "A tent. Use #camp to set it up, and #uncamp to disassemble it.";

ItemData Tent
{
	description = "Tent";
	shapeFile = "armorKit";
	heading = "eMiscellany";
	className = "Accessory";
	shadowDetailMask = 4;
	price = 0;
};

ItemData Lootbag
{
	description = "Backpack";
	className = "Lootbag";
	shapeFile = "ammo2";
	heading = "eMiscellany";
	shadowDetailMask = 4;
	price = 0;
};

//===================
//  LORE ITEMS
//===================
$ItemList[Lore, 1] = "Parchment";
$ItemList[Lore, 2] = "MagicDust";
$ItemList[Lore, 3] = "LightRune";
$ItemList[Lore, 4] = "DarkRune";

$AccessoryVar[Parchment, $Weight] = 0.2;
$AccessoryVar[Parchment, $MiscInfo] = "A parchment";
$LoreItem[Parchment] = True;

ItemData Parchment
{
	description = "Parchment";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};


$AccessoryVar[MagicDust, $Weight] = 0.2;
$AccessoryVar[MagicDust, $MiscInfo] = "A small bag containing magic dust";
$LoreItem[MagicDust] = True;

ItemData MagicDust
{
	description = "Magic Dust";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};


$AccessoryVar[LightRune, $Weight] = 0.2;
$AccessoryVar[LightRune, $MiscInfo] = "A Light In <f2>Darkness<f1>";
$LoreItem[LightRune] = True;

ItemData LightRune
{
	description = "Divine Torch";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};


$AccessoryVar[DarkRune, $Weight] = 0.2;
$AccessoryVar[DarkRune, $MiscInfo] = "May the Shadows <f2>Darken<f1> you.";
$LoreItem[MagicDust] = True;

ItemData DarkRune
{
	description = "Shadow's Snare";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};

//===================================================
// ORBS
//===================================================
$ItemList[Orb, 1] = "OrbOfBreath";
$ItemList[Orb, 2] = "OrbOfLuminance";
$ItemList[Orb, 3] = "DracosEye";
$ItemList[Orb, 4] = "OrbOfXion";

$AccessoryVar[OrbOfLuminance, $AccessoryType] = $OrbAccessoryType;
$AccessoryVar[OrbOfLuminance, $Weight] = 1.0;
$AccessoryVar[OrbOfLuminance, $MiscInfo] = "The Orb Of Luminance provides you with temporary illumination.";
$BurnOut[OrbOfLuminance] = 150;
$BurnOutInRain[OrbOfLuminance] = 5;
$ProtectFromWater[OrbOfLuminance] = "";

ItemImageData OrbOfLuminanceImage
{
	shapeFile = "orb";
	mountPoint = $OverrideMountPoint[OrbOfLuminance];
	mountOffset = {0.0, 0.0, 1.8};
	mountRotation = {5, 3, 3};

	lightType = 2;
	lightRadius = 43;
	lightTime = 9999;
	lightColor = { 0.95, 0.85, 0.55 };
};
ItemData OrbOfLuminance
{
	description = "Orb Of Luminance";
	className = "Accessory";
	shapeFile = "orb";
	imageType = OrbOfLuminanceImage;

	heading = "yOrbs";
	price = 0;
};
ItemData OrbOfLuminance0
{
	description = "Lit Orb Of Luminance";
	className = "Equipped";
	shapeFile = "orb";
	imageType = OrbOfLuminanceImage;

	heading = "aArmor";
};

//Orb of Breath
$AccessoryVar[OrbOfBreath, $AccessoryType] = $OrbAccessoryType;
$AccessoryVar[OrbOfBreath, $Weight] = 0.8;
$AccessoryVar[OrbOfBreath, $MiscInfo] = "The Orb Of Breath provides you with a temporary ability to breathe underwater.";
$BurnOut[OrbOfBreath] = 300;
$BurnOutInRain[OrbOfBreath] = 0;
$ProtectFromWater[OrbOfBreath] = True;

ItemImageData OrbOfBreathImage
{
	shapeFile = "orb";
	mountPoint = $OverrideMountPoint[OrbOfBreath];
	mountOffset = {0.0, 0.0, 1.4};
	mountRotation = {5, 3, 3};
};
ItemData OrbOfBreath
{
	description = "Orb Of Breath";
	className = "Accessory";
	shapeFile = "orb";
	imageType = OrbOfBreathImage;

	heading = "yOrbs";
	price = 0;
};
ItemData OrbOfBreath0
{
	description = "Orb Of Breath in use";
	className = "Equipped";
	shapeFile = "orb";
	imageType = OrbOfBreathImage;

	heading = "aArmor";
};

// Relics //

$AccessoryVar[RelicOfTheWind, $Weight] = 8;
$AccessoryVar[RelicOfTheWind, $MiscInfo] = "A ancient relic which possess magical properties.";

ItemData RelicOfTheWind
{
	description = "Relic of the Wind";
	className = "Accessory";
	shapeFile = "granite";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[RelicOfProtection, $Weight] = 8;
$AccessoryVar[RelicOfProtection, $MiscInfo] = "A ancient relic which possess magical properties.";

ItemData RelicOfProtection
{
	description = "Relic of Protection";
	className = "Accessory";
	shapeFile = "granite";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[RelicOfTheTree, $Weight] = 8;
$AccessoryVar[RelicOfTheTree, $MiscInfo] = "A ancient relic which possess magical properties.";

ItemData RelicOfTheRoot
{
	description = "Relic of the Root";
	className = "Accessory";
	shapeFile = "granite";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[RelicOfTheRiver, $Weight] = 8;
$AccessoryVar[RelicOfTheRiver, $MiscInfo] = "A ancient relic which possess magical properties.";
$ProtectFromWater[RelicofTheRiver] = True;
$ItemList[wrelic, 1] = "RelicofTheRiver";

ItemData RelicOfTheRiver
{
	description = "Relic of the River";
	className = "Accessory";
	shapeFile = "granite";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[Token, $Weight] = 0.1;
$AccessoryVar[Token, $MiscInfo] = "A token given by admins for good deeds. Collect them and trade em in for good stuff!";

ItemData Token
{
	description = "Token";
	className = "Accessory";
	shapeFile = "granite";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};


$AccessoryVar[Soul, $Weight] = 0.1;
$AccessoryVar[Soul, $MiscInfo] = "You have the soul of someone in your hands.";

ItemData Soul
{
	description = "Soul";
	className = "Accessory";
	shapeFile = "granite";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[LHeart, $Weight] = 0.1;
$AccessoryVar[LHeart, $MiscInfo] = "A petrified peice of a Human Heart.. Or is it really from a human?";

ItemData LHeart
{
	description = "Left Heart";
	className = "Accessory";
	shapeFile = "granite";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[RHeart, $Weight] = 0.1;
$AccessoryVar[RHeart, $MiscInfo] = "A petrified peice of a Human Heart.. Or is it really from a human?";

ItemData RHeart
{
	description = "Right Heart";
	className = "Accessory";
	shapeFile = "granite";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[AHeart, $Weight] = 0.1;
$AccessoryVar[AHeart, $MiscInfo] = "A heart from the very body of a Celestial.";

ItemData AHeart
{
	description = "Angel Heart";
	className = "Accessory";
	shapeFile = "granite";
	heading = "zRares";
	shadowDetailMask = 4;
	price = 0;
};



$StealProtectedItem[RelicOfTheWind] = true;
$StealProtectedItem[RelicOfProtection] = true;
$StealProtectedItem[RelicOfTheRoot] = true;
$StealProtectedItem[RelicOfTheRiver] = true;
$StealProtectedItem[Token] = true;
$StealProtectedItem[LHeart] = true;
$StealProtectedItem[RHeart] = true;
$StealProtectedItem[AHeart] = true;

$ItemList[Arm, 1] = "ArmGuard";
$SkillRestriction[ArmGuard] = $SkillEndurance @ " 124";
$AccessoryVar[ArmGuard, $AccessoryType] = $LeftArmAccessoryType;
$AccessoryVar[ArmGuard, $SpecialVar] = "7 30";
$AccessoryVar[ArmGuard, $Weight] = 2;
$AccessoryVar[ArmGuard, $MiscInfo] = "Protect your left shoulder with this.";
$HardcodedItemCost[ArmGuard] = 10000;

ItemImageData ArmGuardImage
{
	shapeFile = "shieldPack";
	mountPoint = 2;
      mountOffset = { -0.45, 0.1, 0.1 };
      mountRotation = { -0.2, 0, 46 }; 
};
ItemData ArmGuard
{
	description = "Arm Guard";
	className = "Accessory";
	shapeFile = "shieldPack";
	imageType = ArmGuardImage;

	heading = "eMiscellany";
	price = 0;
};
ItemData ArmGuard0
{
	description = "Arm Guard";
	className = "Equipped";
	shapeFile = "armorPack";
	imageType = ArmGuardImage;

	heading = "aArmor";
};

//===================
// Badges
//===================
$ItemList[Badge, 1] = "Vesperillitus";
$ItemList[Badge, 2] = "Nexiom";
$ItemList[Badge, 3] = "Scythis";
$ItemList[Badge, 4] = "Aerius";
$ItemList[Badge, 5] = "Macrius";


$AccessoryVar[Vesperillitus, $Weight] = 1;
$AccessoryVar[Vesperillitus, $MiscInfo] = "One | Jester ";
$BonusItem[Vesperillitus] = "LCK 1 220";	//a chance in 220 every ZoneCheck that 1 LCK will be awarded
$StealProtectedItem[Vesperillitus] = True;

ItemData Vesperillitus
{
	description = "Vesperillitus";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "eMiscellany";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[Nexium, $Weight] = 1;
$AccessoryVar[Nexium, $MiscInfo] = "Two | Power";
$BonusItem[Nexium] = "EXP 3 120";
$StealProtectedItem[Nexium] = True;

ItemData Nexium
{
	description = "Nexium";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "eMiscellany";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[Scythis, $Weight] = 1;
$AccessoryVar[Scythis, $MiscInfo] = "Three | Greed";
$BonusItem[Scythis] = "COINS 50 80";
$StealProtectedItem[Scythis] = True;

ItemData Scythis
{
	description = "Scythis";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "eMiscellany";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[Aerius, $Weight] = 1;
$AccessoryVar[Aerius, $MiscInfo] = "Four | Knowledge";
$BonusItem[Aerius] = "SP 1 180";
$StealProtectedItem[Aerius] = True;

ItemData Aerius
{
	description = "Aerius";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "eMiscellany";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[Trancephyte, $Weight] = 1;
$StealProtectedItem[Trancephyte] = True;
ItemData Trancephyte
{
	description = "Trancephyte";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "eMiscellany";
	shadowDetailMask = 4;
	price = 0;
};

$AccessoryVar[Macrius, $Weight] = 1;
$AccessoryVar[Macrius, $MiscInfo] = "Five | Warrior ";
$BonusItem[Macrius] = "COINS 10";
$StealProtectedItem[Macrius] = True;

ItemData Macrius
{
	description = "Macrius";
	className = "Accessory";
	shapeFile = "grenade";
	heading = "eMiscellany";
	shadowDetailMask = 4;
	price = 0;
};