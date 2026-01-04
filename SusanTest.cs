//TESTING use of the compass
echo("Susan Compass Test in progess..");

function Susan::compass(%ci,%oi)
{
%ti = Player::getClient(%oi);
%n = Client::getName(%ti);
%pos = GameBase::getPosition(%oi);
%posX = getWord(%pos,0);
%posY = getWord(%pos,1);
issueCommand(%ci, %ci, 0, %n @ " is this way.", %posX, %posY);
}

function Susan::clearWaypoint(%ci, %s)
{
if(%s)
setCommandStatus(%ci, 0, "There they are.~wobjcomp");
else
setCommandStatus(%ci, 0, "Lost em.");
}
$Track =1;

function Susan::Test(%ci, %td)
{
%oi = Client::getOwnedObject(%td);
if($Track == 1)
{
schedule("Susan::compass(" @ %ci @ ", " @ %oi @ ");", 2);
schedule("Susan::Test(" @ %ci @ ", " @ %td @ ");", 5);
}
else
{
Susan::clearWaypoint(%ci, 1);
$Test = "";
}
}