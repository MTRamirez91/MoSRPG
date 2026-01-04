$Aeon::lastRock = 0;
$Aeon::rockFall = 90; //- 1 rock every 1.5 minutes
$Aeon::rockHght = 800; //- Origin height for rocks from 0
$Aeon::rockHold = 1.0; //- time to wait to launch rock
$Aeon::rockStay = 10.0; //- pop time on rock hulk in minutes
$Aeon::rockValue = 0.05;

$Atmos::updateTime = 0.1;
$DynSky::Texture = "";
$DynSky::Rotation = 0;
$DynSky::Rotating = "true";
$DynSky::rotRate = 0.1;
$DynSky::RBGColor = "false";
$DynSky::RGB[0] = RGB::conv(130);
$DynSky::RGB[1] = RGB::conv(154);
$DynSky::RGB[2] = RGB::conv(215);
$DynSun::Texture = "";

function Atmos::loop()
{
	if($DynSky::Rotating == "true" && DynSky::isTexture($DynSky::Texture) == true)
		DynSky::rotate();
	if($DynSky::RGBColor == "true" && $DynSky::RGB[2] > 0) {
		DynSky::RGBclr(-0.01);
	}
	else if($DynSky::RGBColor == "false" && $DynSky::RGB[2] < 0.4) {
		DynSky::RGBclr(0.01);
	}
	if($DynSun::Moving == "true")
		DynSun::Move();
	%group = nameToID("MissionCleanup\\DynSky");
	if(%group == -1) {
		%group = newObject("DynSky",SimGroup,"Group");
		addToSet("MissionCleanup",%group);
		%main = nameToID("MissionGroup\\Landscape");
		for(%i = 0; %i < Group::objectCount(%main); %i++) {
			if(getObjectType(Group::getObject(%main,%i)) == "Sky") // || getObjectType(Group::getObject(%main,%i)) == "Planet")
				deleteObject(Group::getObject(%main,%i));
		}
	}
	else {
		deleteObject(Group::getObject(%group,0));
		//deleteObject(Group::getObject(%group,1));
	}
	%DynSky = newObject("DynSky",Sky,$DynSky::RGB[0],$DynSky::RGB[1],$DynSky::RGB[2]+0.1,$DynSky::Texture,$DynSky::rotation,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15);
	addToSet("MissionCleanup\\DynSky",%DynSky);
	//%DynSun = newObject("DynSun",Planet,$DynSun::RGB[0],$DynSun::RGB[1],$DynSun::RGB[2],$DynSun::Texture,0,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15);
	//addToSet("MissionCleanup\\DynSky",%DynSun);
	schedule("Atmos::loop();",$Atmos::updateTime);
}

function DynSky::rotate()
{
	if($DynSky::rotation >= 360)
		$DynSky::rotation = 0;
	$DynSky::rotation += $DynSky::rotRate;
}

function DynSky::RBGclr(%val)
{
	$DynSky::RGB[0]+=%val;
	$DynSky::RGB[1]+=%val;
	$DynSky::RGB[2]+=%val;
}

function DynSky::isTexture(%texture)
{
	if(%texture != "" && %texture != -1) {
		if(String::findSubStr(%texture,".dml") >= 0)
			return true;
		return false;
	}
	return false;
}

function DynSun::Move()
{
	if($DynSun::rotation >= 360)
		$DynSun::rotation = 0;
	$DynSun::rotation += $DynSun::rotRate;	
}

function Aeon::rockMan(%player)
{
	%clientId = Player::getClient(%player);
	if(%clientId != -1) {
		if(GameBase::getLOSInfo(%player,5)) {
			Aeon::rockCall($los::position);
			bottomPrint2(%clientId,"<jc><f3>Meteor Coming!",1,"Error_Message.wav");
		}
	}
}

function Aeon::rockCall(%pos)
{
	if(Client::getFirst() < 2049)
		return;
	%z = $Aeon::rockHght;
	%OriX = -420+(ranDim(3070-%z));
	%OriY = -650+(ranDim(3070-%z));
	%Orgn = %OriX@" "@%OriY@" "@%z;
	%TRot = (((-2+ranDim(1))*$Pi)/4)@" "@(((-2+ranDim(1))*$Pi)/4)@" 0";
	if(%pos != -1 && %pos != "") {
		%Orgn = getWord(%pos,0)+ranDim(%z/2)@" "@getWord(%pos,1)+ranDim(%z/2)@" "@%z;
		%TRot = Vector::getRotAim(%Orgn,%pos);
	}
	%temp = newObject("",StaticShape,"rockTemp",true);
	addToSet("MissionCleanup",%temp);
	GameBase::setPosition(%temp,%Orgn);
	GameBase::setRotation(%temp,%TRot);
	schedule("Aeon::rockFall("@%temp@");",$Aeon::rockHold,%temp);
}

function Aeon::rockFall(%rock)
{
	if(%rock == -1)
		return;
	if(!%rock.cancel) {
		%trans = GameBase::getMuzzleTransform(%rock);
		%vec = Vector::getFromRot(GameBase::getRotation(%rock),30+ranDim(10));
		%proj = projectile::spawnProjectile("rockProj1",%trans,%rock,%vec);
	}
	deleteObject(%rock);	
}

function Aeon::rockImpact(%pos)
{
	%pos = Vector::add(%pos,"0 0 0.1");
	%rot  = "0 0 0";
	%closest = 1000;
	for(%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl)) {
		%dist = Vector::getDistance(%pos,GameBase::getPosition(%cl));
		if(%dist < %closest && %dist != -1)
			%closest = %dist;
	}
	if(%closest < 500) {
		for(%i = -$Pi; %i <= $Pi; %i += $Pi/5) {
			%newRot = Vector::Add(%rot,"0 0 "@%i);
			%newVec = Vector::getFromRot(%newRot,0.5);
			%trans = %rot@" "@%newVec@" "@%rot@" "@%pos;
			Projectile::spawnProjectile(rockSpark,%trans,2048,%newVec);
		}
		Projectile::spawnProjectile(rockSmoke,"1 0 0 0 1 0 0 0 1 "@%pos,2048,"0 0 10");
	}
	if(Aeon::inProperty(%pos))
		return;
	for(%i = 1; %i <= 6; %i++) {
		%rock[%i] = newObject("",InteriorShape,"lrock"@%i@".dis");
		if(%i == 1) {
			$Aeon::impactSite[%rock[%i]] = %pos;
			%Group = newObject("ImpactSite #"@%rock[1],SimGroup,"Group");
			addToSet("MissionCleanup",%Group);
		}
		addToSet("MissionCleanup/ImpactSite #"@%rock[1],%rock[%i]);
		%newRot = Vector::Add(%rot,"0 0 "@2*((%i*$Pi)/6));
		%newVec = Vector::getFromRot(%newRot,15+ranDim(5));
		%newPos = Vector::add(%pos,%newVec);
		if(getLOSInfo(%newPos,Vector::add(%newPos,"0 0 -50"),1))
			%newPos = Vector::add($los::position,"0 0 0");
		else
			%newPos = Vector::add(%newPos,"0 0 1");
		%prop = Aeon::inProperty(%newPos);
		GameBase::setRotation(%rock[%i],Vector::add(Vector::mult(Vector::normalize(%newRot),"180 180 180"),"0 90 0"));
		if(%prop != false) {
			deleteObject(%rock[%i]);
			return;
		}
		else
			GameBase::setPosition(%rock[%i],%newPos);
		%rock[%i].isRock = getSimTime();
		schedule("Aeon::rockHulk("@%group@");",$Aeon::rockStay*60,%group);
	}
	$impactCount++;
}

function Aeon::rockHulk(%group)
{
	if(%group == -1)
		return;
	$impactCount--;
	deleteObject(%group);
}

function Aeon::rockConvert(%rock)
{
	%group = getGroup(%rock);
	deleteObject(%rock);
	%rocks = Group::objectCount(%group);
	if(%rocks < 1) {
		deleteObject(%group);
		$impactCount--;
	}
}

function rockProj1::onAdd(%this)
{
	GameBase::setMapName(%this,"Rock");
	Rock::spark(%this);
}

function rockProj1::onRemove(%this)
{
	Aeon::rockImpact($tempPos[%this]);
}

function Rock::spark(%this)
{
	%pos = Vector::add(GameBase::getPosition(%this),"0 0 2");
	%rot = GameBase::getRotation(%this);
	%vel = Item::getVelocity(%this);
	%vec = Vector::getFromRot(%rot,5);
	%trans = %rot@" "@%vec@" "@%rot@" "@%pos;
	Projectile::spawnProjectile(rockSpark,%trans,2048,%vel);
	$tempPos[%this] = GameBase::getPosition(%this);
	schedule("Rock::spark("@%this@");",0.2,%this);
}

function ranDim(%dim)
{
	%rand = %dim*(2*getRandom()-1);
	return %rand;
}