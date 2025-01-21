//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

// note:
//   1 geo unit = 2 meters = 4 torque world units
//   1 geo cell = 2x2 meters = 4x4 torque world units

function updateCMConfig(%serverId)
{
	$Con::showStartupScriptErrors = false;
	echo("Currently-used server:", %serverId);
	$IsUseMainWorldMapOrNewbie = %serverId < 50;
	$cm_config::Server::TerrainXCount = 3; // numbering line by line (terrains at server)
	$cm_config::Server::TerrainYCount = 3;
	if($IsUseMainWorldMapOrNewbie)
	{
		// main world
		$cm_config::Server::ServerXCount     = 7; // numbering line by line
		$cm_config::Server::ServerYCount     = 7;
		$cm_config::Server::TerrainSkipCount = 0;
		$cm_config::Server::ServerSkipCount  = 0;
	}
	else
	{
		// newbie world
		$cm_config::Server::ServerXCount     = 1; // numbering line by line
		$cm_config::Server::ServerYCount     = 1;
		$cm_config::Server::TerrainSkipCount = 441;
		$cm_config::Server::ServerSkipCount  = 49;
	}
}


// cm server confuguration constants

// database connection
// $cm_config::DB::disabled = 0; // you can disable using of database here
// $cm_config::DB::keepConnection = 1; // when true, we don't reopen connection for each query

// $cm_config::DB::Connect::db_name =  "cm";
// $cm_config::DB::Connect::server =   "127.0.0.1";
// $cm_config::DB::Connect::user =     "cm";
// $cm_config::DB::Connect::password = "cm"; 

// server/terrain counters
$cm_config::Server::TerrainXCount = 3; // numbering line by line (terrains at server)
$cm_config::Server::TerrainYCount = 3;
if(false)
{
	// main world
	$cm_config::Server::ServerXCount     = 1;//7; // numbering line by line
	$cm_config::Server::ServerYCount     = 1;//7;
	$cm_config::Server::TerrainSkipCount = 0;
	$cm_config::Server::ServerSkipCount  = 0;
}
else
{
	// newbie world
	$cm_config::Server::ServerXCount     = 1; // numbering line by line
	$cm_config::Server::ServerYCount     = 1;
	$cm_config::Server::TerrainSkipCount = 441;
	$cm_config::Server::ServerSkipCount  = 49;
}

// terrain modifications
//$cm_config::Terrain::SquareSize =            2.0; // in torque world units
$cm_config::Terrain::AllowedTunnelNearness = 2.0; // in torque world units
//$cm_config::Terrain::HeightAdjustRaise =     0.2; // in torque world units
//$cm_config::Terrain::HeightAdjustLower =    -0.2; // in torque world units
//$cm_config::Terrain::DigAdjust =             1.0; // in torque world units
//$cm_config::Terrain::MaxAltitudeDiffBeforeFall = 8.0; // in torque world units
$cm_config::Terrain::SlopeFlattenDiff =      1.0; // in torque world units

// terrain modifications timings
//$cm_config::Terrain::HeightRaiseTime  = 1000; // in milliseconds
//$cm_config::Terrain::HeightLowerTime  = 1000; // in milliseconds
//$cm_config::Terrain::DigTime          = 1000; // in milliseconds
//$cm_config::Terrain::FlattenTime      = 1000; // in milliseconds
//$cm_config::Terrain::SlopeFlattenTime = 1000; // in milliseconds

// build iteration time
//$cm_config::Building::IterationTime = 5000; // in milliseconds

// geo timbering
//$cm_config::Geo::TimberIntersectPercentForArm = 50; // 0-100
$cm_config::Geo::LightTimberWidth = 0.3; // in torque world units
$cm_config::Geo::HeavyTimberWidth = 0.4; // in torque world units

// geo decay
// $cm_config::Geo::TunnelBaseDecayResource         = 8;  // 16 bits, unsigned
// $cm_config::Geo::LightTimberDefaultDecayResource = 10; // 16 bits, unsigned

// $cm_config::Geo::TunnelDecayValue      = 1;  // 16 bits, unsigned. 0 = no decay
// $cm_config::Geo::LightTimberDecayValue = 1;  // 16 bits, unsigned. 0 = no decay
// $cm_config::Geo::HeavyTimberDecayValue = 1;  // 16 bits, unsigned. 0 = no decay

// house objects
$cm_config::Building::House::MaxArea = 100; // geo cells count

$cm_config::Building::House::Floor::Thickness = 0.05; // in torque world units
$cm_config::Building::House::Floor::Padding = 0.1; // in torque world units
$cm_config::Building::House::Floor::BottomPadding = 0; // in torque world units

$cm_config::Building::House::Ceiling::Thickness = 0.05; // in torque world units
$cm_config::Building::House::Ceiling::Padding = 0.1; // in torque world units
$cm_config::Building::House::Ceiling::BottomPadding = 3.9; // in torque world units

$cm_config::Building::House::Roof::Padding = 0; // in torque world units
$cm_config::Building::House::Roof::BottomPadding = ($cm_config::Building::House::Ceiling::BottomPadding + $cm_config::Building::House::Ceiling::Thickness);//4.0; // in torque world units
$cm_config::Building::House::Roof::SlopeAngle = 45; // in degrees

// build iteration parameters
//$cm_config::Building::MaxIterationQuantity = 100; // in kg

// geo metrics
$cm_config::Geo::SizeX = 511; // in geo units
$cm_config::Geo::SizeY = 511; // in geo units

// geo damage metrics
//$cm_config::Geo::QuantityPerLevel       = 3000;
//$cm_config::Geo::QuantityMass           = 0.01;
//$cm_config::Geo::QuantityMassMining     = 0.02;
//$cm_config::Geo::QuantityDamagePerDig   = 60000;//800;//###
//$cm_config::Geo::QuantityDamagePerLower = 3000;
//$cm_config::Geo::TunnellingRockRatio    = 0.5; // 0.0 - 1.0. For mining always uses 0.0

// EProxy // 8x8 terrain blocks //512 64 1024 for 16x16
$cm_config::EProxy::Size        = 512;  // heightmap size // power of 2
$cm_config::EProxy::SquareSize  = 64;   // in torque world units // power of 2
$cm_config::EProxy::BaseTexSize = 1024; // in pixels // power of 2

$cm_config::ObserveTerrain::fontSize1 = 12;
$cm_config::ObserveTerrain::fontSize2 = 14;
$cm_config::ObserveTerrain::fontSize3 = 16;
$cm_config::ObserveTerrain::fontSize4 = 18;
$cm_config::ObserveTerrain::fontSize5 = 20;
$cm_config::ObserveTerrain::SquareSize = 11;

// cm server functions

// function cm_config_CalcHouseMaterialQuantity(%currQuantity, %cellCount)
// {
	// return (%currQuantity + %cellCount * 2.1);
// }

// %hitSpeed in m\s
// %hitNodeName may be slashing, piercing, blunt, or anithing else (treated as incorrect type)
// %hitBoxName it is name of hitbox (shield, head, torso, rightArm, rightForearm, leftArm, leftForearm, rightThigh, rightShin, leftThigh, leftShin)
// function cm_config_CalcPlayerDmgByHit(%hitSpeed, %hitNodeName, %hitBoxName, %groupDmgLevel)
// {
	// %node_mul = 0.0;
	// %box_mul = 0.0;
	// switch$(%hitNodeName)
	// {
		// case "slashing": %node_mul = 1.7;
		// case "piercing": %node_mul = 2.0;
		// case "blunt":    %node_mul = 1.1;
		
		// default:
			// // unknown hit type
			// %hitNodeName = "unknown";
			// //return 0.0;
	// }
	
	// switch$(%hitBoxName)
	// {
		// case "shield":       %box_mul = 0.0; //return 0.0;
		// case "head":         %box_mul = 10.0;
		// case "torso":        %box_mul = 8.0;
		// case "rightArm":     %box_mul = 3.8;
		// case "rightForearm": %box_mul = 2.1;
		// case "leftArm":      %box_mul = 3.2;
		// case "leftForearm":  %box_mul = 2.0;
		// case "rightThigh":   %box_mul = 4.0;
		// case "rightShin":    %box_mul = 3.3;
		// case "leftThigh":    %box_mul = 4.0;
		// case "leftShin":     %box_mul = 3.3;
		
		// default:
			// // uncknown hitbox type
			// %hitBoxName = "unknown";
			// //return 0.0;
	// }
	
	// %ret = (%hitSpeed * %node_mul * %box_mul * %groupDmgLevel);
	// echo("DMG_CALC speed=" @ %hitSpeed @ " hitbox=" @ %hitBoxName @ " hit=" @ %hitNodeName @ " dmgLevel=" @ %groupDmgLevel @ " ret=" @ %ret);
	
	// return %ret;
// }

$hit_scale = 1.0;
$hit_scale_wait = 0.01;

// %lvl - level of player
function cm_config_CalcPlayerHitTimeScale(%lvl)
{
//echo("### get player (lvl=" @ %lvl @ ") scale: " @ ((101 - %lvl) / 100));
//	return ((101 - %lvl) / 100);

//echo("### get player (lvl=" @ %lvl @ ") scale: " @ ($hit_scale_mul));
return $hit_scale;
}

// %lvl - level of player
function cm_config_CalcPlayerPostHitTimeScale(%lvl)
{
//	return ((101 - %lvl) / 100);
return $hit_scale_wait;
}

$cm_config::Claims::FlashTimeMs =200;
$cm_config::Claims::GuildCellPrice =1;

$cm_config::Building::FilterSloppedObjectsOnUnflattenedCells =0;

$sHorseTrembleConst = 0.003;

