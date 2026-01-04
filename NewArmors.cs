function GenerateAllArmorCosts()
{
	$ItemCost[ScaleMail] = 0;
	$ItemCost[BrigandineArmor] = GenerateItemCost(BrigandineArmor);
	$ItemCost[ChainMail] = GenerateItemCost(ChainMail);
	$ItemCost[RingMail] = GenerateItemCost(RingMail);
	$ItemCost[BandedMail] = GenerateItemCost(BandedMail);
	$ItemCost[SplintMail] = GenerateItemCost(SplintMail);
	$ItemCost[BronzePlateMail] = GenerateItemCost(BronzePlateMail);
	$ItemCost[DracoPlateMail] = GenerateItemCost(DracoPlateMail);
	$ItemCost[DragonMail] = 700000;
	$ItemCost[FullPlateArmor] = GenerateItemCost(FullPlateArmor);
	$ItemCost[KnightsArmor] = GenerateItemCost(KnightsArmor);
	$ItemCost[KeldrinArmor] = GenerateItemCost(KeldrinArmor);
	$ItemCost[DevilsArmor] = 8000000;
	$ItemCost[MithrilMail] = 12000000;
// robes
	$ItemCost[LightRobe] = GenerateItemCost(LightRobe);
	$ItemCost[BloodRobe] = GenerateItemCost(BloodRobe);
	$ItemCost[AdvisorRobe] = GenerateItemCost(AdvisorRobe);
	$ItemCost[PhensRobe] = GenerateItemCost(PhensRobe);
	$ItemCost[ArkemnsRobe] = GenerateItemCost(ArkemnsRobe);
	$ItemCost[CenturionRobe] = 200000;
	$ItemCost[RobeofVigor] = 250000;
	$ItemCost[RobeofThought] = 250000;
	$ItemCost[QuestMasterRobe] = 0;
	$ItemCost[ElvenRobe] = GenerateItemCost(ElvenRobe);
// movement mods
	$ItemCost[CheetaursPaws] = GenerateItemCost(CheetaursPaws);
	$ItemCost[BootsOfGliding] = GenerateItemCost(BootsOfGliding);
	$ItemCost[WindWalkers] = GenerateItemCost(WindWalkers);
}

$AccessoryVar[ScaleMail, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[BrigandineArmor, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[ChainMail, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[RingMail, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[BandedMail, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[SplintMail, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[BronzePlateMail, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[DracoPlateMail, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[FullPlateArmor, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[KnightsArmor, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[LightRobe, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[BloodRobe, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[AdvisorRobe, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[PhensRobe, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[ArkemnsRobe, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[CenturionRobe, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[RobeofVigor, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[RobeofThought, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[QuestMasterRobe, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[ElvenRobe, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[DragonMail, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[KeldrinArmor, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[DevilsArmor, $AccessoryType] = $BodyAccessoryType;
$AccessoryVar[MithrilMail, $AccessoryType] = $BodyAccessoryType;

$AccessoryVar[ScaleMail, $SpecialVar] = "7 280 4 22";
$AccessoryVar[BrigandineArmor, $SpecialVar] = "7 330 4 28";
$AccessoryVar[ChainMail, $SpecialVar] = "7 380 4 33";
$AccessoryVar[RingMail, $SpecialVar] = "7 430 4 38";
$AccessoryVar[BandedMail, $SpecialVar] = "7 480 4 43";
$AccessoryVar[SplintMail, $SpecialVar] = "7 530 4 47";
$AccessoryVar[DragonMail, $SpecialVar] = "7 730 4 70";
$AccessoryVar[BronzePlateMail, $SpecialVar] = "7 580 4 53";
$AccessoryVar[DracoPlateMail, $SpecialVar] = "7 690 4 65";
$AccessoryVar[FullPlateArmor, $SpecialVar] = "7 780 4 75";
$AccessoryVar[KnightsArmor, $SpecialVar] = "7 820 4 100";
$AccessoryVar[KeldrinArmor, $SpecialVar] = "7 880 3 350 4 110";
$AccessoryVar[LightRobe, $SpecialVar] = "3 100 4 2";
$AccessoryVar[BloodRobe, $SpecialVar] = "3 320 4 7";
$AccessoryVar[AdvisorRobe, $SpecialVar] = "3 400 4 8";
$AccessoryVar[ElvenRobe, $SpecialVar] = "3 480 4 11";
$AccessoryVar[RobeOfVenjance, $SpecialVar] = "3 600 4 15";
$AccessoryVar[PhensRobe, $SpecialVar] = "3 800 4 15 11 125";
$AccessoryVar[ArkemnsRobe, $SpecialVar] = "7 500 3 900 4 100 11 300";
$AccessoryVar[QuestMasterRobe, $SpecialVar] = "3 1000 4 1000 5 1000 6 1000 7 1000 10 1000 11 1000";
$AccessoryVar[CenturionRobe, $SpecialVar] = "3 480 4 20 7 100";
$AccessoryVar[RobeofVigor, $SpecialVar] = "4 200 10 15";
$AccessoryVar[RobeofThought, $SpecialVar] = "3 50 5 100";
$AccessoryVar[DevilsArmor, $SpecialVar] = "7 750 3 600 4 100";
$AccessoryVar[MithrilMail, $SpecialVar] = "3 550 4 310 7 1350 10 5";

$AccessoryVar[ScaleMail, $Weight] = 40;
$AccessoryVar[BrigandineArmor, $Weight] = 35;
$AccessoryVar[ChainMail, $Weight] = 40;
$AccessoryVar[RingMail, $Weight] = 30;
$AccessoryVar[BandedMail, $Weight] = 35;
$AccessoryVar[SplintMail, $Weight] = 40;
$AccessoryVar[BronzePlateMail, $Weight] = 45;
$AccessoryVar[DracoPlateMail, $Weight] = 35;
$AccessoryVar[FullPlateArmor, $Weight] = 70;
$AccessoryVar[KnightsArmor, $Weight] = 20;
$AccessoryVar[LightRobe, $Weight] = 19;
$AccessoryVar[BloodRobe, $Weight] = 18;
$AccessoryVar[AdvisorRobe, $Weight] = 17;
$AccessoryVar[PhensRobe, $Weight] = 15;
$AccessoryVar[ArkemnsRobe, $Weight] = 15;
$AccessoryVar[CenturionRobe, $Weight] = 10;
$AccessoryVar[RobeofVigor, $Weight] = 5;
$AccessoryVar[RobeofThought, $Weight] = 8;
$AccessoryVar[QuestMasterRobe, $Weight] = 14;
$AccessoryVar[ElvenRobe, $Weight] = 10;
$AccessoryVar[DragonMail, $Weight] = 35;
$AccessoryVar[KeldrinArmor, $Weight] = 105;
$AccessoryVar[DevilsArmor, $Weight] = 80;
$AccessoryVar[MithrilMail, $Weight] = 80;

$AccessoryVar[ScaleMail, $MiscInfo] = "Scale Mail";
$AccessoryVar[BrigandineArmor, $MiscInfo] = "Brigandine Armor";
$AccessoryVar[ChainMail, $MiscInfo] = "Chain Mail";
$AccessoryVar[RingMail, $MiscInfo] = "Ring Mail";
$AccessoryVar[BandedMail, $MiscInfo] = "Banded Mail";
$AccessoryVar[SplintMail, $MiscInfo] = "Splint Mail";
$AccessoryVar[BronzePlateMail, $MiscInfo] = "Bronze Plate Mail";
$AccessoryVar[DracoPlateMail, $MiscInfo] = "Draco Plate Mail";
$AccessoryVar[FullPlateArmor, $MiscInfo] = "Full Plate Armor";
$AccessoryVar[KnightsArmor, $MiscInfo] = "Only worn by honored Knights.";
$AccessoryVar[LightRobe, $MiscInfo] = "Light Robe";
$AccessoryVar[BloodRobe, $MiscInfo] = "Blood Robe";
$AccessoryVar[AdvisorRobe, $MiscInfo] = "A robe worn by the elite mages of the realm";
$AccessoryVar[PhensRobe, $MiscInfo] = "<f1>The godly mage <f2>Phen's <f1>robe";
$AccessoryVar[ArkemnsRobe, $MiscInfo] = "<f1>The godly mage <f2>Arkemn's <f1>robe";
$AccessoryVar[QuestMasterRobe, $MiscInfo] = "<f2>Quest Master Robe";
$AccessoryVar[ElvenRobe, $MiscInfo] = "An elven robe";
$AccessoryVar[CenturionRobe, $MiscInfo] = "A strong robe worn by the Centurions";
$AccessoryVar[RobeofVigor, $MiscInfo] = "Infused with an ubers blood to increase the wearers health";
$AccessoryVar[RobeofThought, $MiscInfo] = "Raises the owners thinking capacity";
$AccessoryVar[DragonMail, $MiscInfo] = "A dragon scale mail";
$AccessoryVar[KeldrinArmor, $MiscInfo] = "Keldrinite-plated armor";
$AccessoryVar[DevilsArmor, $MiscInfo] = "Worn by the Devil's troops.";
$AccessoryVar[MithrilMail, $MiscInfo] = "<f2>Armor Smithed with Mithril. Worn only by the most elite Fighters.";

$ArmorSkin[ScaleMail] = "rpgscalemail";
$ArmorSkin[BrigandineArmor] = "rpgbrigandine";
$ArmorSkin[ChainMail] = "rpgchainmail";
$ArmorSkin[RingMail] = "rpgringmail";
$ArmorSkin[BandedMail] = "rpgbandedmail";
$ArmorSkin[SplintMail] = "rpgsplintmail";
$ArmorSkin[BronzePlateMail] = "rpgbronzeplate";
$ArmorSkin[DracoPlateMail] = "min";
$ArmorSkin[FullPlateArmor] = "rpgfullplate";
$ArmorSkin[KnightsArmor] = "cphoenix";
$ArmorSkin[LightRobe] = "robepurple";
$ArmorSkin[BloodRobe] = "robered";
$ArmorSkin[AdvisorRobe] = "robeblue";
$ArmorSkin[PhensRobe] = "robewhite";
$ArmorSkin[ArkemnsRobe] = "robebrown";
$ArmorSkin[QuestMasterRobe] = "robeorange";
$ArmorSkin[ElvenRobe] = "robegreen";
$ArmorSkin[CenturionRobe] = "robeblack";
$ArmorSkin[RobeofVigor] = "robegreen";
$ArmorSkin[RobeofThought] = "robewhite";
$ArmorSkin[DragonMail] = "rpghuman6";
$ArmorSkin[KeldrinArmor] = "rpgfullplate";
$ArmorSkin[DevilsArmor] = "knightarmor";
$ArmorSkin[MithrilMail] = "rpghuman7";

//the way it works is:
// $RACE[%clientId] @ $ArmorPlayerModel[WhateverArmor]
$ArmorPlayerModel[ScaleMail] = "";
$ArmorPlayerModel[BrigandineArmor] = "";
$ArmorPlayerModel[ChainMail] = "";
$ArmorPlayerModel[RingMail] = "";
$ArmorPlayerModel[BandedMail] = "";
$ArmorPlayerModel[SplintMail] = "";
$ArmorPlayerModel[BronzePlateMail] = "";
$ArmorPlayerModel[DracoPlateMail] = "";
$ArmorPlayerModel[FullPlateArmor] = "";
$ArmorPlayerModel[KnightsArmor] = "";
$ArmorPlayerModel[LightRobe] = "";
$ArmorPlayerModel[BloodRobe] = "";
$ArmorPlayerModel[AdvisorRobe] = "";
$ArmorPlayerModel[PhensRobe] = "";
$ArmorPlayerModel[ArkemnsRobe] = "";
$ArmorPlayerModel[QuestMasterRobe] = "";
$ArmorPlayerModel[CenturionRobe] = "";
$ArmorPlayerModel[RobeofVigor] = "";
$ArmorPlayerModel[RobeofThought] = "";
$ArmorPlayerModel[ElvenRobe] = "";
$ArmorPlayerModel[DragonMail] = "";
$ArmorPlayerModel[KeldrinArmor] = "";
$ArmorPlayerModel[DevilsArmor] = "";
$ArmorPlayerModel[MithrilMail] = "";

$ArmorHitSound[ScaleMail] = SoundHitChain;
$ArmorHitSound[BrigandineArmor] = SoundHitChain;
$ArmorHitSound[ChainMail] = SoundHitChain;
$ArmorHitSound[RingMail] = SoundHitChain;
$ArmorHitSound[BandedMail] = SoundHitChain;
$ArmorHitSound[SplintMail] = SoundHitChain;
$ArmorHitSound[BronzePlateMail] = SoundHitPlate;
$ArmorHitSound[DracoPlateMail] = SoundHitPlate;
$ArmorHitSound[FullPlateArmor] = SoundHitPlate;
$ArmorHitSound[KnightsArmor] = SoundHitChain;
$ArmorHitSound[LightRobe] = SoundHitFlesh;
$ArmorHitSound[BloodRobe] = SoundHitFlesh;
$ArmorHitSound[AdvisorRobe] = SoundHitFlesh;
$ArmorHitSound[PhensRobe] = SoundHitFlesh;
$ArmorHitSound[ArkemnsRobe] = SoundHitFlesh;
$ArmorHitSound[QuestMasterRobe] = SoundHitFlesh;
$ArmorHitSound[ElvenRobe] = SoundHitFlesh;
$ArmorHitSound[CenturionRobe] = SoundHitLeather;
$ArmorHitSound[RobeofVigor] = SoundHitFlesh;
$ArmorHitSound[RobeofThought] = SoundHitFlesh;
$ArmorHitSound[DragonMail] = SoundHitChain;
$ArmorHitSound[KeldrinArmor] = SoundHitPlate;
$ArmorHitSound[DevilsArmor] = SoundHitPlate;
$ArmorHitSound[MithrilMail] = SoundHitPlate;

//this list is used to make things easy when cycling between armors
$ArmorList[1] = "ScaleMail";
$ArmorList[2] = "BrigandineArmor";
$ArmorList[3] = "ChainMail";
$ArmorList[4] = "RingMail";
$ArmorList[5] = "BandedMail";
$ArmorList[6] = "SplintMail";
$ArmorList[7] = "BronzePlateMail";
$ArmorList[8] = "FullPlateArmor";
$ArmorList[9] = "DevilsArmor";
$ArmorList[11] = "MithrilMail";
$ArmorList[12] = "LightRobe";
$ArmorList[13] = "BloodRobe";
$ArmorList[14] = "AdvisorRobe";
$ArmorList[15] = "RobeofThought";
$ArmorList[16] = "PhensRobe";
$ArmorList[17] = "QuestMasterRobe";
$ArmorList[18] = "ElvenRobe";
$ArmorList[19] = "DragonMail";
$ArmorList[20] = "KeldrinArmor";
$ArmorList[21] = "SpikedLeather";
$ArmorList[22] = "ArkemnsRobe";
$ArmorList[23] = "CenturionRobe";
$ArmorList[24] = "RobeofVigor";
$ArmorList[25] = "DracoPlateMail";
$ArmorList[26] = "KnightsArmor";


//============================================================================
ItemData ScaleMail
{
	description = "Scale Mail";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData BrigandineArmor
{
	description = "Brigandine Armor";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData ChainMail
{
	description = "Chain Mail";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData RingMail
{
	description = "Ring Mail";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData BandedMail
{
	description = "Banded Mail";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData SplintMail
{
	description = "Splint Mail";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData DragonMail
{
	description = "Dragon Mail";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData BronzePlateMail
{
	description = "Bronze Plate Mail";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData DracoPlateMail
{
	description = "Draco Plate Mail";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData FullPlateArmor
{
	description = "Full Plate Armor";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData KnightsArmor
{
	description = "Knights Armor";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData KeldrinArmor
{
	description = "Keldrin Armor";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData DevilsArmor
{
	description = "Devil's Armor";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//=============================================================================
ItemData MithrilMail
{
	description = "Mithril Mail";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData LightRobe
{
	description = "Light Robe";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData ElvenRobe
{
	description = "Elven Robe";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData BloodRobe
{
	description = "Blood Robe";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData AdvisorRobe
{
	description = "Advisor Robe";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData PhensRobe
{
	description = "Phen's Robe";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData ArkemnsRobe
{
	description = "Arkemn's Robe";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData QuestMasterRobe
{
	description = "Quest Master Robe";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData CenturionRobe
{
	description = "Centurion Robe";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData RobeofVigor
{
	description = "Robe of Vigor";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};

//============================================================================
ItemData RobeofThought
{
	description = "Robe of Thought";
	className = "Armor";
	shapeFile = "discammo";

	heading = "eMiscellany";
	price = 0;
};
