//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

// datablocks here
new SimGroup(CmObjectDatablocksGroup)
{
	// house segments //
	
	new StaticShapeData(houseWallData : _BaseData)
	{
		shapeFile = "art/shapes/house/wall.dts";
	};
	
	new StaticShapeData(houseWindowData : _BaseData)
	{
		shapeFile = "art/shapes/house/window.dts";
	};
	
	new StaticShapeData(houseDoorData : _BaseData)
	{
		shapeFile = "art/shapes/house/door.dts";
	};
};

new SimGroup(CmHouseSegmentListGroup)
{

//	// Example
//	singleton CmHouseSegmentType(ExampleObject)
//	{
//		name = "Example"; // user-friendly name
//		positionOffset = "0 1.8 0"; // x, y, z. Float. After shifting should be at north internal side of cell
//		segmentType = Wall; // May be "Door", "Wall", "Window", "Arch"
//		
//		objectRef = "SmallWallData"; // StaticShapeData datablock name or path of .pferab file
//		objectIncompleteRef = "SmallWallDataIncomplete"; // StaticShapeData datablock name or path of .pferab file for incomplete model
//	};

	singleton CmHouseSegmentType(HouseWall)
	{
		name = "House wall";
		positionOffset = "0 1.8 0";
		segmentType = Wall;
		
		objectRef = "houseWallData";
	};
	
	singleton CmHouseSegmentType(HouseWindow)
	{
		name = "House window";
		positionOffset = "0 1.8 0";
		segmentType = Window;
		
		objectRef = "houseWindowData";
	};
	
	singleton CmHouseSegmentType(HouseDoor)
	{
		name = "House door";
		positionOffset = "0 1.8 0";
		segmentType = Door;
		
		objectRef = "houseDoorData";
	};
};


new SimGroup(CmHouseMaterialListGroup)
{
	singleton CmHouseFloorMaterial()
	{
		name = "Rock";
		material = "TunnelFloorRockMaterial";
	};
	
	singleton CmHouseCeilingMaterial()
	{
		name = "Rock";
		material = "TunnelCeilingRockMaterial";
	};
	
	singleton CmHouseRoofMaterial()
	{
		name = "Rock";
		material = "TunnelWallsRockMaterial";
	};
};