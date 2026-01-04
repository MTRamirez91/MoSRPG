			if(%w1 == "#spawnflyer")
			{
			
			  if(%clientToServerAdminLevel < 5)
			    {
			     Client::sendMessage(%TrueClientId,0,"need admin 5");
			  	return false;
			  }
			  if(getword(%cropped,0) == -1)
			  {
			   Client::sendMessage(%TrueClientId,0,"go #spawnflyer scout, lapc or hapc");
				return false;
			  }
			
			    %player = Client::getownedObject(%TrueclientId);
			     if (GameBase::getLOSInfo(%player,50))
			      {
				%rot = GameBase::getRotation(%player); 
				%turret = newObject("Flyer","Flier",getword(%cropped,0),true);
				addToSet("MissionCleanup", %turret);
				GameBase::setTeam(%turret,GameBase::getTeam(%player));
				GameBase::setPosition(%turret,$los::position);
				GameBase::setRotation(%turret,%rot);
				Client::sendMessage(%TrueClientId,0,getword(%cropped,0)@ " spawned.");
				playSound(SoundPickupBackpack,$los::position);
			      return true;
						
			      }
			     else 
			    Client::sendMessage(%client,0,"Deploy position out of range");
			
		         return false;
		}