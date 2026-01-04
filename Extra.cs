//-----------//
// SpinFuzor //
//-----------//
$AccessoryVar[SpinFuzor, $SpecialVar] = "6 1000";
$AccessoryVar[SpinFuzor, $AccessoryType] = $SwordAccessoryType;
$AccessoryVar[SpinFuzor, $Weight] = "1.0";
$AccessoryVar[SpinFuzor, $MiscInfo] = "<f0>Legendary <f1>SpinFuzor<f0>. Forged by <f2>Surfer666";
$WeaponRange[SpinFuzor] = 1000.0;
$WeaponDelay[SpinFuzor] = 0.3;
$SkillType[SpinFuzor] = $SkillSlashing;
$SkillRestriction[SpinFuzor] = $MinAdmin @ " 3";

ItemImageData SpinFuzorImage
{
	shapeFile  = "disc";
	mountPoint = 0;
	weaponType = 0;
	reloadTime = 0.1;
	fireTime = 0.3;
	showInventory = false;
	fireTime = $WeaponDelay[SpinFuzor];
	minEnergy = 0;
	maxEnergy = 0;
	accuFire = true;
	sfxFire = SoundFireDisc;
	sfxActivate = SoundPickUpWeapon;
	sfxReady = SoundDiscSpin;
};
ItemData SpinFuzor
{
	heading = "bWeapons";
	description = "SpinFuzor";
	className = "Weapon";
	shapeFile  = "disc";
	hudIcon = "disc";
	shadowDetailMask = 4;
	imageType = SpinFuzorImage;
	price = 0;
	showWeaponBar = true;
};
function SpinFuzorImage::onFire(%player, %slot) 
{
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);

	%clientId = Player::getClient(%player);
	
	if(GameBase::getLOSinfo(%player, $WeaponRange[SpinFuzor]))
	   %losobj = $los::object;
	else
	   %losobj = 0;

	if(getObjectType(%losObj) == "Player")
	  %id = Player::getClient(%losObj);
	
	%b = GameBase::getRotation(%clientId);
	%c1 = Cap(10+$PlayerSkill[%clientId, $SkillType[SpinFuzor]]/2.4,20,100);
	%c2 = %c1/4;
	%mom = Vector::getFromRot( %b, %c1, %c2 );

	Player::applyImpulse(%id, (%mom));
	UseSkill(%clientId, $SkillType[SpinFuzor], True, True);

	Projectile::spawnProjectile("SpinFuzorShot",%trans,%player,%vel);
}

RocketData SpinFuzorShot
{ 
	bulletShapeName = "discb.dts"; 
	explosionTag = rocketExp; 
	collisionRadius = 0.0; 
	mass = 2.0;
	damageClass = 1;
	damageValue = 7.99;
	baseDamageType = $SpellDamageType;
	explosionRadius = 10.0;
	kickBackStrength = 100.0;
	muzzleVelocity   = 250.0;
	terminalVelocity = 2000.0;
	acceleration = 85.0;
	totalTime = 10.0;
	liveTime = 6.66;
	lightRange = 10.0;
	lightColor = { 0.4, 0.4, 1.0 };
	inheritedVelocityScale = 0.5;
	trailType = 1;
	trailLength = 100;
	trailWidth  = 0.5;
    soundId = SoundDiscSpin;
};

//---===============---
//---===Admin Slap Thing===---
//---===============---

$AccessoryVar[BitchSlap, $SpecialVar] = "1 666";
$AccessoryVar[BitchSlap, $AccessoryType] = $SwordAccessoryType;
$AccessoryVar[BitchSlap, $Weight] = "1.0";
$AccessoryVar[BitchSlap, $MiscInfo] = "<f1>BitchSlap<f0>.";
$WeaponRange[BitchSlap] = 200.0;
$WeaponDelay[BitchSlap] = 0.5;
$SkillType[BitchSlap] = $SkillSlashing;
$SkillRestriction[BitchSlap] = $MinAdmin @ " 1";

ItemImageData BitchSlapImage
{
	shapeFile  = "invisable";
	mountPoint = 0;
	mountOffset = {0, 0, 0};
	mountRotation = {0, 0, 0};

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[BitchSlap];
	lightType = 3;  // Weapon Fire
	lightRadius = 15;
	lightTime = 4.0;
	lightColor = { 3, 1, 2 };
	

	accuFire = true;

	sfxFire = ActivateTD;
	sfxActivate = ActivateTD;
};
ItemData BitchSlap
{
	heading = "bWeapons";
	description = "Admins Slap Stick :P";
	className = "Weapon";
	shapeFile  = "hammer";
	hudIcon = "hammer";
	shadowDetailMask = 4;
	imageType = BitchSlapImage;
	price = 0;
	showWeaponBar = true;
};
function BitchSlapImage::onFire(%player, %slot)
{	
	%clientId = Player::getClient(%player);
	
	if(fetchData(%clientid, "MANA") > 1)
	{
	  setMANA(%clientid, fetchData(%clientid, "MANA") -1);
	
	  if(GameBase::getLOSinfo(%player, $WeaponRange[BitchSlap]))
	   %losobj = $los::object;
	  else
	   %losobj = 0;

          if(getObjectType(%losObj) == "Player")
	   %id = Player::getClient(%losObj);
	  else
	   return;
	
	 %b = GameBase::getRotation(%clientId);
	 %c1 = Cap(10+$PlayerSkill[%clientId, $SkillType[BitchSlap]]/2.4,20,1500);
	 %c2 = %c1/4;
	 %mom = Vector::getFromRot( %b, %c1, %c2 );
	 Player::applyImpulse(%id, %mom);
	//IHitHim(%clientid,%id);
	 UseSkill(%clientId, $SkillType[BitchSlap], True, True);
	}
}