ItemData PoisonArrow
{
description = "Poison Arrow";
className = "Projectile";
psn = "1";
shapeFile = "tracer";
heading = "xAmmunition";
shadowDetailMask = 4;
price = 0;
};
$ItemCost[PoisonArrow] = 1;
$ProjRestrictions[PoisonArrow] = ",LongBow,crystalbow,dracosbow,elvenbow,archersforce";
$SkillType[PoisonArrow] = $SkillArchery;
$AccessoryVar[PoisonArrow, $MiscInfo] = "<f0>A <f2>Poison Arrow<f0>, be careful of these.  Dont hurt victim too much, but causes <f2> Poison!<nl><f1>Thanks Newbie!";
$AccessoryVar[PoisonArrow, $Weight] = "0.1";
$AccessoryVar[PoisonArrow, $SpecialVar] = "6 15";
$AccessoryVar[PoisonArrow, $AccessoryType] = $ProjectileAccessoryType;
$WeaponDelay[PoisonArrow] = "";
$WeaponRange[PoisonArrow] = 100;

function Poison::DoDamage(%shooterClient, %ClientID, %type)
{
if(Poison::PoisonResist(%shooterClient, %ClientID) == 1)
	{
	if(%shooterClient != %ClientID)
		{
		UseSkill(%ClientID, $SkillPoisonResistance, True, False, 60);
		storedata(%ClientID, "Poisoned", fetchdata(%ClientID, "Poisoned") + %type);
		Poison::ApplyPoison(%shooterClient, %ClientID);
		}
	}
else if(%shooterClient == %ClientID)
	{
	Client::sendMessage(%ClientID, $MsgRed, "You Poisoned yourself!");
	storedata(%ClientID, "Poisoned", fetchdata(%ClientID, "Poisoned") + %type);
	Poison::ApplyPoison(%shooterClient, %ClientID);
	}
else if(Poison::PoisonResist(%shooterClient, %ClientID) != 1)
	{
	Client::sendMessage(%shooterClient, $MsgRed, "You failed to Poison " @ client::getname(%ClientID));
	Client::sendMessage(%ClientID, $MsgRed, client::getname(%shooterClient) @ " tried to Poison you, but failed!");
	} 
}		
		
function Poison::PoisonResist(%shooterClient, %ClientID)
{
if(String::FindSubSTR(Client::getName(%ClientID), "Trainer") == 0)
	return;
%x = (getRandom() * 20) + 5;
%y = (getrandon() * 20) + 5;
%n = %x + %y;

%r = floor(getRandom() * %n) + 1;
if(%r <= %x)
%isResist = 1;
if(%isResist == 1)
	storedata(%ClientID, "Poisoned");
return %isResist;
}


function Poison::ApplyPoison(%shooterClient, %ClientID, %type)
{
	if(Client::getName(%ClientID) != "")
		{
		if(fetchdata(%ClientID, "Poisoned") > 0)
			{
				%time = getIntegerTime(true) >> 5;
				if(%time - fetchdata(%clientId, "lastpsndmg") <= 1.9)
					return;
				storedata(%clientId, "lastpsndmg", %time);

				%flash = Player::getDamageFlash(%ClientID) + %type * 2;
				if(%flash > 0.75)
					%flash = 0.75;
				Player::setDamageFlash(%ClientID,%flash);
			%chp = fetchData(%ClientID, "HP");
			%dmg = round(fetchdata(%ClientID, "Poisoned") * getRandom());
			%dmg = %dmg + ($PlayerSkill[%shooterClient, $SkillArchery] / 3);
			%nhp = round(%chp - %dmg);
		if(%nhp > 0)
			{
			Client::sendMessage(%shooterClient, $MsgRed, "You Poisoned " @ Client::getName(%ClientID) @ " for " @ round(%dmg) @ "!");
			Client::sendMessage(%ClientID, $MsgRed, "You were Poisoned by " @ client::getname(%shooterClient) @ " for " @ round(%dmg) @ "!");
			radiusAllExcept(%ClientID, %shooterClient, client::getname(%ClientID) @ " takes Poison damage of " @ round(%dmg) @ "!");
			setHP(%ClientID, %nhp);
				schedule("Poison::DoDamage(" @ %shooterClient @ ", " @ %ClientID @ ", 0);", 2);
			}
		else 
			{
			if(fetchData(%clientId, "LCKconsequence") == "death")
				{
				DistributeExpForKilling(%clientId);
				playNextAnim(%clientId);
				Player::Kill(%clientId);
				storedata(%clientid, "LCK", fetchdata(%clientId, "LCK") - 1);
				}
			if(fetchData(%clientId, "LCKconsequence") == "miss")
				{
				storedata(%clientid, "LCK", fetchdata(%clientId, "LCK") - 1);
				Client::sendMessage(%shooterClient, $MsgRed, "You try to Poisoned " @ Client::getName(%ClientID) @ "(LCK)!");
				Client::sendMessage(%ClientID, $MsgRed, "You were Poisoned by " @ client::getname(%shooterClient) @ ",but they failed(LCK)!");
				
			}
	}
}
}
}