     //--------------------------------------------//
    // Auth: Carling                              //
   // Date: 26 July 05                           //
  // Purp: Help stop some of the server crashes // 
 //--------------------------------------------//
 
 //Note %cl.lastLMSG = ""; to be added in 
//connectivity.cs for when client drops

 //Animation and sound repeated to fast crashes serv
//hopefully this will prevent such crashes

function remotePlayAnimWav(%cl, %anim, %wav)
{
	if(!Player::isAiControlled(%cl))
	{
		%sl = getsimtime() - %cl.lastLMSG;
		if(%sl >= 0.5)
		{
			remotePlayAnim(%cl, %anim);
			playVoice(%cl, %wav);
			%cl.lastLMSG = getsimtime();
		}
	}
}

  //Note as bad as the above function but lags serv
 //so hopefully this delay should slow it down
//thanks to newbie for the delay idea.

function remoteLMSG(%cl, %wav)
{
	if(!Player::isAiControlled(%cl))
	{
		%sl = getsimtime() - %cl.lastLMSG;
		if(%sl >= 0.5)
		{
			playVoice(%cl, %wav);
			%cl.lastLMSG = getsimtime();
		}
	}
}

function dbecho() { }