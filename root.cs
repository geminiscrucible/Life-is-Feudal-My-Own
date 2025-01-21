
// process run once scripts
exec("scripts/run_once/main.cs");

$preloadShaderCache = true;

$appName = getEngineVersion();
$defaultGame = "scripts";
$pref::Video::ProfilePath = "core/profile";

$bindingsConfig ="data/bindings.cs";

// we don't need non-actual deadlock data in our reports
fileDelete("dumpMutex.txt");

function createCanvas(%windowTitle)
{
   dumpSysInfo("createCanvas");
   
   // Create the Canvas
   %tmp = $pref::Video::mode;
   $pref::Video::mode = "160 120 false 32 60 0";
   %foo = new GuiCanvas(Canvas);
   $pref::Video::mode = %tmp;

   if(!isObject(%foo))
      return false;

   // Set the window title
   if (isObject(Canvas) && isDebugBuild())
      Canvas.setWindowTitle($appName SPC "-" SPC getBuildString() SPC "build");
   
   return true;
}

function clientCmdTakeCameraPos(%pos)
{
   setClipboard(%pos);
}

$Con::WindowTitle = $appName;

// Load dirs
$dirCount = 1;
$userDirs = $defaultGame @ ";art";

if($dirCount == 0) {
      $userDirs = $defaultGame;
      $dirCount = 1;
}

//-----------------------------------------------------------------------------
// Display a splash window immediately to improve app responsiveness before
// engine is initialized and main window created
displaySplashWindow();

//------------------------------------------------------------------------------
// Check if a script file exists, compiled or not.
function isScriptFile(%path)
{
   if( isFile(%path @ ".dso") || isFile(%path) )
      return true;
   
   return false;
}

// Default to a new logfile each session.
if( !$logModeSpecified )
{
   if( $platform !$= "xbox" && $platform !$= "xenon" )
      setLogMode(6);
}

// Get the first dir on the list, which will be the last to be applied... this
// does not modify the list.
nextToken($userDirs, currentMod, ";");

// Execute startup scripts for each mod, starting at base and working up
function loadDir(%dir)
{
   pushback($userDirs, %dir, ";");

   if (isScriptFile(%dir @ "/main.cs"))
   exec(%dir @ "/main.cs");
}

function dumpSysInfo(%where)
{
   %sysinfoGetOwnMemoryUsage = sysinfoGetOwnMemoryUsage();
   warn("---------------------------------------- sysInfo @ "@ %where @" ----------------------------------------");
   hack("OS:", getWindowsVersionName(), "| Ver:", getWindowsVersionNum());
   hack(sysinfoGetTotalVirtualMemory, sysinfoGetTotalVirtualMemory(), "MB");
   hack(sysinfoGetUsedVirtualMemory, sysinfoGetUsedVirtualMemory(), "MB");
   hack(sysinfoGetFreeVirtualMemory, sysinfoGetFreeVirtualMemory(), "MB");
   hack(sysinfoGetOwnVirtualMemoryUsage, sysinfoGetOwnVirtualMemoryUsage(), "MB");
   hack(sysinfoGetTotalPhysicalMemory, sysinfoGetTotalPhysicalMemory(), "MB");
   hack(sysinfoGetUsedPhysicalMemory, sysinfoGetUsedPhysicalMemory(), "MB");
   hack(sysinfoGetFreePhysicalMemory, sysinfoGetFreePhysicalMemory(), "MB");
   hack(sysinfoGetOwnMemoryUsage, %sysinfoGetOwnMemoryUsage, "MB");
   hack(sysinfoGetCPUUsage, sysinfoGetCPUUsage(), "% total");
   hack(sysinfoGetOwnCPUUsage, sysinfoGetOwnCPUUsage(), "% for single core");
   if(!$tmp::runReportDone)
   {
      $tmp::runReportDone = true;
      hack(getExperienceRating, getExperienceRating());
      hack("C locale:", getCLocaleName());
      hack("icu locale:", getIcuLocaleName());
      hack("icu LCID:", getIcuLCID());
      hack("windows default locale:", getWindowsDefaultLocaleName());
      hack("windows user default locale:", getWindowsUserDefaultLocaleName());
      hack("windows LangID:", getWindowsDefaultLangID());
   }
}

dumpSysInfo("root");

echo("--------- Loading DIRS ---------");
function loadDirs(%dirPath)
{
   %dirPath = nextToken(%dirPath, token, ";");
   if (%dirPath !$= "")
      loadDirs(%dirPath);

   if(exec(%token @ "/main.cs") != true)
   {
      error("Error: Unable to find specified directory: " @ %token );
      $dirCount--;
   }
}
loadDirs($userDirs);
echo("");

if($dirCount == 0) {
   enableWinConsole(true);
   error("Error: Unable to load any specified directories");
   quit();
}
// Parse the command line arguments
echo("--------- Parsing Arguments ---------");
parseArgs();

onStart();
echo("Engine initialized...");
schedule(0, 0, setVariable, "$Con::showStartupScriptErrors", false);

// Display an error message for unused arguments
for ($i = 1; $i < $Game::argc; $i++)  {
   if (!$argUsed[$i])
      error("Error: Unknown command line argument: " @ $Game::argv[$i]);
}

//###
function cm_debug_print(%msg)
{
	if(!$bottomPrintDlgPositionChanged)
	{
		bottomPrintDlg.position = (firstWord(bottomPrintDlg.position) + 100) @ " " @ (restWords(bottomPrintDlg.position) - 30);
		$bottomPrintDlgPositionChanged = 1;
	}
	
	clientCmdBottomPrint(%msg, 0, 3);
}
//###/

exec("art/decals/materials.cs");
exec("art/decals/managedDecalData.cs");
