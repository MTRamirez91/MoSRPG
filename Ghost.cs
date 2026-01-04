$InvList[GhostPack] = 1;
$MobileInvList[GhostPack] = 1;
$RemoteInvList[GhostPack] = 0;
additem(GhostPack);
//-----------------------------------

$ItemMax[larmor, GhostPack] = 1;
$ItemMax[lfemale, GhostPack] = 1;
$ItemMax[Marmor, GhostPack] = 0;
$ItemMax[mfemale, GhostPack] = 0;
$ItemMax[Harmor, GhostPack] = 0;

ItemData GhostArmor
{
	heading = "aArmor";
	description = "Ghosting";
	className = "Armor";
	price = 175;
	showInventory = false; //armor won't show in any inv, including when you're wearing it.
};

ItemImageData GhostPackImage
{
	shapeFile = "Chaingun";
	mountPoint = 2;
//	mountOffset = { -0.375, 0, 0 };
	mountRotation = {1.57,0, 3.14 };
	mass = 2.5;
	firstPerson = false;
	lightType = 3; // Pulsing 2 pulsing, 3 fire, 1 continuous
	lightRadius = 5;
//	lightTime = 0.1;
	lightColor = { 0.3, 0.4, 0.5};
};

ItemData GhostPack
{
	description = "Ghost Pack";
	shapeFile = "Chaingun";
	className = "Backpack";
	heading = $InvHead[ihBac];
	imageType = GhostPackImage;
	shadowDetailMask = 4;
	mass = 2.5;
	elasticity = 0.2;
	price = 500;
	hudIcon = "deployable";
	showWeaponBar = true;
	hiliteOnActive = true;
};

ItemImageData GhostPack2Image 
{
	shapeFile = "mine";
	mountPoint = 2;
	mountOffset = { 0 , -0.3, 0.2 };
	mountRotation = {-1.57,0, 0 };//{1.57,0, 3.14 }
	weaponType = 0;
	lightType = 1; // Pulsing, 2 pulsing, 3 fire, 1 continuous
	lightRadius = 5;
//	lightTime = 0.1;
	lightColor = { 0.3, 0.4, 0.5};
};

ItemData GhostPack2
{
	description = "gpack";
	shapeFile = "Disc";
	className = "Backpack"; 
	heading = "cBackpacks";
	imageType = GhostPack2Image;
	shadowDetailMask = 4;
	mass = 2.5;
	elasticity = 0.2;
	price = 500;
	hudIcon = "deployable";
	showWeaponBar = true;
	hiliteOnActive = true;
};

ItemImageData GhostPack3Image
{
	shapeFile = "sensor_small";
	mountPoint = 2;
	mountOffset = { 0 , 0.05, 0.15 };
	mountRotation = {1.57,0, 0 };
	weaponType = 0;
	lightType = 1; // Pulsing, 2 pulsing, 3 fire, 1 continuous
	lightRadius = 5;
//	lightTime = 0.1;
	lightColor = { 0.3, 0.4, 0.5};
};

ItemData GhostPack3
{
	description = "Ghost Pack";
	shapeFile = "Sensor_small";
	className = "Backpack";
	heading = "cBackpacks";
	shadowDetailMask = 4;
	imageType = GhostPack3Image;
	price = 1500;
	hudIcon = "energypack";
	showWeaponBar = true;
	hiliteOnActive = true;
};


function GhostPack::onMount(%player,%item)
{	
	if($debug)
		echo("?? EVENT mount "@ %item @" onto player "@ %player @" cl# "@ Player::getclient(%player));
	GhostPack::onUse(%client,ghostpack);
	Player::mountItem(%player, GhostPack2, 7);
	gamebase::setautorepairrate(%player, 0.007);
	}

function noghost(%player)
{
	gamebase::setautorepairrate(%player, 0.007);
	Player::unmountItem(%player, 6);
	%client = GameBase::getOwnerClient(%player);
	%player.Ghoster = false;
	Player::trigger(%player,$BackpackSlot,false);
	%c = Player::getClient(%player);
	gamebase::setautorepairrate(%player, 0.7);
	%player.repairRate = 0.00;
	Client::sendMessage(Player::getClient(%player), 1, "Pack Off.");
	%armor = Player::getArmor(%client);
	%buyarmor = $ArmorType[Client::getGender(%client), iarmorNecro];
	%energy = GameBase::getEnergy(%player);
	Player::setArmor(%client, lfemale);
	GameBase::setEnergy(%player,%energy);
      }

function GhostPack::onUnmount(%player,%item)
{	
	if (Player::getItemCount(%player, GhostArmor) == 1) noghost(%player);
	Player::unmountItem(%player, 7);
	Player::setArmor(%client, lfemale);
      gamebase::setautorepairrate(%player, 0.0);
}

$DropFlagChance = 15;

function GhostPack::onUse(%player,%item)
{
	%client = GameBase::getOwnerClient(%player);

	if (Player::getMountedItem(%player,$BackpackSlot) != %item)
	{
		Player::mountItem(%player,%item,$BackpackSlot);
		gamebase::setautorepairrate(%player, 0.007);
		}
	else
	{
		if (!%player.ghoster)
		{
			%player.ghoster = true;
			Player::mountItem(%player, GhostPack3, 6);
			Player::trigger(%player,$BackpackSlot,true);
			Casper( %player);
			Client::sendMessage(Player::getClient(%player), 1, "Pack On.");
			%c = Player::getClient(%player);
			gamebase::setautorepairrate(%player, 0.0);
//			%armor = Player::getArmor(%client);
			%buyarmor = $ArmorType[Client::getGender(%client), GhostArmor];
			%energy = GameBase::getEnergy(%player);
			Player::setArmor(%client,%buyarmor);
			GameBase::setEnergy(%player,999999);
			Player::setItemCount(%client, GhostArmor, 1);
		}
		else
			NoGhost(%player);
	}
}

function Casper (%player)
{
	if(%player.ghoster)
	{
		GameBase::playSound(%player, SoundActivateMotionSensor, 0);
		%svec = Vector::getFromRot(GameBase::getRotation(Player::getClient(%player)),10,0);
		GameBase::activateShield(%player,%svec, 0.75);
		%c = Player::getClient(%player);
		if(Player::getMountedItem(%player, 2) == "flag")
		{
			if(floor(getrandom() * 100) < $DropFlagChance)
			{
				Player::dropItem(%player,Player::getMountedItem(%player, 2));
				}
		}
		%name = Client::getName(%c);
		if(!$noplayerdamage)
		{
			%data = GameBase::getDataName(%player);
			if(%dlevel > %data.maxDamage)
			{
				player::kill(%c);
				%player.Ghoster = false;
			}
			
			else
				GameBase::setDamageLevel(%player,%dlevel);
		}
		if(Player::isDead(%player))
		{
			Messageall(0,%name@": Opps."); 
			playNextAnim(%player); 
			%player.Ghoster = false;
			Player::kill(%obj); 
		}
		schedule("Casper(" @ %player @  ");", 0.75);
	}
}


//===================================================================== Armor

$InvList[GhostArmor] = 1;
$MobileInvList[GhostArmor] = 1;
$RemoteInvList[GhostArmor] = 0;
AddItem(GhostArmor);

$ArmorType[Male, GhostArmor] = lghost;
$ArmorType[Female, GhostArmor] = fghost;
$ArmorName[lghost] = GhostArmor;
$ArmorName[fghost] = GhostArmor;
$ArmorKickback[GhostArmor] = 2.80; 

PlayerData lghost
{
	className = "Armor";
	shapeFile = "larmor";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
// New jetpack image
//Lucid
	flameShapeName = "fusionbolt";
	shieldShapeName = "shield";
	shadowDetailMask = 1;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = true;
	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 35;//22
	minJetEnergy = 1;
	jetForce = 350;//236
	jetEnergyDrain = 0;//0.8
	maxDamage = 0.76;
	maxForwardSpeed = 15;//11
	maxBackwardSpeed = 10;
	maxSideSpeed = 10;
	groundForce = 40 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 120;
	drag = 1.0;
	density = 1.2;
	minDamageSpeed = 25;
	damageScale = 0.005;
	jumpImpulse = 125;//75
	jumpSurfaceMinDot = 0.2;
	animData[0] = { "root", none, 1, true, true, true, false, 0 };
	animData[1] = { "run", none, 1, true, false, true, false, 3 };
	animData[2] = { "runback", none, 1, true, false, true, false, 3 };
	animData[3] = { "side left", none, 1, true, false, true, false, 3 };
	animData[4] = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14] = { "fall", none, 1, true, true, true, false, 3 };
	animData[15] = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16] = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17] = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18] = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[38] = { "sign over here", none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };
// Custom Jet sound
//Lucid
	jetSound = SoundJetLight;	//SoundNecroJet;
	rFootSounds = { SoundLFootRSoft, SoundLFootRHard, SoundLFootRSoft, SoundLFootRHard, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRHard, SoundLFootRSnow, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft };
	lFootSounds = { SoundLFootLSoft, SoundLFootLHard, SoundLFootLSoft, SoundLFootLHard, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLHard, SoundLFootLSnow, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft };
	footPrints = { 0, 1 };
	boxWidth = 0.0;
	boxDepth = 0.0;
	boxNormalHeight = 2.2;
	boxCrouchHeight = 1.8;
	boxNormalHeadPercentage = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;
	boxHeadLeftPercentage = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage = 0;
	boxHeadFrontPercentage = 1;
};

function lghost::onPoison(%client, %player)
{
	Armor::onPoison(%client, %player);
}

function lghost::onBurn(%client, %player)
{
	Armor::onBurn(%client, %player);
}

function lghost::onShock(%client, %player)
{
	Armor::onShock(%client, %player);
}



function lghost::onPlayerContact(%damagedPlayer, %damagingPlayer)
{
	Drain(%damagedPlayer, %damagingPlayer);
}

function lghost::onGrenade(%player)
{
	%obj = newObject("","Mine","HoloMine");
	Armor::ThrowGrenade(%player, %obj);
}

function lghost::onBeacon(%player, %item)
{
	startCloak(Player::getClient(%player));
	if(!$build)
		Player::decItemCount(%player, %item);
}

function lghost::onRepairKit(%player)
{
	Armor::onRepairKit(%player);
}

PlayerData fghost
{
	className = "Armor";
	shapeFile = "lfemale";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = true;
	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 35;//22
	minJetEnergy = 1;
	jetForce = 350;//236
	jetEnergyDrain = 0.6;//0.8
	maxDamage = 0.76;
	maxForwardSpeed = 15;//11
	maxBackwardSpeed = 10;
	maxSideSpeed = 10;
	groundForce = 40 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 120;
	drag = 1.0;
	density = 1.2;
	minDamageSpeed = 25;
	damageScale = 0.005;
	jumpImpulse = 125;//75
	jumpSurfaceMinDot = 0.2;
	animData[0] = { "root", none, 1, true, true, true, false, 0 };
	animData[1] = { "run", none, 1, true, false, true, false, 3 };
	animData[2] = { "runback", none, 1, true, false, true, false, 3 };
	animData[3] = { "side left", none, 1, true, false, true, false, 3 };
	animData[4] = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14] = { "fall", none, 1, true, true, true, false, 3 };
	animData[15] = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16] = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17] = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18] = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc root", none, 1, false, false, false, false, 3 };
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[38] = { "sign over here", none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };
	jetSound = SoundJetLight;
	rFootSounds = { SoundLFootRSoft, SoundLFootRHard, SoundLFootRSoft, SoundLFootRHard, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRHard, SoundLFootRSnow, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft, SoundLFootRSoft };
	lFootSounds = { SoundLFootLSoft, SoundLFootLHard, SoundLFootLSoft, SoundLFootLHard, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLHard, SoundLFootLSnow, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft, SoundLFootLSoft };
	footPrints = { 0, 1 };
	boxWidth = 0.0;
	boxDepth = 0.0;
	boxNormalHeight = 2.2;
	boxCrouchHeight = 1.8;
	boxNormalHeadPercentage = 0.85;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage = 0.88;
	boxCrouchTorsoPercentage = 0.35;
	boxHeadLeftPercentage = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage = 0;
	boxHeadFrontPercentage = 1;
};

function fghost::onPoison(%client, %player)
{
	Armor::onPoison(%client, %player);
}

function fghost::onBurn(%client, %player)
{
	Armor::onBurn(%client, %player);
}

function fghost::onShock(%client, %player)
{
	Armor::onShock(%client, %player);
}


function fghost::onPlayerContact(%damagedPlayer, %damagingPlayer)
{
	Drain(%damagedPlayer, %damagingPlayer);
}

function fghost::onGrenade(%player)
{
	%obj = newObject("","Mine","HoloMine");
	Armor::ThrowGrenade(%player, %obj);
}

function fghost::onBeacon(%player, %item)
{
	startCloak(Player::getClient(%player));
	if(!$build)
		Player::decItemCount(%player, %item);
}

function fghost::onRepairKit(%player)
{
	Armor::onRepairKit(%player);
}