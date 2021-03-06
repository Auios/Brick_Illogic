datablock fxDTSBrickData(LogicGate_Enabler_Data)
{
	brickFile = "Add-Ons/Brick_Illogic/bricks/blb/4bitDFlipFlop.blb";
	category = "Logic Bricks";
	subCategory = "Chips";
	uiName = "Enabler";
	iconName = "";
	hasPrint = 1;
	printAspectRatio = "Logic";
	orientationFix = 3;

	isLogic = true;
	isLogicGate = true;
	isLogicInput = false;

	logicUIName = "Enabler";
	logicUIDesc = "4 bit enabler with enable propagate";

	numLogicPorts = 10;

	logicPortType[0] = 1;
	logicPortPos[0] = "3 0 0";
	logicPortDir[0] = 3;
	logicPortUIName[0] = "D0";

	logicPortType[1] = 1;
	logicPortPos[1] = "1 0 0";
	logicPortDir[1] = 3;
	logicPortUIName[1] = "D1";

	logicPortType[2] = 1;
	logicPortPos[2] = "-1 0 0";
	logicPortDir[2] = 3;
	logicPortUIName[2] = "D2";

	logicPortType[3] = 1;
	logicPortPos[3] = "-3 0 0";
	logicPortDir[3] = 3;
	logicPortUIName[3] = "D3";

	logicPortType[4] = 1;
	logicPortPos[4] = "3 0 0";
	logicPortDir[4] = 2;
	logicPortUIName[4] = "EnableIn";

	logicPortType[5] = 0;
	logicPortPos[5] = "-3 0 0";
	logicPortDir[5] = 0;
	logicPortUIName[5] = "EnableOut";

	logicPortType[6] = 0;
	logicPortPos[6] = "3 0 0";
	logicPortDir[6] = 1;
	logicPortUIName[6] = "Q0";

	logicPortType[7] = 0;
	logicPortPos[7] = "1 0 0";
	logicPortDir[7] = 1;
	logicPortUIName[7] = "Q1";

	logicPortType[8] = 0;
	logicPortPos[8] = "-1 0 0";
	logicPortDir[8] = 1;
	logicPortUIName[8] = "Q2";

	logicPortType[9] = 0;
	logicPortPos[9] = "-3 0 0";
	logicPortDir[9] = 1;
	logicPortUIName[9] = "Q3";
};

function LogicGate_Enabler_Data::doLogic(%this, %obj)
{
	if($LBC::Ports::BrickState[%obj, 4])
	{
		%obj.Logic_SetOutput(6, $LBC::Ports::BrickState[%obj, 0]);
		%obj.Logic_SetOutput(7, $LBC::Ports::BrickState[%obj, 1]);
		%obj.Logic_SetOutput(8, $LBC::Ports::BrickState[%obj, 2]);
		%obj.Logic_SetOutput(9, $LBC::Ports::BrickState[%obj, 3]);
		%obj.Logic_SetOutput(5, 1);
	}
	else
	{
		%obj.Logic_SetOutput(6, 0);
		%obj.Logic_SetOutput(7, 0);
		%obj.Logic_SetOutput(8, 0);
		%obj.Logic_SetOutput(9, 0);
		%obj.Logic_SetOutput(5, 0);
	}
}