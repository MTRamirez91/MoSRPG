$POSX[0] = -2614;
$POSY[0] = -389;
$POSZ[0] = 70;

$POSX[1] = -2457;
$POSY[1] = -560;
$POSZ[1] = 195;

$POSX[2] = -2141;
$POSY[2] = -144;
$POSZ[2] = 180;

$POSXC[0] = "-2328.9 -263.852 65 1 1 0";


$NPOSX = 0;
$NPOSY = 0;

$Destination = "-2415.13 -307.16 65";

$Type[Goblin] = "runt";
$Type[Gnoll] = "pup";
$Type[Elf] = "Lord";
$Type[Draco] = "BodyGuard";

function SC()
{
say(0, "#loadout SC CLASS Mage EXP 150000 CastingBlade 1");
say(0, "#spawn Gohort Magician SC 6 " @ $POSXC[0]);
	say(0, "#attacklos Magician " @ $Destination);
schedule("SC2();", 2);
}

function SC2()
{
schedule("Cast();", 0.2);
}

function Cast()
{
say(0, "#refeshbotskills Magician");
say(0, "#fw Magician #bash");
}


function Begin(%t)
{
$NPOSX = 0;
$NPOSY = 0;
%cnt = 1;
%r = floor(getRandom() * %cnt);    
if (%t == "Goblin")
say(0, "#loadout raid CLASS Fighter EXP 15000 Club 1");
if (%t == "Gnoll")
say(0, "#loadout raid CLASS Fighter EXP 25000 Mace 1");

say(0, "#createbotgroup Raiders");
for(%i = 0; %i <= 2; %i++)
{
$NPOSX = ($POSX[%r] + (%i + 3));
$NPOSY = ($POSY[%r] - (%i + 3));
%n = %t @ "" @ %i;
say(0, "#spawn " @ $Type[%t] @ "  Escaped_" @ %n @ " raid 1 " @ $NPOSX @ " " @ $NPOSY @ " " @ $POSZ[%r]);
say(0, "#botgroup Escaped_" @ %n @ " Raiders");
say(0, "#freeze Escaped_" @ %n);
}
schedule("Part2(" @ %t @ ", " @ %n @ ", " @ %r @ ");", 1);
}

function Part2(%t, %n, %r, %t)
{
for(%i = 2; %i <=4 ; %i++)
{
$NPOSX = ($POSX[%r] + (%i + 3));
$NPOSY = ($POSY[%r] - (%i + 3));
//echo("%NPOSX = " @ %NPOSX @ " , %NPOSY = " @ %NPOSY);
%n = %t @ "" @ %i;
say(0, "#spawn " @ $Type[%t] @ "  Escaped_" @ %n @ " raid 1 " @ $NPOSX @ " " @ $NPOSY @ " " @ $POSZ[%r]);
say(0, "#botgroup Escaped_" @ %n @ " Raiders");
say(0, "#freeze Escaped_" @ %n);
}
schedule("Part3(" @ %t @ ", " @ %n @ ", " @ %r @ ");", 1);
}

function Part3(%t, %n, %r, %t)
{
for(%i = 4; %i <=6 ; %i++)
{
$NPOSX = ($POSX[%r] + (%i + 3));
$NPOSY = ($POSY[%r] - (%i + 3));
//echo("%NPOSX = " @ %NPOSX @ " , %NPOSY = " @ %NPOSY);
%n = %t @ "" @ %i;
say(0, "#spawn " @ $Type[%t] @ "  Escaped_" @ %n @ " raid 1 " @ $NPOSX @ " " @ $NPOSY @ " " @ $POSZ[%r]);
say(0, "#botgroup Escaped_" @ %n @ " Raiders");
say(0, "#freeze Escaped_" @ %n);
}
schedule("Go(" @ %t @ ");", 1);
}
function Go(%t)
{
for(%i=0; %i <= 6; %i++)
{%n = %t @ "" @ %i;
say(0, "#cancelfreeze Escaped_" @ %n);
say(0, "#follow Escaped_" @ %t @ "0 Escaped_" @ %n);
}
say(0, "#cancelfollow Escaped_" @ %t @ "0");
say(0, "#attacklos Escaped_" @ %t @ "0" @ " " @ $Destination);
}
function Clean(%t)
{
for(%i=0; %i <=10; %i++)
{
say(0, "#nodroppack Escaped_" @ %t @ "" @ %i @ " 1");
	say(0, "#kill Escaped_" @ %t @ "" @ %i);
		
}
say(0, "#delloadout raid");
say(0, "#discardbotgroup Raiders");
}
