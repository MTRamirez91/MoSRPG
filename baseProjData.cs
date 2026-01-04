$ImpactDamageType      = -1;
$LandingDamageType     =  0;
$BulletDamageType      =  1;
$EnergyDamageType      =  2;
$PlasmaDamageType      =  3;
$ExplosionDamageType   =  4;
$ShrapnelDamageType    =  5;
$LaserDamageType       =  6;
$MortarDamageType      =  7;
$BlasterDamageType     =  8;
$ElectricityDamageType =  9;
$CrushDamageType       = 10;
$DebrisDamageType      = 11;
$MissileDamageType     = 12;
$MineDamageType        = 13;
$NullDamageType        = 14;
$SpellDamageType       = 15;

//--------------------------------------
BulletData FusionBolt
{
	bulletShapeName = "Rocket.dts"; 
	explosionTag = RocketEXP; 
	collisionRadius = 0.0; 
	mass = 2.0;
	damageClass = 1;
	damageValue = 3.5; 
	baseDamageType = $SpellDamageType;
	explosionRadius = 2.0;
	kickBackStrength = 0.0;
	muzzleVelocity   = 40.0;
	terminalVelocity = 40.0;
	acceleration = 2.0;
	totalTime = 2.0;
	liveTime = 1.6;
	lightRange = 20.0;
	colors[0] = { 10.0, 0.75, 0.75 };
	colors[1] = { 1.0, 0.25, 10.25 };
	inheritedVelocityScale = 0.5;
	trailType = 2;
	trailString = "plasmatrail.dts";
	smokeDist = 4;
	soundId = SoundJetHeavy;
	rotationPeriod = 0.1;
};

//--------------------------------------
BulletData MiniFusionBolt
{
   bulletShapeName    = "enbolt.dts";
   explosionTag       = energyExp;

   damageClass        = 1;
   damageValue        = 500;
   damageType         = $EnergyDamageType;

   muzzleVelocity     = 80.0;
   totalTime          = 4.0;
   liveTime           = 2.0;

   lightRange         = 3.0;
   lightColor         = { 0.25, 0.25, 1.0 };
   //inheritedVelocityScale = 0.5;
   isVisible          = True;

   rotationPeriod = 1;
};
function MiniFusionBolt::onAdd(%this)
{
}



//--------------------------------------
GrenadeData MortarTurretShell
{
   bulletShapeName    = "mortar.dts";
   explosionTag       = mortarExp;
   collideWithOwner   = True;
   ownerGraceMS       = 400;
   collisionRadius    = 1.0;
   mass               = 5.0;
   elasticity         = 0.1;

   damageClass        = 1;       // 0 impact, 1, radius
   damageValue        = 10;
   damageType         = $NullDamageType;

   explosionRadius    = 30.0;
   kickBackStrength   = 250.0;
   maxLevelFlightDist = 400;
   totalTime          = 1000.0;
   liveTime           = 2.0;
   projSpecialTime    = 0.05;

   inheritedVelocityScale = 0.5;
   smokeName              = "mortartrail.dts";
};

//--------------------------------------
RocketData FlierRocket
{
   bulletShapeName  = "rocket.dts";
   explosionTag     = rocketExp;
   collisionRadius  = 0.0;
   mass             = 2.0;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 0.5;
   damageType       = $MissileDamageType;

   explosionRadius  = 9.5;
   kickBackStrength = 250.0;
   muzzleVelocity   = 65.0;
   terminalVelocity = 80.0;
   acceleration     = 5.0;
   totalTime        = 10.0;
   liveTime         = 11.0;
   lightRange       = 5.0;
   lightColor       = { 1.0, 0.7, 0.5 };
   //inheritedVelocityScale = 0.5;

   // rocket specific
   trailType   = 2;                // smoke trail
   trailString = "rsmoke.dts";
   smokeDist   = 1.8;

   soundId = SoundJetHeavy;
};

//--------------------------------------
SeekingMissileData TurretMissile
{
   bulletShapeName = "rocket.dts";
   explosionTag    = rocketExp;
   collisionRadius = 0.0;
   mass            = 2.0;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 5;
   damageType       = $MissileDamageType;
   explosionRadius  = 9.5;
   kickBackStrength = 175.0;

   muzzleVelocity    = 72.0;
   totalTime         = 10;
   liveTime          = 10;
   seekingTurningRadius    = 9;
   nonSeekingTurningRadius = 75.0;
   proximityDist     = 1.5;
   smokeDist         = 1.75;

   lightRange       = 5.0;
   lightColor       = { 0.4, 0.4, 1.0 };

   inheritedVelocityScale = 0.5;

   soundId = SoundJetHeavy;
};

LaserData sniperLaser
{
	laserBitmapName   = "laserPulse.bmp";
	hitName           = "laserhit.dts";

	damageConversion  = 0.0;
	baseDamageType    = $LaserDamageType;

 	beamTime          = 1.5;

	lightRange        = 10.0;
	lightColor        = { 0.2, 0.2, 1.0 };

	detachFromShooter = false;
	hitSoundId        = NoSound;
};

function SeekingMissile::updateTargetPercentage(%target)
{
	dbecho($dbechoMode, "SeekingMissile::updateTargetPercentage(" @ %target @ ")");

	return GameBase::virtual(%target, "getHeatFactor");
}

LightningData turretCharge
{
   bitmapName       = "lightningNew.bmp";

   damageType       = $ElectricityDamageType;
   boltLength       = 10.0;
   coneAngle        = 35.0;
   damagePerSec      = 1;
   energyDrainPerSec = 5.0;
   segmentDivisions = 4;
   numSegments      = 2;
   beamWidth        = 0.2;

   updateTime   = 120;
   skipPercent  = 0.5;
   displaceBias = 0.15;

   lightRange = 3.0;
   lightColor = { 0.25, 0.25, 0.85 };

   soundId = SoundELFFire;
};

function Lightning::damageTarget(%target, %timeSlice, %damPerSec, %enDrainPerSec, %pos, %vec, %mom, %shooterId)
{
	dbecho($dbechoMode, "Lightning::damageTarget(" @ %target @ ", " @ %timeSlice @ ", " @ %damPerSec @ ", " @ %enDrainPerSec @ ", " @ %pos @ ", " @ %vec @ ", " @ %mom @ ", " @ %shooterId @ ")");

   %damVal = %timeSlice * %damPerSec;
   %enVal  = %timeSlice * %enDrainPerSec;

   GameBase::applyDamage(%target, $ElectricityDamageType, %damVal, %pos, %vec, %mom, %shooterId);

   %energy = GameBase::getEnergy(%target);
   %energy = %energy - %enVal;
   if (%energy < 0) {
      %energy = 0;
   }
   GameBase::setEnergy(%target, %energy);
}

///////////////////////////NUKEBOMB!!!!!!!!!!!!!!!!!!!!!!!!!!!
GrenadeData Nuke
{ //Aryss made this
bulletShapeName = "Shockwave_Large.dts";
	explosionTag = LargeShockwave;
	collideWithOwner = True;
	ownerGraceMS = 500;
	collisionRadius = 0.1;
	mass = 5.0;
	elasticity = 0.4;
	damageClass = 1;  // 0 impact, 1, radius
	damageValue = 20.0;
	baseDamageType = $SpellDamageType;
	explosionRadius = 100.0;
	kickBackStrength = 1.0;
	maxLevelFlightDist = 350;
	totalTime = 50.0;
	liveTime = 6.0;
	projSpecialTime = 0.01;
	inheritedVelocityScale = 0.5;
	smokeName = "paint.dts";
      smokeDist   = 5.0;
};

GrenadeData Nuke2
{ // Aryss made this
bulletShapeName = "Shockwave_Large.dts";
	explosionTag = LargeShockwave;
	collideWithOwner = True;
	ownerGraceMS = 500;
	collisionRadius = 0.1;
	mass = 5.0;
	elasticity = 0.4;
	damageClass = 1;  // 0 impact, 1, radius
	damageValue = 20.0;
	baseDamageType = $SpellDamageType;
	explosionRadius = 100.0;
	kickBackStrength = 1.0;
	maxLevelFlightDist = 350;
	totalTime = 50.0;
	liveTime = 4.0;
	projSpecialTime = 0.01;
	inheritedVelocityScale = 0.5;
	smokeName = "paint.dts";
      smokeDist   = 5.0;
};

GrenadeData orbthrow
{
  bulletShapeName = "orb.dts";
  explosionTag = DirtyExp;
  collideWithOwner = True;
  ownerGraceMS = 250;
  collisionRadius = 0.3;
  mass = 5.0;
  elasticity = 0.25;
  damageClass = 0;
  damageValue = 2.5;
  damageType = $SpellDamageType;
  explosionRadius = $LargeArea;
  kickBackStrength = 10.0;
  maxLevelFlightDist = 100;
  totalTime = 4.5;
  liveTime = 0.5;
  projSpecialTime = 0.01;
  inheritedVelocityScale = 0.5;
  smokename = "dustplume.dts";
  smokeDist = 8.0;
};

RocketData goddyshot
{
  bulletShapeName = "shockwave_large.dts";
  explosionTag = Shockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.0;
  damageType = $SpellDamageType;
  explosionRadius = $HugeArea;
  kickBackStrength = 10.0;
  muzzleVelocity = 30.0;
  terminalVelocity = 30.0;
  acceleration = 5.0;
  totalTime = 5.0;
  liveTime = 5.0;
  lightRange = 0.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "shockwave_large.dts";
  smokeDist = 2;
};


RocketData amazonlightbeam
{
  bulletShapeName = "shockwave_large.dts";
  explosionTag = Shockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.50;
  damageType = $SpellDamageType;
  explosionRadius = $HugeArea;
  kickBackStrength = 0.0;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 5.0;
  totalTime = 6.5;
  liveTime = 10.0;
  lightRange = 5.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "fusionbolt.dts";
  smokeDist = 2;
};

RocketData swordshot
{
  bulletShapeName = "sword.dts";
  explosionTag = swordexp;
  collisionRadius = 2.0;
  mass = 2.0;
  damageClass = 0;
  damageValue = 1.5;
  damageType = $SpellDamageType;
  explosionRadius = 5;
  kickBackStrength = 2.0;
  muzzleVelocity = 15.0;
  terminalVelocity = 20.0;
  acceleration = 6.0;
  totalTime = 3;
  liveTime = 5;
  lightRange = 5.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 1.5;
  trailType = 2;
  trailString = "dustplume.dts";
  smokeDist = 4;
};

RocketData arrowshot
{
  bulletShapeName = "bullet.dts";
  explosionTag = swordexp;
  collisionRadius = 2.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.50;
  damageType = $SpellDamageType;
  explosionRadius = 5;
  kickBackStrength = 2.0;
  muzzleVelocity = 15.0;
  terminalVelocity = 20.0;
  acceleration = 6.0;
  totalTime = 3;
  liveTime = 5;
  lightRange = 0.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 1.5;
  trailType = 2;
  trailString = "invisable.dts";
  smokeDist = 4;
};