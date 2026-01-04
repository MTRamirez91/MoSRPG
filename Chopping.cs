function HatchetSwing(%player, %length, %weapon)
{
	dbecho($dbechoMode, "HatchetSwing(" @ %player @ ", " @ %length @ ")");

	%clientId = Player::getClient(%player);
	if(%clientId == "")
		%clientId = 0;

	//==== ANTI-SPAM CHECK, CAUSE FOR SPAM UNKNOWN ==========
	%time = getIntegerTime(true) >> 5;
	if(%time - %clientId.lastFireTime <= $fireTimeDelay)
		return;
	%clientId.lastFireTime = %time;
	//=======================================================

	$los::object = "";
	if(GameBase::getLOSinfo(%player, %length))
	{
		%target = $los::object;
		%obj = getObjectType(%target);
		%type = GameBase::getDataName(%target);

		if(%type == "TreeShape")
		{
			%brflag = String::findSubStr(fetchData(%clientId, "RACE"), "Human");
			
			if(Vector::getDistance(%clientId.lastMinePos, GameBase::getPosition(%clientId)) > 1.0 && %brflag != -1)
			{
				playSound(SoundHitLeather, GameBase::getPosition(%target));
				%score = DoRandomChopping(%clientId, %target);
				
				if(%score != "")
				{
					Player::incItemCount(%clientId, %score, 1);
					RefreshAll(%clientId);
					Client::sendMessage(%clientId, 0, "You found " @ %score.description @ ".");

					if( floor(getRandom() * 10) == 5)
						%clientId.lastMinePos = GameBase::getPosition(%clientId);
				}
				UseSkill(%clientId, $SkillChopping, True, True);
			}
			else
				playSound(SoundHitLeather, GameBase::getPosition(%target));
		}		
		if(%obj == "Player")
			GameBase::virtual(%target, "onDamage", "", 1.0, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %clientId, %weapon);
	}
	PostAttack(%clientId, %weapon);
}

function DoRandomChopping(%clientId, %Tree)
{
	dbecho($dbechoMode, "DoRandomChopping(" @ %clientId @ ", " @ %Tree @ ")");

	%lastscore = "";
	for(%i = 1; $ItemList[Chopping, %i] != ""; %i++)
	{
		%w1 = GetWord($ItemList[Chopping, %i], 1) - %Tree.bonus[%i];
		%n = Cap( (%w1 * getRandom()) + (%w1 / 2), 0, %w1);
		%r = 1 + ($PlayerSkill[%clientId, $SkillChopping] * (1/10)) * getRandom();

		if(%n > %r)
			return %lastscore;

		%lastscore = GetWord($ItemList[Chopping, %i], 0);
	}
	return %lastscore;
}


%f = 43;

//======================================================
//======================================================
//======================================================
StaticShapeData Tree
{
	dataBlock = "TreeShape";
	debrisId = flashDebrisSmall;
	maxDamage = 1.0;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = flashExpMedium;
	description = "Tree";
};

StaticShapeData EmptyTree
{
	dataBlock = "TreeShape";
	debrisId = flashDebrisSmall;
	maxDamage = 1.0;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = flashExpMedium;
      description = "Empty Tree";
};

function InitTrees()
{
	dbecho($dbechoMode, "InitTrees()");

	%group = nameToID("MissionGroup\\Trees");

	if(%group != -1)
	{
		for(%i = 0; %i <= Group::objectCount(%group)-1; %i++)
		{
			%this = Group::getObject(%group, %i);
			%info = Object::getName(%this);

			if(%info != "")
			{
				%cnt = 0;
				for(%z = 0; (%p1 = GetWord(%info, %z)) != -1; %z+=2)
				{
					%p2 = GetWord(%info, %z+1);
					%this.bonus[%cnt++] = %p2;
				}
			}
		}
	}
}