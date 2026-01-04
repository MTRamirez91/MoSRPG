		else if(%item.className == Armor)
		{
			if(SkillCanUse(%clientId, %item))
			{
				if(fetchdata(%clientid,"EQUIPPED") == "")
				{
					Client::sendMessage(%clientId, $MsgGreen, "You equipped the " @ %item.description @ ".");
					storedata(%clientid, "EQUIPPED", %item);
				}
				else
				if(fetchdata(%clientid,"EQUIPPED") == %item)
				{
					Client::sendMessage(%clientId, $MsgGreen, "You unequipped " @ %item.description @ ".");
					storedata(%clientid, "EQUIPPED", "");
				}
				else
					Client::sendMessage(%clientId, $MsgRed, "You can't equip two armors!~wC_BuySell.wav");					
			}
			else
				Client::sendMessage(%clientId, $MsgRed, "You are too weak for this armor.~wC_BuySell.wav");
			
			if($OverrideMountPoint[%item] == "")
				Player::mountItem(%player, %item, 1);
		}