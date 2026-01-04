//Data for spells are defined in the SPELL DEFINITIONS section.  Unfortunately, not everything can be designed there
//(ie, special effects etc) so for the great majority, the spells are coded in the DoCastSpell function.  This method
//isn't the ideal one... maybe one day i'll fix that if the need comes along.

//-- SPELL TYPES (not in use due to hardcoding of spells...) -----------------------------------------------------

$SelfType = 1;				//casts only to self
$LOSType = 2;				//casts only at LOS

$SelfRadiusType = 3;			//casts to self and around self
$LOSRadiusType = 4;			//casts at LOS and around LOS

$SelfRadiusLOSType = 5;			//casts to self and around self and at LOS
$LOSRadiusSelfType = 6;			//casts at LOS and around LOS and to self

$SelfRadiusLOSRadiusType = 7;		//casts to self and around self and to LOS and around LOS

//-- SPELL DEFINITIONS -------------------------------------------------------------------------------------------

$Spell::keyword[1] = "firebomb";
$Spell::index[firebomb] = 1;
$Spell::name[1] = "Fire Bomb From Hell";
$Spell::description[1] = "Casts an explosive.";
$Spell::delay[1] = 1.5;
$Spell::recoveryTime[1] = 2.625;
$Spell::radius[1] = 10;
$Spell::damageValue[1] = 75;
$Spell::LOSrange[1] = 80;
$Spell::manaCost[1] = 5;
$Spell::startSound[1] = ActivateBF;
$Spell::endSound[1] = ExplodeLM;
$Spell::groupListCheck[1] = False;
$Spell::refVal[1] = 55;
$Spell::graceDistance[1] = 2;
$SkillType[firebomb] = $SkillOffensiveCasting;

$Spell::keyword[2] = "teleport";
$Spell::index[teleport] = 2;
$Spell::name[2] = "Teleport close to nearest zone";
$Spell::description[2] = "Teleports you near a zone";
$Spell::delay[2] = 3.5;
$Spell::recoveryTime[2] = 16.5;
$Spell::manaCost[2] = 8;
$Spell::startSound[2] = Portal11;
$Spell::endSound[2] = ActivateCH;
$Spell::groupListCheck[2] = False;
$Spell::refVal[2] = 0;
$Spell::graceDistance[2] = 15;
$SkillType[teleport] = $SkillNeutralCasting;

$Spell::keyword[3] = "transport";
$Spell::index[transport] = 3;
$Spell::name[3] = "Transport to zone";
$Spell::description[3] = "Transports to a specific zone";
$Spell::delay[3] = 4.0;
$Spell::recoveryTime[3] = 23;
$Spell::manaCost[3] = 12;
$Spell::startSound[3] = RespawnB;
$Spell::endSound[3] = ActivateCH;
$Spell::groupListCheck[3] = False;
$Spell::refVal[3] = 0;
$Spell::graceDistance[3] = 2;
$SkillType[transport] = $SkillNeutralCasting;

$Spell::keyword[4] = "advtransport";
$Spell::index[advtransport] = 4;
$Spell::name[4] = "Advanced Transport to zone";
$Spell::description[4] = "Transports self OR person in line-of-sight to a specific zone";
$Spell::delay[4] = 4.0;
$Spell::recoveryTime[4] = 27;
$Spell::LOSrange[4] = 500;
$Spell::manaCost[4] = 16;
$Spell::startSound[4] = RespawnB;
$Spell::endSound[4] = ActivateCH;
$Spell::groupListCheck[4] = True;
$Spell::refVal[4] = 0;
$Spell::graceDistance[4] = 2;
$SkillType[advtransport] = $SkillNeutralCasting;

$Spell::keyword[5] = "cloud";
$Spell::index[cloud] = 5;
$Spell::name[5] = "Cloud Attack";
$Spell::description[5] = "Casts an explosive.";
$Spell::delay[5] = 1.5;
$Spell::recoveryTime[5] = 2.625;
$Spell::radius[5] = 10;
$Spell::damageValue[5] = 105;
$Spell::LOSrange[5] = 80;
$Spell::manaCost[5] = 10;
$Spell::startSound[5] = ActivateBF;
$Spell::endSound[5] = ExplodeLM;
$Spell::groupListCheck[5] = False;
$Spell::refVal[5] = 85;
$Spell::graceDistance[5] = 2;
$SkillType[cloud] = $SkillOffensiveCasting;

$Spell::keyword[6] = "melt";
$Spell::index[melt] = 6;
$Spell::name[6] = "Melt Bomb Attack";
$Spell::description[6] = "Casts an explosive.";
$Spell::delay[6] = 1.5;
$Spell::recoveryTime[6] = 2.625;
$Spell::radius[6] = 10;
$Spell::damageValue[6] = 160;
$Spell::LOSrange[6] = 80;
$Spell::manaCost[6] = 15;
$Spell::startSound[6] = ActivateBF;
$Spell::endSound[6] = ExplodeLM;
$Spell::groupListCheck[6] = False;
$Spell::refVal[6] = 140;
$Spell::graceDistance[6] = 2;
$SkillType[melt] = $SkillOffensiveCasting;

$Spell::keyword[7] = "powercloud";
$Spell::index[powercloud] = 7;
$Spell::name[7] = "Power Cloud Attack";
$Spell::description[7] = "Casts three explosives.";
$Spell::delay[7] = 1.5;
$Spell::recoveryTime[7] = 7.5;
$Spell::radius[7] = 10;
$Spell::damageValue[7] = 90;
$Spell::LOSrange[7] = 80;
$Spell::manaCost[7] = 20;
$Spell::startSound[7] = ActivateBF;
$Spell::endSound[7] = ExplodeLM;
$Spell::groupListCheck[7] = False;
$Spell::refVal[7] = 210;
$Spell::graceDistance[7] = 2;
$SkillType[powercloud] = $SkillOffensiveCasting;

$Spell::keyword[8] = "heal";
$Spell::index[heal] = 8;
$Spell::name[8] = "Heal Self";
$Spell::description[8] = "Heals the caster.";
$Spell::delay[8] = 1.5;
$Spell::recoveryTime[8] = 2.25;
$Spell::damageValue[8] = -6;
$Spell::manaCost[8] = 2;
$Spell::startSound[8] = DeActivateWA;
$Spell::endSound[8] = ActivateAR;
$Spell::groupListCheck[8] = False;
$Spell::refVal[8] = -6;
$Spell::graceDistance[8] = 2;
$SkillType[heal] = $SkillDefensiveCasting;

$Spell::keyword[9] = "advheal1";
$Spell::index[advheal1] = 9;
$Spell::name[9] = "Heal Self or Other (1st)";
$Spell::description[9] = "Heals the caster or someone in the LOS.";
$Spell::delay[9] = 1.5;
$Spell::recoveryTime[9] = 3.25;
$Spell::damageValue[9] = -10;
$Spell::LOSrange[9] = 80;
$Spell::manaCost[9] = 3;
$Spell::startSound[9] = DeActivateWA;
$Spell::endSound[9] = ActivateAR;
$Spell::groupListCheck[9] = False;
$Spell::refVal[9] = -10;
$Spell::graceDistance[9] = 2;
$SkillType[advheal1] = $SkillDefensiveCasting;

$Spell::keyword[10] = "advheal2";
$Spell::index[advheal2] = 10;
$Spell::name[10] = "Heal Self Or Other (2nd)";
$Spell::description[10] = "Heals the caster or someone in the LOS.";
$Spell::delay[10] = 1.5;
$Spell::recoveryTime[10] = 4.0;
$Spell::damageValue[10] = -15;
$Spell::LOSrange[10] = 80;
$Spell::manaCost[10] = 4;
$Spell::startSound[10] = DeActivateWA;
$Spell::endSound[10] = ActivateAR;
$Spell::groupListCheck[10] = False;
$Spell::refVal[10] = -15;
$Spell::graceDistance[10] = 2;
$SkillType[advheal2] = $SkillDefensiveCasting;

$Spell::keyword[11] = "godlyheal";
$Spell::index[godlyheal] = 11;
$Spell::name[11] = "Godly Heal Self Or Other";
$Spell::description[11] = "Heals the caster or someone in the LOS.";
$Spell::delay[11] = 1.5;
$Spell::recoveryTime[11] = 6;
$Spell::damageValue[11] = -80;
$Spell::LOSrange[11] = 80;
$Spell::manaCost[11] = 15;
$Spell::startSound[11] = DeActivateWA;
$Spell::endSound[11] = ActivateAR;
$Spell::groupListCheck[11] = False;
$Spell::refVal[11] = -80;
$Spell::graceDistance[11] = 2;
$SkillType[godlyheal] = $SkillDefensiveCasting;

$Spell::keyword[12] = "beam";
$Spell::index[beam] = 12;
$Spell::name[12] = "Beam";
$Spell::description[12] = "Light gathers into a concentrated beam and causes intense damage to the target.";
$Spell::delay[12] = 0.0;
$Spell::recoveryTime[12] = 15;
$Spell::damageValue[12] = 200;
$Spell::LOSrange[12] = 1000;
$Spell::manaCost[12] = 30;
$Spell::startSound[12] = HitLevelDT;
$Spell::endSound[12] = HitBF;
$Spell::groupListCheck[12] = False;
$Spell::refVal[12] = 180;
$Spell::graceDistance[12] = 5;
$SkillType[beam] = $SkillOffensiveCasting;

$Spell::keyword[13] = "thorn";
$Spell::index[thorn] = 13;
$Spell::name[13] = "Thorn";
$Spell::description[13] = "Casts thorn.";
$Spell::delay[13] = 0.1;
$Spell::recoveryTime[13] = 1.5;
$Spell::radius[13] = 6;
$Spell::damageValue[13] = 60;
$Spell::LOSrange[13] = 80;
$Spell::manaCost[13] = 1;
$Spell::startSound[13] = ActivateFK;
$Spell::endSound[13] = DeflectAS;
$Spell::groupListCheck[13] = False;
$Spell::refVal[13] = 20;
$Spell::graceDistance[13] = 5;
$SkillType[thorn] = $SkillOffensiveCasting;

$Spell::keyword[14] = "fireball";
$Spell::index[fireball] = 14;
$Spell::name[14] = "Fireball";
$Spell::description[14] = "Casts a fireball.";
$Spell::delay[14] = 1;
$Spell::recoveryTime[14] = 1.5;
$Spell::radius[14] = 8;
$Spell::damageValue[14] = 65;
$Spell::LOSrange[14] = 80;
$Spell::manaCost[14] = 3;
$Spell::startSound[14] = ActivateAB;
$Spell::endSound[14] = LaunchFB;
$Spell::groupListCheck[14] = False;
$Spell::refVal[14] = 35;
$Spell::graceDistance[14] = 2;
$SkillType[fireball] = $SkillOffensiveCasting;

$Spell::keyword[15] = "icespike";
$Spell::index[icespike] = 15;
$Spell::name[15] = "Icespike";
$Spell::description[15] = "Casts icespike.";
$Spell::delay[15] = 0.1;
$Spell::recoveryTime[15] = 1.5;
$Spell::radius[15] = 6;
$Spell::damageValue[15] = 48;
$Spell::LOSrange[15] = 80;
$Spell::manaCost[15] = 3;
$Spell::startSound[15] = ActivateFK;
$Spell::endSound[15] = HitPawnDT;
$Spell::groupListCheck[15] = False;
$Spell::refVal[15] = 28;
$Spell::graceDistance[15] = 5;
$SkillType[icespike] = $SkillOffensiveCasting;

$Spell::keyword[16] = "icestorm";
$Spell::index[icestorm] = 16;
$Spell::name[16] = "Icestorm";
$Spell::description[16] = "Casts icestorm.";
$Spell::delay[16] = 1;
$Spell::recoveryTime[16] = 2.25;
$Spell::radius[16] = 11;
$Spell::damageValue[16] = 65;
$Spell::LOSrange[16] = 80;
$Spell::manaCost[16] = 4;
$Spell::startSound[16] = ImpactTR;
$Spell::endSound[16] = Reflected;
$Spell::groupListCheck[16] = False;
$Spell::refVal[16] = 45;
$Spell::graceDistance[16] = 2;
$SkillType[icestorm] = $SkillOffensiveCasting;

$Spell::keyword[17] = "ironfist";
$Spell::index[ironfist] = 17;
$Spell::name[17] = "Ironfist";
$Spell::description[17] = "Casts ironfist.";
$Spell::delay[17] = 0.1;
$Spell::recoveryTime[17] = 13.5;
$Spell::radius[17] = 7;
$Spell::damageValue[17] = 148;
$Spell::LOSrange[17] = 80;
$Spell::manaCost[17] = 12;
$Spell::startSound[17] = UnravelAM;
$Spell::endSound[17] = NoSound;
$Spell::groupListCheck[17] = False;
$Spell::refVal[17] = 128;
$Spell::graceDistance[17] = 3;
$SkillType[ironfist] = $SkillOffensiveCasting;

$Spell::keyword[18] = "hellstorm";
$Spell::index[hellstorm] = 18;
$Spell::name[18] = "Hellstorm";
$Spell::description[18] = "Casts hellstorm.";
$Spell::delay[18] = 6;
$Spell::recoveryTime[18] = 9.5;
$Spell::radius[18] = 20;
$Spell::damageValue[18] = 275;
$Spell::LOSrange[18] = 80;
$Spell::manaCost[18] = 20;
$Spell::startSound[18] = LoopLS;
$Spell::endSound[18] = LaunchET;
$Spell::groupListCheck[18] = False;
$Spell::refVal[18] = 265;
$Spell::graceDistance[18] = 2;
$SkillType[hellstorm] = $SkillOffensiveCasting;

$Spell::keyword[19] = "Tornado";
$Spell::index[Tornado] = 19;
$Spell::name[19] = "Tornado";
$Spell::description[19] = "Call a Tornado to your aid.";
$Spell::delay[19] = 5;
$Spell::recoveryTime[19] = 20;
$Spell::radius[19] = 30;
$Spell::damageValue[19] = 130;
$Spell::LOSrange[19] = 80;
$Spell::manaCost[19] = 75;
$Spell::startSound[19] = LaunchLS;
$Spell::endSound[19] = Explode3FW;
$Spell::groupListCheck[19] = False;
$Spell::refVal[19] = 320;
$Spell::graceDistance[19] = 2;
$SkillType[Tornado] = $SkillOffensiveCasting;

$Spell::keyword[20] = "advheal3";
$Spell::index[advheal3] = 20;
$Spell::name[20] = "Heal Self Or Other (3rd)";
$Spell::description[20] = "Heals the caster or someone in the LOS.";
$Spell::delay[20] = 1.5;
$Spell::recoveryTime[20] = 4.75;
$Spell::damageValue[20] = -25;
$Spell::LOSrange[20] = 80;
$Spell::manaCost[20] = 5;
$Spell::startSound[20] = DeActivateWA;
$Spell::endSound[20] = ActivateAR;
$Spell::groupListCheck[20] = False;
$Spell::refVal[20] = -25;
$Spell::graceDistance[20] = 2;
$SkillType[advheal3] = $SkillDefensiveCasting;

$Spell::keyword[21] = "remort";
$Spell::index[remort] = 21;
$Spell::name[21] = "Remort";
$Spell::description[21] = "Remorts a level 101+ character to level 1, with bonuses.";
$Spell::delay[21] = 3;
$Spell::recoveryTime[21] = 0;
$Spell::damageValue[21] = 0;
$Spell::manaCost[21] = 1;
$Spell::startSound[21] = RespawnA;
$Spell::endSound[21] = RespawnC;
$Spell::groupListCheck[21] = False;
$Spell::refVal[21] = 0;
$Spell::graceDistance[21] = 2;
$SkillType[remort] = $SkillNeutralCasting;

$Spell::keyword[22] = "fullheal";
$Spell::index[fullheal] = 22;
$Spell::name[22] = "Full Heal Self";
$Spell::description[22] = "Fully heals the caster.";
$Spell::delay[22] = 1.5;
$Spell::recoveryTime[22] = 60;
$Spell::damageValue[22] = 0;
$Spell::manaCost[22] = 2;
$Spell::startSound[22] = DeActivateWA;
$Spell::endSound[22] = PlaceSeal;
$Spell::groupListCheck[22] = False;
$Spell::refVal[22] = -9998;
$Spell::graceDistance[22] = 2;
$SkillType[fullheal] = $SkillDefensiveCasting;

$Spell::keyword[23] = "massheal";
$Spell::index[massheal] = 23;
$Spell::name[23] = "Mass Heal";
$Spell::description[23] = "Heals caster and friendlies 10 meters around.";
$Spell::delay[23] = 1.5;
$Spell::recoveryTime[23] = 10;
$Spell::radius[23] = 10;
$Spell::damageValue[23] = -30;
$Spell::manaCost[23] = 12;
$Spell::startSound[23] = DeActivateWA;
$Spell::endSound[23] = ActivateAR;
$Spell::groupListCheck[23] = False;
$Spell::refVal[23] = -30;
$Spell::graceDistance[23] = 2;
$SkillType[massheal] = $SkillDefensiveCasting;

$Spell::keyword[24] = "massfullheal";
$Spell::index[massfullheal] = 24;
$Spell::name[24] = "Mass Full Heal";
$Spell::description[24] = "Fully Heals caster and friendlies 12 meters around.";
$Spell::delay[24] = 1.5;
$Spell::recoveryTime[24] = 300;
$Spell::radius[24] = 12;
$Spell::damageValue[24] = 0;
$Spell::manaCost[24] = 200;
$Spell::startSound[24] = DeActivateWA;
$Spell::endSound[24] = PlaceSeal;
$Spell::groupListCheck[24] = False;
$Spell::refVal[24] = -9999;
$Spell::graceDistance[24] = 2;
$SkillType[massfullheal] = $SkillDefensiveCasting;

$Spell::keyword[25] = "shield";
$Spell::index[shield] = 25;
$Spell::name[25] = "Shield Self";
$Spell::description[25] = "A magical shield adds 50 DEF to the caster.";
$Spell::delay[25] = 2.0;
$Spell::recoveryTime[25] = 8;
$Spell::damageValue[25] = "DEF 50";
$Spell::ticks[25] = 150;	//5 minutes
$Spell::manaCost[25] = 5;
$Spell::startSound[25] = ActivateTR;
$Spell::endSound[25] = ActivateTD;
$Spell::groupListCheck[25] = False;
$Spell::refVal[25] = -10;
$Spell::graceDistance[25] = 2;
$SkillType[shield] = $SkillDefensiveCasting;

$Spell::keyword[26] = "advshield1";
$Spell::index[advshield1] = 26;
$Spell::name[26] = "Shield Self Or Other (1st)";
$Spell::description[26] = "A magical shield that adds 80 DEF to the caster or target in LOS.";
$Spell::delay[26] = 2.0;
$Spell::recoveryTime[26] = 10;
$Spell::damageValue[26] = "DEF 80";
$Spell::ticks[26] = 165;	//5:30 minutes
$Spell::LOSrange[26] = 80;
$Spell::manaCost[26] = 8;
$Spell::startSound[26] = ActivateTR;
$Spell::endSound[26] = ActivateTD;
$Spell::groupListCheck[26] = False;
$Spell::refVal[26] = -11;
$Spell::graceDistance[26] = 2;
$SkillType[advshield1] = $SkillDefensiveCasting;

$Spell::keyword[27] = "advshield2";
$Spell::index[advshield2] = 27;
$Spell::name[27] = "Shield Self Or Other (2nd)";
$Spell::description[27] = "A magical shield that adds 70 DEF and 50 MDEF to the caster or target in LOS.";
$Spell::delay[27] = 2.0;
$Spell::recoveryTime[27] = 12;
$Spell::damageValue[27] = "DEF 70 MDEF 50";
$Spell::ticks[27] = 190;	//6:20 minutes
$Spell::LOSrange[27] = 80;
$Spell::manaCost[27] = 15;
$Spell::startSound[27] = ActivateTR;
$Spell::endSound[27] = ActivateTD;
$Spell::groupListCheck[27] = False;
$Spell::refVal[27] = -12;
$Spell::graceDistance[27] = 2;
$SkillType[advshield2] = $SkillDefensiveCasting;

$Spell::keyword[28] = "advshield3";
$Spell::index[advshield3] = 28;
$Spell::name[28] = "Shield Self Or Other (3rd)";
$Spell::description[28] = "A magical shield that adds 120 DEF and 80 MDEF to the caster or target in LOS.";
$Spell::delay[28] = 2.0;
$Spell::recoveryTime[28] = 14;
$Spell::damageValue[28] = "DEF 120 MDEF 80";
$Spell::ticks[28] = 218;	//7:16 minutes
$Spell::LOSrange[28] = 80;
$Spell::manaCost[28] = 18;
$Spell::startSound[28] = ActivateTR;
$Spell::endSound[28] = ActivateTD;
$Spell::groupListCheck[28] = False;
$Spell::refVal[28] = -13;
$Spell::graceDistance[28] = 2;
$SkillType[advshield3] = $SkillDefensiveCasting;

$Spell::keyword[29] = "advshield4";
$Spell::index[advshield4] = 29;
$Spell::name[29] = "Shield Self Or Other (4th)";
$Spell::description[29] = "A magical shield that adds 170 MDEF to the caster or target in LOS.";
$Spell::delay[29] = 2.0;
$Spell::recoveryTime[29] = 16;
$Spell::damageValue[29] = "MDEF 170";
$Spell::ticks[29] = 255;	//8:30 minutes
$Spell::LOSrange[29] = 80;
$Spell::manaCost[29] = 22;
$Spell::startSound[29] = ActivateTR;
$Spell::endSound[29] = ActivateTD;
$Spell::groupListCheck[29] = False;
$Spell::refVal[29] = -14;
$Spell::graceDistance[29] = 2;
$SkillType[advshield4] = $SkillDefensiveCasting;

$Spell::keyword[30] = "advshield5";
$Spell::index[advshield5] = 30;
$Spell::name[30] = "Shield Self Or Other (5th)";
$Spell::description[30] = "A magical shield that adds 150 DEF and 210 MDEF to the caster or target in LOS.";
$Spell::delay[30] = 2.0;
$Spell::recoveryTime[30] = 20;
$Spell::damageValue[30] = "DEF 150 MDEF 210";
$Spell::ticks[30] = 300;	//10 minutes
$Spell::LOSrange[30] = 80;
$Spell::manaCost[30] = 25;
$Spell::startSound[30] = ActivateTR;
$Spell::endSound[30] = ActivateTD;
$Spell::groupListCheck[30] = False;
$Spell::refVal[30] = -15;
$Spell::graceDistance[30] = 2;
$SkillType[advshield5] = $SkillDefensiveCasting;

$Spell::keyword[31] = "massshield";
$Spell::index[massshield] = 31;
$Spell::name[31] = "Mass Shield";
$Spell::description[31] = "A magical shield that adds 115 DEF and 105 MDEF to all friendlies within a 10 meter radius.";
$Spell::delay[31] = 2.0;
$Spell::recoveryTime[31] = 30;
$Spell::radius[31] = 10;
$Spell::damageValue[31] = "DEF 115 MDEF 105";
$Spell::ticks[31] = 270;	//9 minutes
$Spell::manaCost[31] = 20;
$Spell::startSound[31] = ActivateTR;
$Spell::endSound[31] = ActivateTD;
$Spell::groupListCheck[31] = False;
$Spell::refVal[31] = -16;
$Spell::graceDistance[31] = 2;
$SkillType[massshield] = $SkillDefensiveCasting;

$Spell::keyword[32] = "mimic";
$Spell::index[mimic] = 32;
$Spell::name[32] = "Mimic";
$Spell::description[32] = "A very dangerous spell that transforms the caster into the creature in his/her LOS.";
$Spell::delay[32] = 4.0;
$Spell::recoveryTime[32] = 60;
$Spell::LOSrange[32] = 80;
$Spell::damageValue[32] = 0;
$Spell::manaCost[32] = 80;
$Spell::startSound[32] = LoopSP;
$Spell::endSound[32] = AbsorbABS;
$Spell::groupListCheck[32] = False;
$Spell::refVal[32] = 1;
$Spell::graceDistance[32] = 2;
$SkillType[mimic] = $SkillNeutralCasting;

$Spell::keyword[33] = "masstransport";
$Spell::index[masstransport] = 33;
$Spell::name[33] = "Mass Transport";
$Spell::description[33] = "Transports self and all friendlies within a 6 meter radius to a specific zone.";
$Spell::delay[33] = 4.0;
$Spell::recoveryTime[33] = 45;
$Spell::radius[33] = 6;
$Spell::manaCost[33] = 50;
$Spell::startSound[33] = RespawnB;
$Spell::endSound[33] = ActivateCH;
$Spell::groupListCheck[33] = False;
$Spell::refVal[33] = 0;
$Spell::graceDistance[33] = 2;
$SkillType[masstransport] = $SkillNeutralCasting;

$Spell::keyword[34] = "advheal4";
$Spell::index[advheal4] = 34;
$Spell::name[34] = "Heal Self Or Other (4th)";
$Spell::description[34] = "Heals the caster or someone in the LOS.";
$Spell::delay[34] = 1.5;
$Spell::recoveryTime[34] = 5.0;
$Spell::damageValue[34] = -35;
$Spell::LOSrange[34] = 80;
$Spell::manaCost[34] = 6;
$Spell::startSound[34] = DeActivateWA;
$Spell::endSound[34] = ActivateAR;
$Spell::groupListCheck[34] = False;
$Spell::refVal[34] = -35;
$Spell::graceDistance[34] = 2;
$SkillType[advheal4] = $SkillDefensiveCasting;

$Spell::keyword[35] = "advheal5";
$Spell::index[advheal5] = 35;
$Spell::name[35] = "Heal Self Or Other (5th)";
$Spell::description[35] = "Heals the caster or someone in the LOS.";
$Spell::delay[35] = 1.5;
$Spell::recoveryTime[35] = 5.5;
$Spell::damageValue[35] = -50;
$Spell::LOSrange[35] = 80;
$Spell::manaCost[35] = 7;
$Spell::startSound[35] = DeActivateWA;
$Spell::endSound[35] = ActivateAR;
$Spell::groupListCheck[35] = False;
$Spell::refVal[35] = -50;
$Spell::graceDistance[35] = 2;
$SkillType[advheal5] = $SkillDefensiveCasting;

$Spell::keyword[36] = "advheal6";
$Spell::index[advheal6] = 36;
$Spell::name[36] = "Heal Self Or Other (6th)";
$Spell::description[36] = "Heals the caster or someone in the LOS.";
$Spell::delay[36] = 1.5;
$Spell::recoveryTime[36] = 6.0;
$Spell::damageValue[36] = -60;
$Spell::LOSrange[36] = 80;
$Spell::manaCost[36] = 8;
$Spell::startSound[36] = DeActivateWA;
$Spell::endSound[36] = ActivateAR;
$Spell::groupListCheck[36] = False;
$Spell::refVal[36] = -60;
$Spell::graceDistance[36] = 2;
$SkillType[advheal6] = $SkillDefensiveCasting;

$Spell::keyword[37] = "heavensheal";
$Spell::index[heavensheal] = 37;
$Spell::name[37] = "Heavens Heal";
$Spell::description[37] = "Fully Heals caster and friendlies 30 meters around with the power of Heaven.";
$Spell::delay[37] = 1.5;
$Spell::recoveryTime[37] = 60;
$Spell::radius[37] = 30;
$Spell::damageValue[37] = 0;
$Spell::manaCost[37] = 100;
$Spell::startSound[37] = DeActivateWA;
$Spell::endSound[37] = PlaceSeal;
$Spell::groupListCheck[37] = False;
$Spell::refVal[37] = -9999;
$Spell::graceDistance[37] = 2;
$SkillType[heavensheal] = $SkillDefensiveCasting;

$Spell::keyword[38] = "melodyofhate";
$Spell::index[melodyofhate] = 38;
$Spell::name[38] = "Melody Of Hate";
$Spell::description[38] = "<f2>The Melody of Hate. <f3>Show them you hate them. <f3>Takes 150 def and 210 mdef from your LOS for 10 minutes.";
$Spell::delay[38] = 2.0;
$Spell::recoveryTime[38] = 20;
$Spell::damageValue[38] = "DEF -150 MDEF -210";
$Spell::ticks[38] = 600;
$Spell::LOSrange[38] = 80;
$Spell::manaCost[38] = 10;
$Spell::startSound[38] = ActivateTR;
$Spell::endSound[38] = LoopSP;
$Spell::groupListCheck[38] = False;
$Spell::refVal[38] = -15;
$Spell::graceDistance[38] = 2;
$SkillType[melodyofhate] = $SkillSpeech;

$Spell::keyword[39] = "songofhealing";
$Spell::index[songofhealing] = 39;
$Spell::name[39] = "Song Of Healing";
$Spell::description[39] = "Heals the caster.";
$Spell::delay[39] = 1.5;
$Spell::recoveryTime[39] = 2.25;
$Spell::damageValue[39] = -10;
$Spell::manaCost[39] = 2;
$Spell::startSound[39] = DeActivateWA;
$Spell::endSound[39] = ActivateAR;
$Spell::groupListCheck[39] = False;
$Spell::refVal[39] = -6;
$Spell::graceDistance[39] = 2;
$SkillType[SongOfHeal] = $SkillSpeech;

$Spell::keyword[40] = "Petrify";
$Spell::index[mesmerize] = 40;
$Spell::name[40] = "Petrify";
$Spell::description[40] = "Petrify your enemy for 10 seconds.";
$Spell::delay[40] = 1.5;
$Spell::recoveryTime[40] = 60;
$Spell::damageValue[40] = "HP -5";
$Spell::manaCost[40] = 25;
$Spell::startSound[40] = DeActivateWA;
$Spell::endSound[40] = ActivateAR;
$Spell::groupListCheck[40] = False;
$Spell::refVal[40] = -6;
$Spell::graceDistance[40] = 2;
$SkillType[Petrify] = $Skilloffensivecasting;

$Spell::keyword[41] = "hurricane";
$Spell::index[hurricane] = 41;
$Spell::name[41] = "Hurricane Attack";
$Spell::description[41] = "Casts a hurricane.";
$Spell::delay[41] = 2;
$Spell::recoveryTime[41] = 35;
$Spell::radius[41] = 40;
$Spell::damageValue[41] = 300;
$Spell::LOSrange[41] = 160;
$Spell::manaCost[41] = 100;
$Spell::startSound[41] = ActivateDE;
$Spell::endSound[41] = NoSound;
$Spell::groupListCheck[41] = False;
$Spell::refVal[41] = 210;
$Spell::graceDistance[41] = 2;
$SkillType[hurricane] = $SkillOffensiveCasting;

// the new spells //
$Spell::keyword[42] = "Ultima";
$Spell::index[ultima] = 42;
$Spell::name[42] = "Ultima";
$Spell::description[42] = "<f3>Death to those around you.";
$Spell::delay[42] = 13;
$Spell::recoveryTime[42] = 60;
$Spell::radius[42] = 30;
$Spell::damageValue[42] = 1000;
$Spell::LOSrange[42] = 500; //for bots
$Spell::manaCost[42] = 90;
$Spell::startSound[42] = LaunchLS;
$Spell::endSound[42] = PlaceSeal;
$Spell::groupListCheck[42] = False;
$Spell::graceDistance[42] = 2;
$Spell::refVal[42] = 210;
$SkillType[Ultima] = $SkillOffensiveCasting;

$Spell::keyword[43] = "divineray";
$Spell::index[divineray] = 43;
$Spell::name[43] = "Divine Ray";
$Spell::description[43] = "Calls upon Norumen for a peacekeeping spell. It's pretty effective.";
$Spell::delay[43] = 8;
$Spell::recoveryTime[43] = 20;
$Spell::radius[43] = 20;
$Spell::damageValue[43] = 800;
$Spell::LOSrange[43] = 500;
$Spell::manaCost[43] = 50;
$Spell::startSound[43] = LaunchLS;
$Spell::endSound[43] = PlaceSeal;
$Spell::groupListCheck[43] = False;
$Spell::graceDistance[43] = 2;
$SkillType[divineray] = $SkillNeutralCasting;

$Spell::keyword[44] = "rumble";
$Spell::index[rumble] = 44;
$Spell::name[44] = "Rumble";
$Spell::description[44] = "The earth shakes up some rocks to hit the enemy.";
$Spell::delay[44] = 2.0;
$Spell::recoveryTime[44] = 3;
$Spell::radius[44] = 6;
$Spell::damageValue[44] = 160;
$Spell::LOSrange[44] = 80;
$Spell::manaCost[44] = 18;
$Spell::startSound[44] = ActivateBF;
$Spell::endSound[44] = ExplodeLM;
$Spell::groupListCheck[44] = False;
$Spell::graceDistance[44] = 2;
$SkillType[rumble] = $SkillOffensiveCasting;

$Spell::keyword[45] = "quake";
$Spell::index[quake] = 45;
$Spell::name[45] = "Earthquake";
$Spell::description[45] = "Tremors assault the ground, damaging and killing all enemies within a half-mile radius.";
$Spell::delay[45] = 3.5;
$Spell::recoveryTime[45] = 8;
$Spell::radius[45] = 50;
$Spell::damageValue[45] = 200;
$Spell::LOSrange[45] = 180;
$Spell::manaCost[45] = 30;
$Spell::startSound[45] = ActivateBF;
$Spell::endSound[45] = ExplodeLM;
$Spell::groupListCheck[45] = False;
$Spell::graceDistance[45] = 2;
$SkillType[quake] = $SkillOffensiveCasting;

$Spell::keyword[46] = "avalanche";
$Spell::index[avalanche] = 46;
$Spell::name[46] = "Avalanche";
$Spell::description[46] = "Conjures fourty rocks above the target. Gravity does the rest.";
$Spell::delay[46] = 4;
$Spell::recoveryTime[46] = 10;
$Spell::radius[46] = 10;
$Spell::damageValue[46] = 250;
$Spell::LOSrange[46] = 80;
$Spell::manaCost[46] = 45;
$Spell::startSound[46] = ActivateAB;
$Spell::endSound[46] = LaunchET;
$Spell::groupListCheck[46] = False;
$Spell::refVal[46] = 35;
$Spell::graceDistance[46] = 2;
$SkillType[avalanche] = $SkillOffensiveCasting;

$Spell::keyword[47] = "meteor";
$Spell::index[meteor] = 47;
$Spell::name[47] = "Meteor";
$Spell::description[47] = "Calls down a large mass of solid rock the size of a house.";
$Spell::delay[47] = 10;
$Spell::recoveryTime[47] = 100;
$Spell::radius[47] = 60;
$Spell::damageValue[47] = 420;
$Spell::LOSrange[47] = 700;
$Spell::manaCost[47] = 75;
$Spell::startSound[47] = LaunchLS;
$Spell::endSound[47] = ActivateAB;
$Spell::groupListCheck[47] = False;
$Spell::graceDistance[47] = 2;
$SkillType[meteor] = $SkillOffensiveCasting;

$Spell::keyword[48] = "smoke";
$Spell::index[smoke] = 48;
$Spell::description[48] = "Blasts the target with choking smoke.";
$Spell::delay[48] = 4.2;
$Spell::recoveryTime[48] = 2;
$Spell::radius[48] = 8;
$Spell::damageValue[48] = 80;
$Spell::LOSrange[48] = 80;
$Spell::manaCost[48] = 7;
$Spell::startSound[48] = ActivateBF;
$Spell::endSound[48] = ExplodeLM;
$Spell::groupListCheck[48] = False;
$Spell::graceDistance[48] = 2;
$SkillType[smoke] = $SkillOffensiveCasting;

$Spell::keyword[49] = "firespike";
$Spell::index[firespike] = 49;
$Spell::name[49] = "Fire Spike";
$Spell::description[49] = "A spike of firey energy impales the target.";
$Spell::delay[49] = 2;
$Spell::recoveryTime[49] = 5;
$Spell::radius[49] = 5;
$Spell::damageValue[49] = 160;
$Spell::LOSrange[49] = 80;
$Spell::manaCost[49] = 20;
$Spell::startSound[49] = ActivateAB;
$Spell::endSound[49] = LaunchFB;
$Spell::groupListCheck[49] = False;
$Spell::graceDistance[49] = 2;
$SkillType[firespike] = $SkillOffensiveCasting;

$Spell::keyword[50] = "firerain";
$Spell::index[firerain] = 50;
$Spell::name[50] = "Firey Rain";
$Spell::description[50] = "While not really armaggeddon, but some nice fireworks with major pain.";
$Spell::delay[50] = 5;
$Spell::recoveryTime[50] = 15;
$Spell::radius[50] = 20;
$Spell::damageValue[50] = 200;
$Spell::LOSrange[50] = 80;
$Spell::manaCost[50] = 22;
$Spell::startSound[50] = LoopLS;
$Spell::endSound[50] = LaunchFB;
$Spell::groupListCheck[50] = False;
$Spell::graceDistance[50] = 2;
$SkillType[firerain] = $SkillOffensiveCasting;

$Spell::keyword[51] = "lavaburst";
$Spell::index[lavaburst] = 51;
$Spell::name[51] = "Lava Burst";
$Spell::description[51] = "Creates temporary pool of lava to sear the enemy.";
$Spell::delay[51] = 5;
$Spell::recoveryTime[51] = 10;
$Spell::radius[51] = 20;
$Spell::damageValue[51] = 230;
$Spell::LOSrange[51] = 80;
$Spell::manaCost[51] = 25;
$Spell::startSound[51] = LoopLS;
$Spell::endSound[51] = LaunchFB;
$Spell::groupListCheck[51] = False;
$Spell::graceDistance[51] = 2;
$SkillType[lavaburst] = $SkillOffensiveCasting;

$Spell::keyword[52] = "blizzard";
$Spell::index[blizzard] = 52;
$Spell::name[52] = "Blizzard";
$Spell::description[52] = "A small blizzard chills the enemies.";
$Spell::delay[52] = 2;
$Spell::recoveryTime[52] = 5.25;
$Spell::radius[52] = 10;
$Spell::damageValue[52] = 140;
$Spell::LOSrange[52] = 80;
$Spell::manaCost[52] = 10;
$Spell::startSound[52] = ImpactTR;
$Spell::endSound[52] = Reflected;
$Spell::groupListCheck[52] = False;
$Spell::graceDistance[52] = 2;
$SkillType[blizzard] = $SkillOffensiveCasting;

$Spell::keyword[53] = "comet";
$Spell::index[comet] = 53;
$Spell::name[53] = "Ice Comet";
$Spell::description[53] = "Calls down an icy comet.";
$Spell::delay[53] = 10;
$Spell::recoveryTime[53] = 100;
$Spell::radius[53] = 50;
$Spell::damageValue[53] = 420;
$Spell::LOSrange[53] = 600;
$Spell::manaCost[53] = 30;
$Spell::startSound[53] = LaunchLS;
$Spell::endSound[53] = ActivateAB;
$Spell::groupListCheck[53] = False;
$Spell::graceDistance[53] = 2;
$SkillType[comet] = $SkillOffensiveCasting;

$Spell::keyword[54] = "shock";
$Spell::index[shock] = 54;
$Spell::name[54] = "Shock";
$Spell::description[54] = "Shoots a small pulse of electricity.";
$Spell::delay[54] = 1;
$Spell::recoveryTime[54] = 2.5;
$Spell::radius[54] = 7;
$Spell::damageValue[54] = 35;
$Spell::LOSrange[54] = 100;
$Spell::manaCost[54] = 2;
$Spell::startSound[54] = ActivateAB;
$Spell::endSound[54] = Reflected;
$Spell::groupListCheck[54] = False;
$Spell::graceDistance[54] = 20;
$SkillType[shock] = $SkillOffensiveCasting;

$Spell::keyword[55] = "lit";
$Spell::index[lit] = 55;
$Spell::name[55] = "Lighting Blast";
$Spell::description[55] = "Shoots a pulse of electricity.";
$Spell::delay[55] = 1.5;
$Spell::recoveryTime[55] = 2.8;
$Spell::radius[55] = 6;
$Spell::damageValue[55] = 70;
$Spell::LOSrange[55] = 200;
$Spell::manaCost[55] = 5;
$Spell::startSound[55] = ActivateAB;
$Spell::endSound[55] = Reflected;
$Spell::groupListCheck[55] = False;
$Spell::refVal[55] = 120;
$Spell::graceDistance[55] = 20;
$SkillType[lit] = $SkillOffensiveCasting;

$Spell::keyword[56] = "zap";
$Spell::index[zap] = 56;
$Spell::name[56] = "Zap";
$Spell::description[56] = "Shoots a pulse of electricity.";
$Spell::delay[56] = 0.9;
$Spell::recoveryTime[56] = 1.8;
$Spell::radius[56] = 3;
$Spell::damageValue[56] = 90;
$Spell::LOSrange[56] = 200;
$Spell::manaCost[56] = 8;
$Spell::startSound[56] = ActivateAB;
$Spell::endSound[56] = Reflected;
$Spell::groupListCheck[56] = False;
$Spell::refVal[56] = 120;
$Spell::graceDistance[56] = 20;
$SkillType[zap] = $SkillOffensiveCasting;

$Spell::keyword[57] = "electrocute";
$Spell::index[electrocute] = 57;
$Spell::name[57] = "Electrocute";
$Spell::description[57] = "Shoots a few pulses of electricity, rather deadly.";
$Spell::delay[57] = 3;
$Spell::recoveryTime[57] = 6;
$Spell::radius[57] = 6;
$Spell::damageValue[57] = 300;
$Spell::LOSrange[57] = 200;
$Spell::manaCost[57] = 11;
$Spell::startSound[57] = ActivateAB;
$Spell::endSound[57] = Reflected;
$Spell::groupListCheck[57] = False;
$Spell::graceDistance[57] = 20;
$SkillType[electrocute] = $SkillOffensiveCasting;

$Spell::keyword[58] = "bolt";
$Spell::index[bolt] = 58;
$Spell::name[58] = "Thunder Bolt";
$Spell::description[58] = "Calls down an great bolt of thunder.";
$Spell::delay[58] = 0.2;
$Spell::recoveryTime[58] = 25;
$Spell::radius[58] = 50;
$Spell::damageValue[58] = 400;
$Spell::LOSrange[58] = 500;
$Spell::manaCost[58] = 60;
$Spell::startSound[58] = HitLevelDT;
$Spell::endSound[58] = HitBF;
$Spell::groupListCheck[58] = False;
$Spell::refVal[58] = 120;
$Spell::graceDistance[58] = 2;
$SkillType[bolt] = $SkillOffensiveCasting;

$Spell::keyword[59] = "boost";
$Spell::index[boost] = 59;
$Spell::name[59] = "Wind Booster";
$Spell::description[59] = "Use a burst of air to launch yourself forward.";
$Spell::delay[59] = 0.5;
$Spell::recoveryTime[59] = 5;
$Spell::damageValue[59] = "0";
$Spell::manaCost[59] = 15;
$Spell::startSound[59] = ActivateAB;
$Spell::endSound[59] = NoSound;
$Spell::groupListCheck[59] = False;
$Spell::graceDistance[59] = 100;
$SkillType[boost] = $SkillDefensiveCasting;

$Spell::keyword[60] = "stop";
$Spell::index[stop] = 60;
$Spell::name[60] = "Stop";
$Spell::description[60] = "Use a burst of air to cushion your speed.";
$Spell::delay[60] = 0.2;
$Spell::recoveryTime[60] = 5;
$Spell::damageValue[60] = "0";
$Spell::manaCost[60] = 15;
$Spell::startSound[60] = ActivateAB;
$Spell::endSound[60] = NoSound;
$Spell::groupListCheck[60] = False;
$Spell::graceDistance[60] = 200;
$SkillType[stop] = $SkillDefensiveCasting;

$Spell::keyword[61] = "UnHolyRain";
$Spell::index[UnholyRain] = 61;
$Spell::name[61] = "UnHolyRain";
$Spell::description[61] = "Everything burns.";
$Spell::delay[61] = 5;
$Spell::recoveryTime[61] = 71;
$Spell::radius[61] = 24;
$Spell::damageValue[61] = 250;
$Spell::LOSrange[61] = 40;
$Spell::manaCost[61] = 82;
$Spell::startSound[61] = LoopLS;
$Spell::endSound[61] = LaunchFB;
$Spell::groupListCheck[61] = False;
$Spell::graceDistance[61] = 2;
$SkillType[UnHolyRainfirerain] = $SkillOffensiveCasting;

$Spell::keyword[62] = "SwordStorm";
$Spell::index[SwordStorm] = 62;
$Spell::name[62] = "SwordStorm";
$Spell::description[62] = "Summon a fury of swords to slice your enemy.";
$Spell::delay[62] = 6;
$Spell::recoveryTime[62] = 15;
$Spell::damageValue[62] = 60;
$Spell::LOSrange[62] = 200;
$Spell::manaCost[62] = 200;
$Spell::startSound[62] = ActivateAB;
$Spell::endSound[62] = Reflected;
$Spell::groupListCheck[62] = False;
$Spell::graceDistance[62] = 20;
$SkillType[SwordStorm] = $SkillOffensiveCasting;

$Spell::keyword[63] = "DirtyBomb";
$Spell::index[DirtyBomb] = 63;
$Spell::name[63] = "DirtyBomb";
$Spell::description[63] = "ewww...dirty.";
$Spell::delay[63] = 0.3;
$Spell::recoveryTime[63] = 75;
$Spell::damageValue[63] = 400;
$Spell::LOSrange[63] = 700;
$Spell::manaCost[63] = 130;
$Spell::startSound[63] = ActivateAB;
$Spell::endSound[63] = Reflected;
$Spell::groupListCheck[63] = False;
$Spell::graceDistance[63] = 20;
$SkillType[DirtyBomb] = $SkillOffensiveCasting;

$Spell::keyword[64] = "ArrowStorm";
$Spell::index[ArrowStorm] = 64;
$Spell::name[64] = "ArrowStorm";
$Spell::description[64] = "Summon Arrows to pierce your foes head.";
$Spell::delay[64] = 0.5;
$Spell::recoveryTime[64] = 25;
$Spell::damageValue[64] = 400;
$Spell::LOSrange[64] = 700;
$Spell::manaCost[64] = 130;
$Spell::startSound[64] = ActivateAB;
$Spell::endSound[64] = Reflected;
$Spell::groupListCheck[64] = False;
$Spell::graceDistance[64] = 20;
$SkillType[ArrowStorm] = $SkillOffensiveCasting;

$Spell::keyword[65] = "Death";
$Spell::index[Death] = 65;
$Spell::name[65] = "Death";
$Spell::description[65] = "Summon Death.";
$Spell::delay[65] = 6;
$Spell::recoveryTime[65] = 40;
$Spell::damageValue[65] = 400;
$Spell::LOSrange[65] = 200;
$Spell::manaCost[65] = 250;
$Spell::startSound[65] = ActivateAB;
$Spell::endSound[65] = Reflected;
$Spell::groupListCheck[65] = False;
$Spell::graceDistance[65] = 3;
$SkillType[Death] = $SkillOffensiveCasting;

$Spell::keyword[66] = "derajheal";
$Spell::index[derajheal] = 66;
$Spell::name[66] = "GODS HEALING";
$Spell::description[66] = "Fully Heals EVERYONE";
$Spell::delay[66] = 0;
$Spell::recoveryTime[66] = 0;
$Spell::radius[66] = 9999;
$Spell::damageValue[66] = 0;
$Spell::manaCost[66] = 0;
$Spell::startSound[66] = DeActivateWA;
$Spell::endSound[66] = PlaceSeal;
$Spell::groupListCheck[66] = False;
$Spell::refVal[66] = -9999;
$Spell::graceDistance[66] = 2;
$SkillType[derajheal] = $SkillDefensiveCasting;

$Spell::keyword[67] = "derajbeam";
$Spell::index[derajbeam] = 67;
$Spell::name[67] = "Beam Of Doom";
$Spell::description[67] = "A Beem From The Right Hand Of God.";
$Spell::delay[67] = 1;
$Spell::recoveryTime[67] = 1;
$Spell::damageValue[67] = 999999;
$Spell::LOSrange[67] = 9999;
$Spell::manaCost[67] = 0;
$Spell::startSound[67] = HitLevelDT;
$Spell::endSound[67] = HitBF;
$Spell::groupListCheck[67] = False;
$Spell::refVal[67] = 180;
$Spell::graceDistance[67] = 5;
$SkillType[derajbeam] = $SkillOffensiveCasting;

$Spell::keyword[68] = "healofderaj";
$Spell::index[healofderaj] = 68;
$Spell::name[68] = "deraj's Heal Self";
$Spell::description[68] = "Heals the caster with the power of deraj.";
$Spell::delay[68] = 0;
$Spell::recoveryTime[68] = 0;
$Spell::damageValue[68] = -9999;
$Spell::manaCost[68] = 0;
$Spell::startSound[68] = DeActivateWA;
$Spell::endSound[68] = ActivateAR;
$Spell::groupListCheck[68] = False;
$Spell::refVal[68] = -9999;
$Spell::graceDistance[68] = 2;
$SkillType[healofderaj] = $SkillDefensiveCasting;

$Spell::keyword[69] = "derajshield";
$Spell::index[derajshield] = 69;
$Spell::name[69] = "God's Shielding";
$Spell::description[69] = "A magical shield casted by admins.";
$Spell::delay[69] = 0;
$Spell::recoveryTime[69] = 0;
$Spell::radius[69] = 9999;
$Spell::damageValue[69] = "DEF 9999 MDEF 9999";
$Spell::ticks[69] = 900;	//9 minutes
$Spell::manaCost[69] = 0;
$Spell::startSound[69] = ActivateTR;
$Spell::endSound[69] = ActivateTD;
$Spell::groupListCheck[69] = False;
$Spell::refVal[69] = -16;
$Spell::graceDistance[69] = 2;
$SkillType[derajshield] = $SkillDefensiveCasting;

$Spell::keyword[70] = "nuke";
$Spell::index[nuke] = 70;
$Spell::name[70] = "nuke";
$Spell::description[70] = "<f1>Death to EVERYONE.(USE AT YOUR OWN RISK) in other words you will probily DIE!... also";
$Spell::delay[70] = 0;
$Spell::recoveryTime[70] = 0;
$Spell::radius[70] = 9999;
$Spell::damageValue[70] = 9999;
$Spell::LOSrange[70] = 9999; //for bots
$Spell::manaCost[70] = 0;
$Spell::startSound[70] = LaunchLS;
$Spell::endSound[70] = PlaceSeal;
$Spell::groupListCheck[70] = False;
$Spell::graceDistance[70] = 2;
$Spell::refVal[70] = 9999;
$SkillType[nuke] = $SkillOffensiveCasting;

//----------------------------------------------------------------------------------------------------------------

function BeginCastSpell(%clientId, %keyword)
{
	
dbecho($dbechoMode, "BeginCastSpell(" @ %clientId @ ", " @ %keyword @ ")");

%w1 = GetWord(%keyword, 0);
%w2 = String::getSubStr(%keyword, String::len(%w1)+1, 99999);
%w3 = GetWord(%keyword, 1);
%w4 = String::findSubStr(%w3,"+");
// Carling, This is called a comment. You should get used to using them.
// There are now people taking advantage of OLD hacks. This will block the one
// That allows functions to be called at then end of spell keywords.
if(%w4 == 1 && !Player::isAiControlled(%clientId)) 
{
$HACK[%clientId]++;
if($HACK[%clientId] >= 3)
{	
schedule("remotesay(" @ %clientId @ ", 0, \"#global Hello everyone, my name is " @ Client::getName(%clientId) @ ". I am a cheating bag of scrotum hair. Currently, I am trying to hack the server. Have a nice day!\");",0.5);
$HACK[%clientId] = 0;
}
	return;
}
// This is the end of that fix.
// As you can see, it just returns if there is a + after the keyword.
// Susan 27 Aug 05
if(String::findsubstr(%w2, "\@") != -1) 
return False;

if(String::findsubstr(%w2, "$+") != -1) 
return False;

for(%i = 1; $Spell::keyword[%i] != ""; %i++)
{
if(String::ICompare($Spell::keyword[%i], %w1) == 0)
{
if(SkillCanUse(%clientId, $Spell::keyword[%i]))
{
if(fetchData(%clientId, "MANA") >= $Spell::manaCost[%i])
{
Client::sendMessage(%clientId, $MsgBeige, "Casting " @ $Spell::name[%i] @ ".");

%player = Client::getOwnedObject(%clientId);
if(GameBase::getLOSinfo(%player, $Spell::LOSrange[%i]))
{
%lospos = $los::position;
%losobj = $los::object;
}
else
{
%lospos = "";
%losobj = 0;
}
	
storeData(%clientId, "SpellCastStep", 1);
	
%tempManaCost = floor($Spell::manaCost[%i] / 2);
refreshMANA(%clientId, %tempManaCost);
playSound($Spell::startSound[%i], GameBase::getPosition(%clientId));

%skt = $SkillType[$Spell::keyword[%i]];
%sk1 = $PlayerSkill[%clientId, %skt];
%gsa = GetSkillAmount($Spell::keyword[%i], %skt);
%sk2 = %sk1 - %gsa;
%sk = Cap(%sk2, 0, "inf");
%rt = $Spell::recoveryTime[%i];
%a = %rt / 2;
%b = (1000 - %sk) / 1000;
%c = %b * %a;
%recovTime = $Spell::delay[%i] + Cap(%a + %c, %a, %rt);	//recovery time is never smaller than half of the original and never bigger than the original.

schedule("%retval=DoCastSpell(" @ %clientId @ ", " @ %i @ ", \"" @ GameBase::getPosition(%clientId) @ "\", \"" @ %lospos @ "\", \"" @ %losobj @ "\", \"" @ %w2 @ "\"); if(%retval){refreshMANA(" @ %clientId @ ", " @ %tempManaCost @ ");}", $Spell::delay[%i]);
					schedule("storeData(" @ %clientId @ ", \"SpellCastStep\", \"\");sendDoneRecovMsg(" @ %clientId @ ");", %recovTime);
		
					return True;
				}
				else
					Client::sendMessage(%clientId, $MsgWhite, "Insufficient mana to cast this spell.");
			}
			else
				Client::sendMessage(%clientId, $MsgWhite, "You can't cast this spell because you lack the necessary skills.");

			return False;
		}
	}
	Client::sendMessage(%clientId, $MsgWhite, "This spell seems unfamiliar to you.");

	return False;
}

function DoCastSpell(%clientId, %index, %oldpos, %castPos, %castObj, %w2)
{
	dbecho($dbechoMode, "DoCastSpell(" @ %clientId @ ", " @ %index @ ", " @ %oldpos @ ", " @ %castPos @ ", " @ %castObj @ ", " @ %w2 @ ")");

	%player = Client::getOwnedObject(%clientId);

	if(Vector::getDistance(%oldpos, GameBase::getPosition(%clientId)) > $Spell::graceDistance[%index])
	{
		Client::sendMessage(%clientId, $MsgBeige, "Your casting was interrupted.");
		storeData(%clientId, "SpellCastStep", 2);

		return False;
	}

	//group-list check
	if($Spell::groupListCheck[%index])
	{
		%cl = Player::getClient(%castObj);
		if( !(IsInCommaList(fetchData(%clientId, "grouplist"), Client::getName(%cl)) && IsInCommaList(fetchData(%cl, "grouplist"), Client::getName(%clientId))) && %cl != %clientId && %cl != -1)
		{
			Client::sendMessage(%clientId, $MsgBeige, "You are not part of the target's group.");
			storeData(%clientId, "SpellCastStep", 2);

			return False;
		}
	}

	//==================================================================

	//unfortunately hard-coded part -- although that is the original purpose of Tribes scripting
	if(%index == 1)
	{
		//firebomb spell, casts to LOS with radius damage

		if(%castPos != "")
		{
			CreateAndDetBomb(%clientId, "Bomb1", %castPos, True, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}

	if(%index == 2)
	{
		//teleport zone spell

		%zoneId = GetNearestZone(%clientId, %w2, 3);

		if(%zoneId != False)
		{
			Client::sendMessage(%clientId, $MsgBeige, "Teleporting near " @ Zone::getDesc(%zoneId));

			//teleport

			%mpos = Zone::getMarker(%zoneId);
			if(!fetchData(%clientId, "invisible"))
			GameBase::startFadeIn(%clientId);

			GameBase::setPosition(%clientId, %mpos);
			CheckAndBootFromArena(%clientId);
			NullItemList(%clientId, Lore, $MsgRed, "You lost all %1s you were carrying when you teleported.");

			Player::setDamageFlash(%clientId, 0.7);
			%extraDelay = 0.22;	//sometimes the endSound doesn't get played unless there is sufficient delay

			%castPos = SetOnGround(%clientId, 500);
			//%castPos = %newpos;
			CreateAndDetBomb(%clientId, "Bomb1000", %castPos, False, %index);

			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Teleportation failed.");
			%returnFlag = False;
		}
	}

	if(%index == 3)
	{
		//Transport zone spell

		%zoneId = GetZoneByKeywords(%clientId, %w2, 3);

		if(%zoneId != False)
		{
			Client::sendMessage(%clientId, $MsgBeige, "Transporting to " @ Zone::getDesc(%zoneId));

			//teleport

			%system = Object::getName(%zoneId);
			%type = GetWord(%system, 0);
			%desc = String::getSubStr(%system, String::len(%type)+1, 9999);

			%castPos = TeleportToMarker(%clientId, "Zones\\" @ %system @ "\\DropPoints", False, True);
			CreateAndDetBomb(%clientId, "Bomb1000", %castPos, False, %index);
			CheckAndBootFromArena(%clientId);
			NullItemList(%clientId, Lore, $MsgRed, "You lost all %1s you were carrying when you teleported.", belt);

			if(!fetchData(%clientId, "invisible"))
				GameBase::startFadeIn(%clientId);

			Player::setDamageFlash(%clientId, 0.7);
			%extraDelay = 0.22;	//sometimes the endSound doesn't get played unless there is sufficient delay

			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Transportation failed.");
			%returnFlag = False;
		}
	}

	if(%index == 4)
	{
		//Advanced Transport zone spell

		%zoneId = GetZoneByKeywords(%clientId, %w2, 3);

		if(%zoneId != False)
		{
			if(getObjectType(%castObj) == "Player")
				%id = Player::getClient(%castObj);
			else
				%id = %clientId;

			Client::sendMessage(%clientId, $MsgBeige, "Transporting to " @ Zone::getDesc(%zoneId));
			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, "You are being transported to " @ Zone::getDesc(%zoneId));

			//teleport

			%system = Object::getName(%zoneId);
			%type = GetWord(%system, 0);
			%desc = String::getSubStr(%system, String::len(%type)+1, 9999);

			%castPos = TeleportToMarker(%id, "Zones\\" @ %system @ "\\DropPoints", False, True);
			CreateAndDetBomb(%clientId, "Bomb1000", %castPos, False, %index);
			CheckAndBootFromArena(%id);
			NullItemList(%clientId, Lore, $MsgRed, "You lost all %1s you were carrying when you teleported.");

			if(!fetchData(%id, "invisible"))
				GameBase::startFadeIn(%id);

			Player::setDamageFlash(%id, 0.7);
			%extraDelay = 0.22;	//sometimes the endSound doesn't get played unless there is sufficient delay

			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Transportation failed.");
			%returnFlag = False;
		}
	}
	
	if(%index == 5)
	{
		//cloud spell, casts to LOS with radius damage

		if(%castPos != "")
		{
			CreateAndDetBomb(%clientId, "Bomb2", %castPos, True, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}

	if(%index == 6)
	{
		//melt spell, casts to LOS with radius damage

		if(%castPos != "")
		{
			CreateAndDetBomb(%clientId, "Bomb3", %castPos, True, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}

	if(%index == 7)
	{
		//power cloud spell, casts to LOS with radius damage

		if(%castPos != "")
		{
			for(%i = 0; %i <= 2; %i++)
			{
				schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb2\", \"" @ %castPos @ "\", True, " @ %index @ ");", %i / 2, %player);
			}

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}

	if(%index == 8)
	{
		//heal self spell

		Client::sendMessage(%clientId, $MsgBeige, "Healing self");

		%r = $Spell::damageValue[%index] / $TribesDamageToNumericDamage;
		refreshHP(%clientId, %r);

		%castPos = GameBase::getPosition(%clientId);

		%returnFlag = True;
	}


	if(%index == 68)
	{
		//healing of deraj

		Client::sendMessage(%clientId, $MsgBeige, "Healing self with the power of Deraj");

		%r = $Spell::damageValue[%index] / $TribesDamageToNumericDamage;
		refreshHP(%clientId, %r);

		%castPos = GameBase::getPosition(%clientId);

		%returnFlag = True;
	}

	if(%index == 9 || %index == 10 || %index == 11 || %index == 20 || %index == 34 || %index == 35 || %index == 36)
	{
		//heal self or other (LOS) 1st, 2nd, 3rd, 4th, 5th, 6th, godly

		if(getObjectType(%castObj) == "Player" && !Player::isAiControlled(%clientId))
			%id = Player::getClient(%castObj);
		else
			%id = %clientId;

		Client::sendMessage(%clientId, $MsgBeige, "Healing " @ Client::getName(%id));
		if(%clientId != %id)
			Client::sendMessage(%id, $MsgBeige, Client::getName(%clientId) @ " is casting " @ $Spell::name[%index] @ " on you.");

		%r = $Spell::damageValue[%index] / $TribesDamageToNumericDamage;

		refreshHP(%id, %r);

		%castPos = GameBase::getPosition(%id);

		%returnFlag = True;
	}

	if(%index == 12)
	{
		//laser beam

		if(getObjectType(%castObj) == "Player")
			%id = Player::getClient(%castObj);

		%trans = GameBase::getMuzzleTransform(%clientId);
		%p = Projectile::spawnProjectile("sniperLaser", %trans, %player, "0 0 0", 1.0);

		%mom1 = Vector::getFromRot( GameBase::getRotation(%clientId), -60, 1 );
		Player::applyImpulse(%clientId, %mom1);

		%r = $Spell::damageValue[%index];
	
		if(%id != "")
		{
			//%miss = CalcSpellMiss(%clientId, %id, %index);

			SpellDamage(%clientId, %id, %r, %index);
			%mom2 = Vector::getFromRot( GameBase::getRotation(%clientId), 50, 1 );
			Player::applyImpulse(%id, %mom2);
		}

		%castPos = GameBase::getPosition(%clientId);

		%returnFlag = True;
	}

	if(%index == 13)
	{
		if(%castPos != "")
		{
			CreateAndDetBomb(%clientId, "Bomb11", %castPos, True, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
			%returnFlag = False;
		}
	}

	if(%index == 14)
	{
		if(%castPos != "")
		{
			CreateAndDetBomb(%clientId, "Bomb9", %castPos, True, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
			%returnFlag = False;
		}
	}

	if(%index == 15)
	{
		if(%castPos != "")
		{
			CreateAndDetBomb(%clientId, "Bomb7", %castPos, True, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
			%returnFlag = False;
		}
	}

	if(%index == 16)
	{
		if(%castPos != "")
		{
			%minrad = 0;
			%maxrad = $Spell::radius[%index] / 2;
			for(%i = 0; %i <= 8; %i++)
			{
				%tempPos = RandomPositionXY(%minrad, %maxrad);

				%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
				%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
				%zPos = GetWord(%castPos, 2);
		
				%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;

				schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 7, %player);
			}
			CreateAndDetBomb(%clientId, "Bomb10", %castPos, True, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
			%returnFlag = False;
		}
	}

	if(%index == 17)
	{
		if(%castPos != "")
		{
			%minrad = 0;
			%maxrad = $Spell::radius[%index];
			for(%i = 0; %i <= 8; %i++)
			{
				%tempPos = RandomPositionXY(%minrad, %maxrad);

				%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
				%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
				%zPos = GetWord(%castPos, 2) + (%i / 3);
		
				%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;

				schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb12\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 24, %player);
			}
			CreateAndDetBomb(%clientId, "Bomb12", %castPos, True, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
			%returnFlag = False;
		}
	}

	if(%index == 18)
	{
		if(%castPos != "")
		{
			%minrad = 0;
			%maxrad = 5;
			for(%i = 0; %i <= 24; %i++)
			{
				%tempPos = RandomPositionXY(%minrad, %maxrad);

				%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
				%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
				%zPos = GetWord(%castPos, 2) + 72 - (%i * 3);
		
				%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;

				schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb9\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 16, %player);
			}
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb1\", \"" @ %castPos @ "\", True, " @ %index @ ");", %i / 16, %player);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
			%returnFlag = False;
		}
	}

	if(%index == 19)
	{
				if(%castPos != "")
		{
			Dopart1(%castpos, %clientid, %player, %index);

			%overrideEndSound = False;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}
	if(%index == 21)
	{
		if(!fetchData(%clientId, "currentlyRemorting"))
		{
			%castPos = DoRemort(%clientId);		

			%extraDelay = 0.22;
			%returnFlag = True;
		}
		else
			%returnFlag = False;
	}
	if(%index == 22)
	{
		//full heal self spell

		Client::sendMessage(%clientId, $MsgBeige, "Fully healing self");

		setHP(%clientId, fetchData(%clientId, "MaxHP"));

		%castPos = GameBase::getPosition(%clientId);

		%returnFlag = True;
	}
	if(%index == 23 || %index == 24 || %index == 31 || %index == 37 || %index == 66 || %index == 69)
	{
		//23 = mass heal spell
		//24 = mass full heal spell
		//31 = mass shield spell
		//37 = heavens heal
		//66 = GODS HEAL
		//69 = Gods Shield

		%b = $Spell::radius[%index] * 2;
		%set = newObject("set", SimSet);
		%n = containerBoxFillSet(%set, $SimPlayerObjectType, GameBase::getPosition(%clientId), %b, %b, %b, 0);

		Group::iterateRecursive(%set, DoBoxFunction, %clientId, %index, %w2);
		deleteObject(%set);

		%overrideEndSound = True;

		%returnFlag = True;
	}
	if(%index == 25)
	{
		//shield self spell

		Client::sendMessage(%clientId, $MsgBeige, "Shielding self");

		UpdateBonusState(%clientId, $Spell::damageValue[%index], $Spell::ticks[%index]);

		%castPos = GameBase::getPosition(%clientId);
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			%counter = 0.3;
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb1004\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+0.5);

		%returnFlag = True;
	}
	if(%index == 26 || %index == 27 || %index == 28 || %index == 29 || %index == 30)
	{
		//shield self or other (LOS) 1st, 2nd, 3rd, 4th, 5th

		if(getObjectType(%castObj) == "Player" && !Player::isAiControlled(%clientId))
			%id = Player::getClient(%castObj);
		else
			%id = %clientId;

		Client::sendMessage(%clientId, $MsgBeige, "Shielding " @ Client::getName(%id));
		if(%clientId != %id)
			Client::sendMessage(%id, $MsgBeige, Client::getName(%clientId) @ " is casting " @ $Spell::name[%index] @ " on you.");

		UpdateBonusState(%id, $Spell::damageValue[%index], $Spell::ticks[%index]);

		%castPos = GameBase::getPosition(%id);

		%returnFlag = True;
	}
	if(%index == 32)
	{
		//mimic spell
		if(Zone::getType(fetchData(%clientId, "zone")) == "PROTECTED")
		{
			Client::sendMessage(%clientId, $MsgRed, "You can't cast mimic in protected territory.");
			%overrideEndsound = True;
			%returnFlag = False;

		%id = NEWgetClientByName(%cropped);		
		if(floor(%id.adminLevel) >= floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
		Client::sendMessage(%TrueClientId, 0, "WTF? Trying to mimic an admin....");
		}
		else
		{
			%id = Player::getClient(%castObj);
			if(getObjectType(%castObj) == "Player")
			{
				%skilltype = $SkillType[$Spell::keyword[%index]];
				%troll = fetchData(%id, "LVL") + floor(getRandom() * ($PlayerSkill[%id, %skilltype] + ($PlayerSkill[%id, $SkillSpellResistance] * (1/2)) ));
				%yroll = fetchData(%clientId, "LVL") + floor(getRandom() * $PlayerSkill[%clientId, %skilltype]);

				if(%yroll > %troll)
				{
					storeData(%clientId, "RACE", fetchData(%id, "RACE"));
					storeData(%clientId, "isMimic", True);
				
					UpdateTeam(%clientId);
					RefreshAll(%clientId);
				
					%castPos = GameBase::getPosition(%clientId);
					%returnFlag = True;
				}
				else
				{
					Client::sendMessage(%clientId, $MsgBeige, "Mimic failed.");
					%overrideEndsound = True;
					%returnFlag = False;
				}
			}
			else
			{
				Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
				%overrideEndsound = True;
				%returnFlag = False;
			}
		}
	}
	if(%index == 33)
	{
		//mass transport spell

		%zoneId = GetZoneByKeywords(%clientId, %w2, 3);

		if(%zoneId != False)
		{
			%b = $Spell::radius[%index] * 2;
			%set = newObject("set", SimSet);
			%n = containerBoxFillSet(%set, $SimPlayerObjectType, GameBase::getPosition(%clientId), %b, %b, %b, 0);

			Group::iterateRecursive(%set, DoBoxFunction, %clientId, %index, %zoneId);
			deleteObject(%set);

			%overrideEndSound = True;

			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Mass Transportation failed.");
			%returnFlag = False;
		}
	}
	if(%index == 38)
	{
		if(getObjectType(%castObj) == "Player" && !Player::isAiControlled(%clientId))
			%id = Player::getClient(%castObj);
		else
			%id = %clientId;
		
		Client::sendMessage(%clientId, $MsgBeige, "Weakening " @ Client::getName(%id));

		if(%clientId != %id)
			Client::sendMessage(%id, $MsgBeige, Client::getName(%clientId) @ " is singing " @ $Spell::name[%index] @ " for you.");

		UpdateBonusState(%id, $Spell::damageValue[%index], $Spell::ticks[%index]);

		%castPos = GameBase::getPosition(%id);
		%returnFlag = True;
	}
	if(%index == 39)
	{
		Client::sendMessage(%clientId, $MsgBeige, "Singing a song");

		%r = $Spell::damageValue[%index] / $TribesDamageToNumericDamage;
		refreshHP(%clientId, %r);
	
		%castPos = GameBase::getPosition(%clientId);
		%returnFlag = True;
	}
	if(%index == 40)
	{
		if(Player::isAiControlled(%id))
		{
			if(!%echoOff) 
				Client::sendMessage(%TrueClientId, 0, "Petrifying " @ %cropped @ " (" @ %id @ ").");

			storeData(%id, "frozen", True);
			AI::setVar(fetchData(%id, "BotInfoAiName"), SpotDist, 0);
			AI::newDirectiveRemove(fetchData(%id, "BotInfoAiName"), 99);
			Schedule("CancelSPFreeze(%id, %TrueClientId);", 10, %player);
		}
		else
		{
			Client::sendMessage(%TrueClientId, 0, "Name must be a bot.");
			%returnFlag = False;
		}
	}
	if(%index == 41)
	{
		//Hurricane
		if(%castPos != "")
		{
			Dopart1(%castpos, %clientid, %player, %index);

			%overrideEndSound = False;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}

	Player::setAnimation(%clientId, 39);

	if(!%overrideEndSound)
	{
		if(%extraDelay == "")
			playSound($Spell::endSound[%index], %castPos);
		else
			schedule("playSound(" @ $Spell::endSound[%index] @ ", \"" @ %castPos @ "\");", %extraDelay);
	}
	if(%index == 47)
	{//Meteor
		if(%castPos != "")
		{
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			
			%counter = 0.3;
			 schedule("playSound(LaunchET, \"" @ %castPos @ "\");",%counter);

                        schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb9\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+35 @ "\", False, " @ %index @ ");",%counter+3.2);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb9\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+30 @ "\", False, " @ %index @ ");",%counter+3.5);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb9\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+25 @ "\", False, " @ %index @ ");",%counter+3.8);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb9\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+20 @ "\", False, " @ %index @ ");",%counter+4.1);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb9\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+15 @ "\", False, " @ %index @ ");",%counter+4.4);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb9\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+10 @ "\", False, " @ %index @ ");",%counter+4.7);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.0);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.0);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.0);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.0);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.0);
			schedule("playSound(PlaceSeal, \"" @ %castPos @ "\");",%counter+2.0);
	
			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
			%returnFlag = False;
		}
	}
	if(%index == 43)
	{//divineray
		if(%castPos != "")
		{
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			
			%counter = 0.3;
			 schedule("playSound(LaunchET, \"" @ %castPos @ "\");",%counter);

			//schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+80 @ "\", False, " @ %index @ ");",%counter+0.5);
			//schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+75 @ "\", False, " @ %index @ ");",%counter+0.8);
			//schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+70 @ "\", False, " @ %index @ ");",%counter+1.1);
			//schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+65 @ "\", False, " @ %index @ ");",%counter+1.4);
			//schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+60 @ "\", False, " @ %index @ ");",%counter+1.7);
			//schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+55 @ "\", False, " @ %index @ ");",%counter+2.0);
			//schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+50 @ "\", False, " @ %index @ ");",%counter+2.3);
			//schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+45 @ "\", False, " @ %index @ ");",%counter+2.6);
			//schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+40 @ "\", False, " @ %index @ ");",%counter+2.9);
                        schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+35 @ "\", False, " @ %index @ ");",%counter+3.2);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+30 @ "\", False, " @ %index @ ");",%counter+3.5);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+25 @ "\", False, " @ %index @ ");",%counter+3.8);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+20 @ "\", False, " @ %index @ ");",%counter+4.1);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+15 @ "\", False, " @ %index @ ");",%counter+4.4);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+10 @ "\", False, " @ %index @ ");",%counter+4.7);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.0);
			schedule("playSound(PlaceSeal, \"" @ %castPos @ "\");",%counter+2.0);
	
			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
			%returnFlag = False;
		}
	}
	if(%index == 44)
	{//rumble
		if(%castPos != "")
		{
			CreateAndDetBomb(%clientId, "Bomb2", %castPos, True, %index);
			CreateAndDetBomb(%clientId, "Bomb17", %castPos, False, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}
	if(%index == 45)
	{//quake
		if(%castPos != "")
		{
		%minrad = 0;
		%maxrad = 45;
		for(%i = 0; %i <= 6; %i++)
		{
		%tempPos = RandomPositionXY(%minrad, %maxrad);
		%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
		%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
		%zPos = GetWord(%castPos, 2) - 1.0;
		%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;
		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 3, %player);
		}
		%overrideEndSound = True;
		%returnFlag = True;

		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %newPos @ "\", True, " @ %index @ ");", 1, %player);
		
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 46)
	{//avalanche
		if(%castPos != "")
		{
		%minrad = 0;
		%maxrad = 4;
		for(%i = 0; %i <= 20; %i++)
		{
			%tempPos = RandomPositionXY(%minrad, %maxrad);
			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 40 - (%i * 2);
			%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb12\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 16, %player);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb1005\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 16, %player);
		}
		for(%i = 0; %i <= 20; %i++)
		{
			%tempPos = RandomPositionXY(%minrad, %maxrad);
			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 40 - (%i * 2);
			%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb12\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 16 + 1.1, %player);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb1005\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 6 + 1.1, %player);
		}
		schedule("playSound(ExplodeLM, \"" @ %castPos @ "\");",20/16);
		schedule("playSound(ExplodeLM, \"" @ %castPos @ "\");",40/16);
		schedule("SpellRadiusDamage(" @ %clientId @ ", \"" @ %castPos @ "\", " @ %index @ ");",20/16);
		schedule("SpellRadiusDamage(" @ %clientId @ ", \"" @ %castPos @ "\", " @ %index @ ");",40/16);
		%overrideEndSound = True;
		%returnFlag = True;
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 42)
	{//ultima
		if(%castPos != "")
		{
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			
			%counter = 2;
			schedule("playSound(LaunchET, \"" @ %castPos @ "\");",%counter);

			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+3.7);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+1 @ "\", True, " @ %index @ ");",%counter+4.0);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+1 @ "\", True, " @ %index @ ");",%counter+5.0);
			schedule("playSound(ExplodeLM, \"" @ %castPos @ "\");",%counter+3.7);
       	      		schedule("playSound(ExplodeLM, \"" @ %castPos @ "\");",%counter+4.0);
			schedule("playSound(ExplodeLM, \"" @ %castPos @ "\");",%counter+5.0);
			Client::sendMessage(%clientId, $MsgBeige, "Run for Cover.");
				
			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}


	if(%index == 70)
	{//nuke
		if(%castPos != "")
		{
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			
			%counter = 2;
			schedule("playSound(LaunchET, \"" @ %castPos @ "\");",%counter);

			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+3.7);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+1 @ "\", True, " @ %index @ ");",%counter+4.0);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+1 @ "\", True, " @ %index @ ");",%counter+5.0);
			schedule("playSound(ExplodeLM, \"" @ %castPos @ "\");",%counter+3.7);
       	      		schedule("playSound(ExplodeLM, \"" @ %castPos @ "\");",%counter+4.0);
			schedule("playSound(ExplodeLM, \"" @ %castPos @ "\");",%counter+5.0);
			Client::sendMessage(%clientId, $MsgBeige, "You Can't Run.");
				
			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}

	if(%index == 50)
	{//firerain
		if(%castPos != "")
		{
		%minrad = 0;
		%maxrad = 7;
		for(%i = 0; %i <= 20; %i++)
		{
			%tempPos = RandomPositionXY(%minrad, %maxrad);
			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 30 - (%i * 1.5);
			%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb8\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 16, %player);
		}
		for(%i = 0; %i <= 20; %i++)
		{
			%tempPos = RandomPositionXY(%minrad, %maxrad);
			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 30 - (%i*1.5);
			%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb8\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 16 + 1.1, %player);
		}
		schedule("playSound(LaunchET, \"" @ %castPos @ "\");",20/16);
		schedule("playSound(LaunchET, \"" @ %castPos @ "\");",40/16);
		schedule("SpellRadiusDamage(" @ %clientId @ ", \"" @ %castPos @ "\", " @ %index @ ");",20/16);
		schedule("SpellRadiusDamage(" @ %clientId @ ", \"" @ %castPos @ "\", " @ %index @ ");",40/16);
		%overrideEndSound = True;
		%returnFlag = True;
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 48)
	{//smoke
		if(%castPos != "")
		{
		CreateAndDetBomb(%clientId, "Bomb3", %castPos, True, %index);
		%overrideEndSound = True;
		%returnFlag = True;
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 49)
	{//firespike
		if(%castPos != "")
		{
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb8\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos @ "\", True, " @ %index @ ");",0.3);
			
		%overrideEndSound = True;
		%returnFlag = True;
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 51)
	{//lavaburst
		if(%castPos != "")
		{
		%minrad = 0;
		%maxrad = 9;
		for(%i = 0; %i <= 14; %i++)
		{
		%tempPos = RandomPositionXY(%minrad, %maxrad);
		%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
		%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
		%zPos = GetWord(%castPos, 2) - 1.5;
		%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;
		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb9\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 16, %player);
		}
		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb3\", \"" @ %castPos @ "\", True, " @ %index @ ");", %i / 16, %player);
		%overrideEndSound = True;
		%returnFlag = True;
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 52)
	{//blizzard
		if(%castPos != "")
		{
		%minrad = 0;
		%maxrad = $Spell::radius[%index] / 2;
		for(%i = 0; %i <= 10; %i++)
		{
		%tempPos = RandomPositionXY(%minrad, %maxrad);
		%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
		%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
		%zPos = GetWord(%castPos, 2) + 30 - (%i * 3);
		%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;
		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 7, %player);
		}
		CreateAndDetBomb(%clientId, "Bomb10", %castPos, True, %index);
		%overrideEndSound = True;
		%returnFlag = True;
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 53)
	{//comet
		if(%castPos != "")
		{
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			
			%counter = 1;
			 schedule("playSound(LaunchET, \"" @ %castPos @ "\");",%counter);

			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-10.5 @ " " @ %zpos+80 @ "\", False, " @ %index @ ");",%counter+0.8);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-10 @ " " @ %zpos+75 @ "\", False, " @ %index @ ");",%counter+1.1);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-9.5 @ " " @ %zpos+70 @ "\", False, " @ %index @ ");",%counter+1.4);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-9.1 @ " " @ %zpos+65 @ "\", False, " @ %index @ ");",%counter+1.7);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-7.8 @ " " @ %zpos+60 @ "\", False, " @ %index @ ");",%counter+2.0);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-6.6 @ " " @ %zpos+55 @ "\", False, " @ %index @ ");",%counter+2.3);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-5.5 @ " " @ %zpos+50 @ "\", False, " @ %index @ ");",%counter+2.6);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-4.5 @ " " @ %zpos+45 @ "\", False, " @ %index @ ");",%counter+2.9);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-3.6 @ " " @ %zpos+40 @ "\", False, " @ %index @ ");",%counter+3.2);
                        schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-2.8 @ " " @ %zpos+35 @ "\", False, " @ %index @ ");",%counter+3.5);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-2.1 @ " " @ %zpos+30 @ "\", False, " @ %index @ ");",%counter+3.8);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-1.5 @ " " @ %zpos+25 @ "\", False, " @ %index @ ");",%counter+4.1);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-1 @ " " @ %zpos+20 @ "\", False, " @ %index @ ");",%counter+4.4);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-0.6 @ " " @ %zpos+15 @ "\", False, " @ %index @ ");",%counter+4.7);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos-0.3 @ " " @ %zpos+10 @ "\", False, " @ %index @ ");",%counter+5.0);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb2\", \"" @ %xpos @ " " @ %ypos-0.1 @ " " @ %zpos @ "\", True, " @ %index @ ");",%counter+5.3);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.6);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.6);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.6);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+5.6);
			schedule("playSound(ExplodeLM, \"" @ %castPos @ "\");",%counter+3.7);
	
			Client::sendMessage(%clientId, $MsgBeige, "Run for Cover.");
				
			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}
	if(%index == 54)
	{//SHOCK
		if(%castPos != "")
		{
			CreateAndDetBomb(%clientId, "Bomb10", %castPos, True, %index);

			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
			%returnFlag = False;
		}
	}
	if(%index == 55)
	{//lit
		if(%castPos != "")
		{	
		%xpos=getword(%castpos,0);
		%ypos=getword(%castpos,1);
		%zpos=getword(%castpos,2);
		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb10\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos @ "\", True, " @ %index @ ");",0.8);
		%overrideEndSound = True;
		%returnFlag = True;
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 56)
	{//zap
		if(%castPos != "")
		{	
		%xpos=getword(%castpos,0);
		%ypos=getword(%castpos,1);
		%zpos=getword(%castpos,2);
		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb7\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos @ "\", True, " @ %index @ ");",0.8);
		%overrideEndSound = True;
		%returnFlag = True;
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 57)
	{//BOLT
		if(%castPos != "")
		{
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			
			%counter = 1;
		
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos+1 @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+1.5);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos+1 @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+1.7);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+1.5);
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+1.7);
			schedule("playSound(HitBF, \"" @ %castPos @ "\");",%counter+1.5);
	
			%overrideEndSound = True;
			%returnFlag = True;
		}
		else
		{
			Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");

			%returnFlag = False;
		}
	}
	if(%index == 58)
	{//electrocute
		if(%castPos != "")
		{	
		%xpos=getword(%castpos,0);
		%ypos=getword(%castpos,1);
		%zpos=getword(%castpos,2);
		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb7\", \"" @ %xpos @ " " @ %ypos @ " " @ %zpos @ "\", True, " @ %index @ ");",1.8);
		
		%overrideEndSound = True;
		%returnFlag = True;
		}
		else
		{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
		}
	}
	if(%index == 59)
	{//windbooster
		%b = GameBase::getRotation(%clientId);
		%c1 = Cap($PlayerSkill[%clientId, $SkillType[boost]] * 1.8 + 20,75,1000);
		%c2 = %c1/3;
		%mom = Vector::getFromRot( %b, %c1, %c2 );
		Player::applyImpulse(%clientId, %mom);
		%returnFlag = True;
	}
	if(%index == 60)
	{//stop
		Item::setVelocity(%clientId, "0 0 10");
		%returnFlag = True;		
	}
	if(%index == 62)
	{ //Sword Storm
		if(getObjectType(%castObj) == "Player")
			%id = Player::getClient(%castObj);

		%trans = GameBase::getMuzzleTransform(%clientId);
		%p = Projectile::spawnProjectile("swordshot", %trans, %player, "0 1 0", 1);
		%p = Projectile::spawnProjectile("swordshot", %trans, %player, "0 0 0", 1);
		%p = Projectile::spawnProjectile("swordshot", %trans, %player, "0 -1 0", 1);
		%p = Projectile::spawnProjectile("swordshot", %trans, %player, "0 0 1", 1);
		%p = Projectile::spawnProjectile("swordshot", %trans, %player, "0 0 -1", 1);

		%mom1 = Vector::getFromRot( GameBase::getRotation(%clientId), 0, 1 );
		Player::applyImpulse(%clientId, %mom1);

		%r = $Spell::damageValue[%index];
	
		if(%id != "")
		{
			//%miss = CalcSpellMiss(%clientId, %id, %index);

			SpellDamage(%clientId, %id, %r, %index);
			%mom2 = Vector::getFromRot( GameBase::getRotation(%clientId), 0, 1 );
			Player::applyImpulse(%id, %mom2);
		}

		%castPos = GameBase::getPosition(%clientId);

		%returnFlag = True;
	}
	if(%index == 63)
	{ // Dirty Bomb
		if(getObjectType(%castObj) == "Player")
			%id = Player::getClient(%castObj);

		%trans = GameBase::getMuzzleTransform(%clientId);
		%p = Projectile::spawnProjectile("orbthrow", %trans, %player, "0 0 0", 1.0);

		%mom1 = Vector::getFromRot( GameBase::getRotation(%clientId), 0, 1 );
		Player::applyImpulse(%clientId, %mom1);

		%r = $Spell::damageValue[%index];
	
		if(%id != "")
		{
			//%miss = CalcSpellMiss(%clientId, %id, %index);

			SpellDamage(%clientId, %id, %r, %index);
			%mom2 = Vector::getFromRot( GameBase::getRotation(%clientId), 0, 1 );
			Player::applyImpulse(%id, %mom2);
		}

		%castPos = GameBase::getPosition(%clientId);

		%returnFlag = True;
	}
	if(%index == 64)
	{//Arrow Storm
		if(getObjectType(%castObj) == "Player")
			%id = Player::getClient(%castObj);

		%trans = GameBase::getMuzzleTransform(%clientId);
		%p = Projectile::spawnProjectile("arrowshot", %trans, %player, "0 1 0", 1);
		%p = Projectile::spawnProjectile("arrowshot", %trans, %player, "0 0 0", 1);
		%p = Projectile::spawnProjectile("arrowshot", %trans, %player, "0 -1 0", 1);
		%p = Projectile::spawnProjectile("arrowshot", %trans, %player, "0 0 1", 1);
		%p = Projectile::spawnProjectile("arrowshot", %trans, %player, "0 0 -1", 1);

		%mom1 = Vector::getFromRot( GameBase::getRotation(%clientId), 0, 1 );
		Player::applyImpulse(%clientId, %mom1);

		%r = $Spell::damageValue[%index];
	
		if(%id != "")
		{
			//%miss = CalcSpellMiss(%clientId, %id, %index);

			SpellDamage(%clientId, %id, %r, %index);
			%mom2 = Vector::getFromRot( GameBase::getRotation(%clientId), 0, 1 );
			Player::applyImpulse(%id, %mom2);
		}

		%castPos = GameBase::getPosition(%clientId);

		%returnFlag = True;
	}
	if(%index == 65)
	{//death?
		if(%castPos != "")
		{
		%index = 65;
		%minrad = 0;
		%maxrad = 30;
		for(%i = 0; %i <= 150; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0) + 450 -(%i * 3);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1) + 450 -(%i * 3);
			%zPos = GetWord(%castPos, 2) + 450 - (%i * 3);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb611\", \""@%newPos@"\", False, \""@%index@"\");", %i / 50, %player);
		}
		%minrad = 0;
		%maxrad = 50;
		for(%i = 0; %i <= 100; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb612\", \""@%newPos@"\", true, \""@%index@"\");", %i  / 20 + 4, %player);
		}
		%minrad = 50;
		%maxrad = 70;
		for(%i = 0; %i <= 60; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 0.5;

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb612\", \""@%newPos@"\", true, \""@%index@"\");", %i  / 15 + 5, %player);
		}
		%minrad = 70;
		%maxrad = 90;
		for(%i = 0; %i <= 60; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 1;

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb611\", \""@%newPos@"\", true, \""@%index@"\");", %i  / 15 + 6, %player);
		}
		%minrad = 90;
		%maxrad = 100;
		for(%i = 0; %i <= 30; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 1.5;

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb611\", \""@%newPos@"\", true, \""@%index@"\");", %i  / 7 + 7, %player);
		}

		return "returnFlag 1 overrideEndSound 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Could not find a target.");
		return "returnFlag 0";
	     }
	}
	//==================================================================

	%skilltype = $SkillType[$Spell::keyword[%index]];

	if(%returnFlag == True)
	{
		storeData(%clientId, "SpellCastStep", 2);

		if(%skilltype == $SkillNeutralCasting || %skilltype == $SkillDefensiveCasting)
			UseSkill(%clientId, %skilltype, True, True);
		UseSkill(%clientId, $SkillEnergy, True, True);

		return True;
	}
	else if(%returnFlag == False)
	{
		storeData(%clientId, "SpellCastStep", 2);

		UseSkill(%clientId, %skilltype, False, True);
		UseSkill(%clientId, $SkillEnergy, False, True);

		return False;
	}
}

function dopart2(%castpos, %clientid, %player, %index)
{
	if(oddsAre(5))
		$LessThan = 30;
	else
		$LessThan = 40;


}

function Dopart1(%castpos, %clientid, %player, %index)
{
	if(oddsAre(5))
		$LessThan = 20;
	else
		$LessThan = 30;

	for(%i = 1; %i <= $LessThan; %i++)
	{
		%minrad = 0;
		%maxrad = 20;
		%tempPos = RandomPositionXY(%minrad, %maxrad);

		%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
		%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
		%zPos = GetWord(%castPos, 2) + (%i / 4);

		%newPos = %xPos@" "@%yPos@" "@%zPos + ($LessThan/0.5) - (%i/0.5);

		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb7\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 7, %player);
	}
	
	for (%i = 1; %i <= $LessThan; %i++)
	{
		%xpos = GetWord(%CastPos, 0);
		%ypos = GetWord(%CastPos, 1);
		%zpos = GetWord(%CastPos, 2);
		%newPos = %xPos@" "@%yPos@" "@%zPos + ($LessThan/0.5) - (%i/0.5);

		schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %newPos @ "\", True, " @ %index @ ");", %i / 7, %player);
	}
}

function CreateAndDetBomb(%clientId, %b, %castPos, %doDamage, %index)
{
	dbecho($dbechoMode, "CreateAndDetBomb(" @ %clientId @ ", " @ %b @ ", " @ %castPos @ ", " @ %index @ ")");

	%player = Client::getOwnedObject(%clientId);

	%bomb = newObject("", "Mine", %b);

	addToSet("MissionCleanup", %bomb);

	GameBase::Throw(%bomb, %player, 0, false);
	GameBase::setPosition(%bomb, %castPos);
	
	if(%doDamage)
		SpellRadiusDamage(%clientId, %castPos, %index);

	playSound($Spell::endSound[%index], %castPos);
}

function SpellDamage(%clientId, %targetId, %damageValue, %index)
{
	dbecho($dbechoMode, "SpellDamage(" @ %clientId @ ", " @ %targetId @ ", " @ %damageValue @ ", " @ %index @ ")");

	GameBase::virtual(%targetId, "onDamage", $SpellDamageType, %damageValue, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %clientId, $Spell::keyword[%index]);
}

function SpellRadiusDamage(%clientId, %pos, %index)
{
	dbecho($dbechoMode, "SpellRadiusDamage(" @ %clientId @ ", " @ %pos @ ", " @ %index @ ")");

	%b = $Spell::radius[%index] * 2;
	%set = newObject("set", SimSet);
	%n = containerBoxFillSet(%set, $SimPlayerObjectType, %pos, %b, %b, %b, 0);

	Group::iterateRecursive(%set, DoSpellDamage, %clientId, %pos, %index);
	deleteObject(%set);
}
function DoSpellDamage(%object, %clientId, %pos, %index)
{
	dbecho($dbechoMode, "DoSpellDamage(" @ %object @ ", " @ %clientId @ ", " @ %pos @ ", " @ %index @ ")");

	%id = Player::getClient(%object);

	%percMin = 5;
	%percMax = 100;

	%dist = Vector::getDistance(%pos, GameBase::getPosition(%id));

	if(%dist <= $Spell::radius[%index])
	{
		%newDamage = SpellCalcRadiusDamage(%dist, $Spell::radius[%index], $Spell::damageValue[%index], %percMin, %percMax);
		SpellDamage(%clientId, %id, %newDamage, %index);
	}
}

function SpellCalcRadiusDamage(%dist, %radius, %dmg, %percMin, %percMax)
{
	dbecho($dbechoMode, "SpellCalcRadiusDamage(" @ %dist @ ", " @ %radius @ ", " @ %dmg @ ", " @ %percMin @ ", " @ %percMax @ ")");

	%newdmg = %dmg - (%dist * (%dmg / %radius));

	%p = (%newdmg * 100) / %dmg;

	if(%p < %percMin)
		%p = %percMin;
	else if(%p > %percMax)
		%p = %percMax;

	%newdmg = (%p * %dmg) / 100;

	return %newdmg;
}

function GetBestSpell(%clientId, %type, %semiRandomSpell)
{
	dbecho($dbechoMode, "GetBestSpell(" @ %clientId @ ", " @ %type @ ", " @ %semiRandomSpell @ ")");

	%wdelay = 10;	//weights
	%wrecov = 0.5;

	%bestSpell = -1;
	%backupSpell = "";
	%highest = 0.1;

	for(%i = 1; $Spell::keyword[%i] != ""; %i++)
	{
		if(SkillCanUse(%clientId, $Spell::keyword[%i]))
		{
			if(fetchData(%clientId, "MANA") >= $Spell::manaCost[%i])
			{
				%d = ( ($Spell::delay[%i] / %wdelay) + ($Spell::recoveryTime[%i] / %wrecov) );
				%x = (100 / %d) * $Spell::refVal[%i];
				%v =  %x * %type;

				if(%semiRandomSpell)
				{
					%r = getRandom() * 100;
					%rr = getRandom() * 100;
				}
				else
				{
					%r = 1;
					%rr = 0;
				}

				if(%v > %highest)
				{
					if(%r > %rr)
					{
						%bestSpell = %i;
						%highest = %v;
					}
					else
						%backupSpell = %i;
				}
			}
		}
	}
	if(%bestSpell == -1 && %backupSpell != "")
		%bestSpell = %backupSpell;

	return %bestSpell;
}

function CalcSpellMiss(%clientId, %targetId, %index)
{
	dbecho($dbechoMode, "CalcSpellMiss(" @ %clientId @ ", " @ %targetId @ ", " @ %index @ ")");

	%range = $Spell::LOSrange[%index];
	%dist = Vector::getDistance(GameBase::getPosition(%clientId), GameBase::getPosition(%targetId));

	%m = floor((getRandom() * %range)) + (%range / 6);

	//echo(%dist @ " / " @ %range @ " : --> " @ %m);
	if(%m > %dist)
		return False;
	else
		return True;
}

function sendDoneRecovMsg(%clientId)
{
	//this function is here just to make the schedule command where this is called easier to read
	Client::sendMessage(%clientId, $MsgBeige, "You are ready to cast.");
}

function DoBoxFunction(%object, %clientId, %index, %extra)
{
	dbecho($dbechoMode, "DoBoxFunction(" @ %object @ ", " @ %clientId @ ", " @ %index @ ", " @ %extra @ ")");

	%id = Player::getClient(%object);

	if(%index == 23)
	{
		if(GameBase::getTeam(%clientId) == GameBase::getTeam(%id))
		{
			Client::sendMessage(%clientId, $MsgBeige, "Mass Healing " @ Client::getName(%id));
			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, "You are being Mass Healed by " @ Client::getName(%clientId));

			%r = $Spell::damageValue[%index] / $TribesDamageToNumericDamage;
			refreshHP(%id, %r);

			%castPos = GameBase::getPosition(%id);

			CreateAndDetBomb(%clientId, "Bomb10", %castPos, False, %index);
			playSound($Spell::endSound[%index], %castPos);
		}
	}
	if(%index == 24)
	{
		if(GameBase::getTeam(%clientId) == GameBase::getTeam(%id))
		{
			Client::sendMessage(%clientId, $MsgBeige, "Mass Fully Healing " @ Client::getName(%id));
			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, "You are being Mass Fully Healed by " @ Client::getName(%clientId));

			setHP(%id, fetchData(%id, "MaxHP"));

			%castPos = GameBase::getPosition(%id);

			CreateAndDetBomb(%clientId, "Bomb10", %castPos, False, %index);
			playSound($Spell::endSound[%index], %castPos);
		}
	}
	if(%index == 37)
	{
		if(GameBase::getTeam(%clientId) == GameBase::getTeam(%id))
		{
			Client::sendMessage(%clientId, $MsgBeige, "Casting Heavens Heal " @ Client::getName(%id));
			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, "You are being Heavens Healed by " @ Client::getName(%clientId));

			setHP(%id, fetchData(%id, "MaxHP"));

			%castPos = GameBase::getPosition(%id);

			CreateAndDetBomb(%clientId, "Bomb10", %castPos, False, %index);
			playSound($Spell::endSound[%index], %castPos);
		}
	}
	if(%index == 31)
	{
		if(GameBase::getTeam(%clientId) == GameBase::getTeam(%id))
		{
			Client::sendMessage(%clientId, $MsgBeige, "Shielding " @ Client::getName(%id));
			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, Client::getName(%clientId) @ " is casting " @ $Spell::name[%index] @ " on you.");

			UpdateBonusState(%id, $Spell::damageValue[%index], $Spell::ticks[%index]);

			%castPos = GameBase::getPosition(%id);
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			%counter = 0.1;
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb1004\", \"" @ %xpos @ " " @ %ypos-1 @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+0.5);
			playSound($Spell::endSound[%index], %castPos);
		}
	}
	if(%index == 33)
	{
		if(IsInCommaList(fetchData(%clientId, "grouplist"), Client::getName(%id)) && IsInCommaList(fetchData(%id, "grouplist"), Client::getName(%clientId)) || %clientId == %id)
		{
			Client::sendMessage(%clientId, $MsgBeige, "Transporting " @ Client::getName(%id) @ " to " @ Zone::getDesc(%extra));
			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, Client::getName(%clientId) @ " is transporting you to " @ Zone::getDesc(%extra));

			//teleport

			%system = Object::getName(%extra);
			%type = GetWord(%system, 0);
			%desc = String::getSubStr(%system, String::len(%type)+1, 9999);

			%castPos = TeleportToMarker(%id, "Zones\\" @ %system @ "\\DropPoints", False, True);
			CheckAndBootFromArena(%id);
			NullItemList(%clientId, Lore, $MsgRed, "You lost all %1s you were carrying when you teleported.");

			if(!fetchData(%id, "invisible"))
				GameBase::startFadeIn(%id);

			Player::setDamageFlash(%id, 0.7);

			%extraDelay = 0.22;
			schedule("playSound(" @ $Spell::endSound[%index] @ ", \"" @ %castPos @ "\");", %extraDelay);
		}
	}

	if(%index == 66)
	{
		if(GameBase::getTeam(%clientId) == GameBase::getTeam(%id))
		{
			Client::sendMessage(%clientId, $MsgBeige, "Mass Fully Healing " @ Client::getName(%id));
			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, "YOU ARE BEING HEALED BY ADMIN: " @ Client::getName(%clientId));

			setHP(%id, fetchData(%id, "MaxHP"));

			%castPos = GameBase::getPosition(%id);

			CreateAndDetBomb(%clientId, "Bomb10", %castPos, False, %index);
			playSound($Spell::endSound[%index], %castPos);
		}
	}




	if(%index == 67)
	{
		//Beam Of Doom

		if(getObjectType(%castObj) == "Player")
			%id = Player::getClient(%castObj);

		%trans = GameBase::getMuzzleTransform(%clientId);
		%p = Projectile::spawnProjectile("sniperLaser", %trans, %player, "0 0 0", 1.0);

		%mom1 = Vector::getFromRot( GameBase::getRotation(%clientId), -60, 1 );
		Player::applyImpulse(%clientId, %mom1);

		%r = $Spell::damageValue[%index];
	
		if(%id != "")
		{
			//%miss = CalcSpellMiss(%clientId, %id, %index);

			SpellDamage(%clientId, %id, %r, %index);
			%mom2 = Vector::getFromRot( GameBase::getRotation(%clientId), 50, 1 );
			Player::applyImpulse(%id, %mom2);
		}

		%castPos = GameBase::getPosition(%clientId);

		%returnFlag = True;
	}


	if(%index == 69)
	{
		if(GameBase::getTeam(%clientId) == GameBase::getTeam(%id))
		{
			Client::sendMessage(%clientId, $MsgBeige, "Admin Shielding " @ Client::getName(%id));
			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, "Admin: " @ Client::getName(%clientId) @ " is shielding you.");

			UpdateBonusState(%id, $Spell::damageValue[%index], $Spell::ticks[%index]);

			%castPos = GameBase::getPosition(%id);
			%xpos=getword(%castpos,0);
			%ypos=getword(%castpos,1);
			%zpos=getword(%castpos,2);
			%counter = 0.1;
			schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb1004\", \"" @ %xpos @ " " @ %ypos-1 @ " " @ %zpos+2.5 @ "\", True, " @ %index @ ");",%counter+0.5);
			playSound($Spell::endSound[%index], %castPos);
		}
	}





}

function SpellCanCast(%clientId, %keyword)
{
	dbecho($dbechoMode, "SpellCanCast(" @ %clientId @ ", " @ %keyword @ ")");

	for(%i = 1; $Spell::keyword[%i] != ""; %i++)
	{
		if(String::ICompare($Spell::keyword[%i], %keyword) == 0)
		{
			if(SkillCanUse(%clientId, $Spell::keyword[%i]))
			{
				if(fetchData(%clientId, "MaxMANA") >= $Spell::manaCost[%i])
					return True;
			}
		}
	}
	return False;
}

function SpellCanCastNow(%clientId, %keyword)
{
	dbecho($dbechoMode, "SpellCanCastNow(" @ %clientId @ ", " @ %keyword @ ")");

	for(%i = 1; $Spell::keyword[%i] != ""; %i++)
	{
		if(String::ICompare($Spell::keyword[%i], %keyword) == 0)
		{
			if(SkillCanUse(%clientId, $Spell::keyword[%i]))
			{
				if(fetchData(%clientId, "MANA") >= $Spell::manaCost[%i])
					return True;
			}
		}
	}
	return False;
}

function CancelSPFreeze(%id, %TrueClientId)
{
	if(Player::isAiControlled(%id))
	{
		if(!%echoOff) Client::sendMessage(%TrueClientId, 0, %cropped @ " (" @ %id @ ") is defrosting! Run!");
		storeData(%id, "frozen", "");
		AI::SetSpotDist(%id);
	}
	else
		Client::sendMessage(%TrueClientId, 0, "Player must be a bot.");
	
	%returnFlag = False;
}

function damageflash(%obj, %flash)
{

Player::setDamageFlash(%obj,%flash);
}
function CreateAndDetBomb(%clientId, %b, %castPos, %doDamage, %index)
{
	dbecho($dbechoMode, "CreateAndDetBomb(" @ %clientId @ ", " @ %b @ ", " @ %castPos @ ", " @ %index @ ")");

	%player = Client::getOwnedObject(%clientId);

	%bomb = newObject("", "Mine", %b);

	addToSet("MissionCleanup", %bomb);

	GameBase::Throw(%bomb, %player, 0, false);
	GameBase::setPosition(%bomb, %castPos);
	
	if(%doDamage)
		SpellRadiusDamage(%clientId, %castPos, %index);

	playSound($Spell::endSound[%index], %castPos);
}