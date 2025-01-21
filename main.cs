//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

// Load up core script base
loadDir("core"); // Should be loaded at a higher level, but for now leave -- SRZ 11/29/07

//-----------------------------------------------------------------------------
// Package overrides to initialize the mod.
package LiF {

function parseArgs()
{
   // Call the parent
   Parent::parseArgs();

   // Arguments, which override everything else.
   for (%i = 1; %i < $Game::argc ; %i++)
   {
      %arg = $Game::argv[%i];
      %nextArg = $Game::argv[%i+1];
      %hasNextArg = $Game::argc - %i > 1;
   
      switch$ (%arg)
      {
         //--------------------
         case "-connect":
            $argUsed[%i]++;
            if (%hasNextArg) {
               $JoinGameAddress = %nextArg;
               $argUsed[%i+1]++;
               %i++;
            }
            else
               error("Error: Missing Command Line argument. Usage: -connect <ip_address>");

//CM_CHANGE
         case "-ID":
            $argUsed[%i]++;
            if (%hasNextArg) {
               $accountID = %nextArg;
               $argUsed[%i+1]++;
               %i++;
            }
            else
               error("Error: ID is empty");

         case "-Login":
            $argUsed[%i]++;
            if (%hasNextArg) {
               $playerName = %nextArg;
               $argUsed[%i+1]++;
               %i++;
            }
            else
               error("Error: Login is empty");
         case "-Token":
            $argUsed[%i]++;
            if (%hasNextArg) {
               $playerToken = %nextArg;
               $argUsed[%i+1]++;
               %i++;
            }
            else
               error("Error: Token is empty");
//CM_CHANGE/
      }
   }
}

function onStart()
{
   // The core does initialization which requires some of
   // the preferences to loaded... so do that first.  
   exec( "./client/defaults.cs" );
             
   Parent::onStart();
   echo("\n--------- Initializing Directory: scripts ---------");

   // Load the scripts that start it all...
   exec("./client/init.cs");
   //exec("./server/init.cs");
   
   // Init the physics plugin.
   physicsInit();
      
   // Start up the audio system.
   sfxStartup();

   initClient();
   
   TerrainBlock::initHighlightShader();

   exec("./CombatConstants.cs");
   exec("./heraldryConfig.cs");

   // Use our prefs to configure our Canvas/Window
   configureCanvas();

   // Close splash window after we have updated canvas
   // The delay is needed here in order to be sure that canvas preloads everything
   // and "ready to serve", so we schedule the guaranteed closing of splash window
   // on next tick, so we immideately gaining control on DX11 gui window
   schedule(32, 0, closeSplashWindow);

   if($simpleAuth == false)
   {
      EULA();
   }
   else//$simpleAuth == true
   {
      initManagersOnCharSelected("simpleAuthManagersLoaded();");
   }
}

function simpleAuthManagersLoaded()
{
      EULA();
}

// this function initializes variable editors, for now only particle editor
function initializeEditors()
{
   exec("./undoManager.ed.cs");
   exec("./materialEditor/main.cs");
   
   initializeMaterialEditor();
   
   exec("./particleEditor/main.cs");
   
   initializeParticleEditor();
}

function onExit()
{
   disconnectQuit();
   
   // Destroy the physics plugin.
   physicsDestroy();
      
   echo("Exporting client prefs");
   export("$pref::*", "data/prefs.cs", False);

   // clear light proto
   if(isObject(LightPrototypesGroup))
      LightPrototypesGroup.delete();
   if(isObject(EnvironmentGroup))
      EnvironmentGroup.delete();

   TerrainBlock::deleteHighlightShader();
   EProxy::deleteRenderShaders();
   ERenderMan::deleteRenderShaders();

   Parent::onExit();
}

}; // package LiF

// Activate the game package.
activatePackage(LiF);
