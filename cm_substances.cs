new SimGroup(SubstancesGroup) {
singleton Substance(air)
{
   ter2_id = 0;
   terrainMaterialName = "EmptyTerrainMaterial";
   tunnelFloorMaterialName   = "Empty";
   tunnelCeilingMaterialName = "Empty";
   tunnelWallMaterialName    = "Empty";
   quantity_k = 0;
   maxHeightDiffBeforeFall = 0;
   canBeDigged = 0;
   canBeShaped = 0;
   diggedObjectID = 0;
   droppedObjectID = 0;
   footstepsType = "invalid";
   SpeedMultiplier = 1;
};
singleton Substance(soil)
{
   ter2_id = 1;
   terrainMaterialName = "soil";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 1;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(loosensoil)
{
   ter2_id = 6;
   terrainMaterialName = "LoosenSoil";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 334;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(forestsoil)
{
   ter2_id = 7;
   terrainMaterialName = "Forest_soil";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 1;
   canBeShaped = 1;
   diggedObjectID = 332;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(loosenforestsoil)
{
   ter2_id = 8;
   terrainMaterialName = "forest_soil_loose";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 332;
   droppedObjectID = 332;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(steppesoil)
{
   ter2_id = 9;
   terrainMaterialName = "steppe_soil";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 1;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(loosensteppesoil)
{
   ter2_id = 10;
   terrainMaterialName = "steppe_soil_loose";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 333;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(rockbare)
{
   ter2_id = 3;
   terrainMaterialName = "rock";
   tunnelFloorMaterialName   = "TunnelFloorRockMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingRockMaterial";
   tunnelWallMaterialName    = "TunnelWallsRockMaterial";
   quantity_k = 0.5;
   maxHeightDiffBeforeFall = 20;
   canBeDigged = 1;
   canBeShaped = 0;
   diggedObjectID = 241;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(rockfrag)
{
   ter2_id = 11;
   terrainMaterialName = "Rock_frag";
   tunnelFloorMaterialName   = "TunnelWallsRockBareMaterial";
   tunnelCeilingMaterialName = "TunnelWallsRockBareMaterial";
   tunnelWallMaterialName    = "TunnelWallsRockBareMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 241;
   droppedObjectID = 241;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(granite)
{
   ter2_id = 12;
   terrainMaterialName = "Granite";
   tunnelFloorMaterialName   = "TunnelFloorGraniteMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingGraniteMaterial";
   tunnelWallMaterialName    = "TunnelWallsGraniteMaterial";
   quantity_k = 0.25;
   maxHeightDiffBeforeFall = 20;
   canBeDigged = 1;
   canBeShaped = 0;
   diggedObjectID = 243;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(granitefrag)
{
   ter2_id = 13;
   terrainMaterialName = "Granite_fragments";
   tunnelFloorMaterialName   = "TunnelWallsGraniteFragMaterial";
   tunnelCeilingMaterialName = "TunnelWallsGraniteFragMaterial";
   tunnelWallMaterialName    = "TunnelWallsGraniteFragMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 243;
   droppedObjectID = 243;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(marble)
{
   ter2_id = 14;
   terrainMaterialName = "Marble";
   tunnelFloorMaterialName   = "TunnelFloorMarbleMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMarbleMaterial";
   tunnelWallMaterialName    = "TunnelWallsMarbleMaterial";
   quantity_k = 0.25;
   maxHeightDiffBeforeFall = 20;
   canBeDigged = 1;
   canBeShaped = 0;
   diggedObjectID = 242;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(marblefrag)
{
   ter2_id = 15;
   terrainMaterialName = "Marble_fragments";
   tunnelFloorMaterialName   = "TunnelWallsMarbleFragMaterial";
   tunnelCeilingMaterialName = "TunnelWallsMarbleFragMaterial";
   tunnelWallMaterialName    = "TunnelWallsMarbleFragMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 242;
   droppedObjectID = 242;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(slate)
{
   ter2_id = 16;
   terrainMaterialName = "slate";
   tunnelFloorMaterialName   = "TunnelFloorSlateMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSlateMaterial";
   tunnelWallMaterialName    = "TunnelWallsSlateMaterial";
   quantity_k = 0.5;
   maxHeightDiffBeforeFall = 20;
   canBeDigged = 1;
   canBeShaped = 0;
   diggedObjectID = 665;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(slatefrag)
{
   ter2_id = 17;
   terrainMaterialName = "Slate_shards";
   tunnelFloorMaterialName   = "TunnelWallsSlateFragMaterial";
   tunnelCeilingMaterialName = "TunnelWallsSlateFragMaterial";
   tunnelWallMaterialName    = "TunnelWallsSlateFragMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 665;
   droppedObjectID = 665;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(GoldOre)
{
   ter2_id = 5;
   terrainMaterialName = "GoldVein";
   tunnelFloorMaterialName   = "TunnelFloorGoldOreMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingGoldOreMaterial";
   tunnelWallMaterialName    = "TunnelWallsGoldOreMaterial";
   quantity_k = 0.5;
   maxHeightDiffBeforeFall = 20;
   canBeDigged = 1;
   canBeShaped = 0;
   diggedObjectID = 330;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(GoldOreloose)
{
   ter2_id = 18;
   terrainMaterialName = "GoldOre";
   tunnelFloorMaterialName   = "TunnelWallsGoldOreFragMaterial";
   tunnelCeilingMaterialName = "TunnelWallsGoldOreFragMaterial";
   tunnelWallMaterialName    = "TunnelWallsGoldOreFragMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 330;
   droppedObjectID = 330;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(IronOre)
{
   ter2_id = 4;
   terrainMaterialName = "IronVein";
   tunnelFloorMaterialName   = "TunnelFloorIronOreMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingIronOreMaterial";
   tunnelWallMaterialName    = "TunnelWallsIronOreMaterial";
   quantity_k = 0.5;
   maxHeightDiffBeforeFall = 20;
   canBeDigged = 1;
   canBeShaped = 0;
   diggedObjectID = 328;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(IronOreLoose)
{
   ter2_id = 20;
   terrainMaterialName = "IronOre";
   tunnelFloorMaterialName   = "TunnelWallsIronOreFragMaterial";
   tunnelCeilingMaterialName = "TunnelWallsIronOreFragMaterial";
   tunnelWallMaterialName    = "TunnelWallsIronOreFragMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 328;
   droppedObjectID = 328;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(SilverVein)
{
   ter2_id = 21;
   terrainMaterialName = "SilverVein";
   tunnelFloorMaterialName   = "TunnelFloorSilverOreMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSilverOreMaterial";
   tunnelWallMaterialName    = "TunnelWallsSilverOreMaterial";
   quantity_k = 0.5;
   maxHeightDiffBeforeFall = 20;
   canBeDigged = 1;
   canBeShaped = 0;
   diggedObjectID = 331;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(SilverOre)
{
   ter2_id = 22;
   terrainMaterialName = "SilverOre";
   tunnelFloorMaterialName   = "TunnelWallsSilverOreFragMaterial";
   tunnelCeilingMaterialName = "TunnelWallsSilverOreFragMaterial";
   tunnelWallMaterialName    = "TunnelWallsSilverOreFragMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 331;
   droppedObjectID = 331;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(CopperVein)
{
   ter2_id = 23;
   terrainMaterialName = "CopperVein";
   tunnelFloorMaterialName   = "TunnelFloorCopperOreMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingCopperOreMaterial";
   tunnelWallMaterialName    = "TunnelWallsCopperOreMaterial";
   quantity_k = 0.5;
   maxHeightDiffBeforeFall = 20;
   canBeDigged = 1;
   canBeShaped = 0;
   diggedObjectID = 329;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(CopperOre)
{
   ter2_id = 24;
   terrainMaterialName = "CopperOre";
   tunnelFloorMaterialName   = "TunnelWallsCopperOreFragMaterial";
   tunnelCeilingMaterialName = "TunnelWallsCopperOreFragMaterial";
   tunnelWallMaterialName    = "TunnelWallsCopperOreFragMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 329;
   droppedObjectID = 329;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(sand)
{
   ter2_id = 2;
   terrainMaterialName = "sand";
   tunnelFloorMaterialName   = "TunnelWallsSandMaterial";
   tunnelCeilingMaterialName = "TunnelWallsSandMaterial";
   tunnelWallMaterialName    = "TunnelWallsSandMaterial";
   quantity_k = 2;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 245;
   droppedObjectID = 245;
   footstepsType = "sand";
   SpeedMultiplier = 1;
};
singleton Substance(clay)
{
   ter2_id = 19;
   terrainMaterialName = "Clay";
   tunnelFloorMaterialName   = "TunnelFloorClayMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingClayMaterial";
   tunnelWallMaterialName    = "TunnelWallsClayMaterial";
   quantity_k = 0.5;
   maxHeightDiffBeforeFall = 8;
   canBeDigged = 1;
   canBeShaped = 1;
   diggedObjectID = 244;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1.1;
};
singleton Substance(snow)
{
   ter2_id = 25;
   terrainMaterialName = "snow";
   tunnelFloorMaterialName   = "TunnelWallsSnowMaterial";
   tunnelCeilingMaterialName = "TunnelWallsSnowMaterial";
   tunnelWallMaterialName    = "TunnelWallsSnowMaterial";
   quantity_k = 2;
   maxHeightDiffBeforeFall = 10;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 246;
   droppedObjectID = 0;
   footstepsType = "snow";
   SpeedMultiplier = 0.75;
};
singleton Substance(swamp)
{
   ter2_id = 26;
   terrainMaterialName = "Swamp";
   tunnelFloorMaterialName   = "TunnelWallsSwampMaterial";
   tunnelCeilingMaterialName = "TunnelWallsSwampMaterial";
   tunnelWallMaterialName    = "TunnelWallsSwampMaterial";
   quantity_k = 2;
   maxHeightDiffBeforeFall = 2;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "water";
   SpeedMultiplier = 0.5;
};
singleton Substance(RiverRock)
{
   ter2_id = 27;
   terrainMaterialName = "RiverRock";
   tunnelFloorMaterialName   = "TunnelWallsRiverRockMaterial";
   tunnelCeilingMaterialName = "TunnelWallsRiverRockMaterial";
   tunnelWallMaterialName    = "TunnelWallsRiverRockMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 241;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1;
};
singleton Substance(FertileWheatSmall)
{
   ter2_id = 101;
   terrainMaterialName = "FertileWheatSmall";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileWheatSmall)
{
   ter2_id = 102;
   terrainMaterialName = "NonFertileWheatSmall";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileWheatNormal)
{
   ter2_id = 103;
   terrainMaterialName = "FertileWheatNormal";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileWheatNormal)
{
   ter2_id = 104;
   terrainMaterialName = "NonFertileWheatNormal";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileWheatBig)
{
   ter2_id = 105;
   terrainMaterialName = "FertileWheatBig";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileWheatBig)
{
   ter2_id = 106;
   terrainMaterialName = "NonFertileWheatBig";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertilePeaSmall)
{
   ter2_id = 111;
   terrainMaterialName = "FertilePeaSmall";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertilePeaSmall)
{
   ter2_id = 112;
   terrainMaterialName = "NonFertilePeaSmall";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertilePeaNormal)
{
   ter2_id = 113;
   terrainMaterialName = "FertilePeaNormal";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertilePeaNormal)
{
   ter2_id = 114;
   terrainMaterialName = "NonFertilePeaNormal";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertilePeaBig)
{
   ter2_id = 115;
   terrainMaterialName = "FertilePeaBig";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertilePeaBig)
{
   ter2_id = 116;
   terrainMaterialName = "NonFertilePeaBig";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileCabbageSmall)
{
   ter2_id = 121;
   terrainMaterialName = "FertileCabbageSmall";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileCabbageSmall)
{
   ter2_id = 122;
   terrainMaterialName = "NonFertileCabbageSmall";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileCabbageNormal)
{
   ter2_id = 123;
   terrainMaterialName = "FertileCabbageNormal";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileCabbageNormal)
{
   ter2_id = 124;
   terrainMaterialName = "NonFertileCabbageNormal";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileCabbageBig)
{
   ter2_id = 125;
   terrainMaterialName = "FertileCabbageBig";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileCabbageBig)
{
   ter2_id = 126;
   terrainMaterialName = "NonFertileCabbageBig";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileOnionSmall)
{
   ter2_id = 131;
   terrainMaterialName = "FertileOnionSmall";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileOnionSmall)
{
   ter2_id = 132;
   terrainMaterialName = "NonFertileOnionSmall";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileOnionNormal)
{
   ter2_id = 133;
   terrainMaterialName = "FertileOnionNormal";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileOnionNormal)
{
   ter2_id = 134;
   terrainMaterialName = "NonFertileOnionNormal";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileOnionBig)
{
   ter2_id = 135;
   terrainMaterialName = "FertileOnionBig";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileOnionBig)
{
   ter2_id = 136;
   terrainMaterialName = "NonFertileOnionBig";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileCarrotSmall)
{
   ter2_id = 141;
   terrainMaterialName = "FertileCarrotSmall";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileCarrotSmall)
{
   ter2_id = 142;
   terrainMaterialName = "NonFertileCarrotSmall";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileCarrotNormal)
{
   ter2_id = 143;
   terrainMaterialName = "FertileCarrotNormal";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileCarrotNormal)
{
   ter2_id = 144;
   terrainMaterialName = "NonFertileCarrotNormal";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileCarrotBig)
{
   ter2_id = 145;
   terrainMaterialName = "FertileCarrotBig";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileCarrotBig)
{
   ter2_id = 146;
   terrainMaterialName = "NonFertileCarrotBig";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileFlaxSmall)
{
   ter2_id = 151;
   terrainMaterialName = "FertileFlaxSmall";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileFlaxSmall)
{
   ter2_id = 152;
   terrainMaterialName = "NonFertileFlaxSmall";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileFlaxNormal)
{
   ter2_id = 153;
   terrainMaterialName = "FertileFlaxNormal";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileFlaxNormal)
{
   ter2_id = 154;
   terrainMaterialName = "NonFertileFlaxNormal";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileFlaxBig)
{
   ter2_id = 155;
   terrainMaterialName = "FertileFlaxBig";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileFlaxBig)
{
   ter2_id = 156;
   terrainMaterialName = "NonFertileFlaxBig";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileGrapeSmall)
{
   ter2_id = 161;
   terrainMaterialName = "FertileGrapeSmall";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileGrapeSmall)
{
   ter2_id = 162;
   terrainMaterialName = "NonFertileGrapeSmall";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileGrapeNormal)
{
   ter2_id = 163;
   terrainMaterialName = "FertileGrapeNormal";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileGrapeNormal)
{
   ter2_id = 164;
   terrainMaterialName = "NonFertileGrapeNormal";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertileGrapeBig)
{
   ter2_id = 165;
   terrainMaterialName = "FertileGrapeBig";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertileGrapeBig)
{
   ter2_id = 166;
   terrainMaterialName = "NonFertileGrapeBig";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertilePotatoSmall)
{
   ter2_id = 171;
   terrainMaterialName = "FertilePotatoSmall";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertilePotatoSmall)
{
   ter2_id = 172;
   terrainMaterialName = "NonFertilePotatoSmall";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertilePotatoNormal)
{
   ter2_id = 173;
   terrainMaterialName = "FertilePotatoNormal";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertilePotatoNormal)
{
   ter2_id = 174;
   terrainMaterialName = "NonFertilePotatoNormal";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(FertilePotatoBig)
{
   ter2_id = 175;
   terrainMaterialName = "FertilePotatoBig";
   tunnelFloorMaterialName   = "TunnelFloorMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingMaterial";
   tunnelWallMaterialName    = "TunnelWallsMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 334;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(NonFertilePotatoBig)
{
   ter2_id = 176;
   terrainMaterialName = "NonFertilePotatoBig";
   tunnelFloorMaterialName   = "TunnelFloorSteppeSoilMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingSteppeSoilMaterial";
   tunnelWallMaterialName    = "TunnelWallsSteppeSoilMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 333;
   droppedObjectID = 0;
   footstepsType = "soil";
   SpeedMultiplier = 1;
};
singleton Substance(StoneRoad)
{
   ter2_id = 177;
   terrainMaterialName = "StoneRoad";
   tunnelFloorMaterialName   = "TunnelFloorRockMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingRockMaterial";
   tunnelWallMaterialName    = "TunnelWallsRockMaterial";
   quantity_k = 1;
   maxHeightDiffBeforeFall = 8;
   canBeDigged = 1;
   canBeShaped = 1;
   diggedObjectID = 241;
   droppedObjectID = 0;
   footstepsType = "rock";
   SpeedMultiplier = 1.25;
};
singleton Substance(Clay_loose)
{
   ter2_id = 178;
   terrainMaterialName = "Clay_loose";
   tunnelFloorMaterialName   = "TunnelFloorClayMaterial";
   tunnelCeilingMaterialName = "TunnelCeilingClayMaterial";
   tunnelWallMaterialName    = "TunnelWallsClayMaterial";
   quantity_k = 0.5;
   maxHeightDiffBeforeFall = 4;
   canBeDigged = 1;
   canBeShaped = 1;
   diggedObjectID = 244;
   droppedObjectID = 244;
   footstepsType = "soil";
   SpeedMultiplier = 1.1;
};
singleton Substance(Snow_loose)
{
   ter2_id = 179;
   terrainMaterialName = "Snow_loose";
   tunnelFloorMaterialName   = "TunnelWallsSnowMaterial";
   tunnelCeilingMaterialName = "TunnelWallsSnowMaterial";
   tunnelWallMaterialName    = "TunnelWallsSnowMaterial";
   quantity_k = 2;
   maxHeightDiffBeforeFall = 3;
   canBeDigged = 0;
   canBeShaped = 1;
   diggedObjectID = 246;
   droppedObjectID = 246;
   footstepsType = "snow";
   SpeedMultiplier = 0.75;
};

};
