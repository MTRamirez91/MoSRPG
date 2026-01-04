function SetupShop(%clientId, %id)
{
	dbecho($dbechoMode, "SetupShop(" @ %clientId @ ", " @ %id @ ")");

	ClearCurrentShopVars(%clientId);
	%clientId.currentShop = %id;

	%clientId.bulkNum = "";

	Client::clearItemShopping(%clientId);
	Client::clearItemBuying(%clientId);

	Client::setGuiMode(%clientId, 4);

	%txt = "<f1><jc>COINS: " @ fetchData(%clientId, "COINS");
	Client::setInventoryText(%clientId, %txt);

	%info = $BotInfo[%id.name, SHOP];	

	for(%i = 0; GetWord(%info, %i) != -1; %i++)
	{
		%a = GetWord(%info, %i);

		%max = getNumItems();		
		for(%z = 0; %z < %max; %z++)
		{
			%item = getItemData(%z);

			if($AccessoryVar[%item, $ShopIndex] == %a)
			{
				Client::setItemShopping(%clientId, %item);
				Client::setItemBuying(%clientId, %item);
			}
		}
	}
}

function SetupBank(%clientId, %id)
{
	dbecho($dbechoMode, "SetupBank(" @ %clientId @ ", " @ %id @ ")");

	ClearCurrentShopVars(%clientId);
	%clientId.currentBank = %id;

	%clientId.bulkNum = "";

	Client::clearItemShopping(%clientId);
	Client::clearItemBuying(%clientId);

	if(Client::getGuiMode(%clientId) != 4)
		Client::setGuiMode(%clientId, 4);

	%txt = "<f1><jc>COINS: " @ fetchData(%clientId, "COINS");
	Client::setInventoryText(%clientId, %txt);

	%info = fetchData(%clientId, "BankStorage");

	for(%i = 0; GetWord(%info, %i) != -1; %i+=2)
	{
		%item = GetWord(%info, %i);

		Client::setItemShopping(%clientId, %item);
		Client::setItemBuying(%clientId, %item);
	}
}

function SetupBank2(%clientId, %id)
{
	dbecho($dbechoMode, "SetupBank2(" @ %clientId @ ", " @ %id @ ")");

	ClearCurrentShopVars(%clientId);
	%clientId.currentBank = %id;

	%clientId.bulkNum = "";

	Client::clearItemShopping(%clientId);
	Client::clearItemBuying(%clientId);

	if(Client::getGuiMode(%clientId) != 4)
		Client::setGuiMode(%clientId, 4);

	%txt = "<f1><jc>COINS: " @ fetchData(%clientId, "COINS");
	Client::setInventoryText(%clientId, %txt);

	%info = fetchData(%clientId, "BankStorage2");

	for(%i = 0; GetWord(%info, %i) != -1; %i+=2)
	{
		%item = GetWord(%info, %i);

		Client::setItemShopping(%clientId, %item);
		Client::setItemBuying(%clientId, %item);
	}
}

function SetupBlacksmith(%clientId, %id)
{
	dbecho($dbechoMode, "SetupBlacksmith(" @ %clientId @ ", " @ %id @ ")");

	%clientId.currentSmith = %id;

	%clientId.bulkNum = "";

	Client::clearItemShopping(%clientId);
	Client::clearItemBuying(%clientId);

	if(Client::getGuiMode(%clientId) != 4)
		Client::setGuiMode(%clientId, 4);

	%info = fetchData(%clientId, "TempSmith");
	for(%i = 0; GetWord(%info, %i) != -1; %i+=2)
	{
		%item = GetWord(%info, %i);

		Client::setItemShopping(%clientId, %item);
		Client::setItemBuying(%clientId, %item);
	}

	%txt = "<f1><jc>COINS: " @ fetchData(%clientId, "COINS");
	Client::setInventoryText(%clientId, %txt);
}

function SetupInvSteal(%clientId, %id)
{
	dbecho($dbechoMode, "SetupInvSteal(" @ %clientId @ ", " @ %id @ ")");

	ClearCurrentShopVars(%clientId);
	%clientId.currentInvSteal = %id;

	%clientId.bulkNum = "";

	Client::clearItemShopping(%clientId);
	Client::clearItemBuying(%clientId);

	if(Client::getGuiMode(%clientId) != 4)
		Client::setGuiMode(%clientId, 4);

	%txt = "<f1><jc>" @ Client::getName(%id) @ "'s inventory";
	Client::setInventoryText(%clientId, %txt);

	%max = getNumItems();
	for(%i = 0; %i < %max; %i++)
	{
		%item = getItemData(%i);
		%itemcount = Player::getItemCount(%id, %item);

		if(%itemcount > 0)
		{
			Client::setItemShopping(%clientId, %item);
			Client::setItemBuying(%clientId, %item);
		}
	}
}

function SetupCreatePack(%clientId)
{
	dbecho($dbechoMode, "SetupCreatePack(" @ %clientId @ ")");

	Client::clearItemShopping(%clientId);
	Client::clearItemBuying(%clientId);

	if(Client::getGuiMode(%clientId) != 4)
		Client::setGuiMode(%clientId, 4);

	%info = fetchData(%clientId, "TempPack");
	for(%i = 0; GetWord(%info, %i) != -1; %i+=2)
	{
		%item = GetWord(%info, %i);

		Client::setItemShopping(%clientId, %item);
		Client::setItemBuying(%clientId, %item);
	}
}

function ClearCurrentShopVars(%clientId)
{
	dbecho($dbechoMode, "ClearCurrentShopVars(" @ %clientId @ ")");

      %clientId.currentShop = "";
      %clientId.currentBank = "";
      %clientId.currentSmith = "";
	%clientId.currentInvSteal = "";

	storeData(%clientId, "TempPack", "");
	storeData(%clientId, "TempSmith", "");
}

//////////////////////////////////////////////////////////
// Grouped in hundreds for quick add-ons to shops	//
// Below 100 - Misc items				//
// 100's - Armors and Robes				//
// 200's - Shields and Boots				//
// 300's - Slashing Weps				//
// 400's - Bludge Weps					//
// 500's - Pierce Weps					//
// 600's - Archery Weps					//
// 700's - Misc Weps					//
//				//////////////////////////
// K = Keldrin Village		//
// E = Ethren			//
// J = Jaten			//
// D = Delkin			//
// H1 = Heaven Merchant One	//
// H2 = Heaven Merchant Two	//
// Mv = Mystic Village		//
// R = Roxicity			//
// Mg = Mage Town		//
//////////////////////////////////

// Misc //
$AccessoryVar[ReplenishVial, $ShopIndex] = 1;		// K, E, J, D, H1, Mg, Mv, R
$AccessoryVar[Tent, $ShopIndex] = 2;			// K, J, D, Mv, R
$AccessoryVar[OrbOfLuminance, $ShopIndex] = 3;		// E, J, D, R
$AccessoryVar[OrbOfBreath, $ShopIndex] = 4;		// D, Mv, R
$AccessoryVar[OrbofXion, $ShopIndex] = 5;		// H1, Mv, R
// Gems //
$AccessoryVar[Quartz, $ShopIndex] = 6;			// Miner
$AccessoryVar[Granite, $ShopIndex] = 7;			// Miner
$AccessoryVar[Opal, $ShopIndex] = 8;			// Miner
$AccessoryVar[Jade, $ShopIndex] = 9;			// Miner
$AccessoryVar[Turquoise, $ShopIndex] = 10;		// Miner
$AccessoryVar[Ruby, $ShopIndex] = 11;			// Miner
$AccessoryVar[Topaz, $ShopIndex] = 12;			// Miner
$AccessoryVar[Sapphire, $ShopIndex] = 13;		// Miner
$AccessoryVar[Gold, $ShopIndex] = 14;			// Miner
$AccessoryVar[Emerald, $ShopIndex] = 15;		// Miner
// Rings and Talismen //
$AccessoryVar[BlackRing, $ShopIndex] = 16;		// H1
$AccessoryVar[ManaRing, $ShopIndex] = 17;		// H1, Mg
$AccessoryVar[TalismanMregen, $ShopIndex] = 18;		// H1, Mv
$AccessoryVar[TalismanHregen, $ShopIndex] = 19;		// H1, R

// Armors //
$AccessoryVar[BrigandineArmor, $ShopIndex] = 101;	// K
$AccessoryVar[ChainMail, $ShopIndex] = 102;		// K, D
$AccessoryVar[RingMail, $ShopIndex] = 103;		// J, D
$AccessoryVar[BandedMail, $ShopIndex] = 104;		// E, J
$AccessoryVar[SplintMail, $ShopIndex] = 105;		// E
$AccessoryVar[BronzePlateMail, $ShopIndex] = 106;	// E, Mv
$AccessoryVar[FullPlateArmor, $ShopIndex] = 107;	// H2, Mv
$AccessoryVar[DragonMail, $ShopIndex] = 108;		// R
$AccessoryVar[KeldrinArmor, $ShopIndex] = 109;		// H2

// Robes //
$AccessoryVar[LightRobe, $ShopIndex] = 111;		// Mg
$AccessoryVar[BloodRobe, $ShopIndex] = 112;		// Mg
$AccessoryVar[AdvisorRobe, $ShopIndex] = 113;		// Mg
$AccessoryVar[RobeofVigor, $ShopIndex] = 114;		// Mg
$AccessoryVar[RobeofThought, $ShopIndex] = 115;		// Mv
$AccessoryVar[ElvenRobe, $ShopIndex] = 116;		// Mv
$AccessoryVar[ArkemnsRobe, $ShopIndex] = 117;		// Mv
$AccessoryVar[PhensRobe, $ShopIndex] = 118;		// Mv
	
// Boots //
$AccessoryVar[CheetaursPaws, $ShopIndex] = 201;		// J
$AccessoryVar[BootsOfGliding, $ShopIndex] = 202;	// J
$AccessoryVar[WindWalkers, $ShopIndex] = 203;		// H1, Mg
$AccessoryVar[HeavenlyWings, $ShopIndex] = 204;		// H1

// Shields //
$AccessoryVar[KnightShield, $ShopIndex] = 205;		// K, E
$AccessoryVar[DragonShield, $ShopIndex] = 206;		// R
$AccessoryVar[HeavenlyShield, $ShopIndex] = 207;	// H2

// Slashing Weps //
$AccessoryVar[Hatchet, $ShopIndex] = 301;		// K
$AccessoryVar[BroadSword, $ShopIndex] = 302;		// K, D
$AccessoryVar[WarAxe, $ShopIndex] = 303;		// D
$AccessoryVar[LongSword, $ShopIndex] = 304;		// J
$AccessoryVar[BattleAxe, $ShopIndex] = 305;		// E
$AccessoryVar[Claymore, $ShopIndex] = 306;		// E
$AccessoryVar[ElvenBlade, $ShopIndex] = 307;		// J, Mv
$AccessoryVar[Katana, $ShopIndex] = 308;		// H2, Mv
$AccessoryVar[DracosWrath, $ShopIndex] = 309;
$AccessoryVar[DracoSword, $ShopIndex] = 310;
$AccessoryVar[HeavensGlory, $ShopIndex] = 311;		// H2

// Bludgeoning Weps //
$AccessoryVar[Club, $ShopIndex] = 401;			// K
$AccessoryVar[SpikedClub, $ShopIndex] = 402;		// K
$AccessoryVar[Mace, $ShopIndex] = 403;			// J
$AccessoryVar[SpikedBoneClub, $ShopIndex] = 404;	// J
$AccessoryVar[HammerPick, $ShopIndex] = 405;		// E
$AccessoryVar[WarHammer, $ShopIndex] = 406;		// E
$AccessoryVar[WarMaul, $ShopIndex] = 407;		// E
$AccessoryVar[HolyFist, $ShopIndex] = 408;		// H2, Mg
$AccessoryVar[GnarledStaff, $ShopIndex] = 409;		// H2
$AccessoryVar[DragonHammer, $ShopIndex] = 410;		// R
$AccessoryVar[TitaniumHammer, $ShopIndex] = 411;	// H2

// Piercing Weps //
$AccessoryVar[PickAxe, $ShopIndex] = 501;		// K
$AccessoryVar[Knife, $ShopIndex] = 502;			// K
$AccessoryVar[Dagger, $ShopIndex] = 503;		// K
$AccessoryVar[ShortSword, $ShopIndex] = 504;		// D
$AccessoryVar[Spear, $ShopIndex] = 505;			// J, D
$AccessoryVar[Gladius, $ShopIndex] = 506;		// E
$AccessoryVar[Trident, $ShopIndex] = 507;		// E
$AccessoryVar[Rapier, $ShopIndex] = 508;		// E
$AccessoryVar[AwlPike, $ShopIndex] = 509;		// E
$AccessoryVar[QuarterStaff, $ShopIndex] = 510;		// J, Mv
$AccessoryVar[LongStaff, $ShopIndex] = 511;		// Mv
$AccessoryVar[HellsEdge, $ShopIndex] = 512;		// H2
$AccessoryVar[MithrilSword, $ShopIndex] = 513;		// H2

// Archery Shit//
$AccessoryVar[Sling, $ShopIndex] = 601;			// K
$AccessoryVar[ShortBow, $ShopIndex] = 602;		// K
$AccessoryVar[LongBow, $ShopIndex] = 603;		// E
$AccessoryVar[ElvenBow, $ShopIndex] = 604;		// E
$AccessoryVar[CompositeBow, $ShopIndex] = 605;		// J
$AccessoryVar[LightCrossbow, $ShopIndex] = 606;		// E
$AccessoryVar[HeavyCrossbow, $ShopIndex] = 607;		// J, Mv
$AccessoryVar[RepeatingCrossbow, $ShopIndex] = 608;	// Mv
$AccessoryVar[DracosBow, $ShopIndex] = 609;		// H2
$AccessoryVar[ArchersForce, $ShopIndex] = 610;		// H2

$AccessoryVar[BasicArrow, $ShopIndex] = 611;		// K, E
$AccessoryVar[SheafArrow, $ShopIndex] = 612;		// E, Mv
$AccessoryVar[BladedArrow, $ShopIndex] = 613;		// J, Mv
$AccessoryVar[LightQuarrel, $ShopIndex] = 614;		// J
$AccessoryVar[HeavyQuarrel, $ShopIndex] = 615;		// J
$AccessoryVar[ShortQuarrel, $ShopIndex] = 616;		// J

// Other Weps //
$AccessoryVar[SlapStick, $ShopIndex] = 701;		// H1, Mg
$AccessoryVar[FireBreath, $ShopIndex] = 702;		// H1, Mv
$AccessoryVar[WizardStaff, $ShopIndex] = 703;		// H1, Mg
$AccessoryVar[Annihilator, $ShopIndex] = 704;		// H1