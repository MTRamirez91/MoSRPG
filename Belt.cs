          //-----------------------------------
          //
          // ----------------------------------
         // Tribes RPG Belt!!!
        //
       // Created by Carling
      // 07/02/04
     // ---------------------------------------
    // Adds a Belt option to tab menu
    // designed to reduce number of itemdatas
    // in server.
    //
    // This script requires many hookup's into
    // other files and will not run correctly
    // without them.
    //
    // It has been written for Salmons MoS
    // and may not be compatible with other
    // mods.
    //
    // It has been recoded to be compatible
    // TvT.
    //
    // --------------------------------------
   // I take no responsibility for any damage
  // this script may do to your server or
 // computer, although it shouldnt do any..
// ------------------------------------------
//
// ------------------- //
// Menu Functions      //
// ------------------- //

function MenuViewBelt(%clientId, %page)
{
	Client::buildMenu(%clientId, "Belt:", "ViewBelt", true);
//  Gems, Rares, Keys, Scrolls, Unique, SmithBook
	if(Belt::GetNS(%clientid,"GemItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Gems", "GemItems");
	if(Belt::GetNS(%clientid,"RareItems") > 0)	Client::addMenuItem(%clientId, %cnt++ @ "Rares", "RareItems");
	if(Belt::GetNS(%clientid,"KeysItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Keys", "KeysItems");
	if(Belt::GetNS(%clientid,"ScrollsItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Scrolls", "ScrollsItems");
	if(Belt::GetNS(%clientid,"UniqueItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Unique Items", "UniqueItems");
	Client::addMenuItem(%clientId, %cnt++ @ "Smith Book", "smith");
	Client::addMenuItem(%clientId, "xDone", "done");
	return;
}

function processMenuViewBelt(%clientId, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if(%opt == "smith")
	{
		MenuSmithList(%clientId, 1);
		return;
	}

	if($count[%o] > 0)
	{
		MenuBeltGear(%clientid, %o, 1);
		return;
	}

	if(%o != "done")
		MenuViewBelt(%clientId, %p);

	return;
}

function MenuBeltGear(%clientid, %type, %page)
{
	if(%type == "GemItems") 		%disp = "Gems";
	if(%type == "KeysItems") 		%disp = "Keys";
	if(%type == "RareItems")		%disp = "Rares";
	if(%type == "ScrollsItems") 		%disp = "Scrolls";
	if(%type == "UniqueItems") 		%disp = "Unique Items";

	Client::buildMenu(%clientId, %disp@":", "BeltGear", true);
	%clientId.bulkNum = "";

	%l = 6;
	%nx = $count[%type];
	%nf = Belt::GetNS(%clientid,%type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::HasThisStuff(%clientid,%item);
		Client::addMenuItem(%clientId, %cnt++ @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1)
	{
		if(%ns > 6) Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1)
	{
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else
	{
		Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1 @" "@%type);
	}

	return;
}

function processMenuBeltGear(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);

	if(%o != "page" && %o != "done")
	{
		if(%clientId.bulkNum < 1)
			%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)
			%clientId.bulkNum = 500;

		MenuBeltDrop(%clientid, %o, %t);
		return;
	}

	if(%o != "done")
		MenuBeltGear(%clientid, %t, %p);

	return;
}

function MenuBeltDrop(%clientid, %item, %type)
{
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::HasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "BeltDrop", true);

	Client::addMenuItem(%clientId, %cnt++ @ "Drop "@%amnt, %type@" drop "@%item@" "@%amnt);
	Client::addMenuItem(%clientId, %cnt++ @ "Examine", %type@" examine "@%item);
	Client::addMenuItem(%clientId, "xDone", "done");
	return;
}

function processMenuBeltDrop(%clientId, %opt)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);
	if(%amnt <= 0) %amnt = 1;

	if(%amnt != %clientId.bulkNum)
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuBeltDrop(%clientid, %item, %type);
	}
	else if(%option == "smith")
	{
		%k = String::getSubStr(%item, 0, 1);
		%f = String::getSubStr(%item, 1, String::Len(%item) - 5);
		remoteSay(%clientId, 0, "#smith "@%k@" "@%f);
	}
	else if(%option == "drop")
	{
		Belt::DropItem(%clientid,%item,%amnt,%type);
	}
	else if(%option == "examine")
	{
		%msg = WhatIs(%item);
		bottomprint(%clientId, %msg, floor(String::len(%msg) / 20));
	}
	return;
}

function MenuSellBelt(%clientId)
{
	Client::buildMenu(%clientId, "Belt sell:", "SellBelt", true);

	if(Belt::GetNS(%clientid,"GemItems") > 0)	Client::addMenuItem(%clientId, %cnt++ @ "Gems", "GemItems");
	if(Belt::GetNS(%clientid,"RareItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Rares", "RareItems");
	if(Belt::GetNS(%clientid,"KeysItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Keys", "KeysItems");
	if(Belt::GetNS(%clientid,"ScrollsItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Scrolls", "ScrollsItems");
	if(Belt::GetNS(%clientid,"UniqueItems") > 0)	Client::addMenuItem(%clientId, %cnt++ @ "Unique Items", "UniqueItems");
	Client::addMenuItem(%clientId, "xCancel", "done");
	return;
}

function processMenuSellBelt(%clientId, %opt)
{
	if($count[%opt] > 0)
	{
		MenuSellBeltItem(%clientid, %opt, 1);
		return;
	}

	if(%opt != "done")
		MenuSellBelt(%clientId);

	return;
}

function MenuSellBeltItem(%clientid, %type, %page)
{
	if(%type == "GemItems") %disp = "Gems";
	if(%type == "KeysItems") %disp = "Keys";
	if(%type == "ScrollsItems") %disp = "Scrolls";
	if(%type == "RareItems") %disp = "Rares";
	if(%type == "UniqueItems") %disp = "Unique Items";

	Client::buildMenu(%clientId, %disp@" sell:", "SellBeltItem", true);
	%clientId.bulkNum = "";

	%l = 6;
	%nx = $count[%type];
	%nf = Belt::GetNS(%clientid,%type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::HasThisStuff(%clientid,%item);
		Client::addMenuItem(%clientId, %cnt++ @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1)
	{
		if(%ns > 6) Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1)
	{
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else
	{
		Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1 @" "@%type);
	}

	return;
}

function processMenuSellBeltItem(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);

	if(%o != "page" && %o != "done")
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuSellBeltItemFinal(%clientid, %o, %t);
		return;
	}

	if(%o != "done")
		MenuSellBeltItem(%clientid, %t, %p);

	return;
}

function MenuSellBeltItemFinal(%clientid, %item, %type)
{
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::HasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "SellBeltItemFinal", true);

	Client::addMenuItem(%clientId, %cnt++ @ "Sell "@%amnt, %type@" sell "@%item@" "@%amnt);
	Client::addMenuItem(%clientId, "xCancel", "done");
	return;
}

function processMenuSellBeltItemFinal(%clientId, %opt)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);

	if(%clientId.bulkNum != %amnt)
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuSellBeltItemFinal(%clientid, %item, %type);
	}
	else if(%option == "sell")
	{
		%cmnt = Belt::HasThisStuff(%clientid,%item);
		if(%cmnt >= %amnt)
		{
			%cost = Belt::GetSellCost(%clientid,%item) * %amnt;
			UseSkill(%clientId, $SkillHaggling, True, True);
			storeData(%clientId, "COINS", %cost, "inc");
			Belt::TakeThisStuff(%clientid,%item,%amnt);
			Client::SendMessage(%clientId, $MsgWhite, "You received "@%cost@" coins.~wbuysellsound.wav");
			RefreshAll(%clientId);
			%clientId.bulkNum = 1;
		}
	}
	return;
}

//-----------------------------------------------------------------
function MenuStoreBelt(%clientId)
{
	Client::buildMenu(%clientId, "Belt store:", "StoreBelt", true);

	if(Belt::GetNS(%clientid,"GemItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Gems", "GemItems");
	if(Belt::GetNS(%clientid,"RareItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Rares", "RareItems");
	if(Belt::GetNS(%clientid,"KeysItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Keys", "KeysItems");
	if(Belt::GetNS(%clientid,"ScrollsItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Scrolls", "ScrollsItems");
	if(Belt::GetNS(%clientid,"UniqueItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Unique Items", "UniqueItems");

	Client::addMenuItem(%clientid, "wWithdraw","withdraw");
	Client::addMenuItem(%clientId, "xCancel", "done");
	return;
}

function processMenuStoreBelt(%clientId, %opt)
{
	if($count[%opt] > 0)
	{
		MenuStoreBeltItem(%clientid, %opt, 1);
		return;
	}

	if(%opt == "withdraw")
	{
		MenuWithdrawBelt(%clientId);
		return;
	}

	if(%opt != "done")
		MenuStoreBelt(%clientId);

	return;
}

function MenuWithdrawBelt(%clientId)
{
	Client::buildMenu(%clientId, "Belt withdraw:", "WithdrawBelt", true);

	if(Belt::BankGetNS(%clientid,"GemItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Gems", "GemItems");
	if(Belt::BankGetNS(%clientid,"RareItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Rares", "RareItems");
	if(Belt::BankGetNS(%clientid,"KeysItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Keys", "KeysItems");
	if(Belt::BankGetNS(%clientid,"ScrollsItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Scrolls", "ScrollsItems");
	if(Belt::BankGetNS(%clientid,"UniqueItems") > 0)		Client::addMenuItem(%clientId, %cnt++ @ "Unique Items", "UniqueItems");

	Client::addMenuItem(%clientid, "sStore","store");
	Client::addMenuItem(%clientId, "xCancel", "done");
	return;
}

function processMenuWithdrawBelt(%clientId, %opt)
{
	if($count[%opt] > 0)
	{
		MenuWithdrawBeltItem(%clientid, %opt, 1);
		return;
	}

	if(%opt == "store")
	{
		MenuStoreBelt(%clientId);
		return;
	}

	if(%opt != "done")
		MenuWithdrawBelt(%clientId);

	return;
}

function MenuStoreBeltItem(%clientid, %type, %page)
{
	if(%type == "GemItems") %disp = "Gems";
	if(%type == "KeysItems") %disp = "Keys";
	if(%type == "ScrollsItems") %disp = "Scrolls";
	if(%type == "RareItems") %disp = "Rares";
	if(%type == "UniqueItems") %disp = "Unique Items";

	Client::buildMenu(%clientId, %disp@" store:", "StoreBeltItem", true);
	%clientId.bulkNum = "";

	%l = 6;
	%nx = $count[%type];
	%nf = Belt::GetNS(%clientid,%type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::HasThisStuff(%clientid,%item);
		Client::addMenuItem(%clientId, %cnt++ @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1)
	{
		if(%ns > 6) Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1)
	{
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else
	{
		Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1 @" "@%type);
	}

	return;
}

function processMenuStoreBeltItem(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);

	if(%o != "page" && %o != "done")
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuStoreBeltItemFinal(%clientid, %o, %t);
		return;
	}

	if(%o != "done")
		MenuStoreBeltItem(%clientid, %t, %p);

	return;
}

function MenuStoreBeltItemFinal(%clientid, %item, %type)
{
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::HasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "StoreBeltItemFinal", true);

	Client::addMenuItem(%clientId, %cnt++ @ "Store "@%amnt, %type@" store "@%item@" "@%amnt);
	Client::addMenuItem(%clientId, "xCancel", "done");
	return;
}

function processMenuStoreBeltItemFinal(%clientId, %opt)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);

	if(%clientId.bulkNum != %amnt)
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuStoreBeltItemFinal(%clientid, %item, %type);
	}
	else if(%option == "store")
	{
		%cmnt = Belt::HasThisStuff(%clientid,%item);
		if(%cmnt >= %amnt)
		{
			Client::SendMessage(%clientid,0,"You store "@%amnt@" "@%item@".");
			Belt::TakeThisStuff(%clientid,%item,%amnt);
			Belt::BankGiveThisSTuff(%clientid,%item,%amnt);
		}
	}
	return;
}

//---------------------------

function MenuWithdrawBeltItem(%clientid, %type, %page)
{
	if(%type == "GemItems") %disp = "Gems";
	if(%type == "KeysItems") %disp = "Keys";
	if(%type == "ScrollsItems") %disp = "Scrolls";
	if(%type == "RareItems") %disp = "Rares";
	if(%type == "UniqueItems") %disp = "Unique Items";


	Client::buildMenu(%clientId, %disp@" withdraw:", "WithdrawBeltItem", true);
	%clientId.bulkNum = "";

	%l = 6;
	%nx = $count[%type];
	%nf = Belt::BankGetNS(%clientid,%type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::BankHasThisStuff(%clientid,%item);
		Client::addMenuItem(%clientId, %cnt++ @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1)
	{
		if(%ns > 6) Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1)
	{
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else
	{
		Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1 @" "@%type);
	}

	return;
}

function processMenuWithdrawBeltItem(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);

	if(%o != "page" && %o != "done")
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuWithdrawBeltItemFinal(%clientid, %o, %t);
		return;
	}

	if(%o != "done")
		MenuWithdrawBeltItem(%clientid, %t, %p);

	return;
}

function MenuWithdrawBeltItemFinal(%clientid, %item, %type)
{
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::BankHasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "WithdrawBeltItemFinal", true);

	Client::addMenuItem(%clientId, %cnt++ @ "Withdraw "@%amnt, %type@" withdraw "@%item@" "@%amnt);
	Client::addMenuItem(%clientId, "xCancel", "done");
	return;
}

function processMenuWithdrawBeltItemFinal(%clientId, %opt)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);

	if(%clientId.bulkNum != %amnt)
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuWithdrawBeltItemFinal(%clientid, %item, %type);
	}
	else if(%option == "withdraw")
	{
		%cmnt = Belt::BankHasThisStuff(%clientid,%item);
		if(%cmnt >= %amnt)
		{
			Client::SendMessage(%clientid,0,"You withdraw "@%amnt@" "@%item@".");
			Belt::BankTakeThisSTuff(%clientid,%item,%amnt);
			Belt::GiveThisStuff(%clientid,%item,%amnt);
		}
	}
	return;
}

// ------------------- //
// Non Menu Functions  //
// ------------------- //

$count["GemItems"] = 0;
$count["RareItems"] = 0;
$count["KeysItems"] = 0;
$count["ScrollsItems"] = 0;
$count["UniqueItems"] = 0;

function Belt::GetSellCost(%clientid,%item)
{
	%p = $HardcodedItemCost[%item];
	%cost = round(%p * ($resalePercentage/100));

	%p = round($PlayerSkill[%clientId, $SkillHaggling] / 11) / 100;
	%x = round(%cost * Cap(%p, 0.0, 1.0) );
	%cost += %x;

	return %cost;
}

function Belt::Mug(%clientid,%id)
{
	Client::SendMessage(%clientid,1,"#mugbelt");
}

function Belt::Sell(%clientid,%npc)
{
	AI::sayLater(%clientid, %npc, "What would you like to sell?", True);
	MenuSellBelt(%clientId);
}

function Belt::Store(%clientid,%npc)
{
	AI::sayLater(%clientid, %npc, "This is the equipment you have stored from your belt.", True);
	MenuStoreBelt(%clientid,"Store");
}

function Belt::GetWeight(%clientid)
{
	%list[1] = "GemItems";
	%list[2] = "RareItems";
	%list[3] = "KeysItems";
	%list[4] = "ScrollsItems";
	%list[4] = "UniqueItems";

	for(%s=1;%s<=4;%s++)
	{
		%type = %list[%s];
		for(%i=0;%i<=$count[%type];%i++)
		{
			%item = $beltitem[%i, "Num", %type];
			%amnt = Belt::HasThisStuff(%clientid,%item);
			%weig = $AccessoryVar[%item, $Weight];
			%total += %amnt * %weig;
		}
	}
	return %total;
}

function Belt::DropItem(%clientid,%item,%amnt,%type)
{
	%chk = Belt::HasThisStuff(%clientid,%item);
	if(%chk >= %amnt)
	{
		Belt::TakeThisStuff(%clientid,%item,%amnt);
		TossLootbag(%clientId, %item@" "@%amnt, 8, "*", 0, 1);
	}
}

function Belt::GetNS(%clientid,%type)
{
	%bn = 0;
	%num = $count[%type];
	for(%i;%i<=%num;%i++)
	{
		%item = $beltitem[%i, "Num", %type];
		%amnt = Belt::HasThisStuff(%clientid,%item);
		if(%amnt > 0) {
			%list = %list @" "@%item;
			%bn++;
		}
	}

	return %bn@%list;
}

function BeltItem::Add(%name,%item,%type,%weight,%cost)
{
	%num = $count[%type]++;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;
	$AccessoryVar[%item, $Weight] = %weight;
	$HardcodedItemCost[%item] = %cost;
}

function Belt::HasThisStuff(%clientid,%item)
{
	%item = $beltitem[%item, "Item"];
	%type = $beltitem[%item, "Type"];
	%list = fetchdata(%clientid,%type);
	%amnt = Belt::ItemCount(%item,%list);
	return %amnt;
}

function Belt::GiveThisStuff(%clientid, %item, %amnt, %echo)
{
	if(%amnt > 0)
	{
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,%type);
		%count = Belt::ItemCount(%item,%list);

		if(%echo) Client::sendMessage(%clientId, 0, "You received " @ %amnt @ " " @ $beltitem[%item, "Name"] @".");

		if(%count > 0)
		{
			%list = Belt::RemoveFromList(%list, %item@" "@%count);
			%amnt = %amnt + %count;
		}
		%list = Belt::AddToList(%list, %item@" "@%amnt);
		Storedata(%clientid,%type,%list);
	}
}

function Belt::TakeThisStuff(%clientid,%item,%amnt)
{
	if(%amnt > 0)
	{
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,%type);
		%count = Belt::ItemCount(%item,%list);
		%amnt = %count - %amnt;

		%list = Belt::RemoveFromList(%list, %item@" "@%count);
		if(%amnt > 0)	%list = Belt::AddToList(%list, %item@" "@%amnt);

		Storedata(%clientid,%type,%list);
	}
}

function isBeltItem(%item)
{
	%flag = false;
	if((String::ICompare($beltitem[%item, "Item"], %item) == 0))
		%flag = True;

	return %flag;
}

function Belt::ItemCount(%item,%list)
{
	%count = 0;

	for(%i=0;(%w = getword(%list,%i)) != -1;%i++)
	{
		if(%w == %item)
		{
			%count = getword(%list,%i++);
			break;
		}
	}
	return %count;
}

function Belt::AddToList(%list, %item)
{
	%list = %list @ %item @ " ";
	return %list;
}

function Belt::RemoveFromList(%list, %item)
{
	%a = " " @ %list;
	%a = String::replace(%a, " " @ %item @ " ", " ");
	%list = String::NEWgetSubStr(%a, 1, 99999);
	return %list;
}

function Belt::IsInList(%list, %item)
{
	%a = " " @ %list;
	if(String::findSubStr(%a, " " @ %item @ " ") != -1)
		return True;
	else
		return False;
}

function Belt::BankStorageConversion(%clientid)
{
	%bank =  fetchData(%clientId, "BankStorage");
	for(%i=0;getword(%bank,%i)!=-1;%i++)
	{
		%a = getword(%bank,%i);
		%b = getword(%bank,%i++);

		if(IsBeltItem(%a))
			Belt::BankGiveThisStuff(%clientid, %a, %b);
		else
			%banklist = %banklist@%a@" "@%b@" ";
	}
	storeData(%clientId, "BankStorage", " "@%banklist);
}

function Belt::BankGiveThisStuff(%clientid, %item, %amnt)
{
	if(%amnt > 0)
	{
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,"Bank"@%type);
		%count = Belt::ItemCount(%item,%list);

		if(%count > 0)
		{
			%list = Belt::RemoveFromList(%list, %item@" "@%count);
			%amnt = %amnt + %count;
		}
		%list = Belt::AddToList(%list, %item@" "@%amnt);
		Storedata(%clientid,"Bank"@%type,%list);
	}
}

function Belt::BankTakeThisStuff(%clientid,%item,%amnt)
{
	if(%amnt > 0)
	{
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,"Bank"@%type);
		%count = Belt::ItemCount(%item,%list);
		%amnt = %count - %amnt;

		%list = Belt::RemoveFromList(%list, %item@" "@%count);
		if(%amnt > 0)	%list = Belt::AddToList(%list, %item@" "@%amnt);

		Storedata(%clientid,"Bank"@%type,%list);
	}
}

function Belt::BankHasThisStuff(%clientid,%item)
{
	%item = $beltitem[%item, "Item"];
	%type = $beltitem[%item, "Type"];
	%list = fetchdata(%clientid,"Bank"@%type);
	%amnt = Belt::ItemCount(%item,%list);
	return %amnt;
}

function Belt::BankGetNS(%clientid,%type)
{
	%bn = 0;
	%num = $count[%type];
	for(%i;%i<=%num;%i++)
	{
		%item = $beltitem[%i, "Num", %type];
		%amnt = Belt::BankHasThisStuff(%clientid,%item);
		if(%amnt > 0) {
			%list = %list @" "@%item;
			%bn++;
		}
	}

	return %bn@%list;
}

function Belt::GetDeathItems(%clientid)
{
	%tmploot = "";
	if(fetchData(%clientId, "LCK") <= 0)
	{
		%tmploot = %tmploot @ fetchdata(%clientid,"RareItems");
		%tmploot = %tmploot @ fetchdata(%clientid,"GemItems");
		%tmploot = %tmploot @ fetchdata(%clientid,"KeysItems");
		%tmploot = %tmploot @ fetchdata(%clientid,"UniqueItems");

		for(%i=0;getword(%tmploot,%i)!=-1;%i++)
		{
			%a = getword(%tmploot,%i);
			%b = getword(%tmploot,%i++);

			if($StealProtectedItem[%a])
			{
				%ba = Belt::RemoveFromList(%tmploot, %a@" "@%b);
				%tmploot = %ba;
			}
			else
				Belt::TakeThisStuff(%clientid, %a, %b);
		}
	}
	return %tmploot;
}

// ----------------------------- //
// Define the Belt items         //
// ----------------------------- //
// %type =			 //
// KeysItems, GemItems, 	 //
// RareItems, UniqueItems,	 //
// FoodItems                     //
// ----------------------------- //

//BeltItem::Add(%name,%item,%type,%weight,%cost);

//Food//
//BeltItem::Add("Bread","bread","FoodItems",0.01,50);


//Gems//
BeltItem::Add("Quartz","Quartz","GemItems",0.2,250);
BeltItem::Add("Granite","Granite","GemItems",0.2,480);
BeltItem::Add("Opal","Opal","GemItems",0.2,600);
BeltItem::Add("Jade","Jade","GemItems",0.25,750);
BeltItem::Add("Turquoise","Turquoise","GemItems",0.3,1350);
BeltItem::Add("Ruby","Ruby","GemItems",0.3,1600);
BeltItem::Add("Topaz","Topaz","GemItems",0.5,3004);
BeltItem::Add("Sapphire","Sapphire","GemItems",1.3,4930);
BeltItem::Add("Gold","Gold","GemItems",3.3,9680);
BeltItem::Add("Emerald","Emerald","GemItems",1.2,15702);
BeltItem::Add("Diamond","Diamond","GemItems",0.1,28575);
BeltItem::Add("Keldrinite","Keldrinite","GemItems",5.5,225200);

//Unique Items//
BeltItem::Add("DeathKnight Insignia","DeathKnightInsignia","uniqueItems",1,0);
BeltItem::Add("420 Pin","420Pin","uniqueItems",1,0);
BeltItem::Add("Guardians Badge","GuardiansBadge","uniqueItems",1,0);
BeltItem::Add("Guppy Pass","GuppyPass","uniqueItems",1,250000);
BeltItem::Add("Chuck Noris Doll","ChuckNorisDoll","uniqueItems",1,1000);
BeltItem::Add("Heaven Stone","HeavenStone","uniqueItems",-100,987000);
BeltItem::Add("Chocobo Doll","ChocoboDoll","uniqueItems",-10,1000000);


//Rare Items//
BeltItem::Add("Traveller Flesh","TravellerFlesh","rareItems",1,0);
BeltItem::Add("Broken Handle","BrokenHandle","rareItems",2.8,1);
BeltItem::Add("Broken Blade","BrokenBlade","rareItems",5.3,2);
BeltItem::Add("Azguardian Alloy","AzguardianAlloy","rareItems",15,87000);
BeltItem::Add("A Letter","Letter","rareItems",1,0);
BeltItem::Add("A Document","Document","rareItems",1,0);
BeltItem::Add("Shiny Rock","ShinyRock","rareItems",-20,50);
BeltItem::Add("Green Rock","GreenRock","rareItems",-2,50);
BeltItem::Add("Red Rock","RedRock","rareItems",-2,50);
BeltItem::Add("Blue Rock","BlueRock","rareItems",-2,50);
BeltItem::Add("Brown Rock","BrownRock","rareItems",-2,50);
BeltItem::Add("Yellow Rock","YellowRock","rareItems",-2,50);
BeltItem::Add("Fire Rock","FireRock","rareItems",-10,500);
BeltItem::Add("Space Rock","SpaceRock","rareItems",-100,500);
BeltItem::Add("Magic Rock","MagicRock","rareItems",-1000,500);
BeltItem::Add("Orc Head","OrcHead","rareItems",7.5,0);
BeltItem::Add("Elven Bead","ElvenBead","rareItems",1,150);
BeltItem::Add("Nose Ring","NoseRing","rareItems",1,250);
BeltItem::Add("Azguard Crown","AzguardCrown","rareItems",-5,1000);
BeltItem::Add("Ogre Heart","OgreHeart","rareItems",3,0);
BeltItem::Add("Vial of Goo","VialofGoo","rareItems",3,0);
BeltItem::Add("Manuscript Piece","ManuscriptPiece","rareItems",2,0);
BeltItem::Add("Spell Book","SpellBook","rareItems",-5,0);
BeltItem::Add("Minotaur Steak","MinotaurSteak","rareItems",1,0);
BeltItem::Add("Minotaur Rib","MinotaurRib","rareItems",1,0);
BeltItem::Add("Dracos Claw","DracosClaw","rareItems",1,0);
BeltItem::Add("Dracos Tooth","DracosTooth","rareItems",1,0);
BeltItem::Add("Book Page","BookPage","rareItems",-1,0);
BeltItem::Add("Book of Life","BookofLife","rareItems",-10,0);
BeltItem::Add("Soul Stone","SoulStone","rareItems",5,0);
BeltItem::Add("Dark Stone","DarkStone","rareItems",-5,0);
BeltItem::Add("Holy Grail","HolyGrail","rareItems",-1000,0);
BeltItem::Add("Mithril","Mithril","rareItems",-100,329511);
BeltItem::Add("Mithril Shard","MithrilShard","rareItems",-3,0);
BeltItem::Add("Ogre Brain","OgreBrain","rareItems",2,0);
BeltItem::Add("Red Herb","RedHerb","rareItems",1,0);
BeltItem::Add("Green Herb","GreenHerb","rareItems",1,0);
BeltItem::Add("Minotaur Horn","MinotaurHorn","rareItems",4,0);
BeltItem::Add("Rose","Rose","rareItems",1,0);
BeltItem::Add("Pearl","Pearl","rareItems",1,0);
BeltItem::Add("Brooch Sliver","BroochSliver","rareItems",-10,0);
BeltItem::Add("Shield Receipt","ShieldReceipt","rareItems",1,0);
BeltItem::Add("Gnoll Eye","GnollEye","rareItems",1,0);
BeltItem::Add("Fish Scale","FishScale","rareItems",1,0);
BeltItem::Add("Fishermens Knife","FishermensKnife","rareItems",4.5,0);
BeltItem::Add("Mithril Brooch","MithrilBrooch","rareItems",-100,0);
BeltItem::Add("Silver Brooch","SilverBrooch","rareItems",-10,0);
BeltItem::Add("Black Statue","BlackStatue","rareItems",3,0);
BeltItem::Add("Skeleton Bone","SkeletonBone","rareItems",1,0);
BeltItem::Add("Enchanted Stone","EnchantedStone","rareItems",-5,0);
BeltItem::Add("Dragon Scale","DragonScale","rareItems",2.3,0);
BeltItem::Add("Aerin's Necklace","AerinsNecklace","rareItems",1,0);
BeltItem::Add("Zombie Skull","ZombieSkull","rareItems",5,0);
BeltItem::Add("Cross","Cross","rareItems",2,0);
BeltItem::Add("Miners Tool","MinersTool","rareItems",7.5,0);
BeltItem::Add("Magic Mushroom","MagicMushroom","RareItems",1,10000);