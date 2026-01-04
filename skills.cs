//######################################################################################
// Skills
//######################################################################################

$SkillSlashing = 1;
$SkillPiercing = 2;
$SkillBludgeoning = 3;
$SkillDodging = 4;
$SkillWeightCapacity = 5;
$SkillBashing = 6;
$SkillStealing = 7;
$SkillHiding = 8;
$SkillBackstabbing = 9;
$SkillOffensiveCasting = 10;
$SkillDefensiveCasting = 11;
$SkillSpellResistance = 12;
$SkillHealing = 13;
$SkillArchery = 14;
$SkillEndurance = 15;
$SkillWeaponMastery = 16;
$SkillMining = 17;
$SkillSpeech = 18;
$SkillSenseHeading = 19;
$SkillEnergy = 20;
$SkillHaggling = 21;
$SkillNeutralCasting = 22;
$MinLevel = "L";
$MinGroup = "G";
$MinClass = "C";
$MinRemort = "R";
$MinAdmin = "A";
$MinHouse = "H";
$MinPlayer = "P";

$SkillDesc[1] = "Slashing";
$SkillDesc[2] = "Piercing";
$SkillDesc[3] = "Bludgeoning";
$SkillDesc[4] = "Dodging";
$SkillDesc[5] = "Weight Capacity";
$SkillDesc[6] = "Bashing";
$SkillDesc[7] = "Stealing";
$SkillDesc[8] = "Hiding";
$SkillDesc[9] = "Backstabbing";
$SkillDesc[10] = "Offensive Casting";
$SkillDesc[11] = "Defensive Casting";
$SkillDesc[12] = "Spell Resistance";
$SkillDesc[13] = "Healing";
$SkillDesc[14] = "Archery";
$SkillDesc[15] = "Endurance";
$SkillDesc[16] = "WeaponMastery";
$SkillDesc[17] = "Mining";
$SkillDesc[18] = "Speech";
$SkillDesc[19] = "Sense Heading";
$SkillDesc[20] = "Energy";
$SkillDesc[21] = "Haggling";
$SkillDesc[22] = "Neutral Casting";
$SkillDesc[L] = "Level";
$SkillDesc[G] = "Group";
$SkillDesc[C] = "Class";
$SkillDesc[R] = "Remort";
$SkillDesc[A] = "Admin Level";
$SkillDesc[H] = "House";
$SkillDesc[P] = "Owner";

//######################################################################################
// Class multipliers
//######################################################################################

//***********************************
// GENERAL RULES FOR MULTIPLIERS:
//***********************************
//- Maximum multiplier should be 2.0
//- Minimum multiplier should be 0.1
//- A 0.1 should be VERY rare.  The normal minimum is 0.2.  If a class should not even
//  be near a certain skill, that's when the 0.1 comes in.

//******** SUMMARY ******************
//- Primary skills use a 2.0 multiplier
//- Secondary skills use a 1.5 multiplier
//- Normal skills use a ~1.0 multiplier
//- Weak skills use a ~0.5 multiplier
//- VERY weak skills use a 0.2
//- Unsuitable skills for a specific class use a 0.1

//--------------
// Cleric
//--------------
// Clerics are good with Bludgeoning weapons but VERY good at healing spells.  They also
// know the basics behind offensive spells.

//Primary Skill: Defensive Casting
//Secondary Skills: Healing, Energy, Bludgeoning

$SkillMultiplier[Cleric, $SkillSlashing] = 0.6;
$SkillMultiplier[Cleric, $SkillPiercing] = 0.7;
$SkillMultiplier[Cleric, $SkillBludgeoning] = 1.5;
$SkillMultiplier[Cleric, $SkillDodging] = 0.7;
$SkillMultiplier[Cleric, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Cleric, $SkillBashing] = 0.5;
$SkillMultiplier[Cleric, $SkillStealing] = 0.2;
$SkillMultiplier[Cleric, $SkillHiding] = 0.2;
$SkillMultiplier[Cleric, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Cleric, $SkillOffensiveCasting] = 0.9;
$SkillMultiplier[Cleric, $SkillDefensiveCasting] = 2.0;
$SkillMultiplier[Cleric, $SkillNeutralCasting] = 1.2;
$SkillMultiplier[Cleric, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Cleric, $SkillHealing] = 2.0;
$SkillMultiplier[Cleric, $SkillArchery] = 0.5;
$SkillMultiplier[Cleric, $SkillEndurance] = 1.1;
$SkillMultiplier[Cleric, $SkillMining] = 1.0;
$SkillMultiplier[Cleric, $SkillWeaponMastery] = 0.5;
$SkillMultiplier[Cleric, $SkillSpeech] = 1.0;
$SkillMultiplier[Cleric, $SkillSenseHeading] = 1.0;
$SkillMultiplier[Cleric, $SkillEnergy] = 1.5;
$SkillMultiplier[Cleric, $SkillHaggling] = 1.0;
$EXPmultiplier[Cleric] = 0.85;

//--------------
// Druid
//--------------
// Druids are good with Bludgeoning weapons and are somewhat familiar with spells.  They specialize in Neutral casting.
// However they are also able to easily hide.

//Primary Skill: Neutral Casting
//Secondary Skill: Hiding, Slashing, Spell Resistance

$SkillMultiplier[Druid, $SkillSlashing] = 1.5;
$SkillMultiplier[Druid, $SkillPiercing] = 0.7;
$SkillMultiplier[Druid, $SkillBludgeoning] = 0.6;
$SkillMultiplier[Druid, $SkillDodging] = 2.0;
$SkillMultiplier[Druid, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[Druid, $SkillBashing] = 0.5;
$SkillMultiplier[Druid, $SkillStealing] = 0.2;
$SkillMultiplier[Druid, $SkillHiding] = 2.0;
$SkillMultiplier[Druid, $SkillBackstabbing] = 0.5;
$SkillMultiplier[Druid, $SkillOffensiveCasting] = 0.7;
$SkillMultiplier[Druid, $SkillDefensiveCasting] = 0.7;
$SkillMultiplier[Druid, $SkillNeutralCasting] = 2.0;
$SkillMultiplier[Druid, $SkillSpellResistance] = 1.0;
$SkillMultiplier[Druid, $SkillHealing] = 1.3;
$SkillMultiplier[Druid, $SkillArchery] = 0.7;
$SkillMultiplier[Druid, $SkillEndurance] = 0.8;
$SkillMultiplier[Druid, $SkillMining] = 2.0;
$SkillMultiplier[Druid, $SkillWeaponMastery] = 1.0;
$SkillMultiplier[Druid, $SkillSpeech] = 1.0;
$SkillMultiplier[Druid, $SkillSenseHeading] = 1.7;
$SkillMultiplier[Druid, $SkillEnergy] = 1.2;
$SkillMultiplier[Druid, $SkillHaggling] = 1.3;
$EXPmultiplier[Druid] = 0.8;

//--------------
// Thief
//--------------
//Thieves handle piercing weapons well enough, and are very good at hiding and backstabbing.
//And of course, they are great at stealing.

//Primary Skill: Stealing
//Secondary Skill: Hiding, Backstabbing, Piercing, Archery

$SkillMultiplier[Thief, $SkillSlashing] = 0.6;
$SkillMultiplier[Thief, $SkillPiercing] = 1.8;
$SkillMultiplier[Thief, $SkillBludgeoning] = 0.5;
$SkillMultiplier[Thief, $SkillDodging] = 1.1;
$SkillMultiplier[Thief, $SkillWeightCapacity] = 0.7;
$SkillMultiplier[Thief, $SkillBashing] = 0.2;
$SkillMultiplier[Thief, $SkillStealing] = 2.0;
$SkillMultiplier[Thief, $SkillHiding] = 2.0;
$SkillMultiplier[Thief, $SkillBackstabbing] = 2.0;
$SkillMultiplier[Thief, $SkillOffensiveCasting] = 0.2;
$SkillMultiplier[Thief, $SkillDefensiveCasting] = 0.2;
$SkillMultiplier[Thief, $SkillNeutralCasting] = 0.2;
$SkillMultiplier[Thief, $SkillSpellResistance] = 0.3;
$SkillMultiplier[Thief, $SkillHealing] = 0.5;
$SkillMultiplier[Thief, $SkillArchery] = 1.6;
$SkillMultiplier[Thief, $SkillEndurance] = 1.0;
$SkillMultiplier[Thief, $SkillMining] = 1.0;
$SkillMultiplier[Thief, $SkillWeaponMastery] = 1.0;
$SkillMultiplier[Thief, $SkillSpeech] = 1.0;
$SkillMultiplier[Thief, $SkillSenseHeading] = 1.0;
$SkillMultiplier[Thief, $SkillEnergy] = 0.5;
$SkillMultiplier[Thief, $SkillHaggling] = 1.5;
$EXPmultiplier[Thief] = 0.8;

//--------------
// Bard
//--------------
//Bards are much like thieves, except that they are a bit more evenly balanced.

//Primary Skill: Stealing
//Secondary Skill: Archery

$SkillMultiplier[Bard, $SkillSlashing] = 1.3;
$SkillMultiplier[Bard, $SkillPiercing] = 1.5;
$SkillMultiplier[Bard, $SkillBludgeoning] = 1.3;
$SkillMultiplier[Bard, $SkillDodging] = 2.0;
$SkillMultiplier[Bard, $SkillWeightCapacity] = 0.8;
$SkillMultiplier[Bard, $SkillBashing] = 0.2;
$SkillMultiplier[Bard, $SkillStealing] = 2.0;
$SkillMultiplier[Bard, $SkillHiding] = 1.8;
$SkillMultiplier[Bard, $SkillBackstabbing] = 1.8;
$SkillMultiplier[Bard, $SkillOffensiveCasting] = 0.3;
$SkillMultiplier[Bard, $SkillDefensiveCasting] = 0.3;
$SkillMultiplier[Bard, $SkillNeutralCasting] = 0.5;
$SkillMultiplier[Bard, $SkillSpellResistance] = 0.5;
$SkillMultiplier[Bard, $SkillHealing] = 2.0;
$SkillMultiplier[Bard, $SkillArchery] = 1.4;
$SkillMultiplier[Bard, $SkillEndurance] = 2.0;
$SkillMultiplier[Bard, $SkillMining] = 2.0;
$SkillMultiplier[Bard, $SkillWeaponMastery] = 2.0;
$SkillMultiplier[Bard, $SkillSpeech] = 2.5;
$SkillMultiplier[Bard, $SkillSenseHeading] = 1.5;
$SkillMultiplier[Bard, $SkillEnergy] = 0.6;
$SkillMultiplier[Bard, $SkillHaggling] = 2.0;
$EXPmultiplier[Bard] = 0.9;

//--------------
// Fighter
//--------------
// Fighters are great with swords, namely slashing weapons.  They are strong, but dumb.
// They know nothing when it comes to spells.  However they can easily wear armor and
// wield all kinds of weapons.

//Primary Skill: Slashing
//Secondary Skill: Bludgeoning

$SkillMultiplier[Fighter, $SkillSlashing] = 2.0;
$SkillMultiplier[Fighter, $SkillPiercing] = 2.0;
$SkillMultiplier[Fighter, $SkillBludgeoning] = 2.0;
$SkillMultiplier[Fighter, $SkillDodging] = 1.5;
$SkillMultiplier[Fighter, $SkillWeightCapacity] = 1.5;
$SkillMultiplier[Fighter, $SkillBashing] = 1.6;
$SkillMultiplier[Fighter, $SkillStealing] = 0.2;
$SkillMultiplier[Fighter, $SkillHiding] = 0.2;
$SkillMultiplier[Fighter, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Fighter, $SkillOffensiveCasting] = 0.1;
$SkillMultiplier[Fighter, $SkillDefensiveCasting] = 0.1;
$SkillMultiplier[Fighter, $SkillNeutralCasting] = 0.1;
$SkillMultiplier[Fighter, $SkillSpellResistance] = 0.2;
$SkillMultiplier[Fighter, $SkillHealing] = 1.2;
$SkillMultiplier[Fighter, $SkillArchery] = 1.6;
$SkillMultiplier[Fighter, $SkillEndurance] = 1.6;
$SkillMultiplier[Fighter, $SkillMining] = 1.0;
$SkillMultiplier[Fighter, $SkillWeaponMastery] = 2.5;
$SkillMultiplier[Fighter, $SkillSpeech] = 0.8;
$SkillMultiplier[Fighter, $SkillSenseHeading] = 0.4;
$SkillMultiplier[Fighter, $SkillEnergy] = 0.2;
$SkillMultiplier[Fighter, $SkillHaggling] = 1.0;
$EXPmultiplier[Fighter] = 1.0;

//--------------
// Paladin
//--------------
//Paladins are much like Fighters, except that they are a bit more evenly balanced.

//Primary Skill: Bludgeoning
//Secondary Skill: Healing

$SkillMultiplier[Paladin, $SkillSlashing] = 1.5;
$SkillMultiplier[Paladin, $SkillPiercing] = 1.5;
$SkillMultiplier[Paladin, $SkillBludgeoning] = 1.2;
$SkillMultiplier[Paladin, $SkillDodging] = 1.5;
$SkillMultiplier[Paladin, $SkillWeightCapacity] = 1.5;
$SkillMultiplier[Paladin, $SkillBashing] = 1.5;
$SkillMultiplier[Paladin, $SkillStealing] = 0.3;
$SkillMultiplier[Paladin, $SkillHiding] = 0.3;
$SkillMultiplier[Paladin, $SkillBackstabbing] = 0.3;
$SkillMultiplier[Paladin, $SkillOffensiveCasting] = 0.2;
$SkillMultiplier[Paladin, $SkillDefensiveCasting] = 1.2;
$SkillMultiplier[Paladin, $SkillNeutralCasting] = 0.3;
$SkillMultiplier[Paladin, $SkillSpellResistance] = 0.9;
$SkillMultiplier[Paladin, $SkillHealing] = 1.3;
$SkillMultiplier[Paladin, $SkillArchery] = 1.2;
$SkillMultiplier[Paladin, $SkillEndurance] = 1.5;
$SkillMultiplier[Paladin, $SkillMining] = 1.0;
$SkillMultiplier[Paladin, $SkillWeaponMastery] = 1.5;
$SkillMultiplier[Paladin, $SkillSpeech] = 0.8;
$SkillMultiplier[Paladin, $SkillSenseHeading] = 0.5;
$SkillMultiplier[Paladin, $SkillEnergy] = 0.9;
$SkillMultiplier[Paladin, $SkillHaggling] = 1.3;
$EXPmultiplier[Paladin] = 1.0;

//--------------
// Ranger
//--------------
// Rangers specialize in ranged weaponry.  They are also good at finding their way when lost.
// They can also wear armors and wield weapons easily enough.

//Primary Skill: Archery
//Secondary Skills: Slashing, Sense Heading

$SkillMultiplier[Ranger, $SkillSlashing] = 1.2;
$SkillMultiplier[Ranger, $SkillPiercing] = 1.1;
$SkillMultiplier[Ranger, $SkillBludgeoning] = 1.2;
$SkillMultiplier[Ranger, $SkillDodging] = 1.8;
$SkillMultiplier[Ranger, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Ranger, $SkillBashing] = 0.9;
$SkillMultiplier[Ranger, $SkillStealing] = 0.5;
$SkillMultiplier[Ranger, $SkillHiding] = 1.0;
$SkillMultiplier[Ranger, $SkillBackstabbing] = 0.4;
$SkillMultiplier[Ranger, $SkillOffensiveCasting] = 0.2;
$SkillMultiplier[Ranger, $SkillDefensiveCasting] = 0.4;
$SkillMultiplier[Ranger, $SkillNeutralCasting] = 0.3;
$SkillMultiplier[Ranger, $SkillSpellResistance] = 0.2;
$SkillMultiplier[Ranger, $SkillHealing] = 0.8;
$SkillMultiplier[Ranger, $SkillArchery] = 2.0;
$SkillMultiplier[Ranger, $SkillEndurance] = 1.2;
$SkillMultiplier[Ranger, $SkillMining] = 1.0;
$SkillMultiplier[Ranger, $SkillWeaponMastery] = 1.5;
$SkillMultiplier[Ranger, $SkillSpeech] = 1.0;
$SkillMultiplier[Ranger, $SkillSenseHeading] = 2.0;
$SkillMultiplier[Ranger, $SkillEnergy] = 0.7;
$SkillMultiplier[Ranger, $SkillHaggling] = 0.7;
$EXPmultiplier[Ranger] = 0.95;

//--------------
// Mage
//--------------
// Mages are horrible with weapons and armor, but excel in anything that
// relates to spells.

//Primary Skill: Offensive Casting
//Secondary Skills: Energy

$SkillMultiplier[Mage, $SkillSlashing] = 0.3;
$SkillMultiplier[Mage, $SkillPiercing] = 0.8;
$SkillMultiplier[Mage, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Mage, $SkillDodging] = 1.2;
$SkillMultiplier[Mage, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Mage, $SkillBashing] = 0.2;
$SkillMultiplier[Mage, $SkillStealing] = 0.2;
$SkillMultiplier[Mage, $SkillHiding] = 0.2;
$SkillMultiplier[Mage, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Mage, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Mage, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Mage, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Mage, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Mage, $SkillHealing] = 0.7;
$SkillMultiplier[Mage, $SkillArchery] = 0.8;
$SkillMultiplier[Mage, $SkillEndurance] = 0.4;
$SkillMultiplier[Mage, $SkillMining] = 1.0;
$SkillMultiplier[Mage, $SkillWeaponMastery] = 0.5;
$SkillMultiplier[Mage, $SkillSpeech] = 1.2;
$SkillMultiplier[Mage, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Mage, $SkillEnergy] = 2.0;
$SkillMultiplier[Mage, $SkillHaggling] = 1.0;
$EXPmultiplier[Mage] = 1.0;

//Peasant
$SkillMultiplier[Peasant, $SkillSlashing] = 1.8;
$SkillMultiplier[Peasant, $SkillPiercing] = 1.2;
$SkillMultiplier[Peasant, $SkillBludgeoning] = 2.0;
$SkillMultiplier[Peasant, $SkillDodging] = 1.2;
$SkillMultiplier[Peasant, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[Peasant, $SkillBashing] = 2.0;
$SkillMultiplier[Peasant, $SkillStealing] = 1.0;
$SkillMultiplier[Peasant, $SkillHiding] = 0.5;
$SkillMultiplier[Peasant, $SkillBackstabbing] = 0.1;
$SkillMultiplier[Peasant, $SkillOffensiveCasting] = 0.1;
$SkillMultiplier[Peasant, $SkillDefensiveCasting] = 0.1;
$SkillMultiplier[Peasant, $SkillNeutralCasting] = 0.1;
$SkillMultiplier[Peasant, $SkillSpellResistance] = 0.5;
$SkillMultiplier[Peasant, $SkillHealing] = 1.2;
$SkillMultiplier[Peasant, $SkillArchery] = 1.0;
$SkillMultiplier[Peasant, $SkillEndurance] = 1.1;
$SkillMultiplier[Peasant, $SkillMining] = 2.0;
$SkillMultiplier[Peasant, $SkillWeaponMastery] = 1.0;
$SkillMultiplier[Peasant, $SkillSpeech] = 0.2;
$SkillMultiplier[Peasant, $SkillSenseHeading] = 1.0;
$SkillMultiplier[Peasant, $SkillEnergy] = 0.1;
$SkillMultiplier[Peasant, $SkillHaggling] = 1.5;
$EXPmultiplier[Peasant] = 0.7;

//LowerLord
$SkillMultiplier[LowerLord, $SkillSlashing] = 2.0;
$SkillMultiplier[LowerLord, $SkillPiercing] = 0.5;
$SkillMultiplier[LowerLord, $SkillBludgeoning] = 0.5;
$SkillMultiplier[LowerLord, $SkillDodging] = 1.0;
$SkillMultiplier[LowerLord, $SkillWeightCapacity] = 0.5;
$SkillMultiplier[LowerLord, $SkillBashing] = 0.5;
$SkillMultiplier[LowerLord, $SkillStealing] = 0.2;
$SkillMultiplier[LowerLord, $SkillHiding] = 0.2;
$SkillMultiplier[LowerLord, $SkillBackstabbing] = 0.2;
$SkillMultiplier[LowerLord, $SkillOffensiveCasting] = 0.5;
$SkillMultiplier[LowerLord, $SkillDefensiveCasting] = 1.2;
$SkillMultiplier[LowerLord, $SkillNeutralCasting] = 0.7;
$SkillMultiplier[LowerLord, $SkillSpellResistance] = 1.2;
$SkillMultiplier[LowerLord, $SkillHealing] = 1.0;
$SkillMultiplier[LowerLord, $SkillArchery] = 1.0;
$SkillMultiplier[LowerLord, $SkillEndurance] = 1.5;
$SkillMultiplier[LowerLord, $SkillMining] = 0.2;
$SkillMultiplier[LowerLord, $SkillWeaponMastery] = 1.2;
$SkillMultiplier[LowerLord, $SkillSpeech] = 2.0;
$SkillMultiplier[LowerLord, $SkillSenseHeading] = 0.5;
$SkillMultiplier[LowerLord, $SkillEnergy] = 0.5;
$SkillMultiplier[LowerLord, $SkillHaggling] = 1.5;
$EXPmultiplier[LowerLord] = 1.0;

//Outcast
$SkillMultiplier[Outcast, $SkillSlashing] = 2.0;
$SkillMultiplier[Outcast, $SkillPiercing] = 0.9;
$SkillMultiplier[Outcast, $SkillBludgeoning] = 0.9;
$SkillMultiplier[Outcast, $SkillDodging] = 1.3;
$SkillMultiplier[Outcast, $SkillWeightCapacity] = 1.5;
$SkillMultiplier[Outcast, $SkillBashing] = 0.5;
$SkillMultiplier[Outcast, $SkillStealing] = 0.2;
$SkillMultiplier[Outcast, $SkillHiding] = 0.2;
$SkillMultiplier[Outcast, $SkillBackstabbing] = 1.0;
$SkillMultiplier[Outcast, $SkillOffensiveCasting] = 0.2;
$SkillMultiplier[Outcast, $SkillDefensiveCasting] = 1.2;
$SkillMultiplier[Outcast, $SkillNeutralCasting] = 1.2;
$SkillMultiplier[Outcast, $SkillSpellResistance] = 0.7;
$SkillMultiplier[Outcast, $SkillHealing] = 0.8;
$SkillMultiplier[Outcast, $SkillArchery] = 1.2;
$SkillMultiplier[Outcast, $SkillEndurance] = 1.2;
$SkillMultiplier[Outcast, $SkillMining] = 2.0;
$SkillMultiplier[Outcast, $SkillWeaponMastery] = 2.0;
$SkillMultiplier[Outcast, $SkillSpeech] = 0.8;
$SkillMultiplier[Outcast, $SkillSenseHeading] = 1.1;
$SkillMultiplier[Outcast, $SkillEnergy] = 0.2;
$SkillMultiplier[Outcast, $SkillHaggling] = 2.0;
$EXPmultiplier[Outcast] = 1.0;

//conjurer
$SkillMultiplier[Conjurer, $SkillSlashing] = 0.3;
$SkillMultiplier[Conjurer, $SkillPiercing] = 1.3;
$SkillMultiplier[Conjurer, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Conjurer, $SkillDodging] = 0.8;
$SkillMultiplier[Conjurer, $SkillWeightCapacity] = 0.9;
$SkillMultiplier[Conjurer, $SkillBashing] = 0.1;
$SkillMultiplier[Conjurer, $SkillStealing] = 0.8;
$SkillMultiplier[Conjurer, $SkillHiding] = 0.3;
$SkillMultiplier[Conjurer, $SkillBackstabbing] = 0.5;
$SkillMultiplier[Conjurer, $SkillOffensiveCasting] = 1.5;
$SkillMultiplier[Conjurer, $SkillDefensiveCasting] = 1.5;
$SkillMultiplier[Conjurer, $SkillNeutralCasting] = 1.5;
$SkillMultiplier[Conjurer, $SkillSpellResistance] = 2.0;
$SkillMultiplier[Conjurer, $SkillHealing] = 0.3;
$SkillMultiplier[Conjurer, $SkillArchery] = 0.3;
$SkillMultiplier[Conjurer, $SkillEndurance] = 0.5;
$SkillMultiplier[Conjurer, $SkillMining] = 1.0;
$SkillMultiplier[Conjurer, $SkillWeaponMastery] = 0.7;
$SkillMultiplier[Conjurer, $SkillSpeech] = 1.0;
$SkillMultiplier[Conjurer, $SkillSenseHeading] = 0.5;
$SkillMultiplier[Conjurer, $SkillEnergy] = 1.2;
$SkillMultiplier[Conjurer, $SkillHaggling] = 0.8;
$EXPmultiplier[Conjurer] = 0.8;

//assasin
$SkillMultiplier[Assassin, $SkillSlashing] = 0.8;
$SkillMultiplier[Assassin, $SkillPiercing] = 2.0;
$SkillMultiplier[Assassin, $SkillBludgeoning] = 0.8;
$SkillMultiplier[Assassin, $SkillDodging] = 0.8;
$SkillMultiplier[Assassin, $SkillWeightCapacity] = 1.5;
$SkillMultiplier[Assassin, $SkillBashing] = 0.5;
$SkillMultiplier[Assassin, $SkillStealing] = 1.5;
$SkillMultiplier[Assassin, $SkillHiding] = 1.5;
$SkillMultiplier[Assassin, $SkillBackstabbing] = 2.0;
$SkillMultiplier[Assassin, $SkillOffensiveCasting] = 0.8;
$SkillMultiplier[Assassin, $SkillDefensiveCasting] = 0.8;
$SkillMultiplier[Assassin, $SkillNeutralCasting] = 0.5;
$SkillMultiplier[Assassin, $SkillSpellResistance] = 0.3;
$SkillMultiplier[Assassin, $SkillHealing] = 0.8;
$SkillMultiplier[Assassin, $SkillArchery] = 1.0;
$SkillMultiplier[Assassin, $SkillEndurance] = 1.0;
$SkillMultiplier[Assassin, $SkillMining] = 0.8;
$SkillMultiplier[Assassin, $SkillWeaponMastery] = 1.8;
$SkillMultiplier[Assassin, $SkillSpeech] = 1.0;
$SkillMultiplier[Assassin, $SkillSenseHeading] = 1.0;
$SkillMultiplier[Assassin, $SkillEnergy] = 0.5;
$SkillMultiplier[Assassin, $SkillHaggling] = 1.0;
$EXPmultiplier[Assassin] = 1.0;

//Xirios
$SkillMultiplier[Xirios, $SkillSlashing] = 2.8;
$SkillMultiplier[Xirios, $SkillPiercing] = 2.5;
$SkillMultiplier[Xirios, $SkillBludgeoning] = 2.8;
$SkillMultiplier[Xirios, $SkillDodging] = 3.8;
$SkillMultiplier[Xirios, $SkillWeightCapacity] = 2.5;
$SkillMultiplier[Xirios, $SkillBashing] = 2.5;
$SkillMultiplier[Xirios, $SkillStealing] = 0.5;
$SkillMultiplier[Xirios, $SkillHiding] = 1.5;
$SkillMultiplier[Xirios, $SkillBackstabbing] = 2.0;
$SkillMultiplier[Xirios, $SkillOffensiveCasting] = 0.8;
$SkillMultiplier[Xirios, $SkillDefensiveCasting] = 0.8;
$SkillMultiplier[Xirios, $SkillNeutralCasting] = 0.5;
$SkillMultiplier[Xirios, $SkillSpellResistance] = 2.3;
$SkillMultiplier[Xirios, $SkillHealing] = 2.5;
$SkillMultiplier[Xirios, $SkillArchery] = 2.5;
$SkillMultiplier[Xirios, $SkillEndurance] = 4.0;
$SkillMultiplier[Xirios, $SkillMining] = 1.8;
$SkillMultiplier[Xirios, $SkillWeaponMastery] = 5.8;
$SkillMultiplier[Xirios, $SkillSpeech] = 2.0;
$SkillMultiplier[Xirios, $SkillSenseHeading] = 5.0;
$SkillMultiplier[Xirios, $SkillEnergy] = 0.5;
$SkillMultiplier[Xirios, $SkillHaggling] = 4.0;
$EXPmultiplier[Xirios] = 1.0;
//######################################################################################
// Skill Restriction tables
//######################################################################################

//To determine skill restrictions, do the following:
//
//-Determine the following variables first:
//	(weapon):
//	a = ATK * 1.1 (archery is 0.75)
//	b = Delay = Cap((Weight / 3), 1, "inf")
//
//	(armor):
//	a = (DEF + MDEF) / 6
//	b = 1.0
//
//-To find out what the skill restriction number is, follow this formula, where s is the final skill restriction:
//	s = Cap((a / b) - 20), 0, "inf") * 10.0;
//

//.............Armors and Items

$SkillRestriction[KnightShield] = $SkillEndurance @ " 250";
$SkillRestriction[DragonShield] = $SkillEndurance @ " 500 " @ $MinRemort @ " 4";
$SkillRestriction[heavenlyShield] = $SkillEndurance @ " 750 " @ $MinRemort @ " 8";
$SkillRestriction[minotaurShield] = $SkillEndurance @ " 900 " @ $MinRemort @ " 8";
$SkillRestriction[saraka] = $SkillEndurance @ " 1000 " @ $MinRemort @ " 11";

$SkillRestriction[LightRobe] = $SkillEndurance @ " 2 " @ $SkillEnergy @ " 30";
$SkillRestriction[BloodRobe] = $SkillEndurance @ " 8 " @ $SkillEnergy @ " 90";
$SkillRestriction[AdvisorRobe] = $SkillEndurance @ " 10 " @ $SkillEnergy @ " 180";
$SkillRestriction[CenturionRobe] = $SkillEndurance @ " 50 " @ $SkillEnergy @ " 200 " @ $MinRemort @ " 2";
$SkillRestriction[ElvenRobe] = $SkillEndurance @ " 12 " @ $SkillEnergy @ " 260";
$SkillRestriction[PhensRobe] = $SkillEndurance @ " 20 " @ $SkillEnergy @ " 500";
$SkillRestriction[ArkemnsRobe] = $SkillEndurance @ " 20 " @ $SkillEnergy @ " 700 " @ $MinRemort @ " 5";
$SkillRestriction[RobeofVigor] = $SkillEndurance @ " 100 " @ $SkillHealing @ " 65 " @ $MinRemort @ " 3";
$SkillRestriction[RobeofThought] = $SkillEndurance @ " 100 " @ $SkillEnergy @ " 65 " @ $MinRemort @ " 3";
$SkillRestriction[QuestMasterRobe] = $MinAdmin @ " 5";

$SkillRestriction[ScaleMail] = $SkillEndurance @ " 100";
$SkillRestriction[BrigandineArmor] = $SkillEndurance @ " 150";
$SkillRestriction[ChainMail] = $SkillEndurance @ " 190";
$SkillRestriction[RingMail] = $SkillEndurance @ " 260";
$SkillRestriction[BandedMail] = $SkillEndurance @ " 330";
$SkillRestriction[SplintMail] = $SkillEndurance @ " 500";
$SkillRestriction[BronzePlateMail] = $SkillEndurance @ " 640";
$SkillRestriction[DracoPlateMail] = $SkillEndurance @ " 850";
$SkillRestriction[DragonMail] = $SkillEndurance @ " 600 " @ $MinRemort @ " 3";
$SkillRestriction[FullPlateArmor] = $SkillEndurance @ " 900 " @ $MinRemort @ " 5";
$SkillRestriction[KnightsArmor] = $SkillEndurance @ " 550 " @ $MinRemort @ " 5 " @ $MinClass @ " Fighter";
$SkillRestriction[KeldrinArmor] = $SkillEndurance @ " 1035 " @ $MinRemort @ " 8";
$SkillRestriction[MithrilMail] = $SkillEndurance @ " 1200 " @ $SkillDodging @ " 700 " @ $MinRemort @ " 12";
$SkillRestriction[Devilsarmor] = $SkillEndurance @ " 1600 " @ $SkillDodging @ " 700 " @ $MinRemort @ " 10";

$SkillRestriction[CheetaursPaws] = $MinLevel @ " 5";
$SkillRestriction[BootsOfGliding] = $MinLevel @ " 20";
$SkillRestriction[WindWalkers] = $MinLevel @ " 50";
$SkillRestriction[HeavenlyWings] = $MinLevel @ " 60 " @ $MinRemort @ " 2";

//.............Melee Weapons

$SkillRestriction[Hatchet] = $SkillSlashing @ " 0";
$SkillRestriction[BroadSword] = $SkillSlashing @ " 90";
$SkillRestriction[WarAxe] = $SkillSlashing @ " 145";
$SkillRestriction[LongSword] = $SkillSlashing @ " 185";
$SkillRestriction[BattleAxe] = $SkillSlashing @ " 240";
$SkillRestriction[Claymore] = $SkillSlashing @ " 390";
$SkillRestriction[VenomBLade] = $SkillSlashing @ " 500";
$SkillRestriction[ElvenBlade] = $SkillSlashing @ " 250 " @ $minremort @ " 1";
$SkillRestriction[Katana] = $SkillSlashing @ " 690 " @ $MinRemort @ " 3";
$SkillRestriction[IronsMight] = $minremort @ " 5 " @ $SkillSlashing @ " 600 " @ $SkillBludgeoning @ " 600";
$SkillRestriction[HeavyAxe] = $SkillSlashing @ " 600 " @ $MinRemort @ " 5";
$SkillRestriction[DracosWrath] = $SkillSlashing @ " 700 " @ $MinRemort @ " 7";
$SkillRestriction[DracoSword] = $SkillSlashing @ " 550 " @ $MinRemort @ " 8";
$SkillRestriction[HeavensGlory] = $SkillSlashing @ " 1050 " @ $MinRemort @ " 10";
$SkillRestriction[SoulSlicer] = $MinRemort @ " 15 " @ $SkillSlashing @ " 1100";
$SkillRestriction[CosmicBlade] = $MinRemort @ " 30 " @ $SkillSlashing @ " 725 " @ $SkillWeaponMastery @ " 500";

$SkillRestriction[Club] = $SkillBludgeoning @ " 0";
$SkillRestriction[SpikedClub] = $SkillBludgeoning @ " 90";
$SkillRestriction[Mace] = $SkillBludgeoning @ " 145";
$SkillRestriction[SpikedBoneClub] = $SkillBludgeoning @ " 170";
$SkillRestriction[HammerPick] = $SkillBludgeoning @ " 195";
$SkillRestriction[MorningStar] = $SkillBludgeoning @ " 240";
$SkillRestriction[WarHammer] = $SkillBludgeoning @ " 390";
$SkillRestriction[WarMaul] = $SkillBludgeoning @ " 450 " @ $MinRemort @ " 1";
$SkillRestriction[GnarledStaff] = $SkillBludgeoning @ " 600 "  @ $MinRemort @ " 3";
$SkillRestriction[TitaniumHammer] = $SkillBludgeoning @ " 650 " @ $MinRemort @ " 5";
$SkillRestriction[DragonHammer] = $SkillBludgeoning @ " 750 " @ $MinRemort @ " 8";

$SkillRestriction[Board] = $MinLevel @ " 10";

$SkillRestriction[TotalGym] = $MinRemort @ " 3";
$SkillRestriction[TheX] = $MinRemort @ " 3";
$SkillRestriction[PickAxe] = $SkillPiercing @ " 0";
$SkillRestriction[Dagger] = $SkillPiercing @ " 90";
$SkillRestriction[ShortSword] = $SkillPiercing @ " 130";
$SkillRestriction[Spear] = $SkillPiercing @ " 175";
$SkillRestriction[Gladius] = $SkillPiercing @ " 210";
$SkillRestriction[Trident] = $SkillPiercing @ " 250";
$SkillRestriction[Rapier] = $SkillPiercing @ " 290";
$SkillRestriction[LongStaff] = $SkillPiercing @ " 375";
$SkillRestriction[AwlPike] = $SkillPiercing @ " 450";
$SkillRestriction[QuarterStaff] = $SkillPiercing @ " 105 " @ $MinRemort @ " 1";
$SkillRestriction[DevilsClaw] = $SkillPiercing @ " 500 " @ $SkillSlashing @ " 500 " @$MinRemort @ " 3";
$SkillRestriction[SkeletalStaff] = $SkillPiercing @ " 130 "  @ $MinRemort @ " 10";
$SkillRestriction[MithrilSword] = $MinRemort @ " 9 " @ $SkillPiercing @ " 1000 ";
$SkillRestriction[HellsEdge] = $SkillPiercing @ " 750 " @ $MinRemort @ " 3";
$SkillRestriction[Exterminator] = $SkillPiercing @ " 900 " @ $MinRemort @ " 50 " @ $SkillWeaponMastery @ " 800";

//..............Staffs and others

$SkillRestriction[BitchSlap] = $MinAdmin @ " 150";
$SkillRestriction[SlapStick] = $MinAdmin @ " 150";
$SkillRestriction[Griller] = $MinAdmin @ " 5";
$SkillRestriction[FireBreath] = $SkillEnergy @ " 450";
$SkillRestriction[SlapStick] = $SkillEnergy @ " 300 " @ $SkillOffensiveCasting @ " 500";
$SkillRestriction[HolyFist] = $SkillBludgeoning @ " 700 " @ $MinGroup @ " Priest";
$SkillRestriction[WizardStaff] = $SkillOffensiveCasting @ " 1000 " @ $MinGroup @ " Wizard";
$SkillRestriction[Annihilator] = $SkillEndurance @ " 1100 " @ $MinGroup @ " Warrior";

//..............Archery Weapons

$SkillRestriction[ShortBow] = $SkillArchery @ " 20";
$SkillRestriction[LongBow] = $SkillArchery @ " 75";
$SkillRestriction[ElvenBow] = $SkillArchery @ " 120";
$SkillRestriction[LightCrossbow] = $SkillArchery @ " 75";
$SkillRestriction[HeavyCrossbow] = $SkillArchery @ " 300";
$SkillRestriction[RepeatingCrossbow] = $SkillArchery @ " 350";
$SkillRestriction[CrystalBow] = $SkillArchery @ " 450 " @$MinRemort @ " 3";
$SkillRestriction[DracosBow] = $SkillArchery @ " 600 " @$MinRemort @ " 5";
$SkillRestriction[ArchersForce] = $SkillArchery @ " 600 " @ $MinClass @ " Ranger " @$MinRemort @ " 7";

$SkillRestriction[SmallRock] = $SkillArchery @ " 0";
$SkillRestriction[BasicArrow] = $SkillArchery @ " 0";
$SkillRestriction[SheafArrow] = $SkillArchery @ " 50";
$SkillRestriction[BladedArrow] = $SkillArchery @ " 100";
$SkillRestriction[LightQuarrel] = $SkillArchery @ " 0";
$SkillRestriction[ShortQuarrel] = $SkillArchery @ " 0";
$SkillRestriction[UberFeather] = $SkillArchery @ " 300 " @$MinRemort @ " 5";

// Chat functions

$SkillRestriction["#say"] = $SkillSpeech @ " 0";
$SkillRestriction["#shout"] = $SkillSpeech @ " 3";
$SkillRestriction["#scream"] = $SkillSpeech @ " 3";
$SkillRestriction["#tell"] = $SkillSpeech @ " 0";
$SkillRestriction["#global"] = $SkillSpeech @ " 5";
$SkillRestriction["#zone"] = $SkillSpeech @ " 0";
$SkillRestriction["#group"] = $SkillSpeech @ " 6";
$SkillRestriction["#party"] = $SkillSpeech @ " 0";
$SkillRestriction["#steal"] = $SkillStealing @ " 15";
$SkillRestriction["#pickpocket"] = $SkillStealing @ " 270";
$SkillRestriction["#mug"] = $SkillStealing @ " 600";
$SkillRestriction["#compass"] = $SkillSenseHeading @ " 3";
$SkillRestriction["#track"] = $SkillSenseHeading @ " 15";
$SkillRestriction["#trackpack"] = $SkillSenseHeading @ " 85";
$SkillRestriction["#hide"] = $SkillHiding @ " 15";
$SkillRestriction["#bash"] = $SkillBashing @ " 15";
$SkillRestriction["#shove"] = $SkillBashing @ " 2";
$SkillRestriction["#zonelist"] = $SkillSenseHeading @ " 45";
$SkillRestriction["#advcompass"] = $SkillSenseHeading @ " 20";
$SkillRestriction["#disarm"] = $MinLevel @ " 200 " @$MinRemort @ " 25";

// Spells
$SkillRestriction[Death] = $MinAdmin @ " 1000";
$SkillRestriction[thorn] = $SkillOffensiveCasting @ " 1";
$SkillRestriction[fireball] = $SkillOffensiveCasting @ " 10";
$SkillRestriction[firebomb] = $SkillOffensiveCasting @ " 20";
$SkillRestriction[icespike] = $SkillOffensiveCasting @ " 35";
$SkillRestriction[icestorm] = $SkillOffensiveCasting @ " 75";
$SkillRestriction[ironfist] = $SkillOffensiveCasting @ " 100";
$SkillRestriction[cloud] = $SkillOffensiveCasting @ " 135";
$SkillRestriction[melt] = $SkillOffensiveCasting @ " 210";
$SkillRestriction[powercloud] = $SkillOffensiveCasting @ " 330";
$SkillRestriction[hellstorm] = $SkillOffensiveCasting @ " 420";
$SkillRestriction[beam] = $SkillOffensiveCasting @ " 520";
$SkillRestriction[hurricane] = $MinRemort @ " 5 " @ $SkillOffensiveCasting @ " 600";
$SkillRestriction[Tornado] = $MinRemort @ " 2 " @ $SkillOffensiveCasting @ " 682";
$SkillRestriction[Ultima] = $MinRemort @ " 420 " @ $SkillOffensiveCasting @ " 600";

$SkillRestriction[melodyofhate] = $SkillSpeech @ " 100 " @ $MinClass @ " Bard";
$SkillRestriction[songofhealing] = $SkillSpeech @ " 200 " @ $MinClass @ " Bard";
$SkillRestriction[mesmerize] = $SkillSpeech @ " 400 " @ $MinRemort @ " 2 " @ $MinClass @ " Bard";

$SkillRestriction[teleport] = $SkillNeutralCasting @ " 60";
$SkillRestriction[transport] = $SkillNeutralCasting @ " 180";
$SkillRestriction[advtransport] = $SkillNeutralCasting @ " 300";
$SkillRestriction[remort] = $SkillNeutralCasting @ " 0 " @ $MinLevel @ " 101";
$SkillRestriction[mimic] = $SkillNeutralCasting @ " 1200 " @ $MinRemort @ " 666";
$SkillRestriction[masstransport] = $SkillNeutralCasting @ " 550 " @ $MinRemort @ " 1";

$SkillRestriction[heal] = $SkillDefensiveCasting @ " 10";
$SkillRestriction[advheal1] = $SkillDefensiveCasting @ " 35";
$SkillRestriction[advheal2] = $SkillDefensiveCasting @ " 85";
$SkillRestriction[advheal3] = $SkillDefensiveCasting @ " 150";
$SkillRestriction[advheal4] = $SkillDefensiveCasting @ " 260";
$SkillRestriction[advheal5] = $SkillDefensiveCasting @ " 350";
$SkillRestriction[advheal6] = $SkillDefensiveCasting @ " 470";
$SkillRestriction[godlyheal] = $SkillDefensiveCasting @ " 600";
$SkillRestriction[fullheal] = $SkillDefensiveCasting @ " 750";
$SkillRestriction[massheal] = $SkillDefensiveCasting @ " 850 " @ $MinRemort @ " 2";
$SkillRestriction[massfullheal] = $SkillDefensiveCasting @ " 950 " @ $MinRemort @ " 3";
$SkillRestriction[heavensheal] = $SkillDefensiveCasting @ " 670 " @ $MinRemort @ " 5";
$SkillRestriction[shield] = $SkillDefensiveCasting @ " 20";
$SkillRestriction[advshield1] = $SkillDefensiveCasting @ " 60";
$SkillRestriction[advshield2] = $SkillDefensiveCasting @ " 140";
$SkillRestriction[advshield3] = $SkillDefensiveCasting @ " 290";
$SkillRestriction[advshield4] = $SkillDefensiveCasting @ " 420";
$SkillRestriction[advshield5] = $SkillDefensiveCasting @ " 635";
$SkillRestriction[massshield] = $SkillDefensiveCasting @ " 680";
$SkillRestriction[bless] = $Skilldefensivecasting @ " 500 " @ $MinRemort @ " 4 " @ $MinClass @ " Cleric";

// new Spells

$SkillRestriction[divineray] = $SkillNeutralCasting @ " 1000 " @ $MinRemort @ " 5 " @ $MinGroup @ " Priest";
$SkillRestriction[rumble] = $SkillOffensiveCasting @ " 260";
$SkillRestriction[quake] = $SkillOffensiveCasting @ " 400";
$SkillRestriction[avalanche] = $SkillOffensiveCasting @ " 600 " @ $MinRemort @ " 5 " @ $MinClass @ " Mage";
$SkillRestriction[meteor] = $SkillOffensiveCasting @ " 1000 " @ $MinRemort @ " 10 " @ $MinClass @ " Mage";
$SkillRestriction[smoke] = $SkillOffensiveCasting @ " 110";
$SkillRestriction[firespike] = $SkillOffensiveCasting @ " 470";
$SkillRestriction[firerain] = $SkillOffensiveCasting @ " 600";
$SkillRestriction[lavaburst] = $SkillOffensiveCasting @ " 750";
$SkillRestriction[blizzard] = $SkillOffensiveCasting @ " 500";
$SkillRestriction[comet] = $SkillOffensiveCasting @ " 1000 " @ $MinRemort @ " 10 " @ $MinClass @ " Conjurer";
$SkillRestriction[shock] = $SkillOffensiveCasting @ " 10";
$SkillRestriction[lit] = $SkillOffensiveCasting @ " 60";
$SkillRestriction[zap] = $SkillOffensiveCasting @ " 120";
$SkillRestriction[electrocute] = $SkillOffensiveCasting @ " 600 " @ $MinRemort @ " 5 " @ $MinClass @ " Conjurer";
$SkillRestriction[bolt] = $SkillOffensiveCasting @ " 1000";
$SkillRestriction[boost] = $SkillDefensiveCasting @ " 500 " @ $MinRemort @ " 3";
$SkillRestriction[stop] = $SkillDefensiveCasting @ " 280 " @ $MinRemort @ " 3";

//My Spells!
$SkillRestriction[healofderaj] = $MinRemort @ " 100";
$SkillRestriction[derajheal] = $MinAdmin @ " 3";
$SkillRestriction[derajshield] = $MinAdmin @ " 3";
$SkillRestriction[nuke] = $MinRemort @ " 500";


//######################################################################################
// Skill functions
//######################################################################################

function GetNumSkills()
{
	dbecho($dbechoMode, "GetNumSkills()");

	for(%i = 1; $SkillDesc[%i] != ""; %i++){}
	return %i-1;
}

function AddSkillPoint(%clientId, %skill, %delta)
{
	dbecho($dbechoMode, "AddSkillPoint(" @ %clientId @ ", " @ %skill @ ", " @ %delta @ ")");

	if(%delta == "")
		%delta = 1;

	//==== CAPS ================
	//if($PlayerSkill[%clientId, %skill] >= $SkillCap)
	//	return False;

	%ub = ($skillRangePerLevel * fetchData(%clientId, "LVL")) + 50 + fetchData(%clientId, "RemortStep");
	if($PlayerSkill[%clientId, %skill] >= %ub)
		return False;
	//==========================

	%a = GetSkillMultiplier(%clientId, %skill) * %delta;
	%b = $PlayerSkill[%clientId, %skill];
	%c = %a + %b;
	%d = round(%c * 10);
	%e = (%d / 10) * 1.000001;

	$PlayerSkill[%clientId, %skill] = %e;

	return True;
}

function GetPlayerSkill(%clientId, %skill)
{
	return $PlayerSkill[%clientId, %skill];
}
function GetSkillMultiplier(%clientId, %skill)
{
	dbecho($dbechoMode, "GetSkillMultiplier(" @ %clientId @ ", " @ %skill @ ")");

	%a = $SkillMultiplier[fetchData(%clientId, "CLASS"), %skill];
	%b = fetchData(%clientId, "RemortStep") * 0.1;

	%c = Cap(%a + %b, "inf", 30.0);

	return FixDecimals(%c);
}
function GetEXPmultiplier(%clientId)
{
	dbecho($dbechoMode, "GetEXPmultiplier(" @ %clientId @ ")");

	%a = $EXPmultiplier[fetchData(%clientId, "CLASS")];
	%b = fetchData(%clientId, "RemortStep") * 0.5;

	%c = %a + %b;

	return FixDecimals(%c);
}

function SetAllSkills(%clientId, %n)
{
	dbecho($dbechoMode, "SetAllSkills(" @ %clientId @ ", " @ %n @ ")");

	for(%i = 1; $SkillDesc[%i] != ""; %i++)
		$PlayerSkill[%clientId, %i] = %n;
}

function SkillCanUse(%clientId, %thing)
{
	dbecho($dbechoMode, "SkillCanUse(" @ %clientId @ ", " @ %thing @ ")");

	if(%clientId.adminLevel >= 5)
		return True;

	%flag = 0;
	%gc = 0;
	%gcflag = 0;
	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2)
	{
		%s = GetWord($SkillRestriction[%thing], %i);
		%n = GetWord($SkillRestriction[%thing], %i+1);

		if(%s == "L")
		{
			if(fetchData(%clientId, "LVL") < %n)
				%flag = 1;
		}
		else if(%s == "R")
		{
			if(fetchData(%clientId, "RemortStep") < %n)
				%flag = 1;
		}
		else if(%s == "A")
		{
			if(%clientId.adminLevel < %n)
				%flag = 1;
		}
		else if(%s == "G")
		{
			%gcflag++;
			if(String::ICompare(fetchData(%clientId, "GROUP"), %n) == 0)
				%gc = 1;
		}
		else if(%s == "C")
		{
			%gcflag++;
			if(String::ICompare(fetchData(%clientId, "CLASS"), %n) == 0)
				%gc = 1;
		}
		else if(%s == "H")
		{
			%hflag++;
			if(String::ICompare(fetchData(%clientId, "MyHouse"), %n) == 0)
				%hh = 1;
		}
		else if(%s == "P")
		{
			if(fetchData(%clientId, "somethinghere") < %n)
				%flag = 1;
		}
		else
		{
			if($PlayerSkill[%clientId, %s] < %n)
				%flag = 1;
		}
	}

	//First, if there are any class/group restrictions, house restrictions, check these first.
	if(%gcflag > 0)
	{
		if(%gc == 0)
			%flag = 1;
	}
	if(%hflag > 0)
	{
		if(%hh == 0)
			%flag = 1;
	}

	
	if(%flag != 1)
		return True;
	else
		return False;
}

function UseSkill(%clientId, %skilltype, %successful, %showmsg, %base, %refreshall)
{
	dbecho($dbechoMode, "UseSkill(" @ %clientId @ ", " @ %skilltype @ ", " @ %successful @ ", " @ %showmsg @ ", " @ %base @ ", " @ %refreshall @ ")");

	if(%base == "") %base = 35;

	%ub = ($skillRangePerLevel * fetchData(%clientId, "LVL")) + 50 + fetchData(%clientId, "RemortStep");
	if($PlayerSkill[%clientId, %skilltype] < %ub)
	{
		if(%successful)
			$SkillCounter[%clientId, %skilltype] += 1;
		else
			$SkillCounter[%clientId, %skilltype] += 0.05;

		%p = 1 - ($PlayerSkill[%clientId, %skilltype] / 1150);
		%e = round( (%base / GetSkillMultiplier(%clientId, %skilltype)) * %p );

		if($SkillCounter[%clientId, %skilltype] >= %e)
		{
			$SkillCounter[%clientId, %skilltype] = 0;
			%retval = AddSkillPoint(%clientId, %skilltype, 1);

			if(%retval)
			{
				if(%showmsg)
					Client::sendMessage(%clientId, $MsgBeige, "You have increased your skill in " @ $SkillDesc[%skilltype] @ " (" @ $PlayerSkill[%clientId, %skilltype] @ ")");
				if(%refreshall)
					RefreshAll(%clientId);
			}
		}
	}
}

function WhatSkills(%thing)
{
	dbecho($dbechoMode, "WhatSkills(" @ %thing @ ")");

	%t = "";
	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2)
	{
		%s = GetWord($SkillRestriction[%thing], %i);
		%n = GetWord($SkillRestriction[%thing], %i+1);

		%t = %t @ $SkillDesc[%s] @ ": " @ %n @ ", ";
	}
	if(%t == "")
		%t = "None";
	else
		%t = String::getSubStr(%t, 0, String::len(%t)-2);
	
	return %t;
}

function GetSkillAmount(%thing, %skill)
{
	dbecho($dbechoMode, "GetSkillAmount(" @ %thing @ ", " @ %skill @ ")");

	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2)
	{
		%s = GetWord($SkillRestriction[%thing], %i);

		if(%s == %skill)
			return GetWord($SkillRestriction[%thing], %i+1);
	}
	return 0;
}

