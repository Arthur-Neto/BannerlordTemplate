using System.Collections.Generic;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace BannerlordTemplate
{
    public class BannerlordTemplateSubModule : MBSubModuleBase // Must have a class inherting MBSubModuleBase, the entry point of the mod
    {
        protected override void OnSubModuleLoad() // Called during the first loading screen of the game, always the first override to be called, this is where you should be doing the bulk of your initial setup
        {
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Message",
                new TextObject("Message", null),
                9990,
                () =>
                {
                    InformationManager.DisplayMessage(new InformationMessage("Hello World!")); // Display message on chatlog
                },
                false)
            );

            var character = MBObjectManager.Instance.GetObject<BasicCharacterObject>("example_troop_id"); // BasicCharacterObject example

            GameEntity.Instantiate(Mission.Current.Scene, "ship_a", Agent.Main.Frame); // Example spawning a ship_a at current character location

            // Getting all loaded modules currently loaded
            var loadedMods = new List<ModuleInfo>();
            foreach (var moduleName in Utilities.GetModulesNames())
            {
                var moduleInfo = new ModuleInfo();
                moduleInfo.Load(moduleName);
                loadedMods.Add(moduleInfo);
            }
        }

        public override void BeginGameStart(Game game) // Called immediately after loading the selected game mode (submodule) has completed
        {
            base.BeginGameStart(game);
        }

        public override bool DoLoading(Game game) // Called seemingly as loading is ending, not entirely sure of this one
        {
            return base.DoLoading(game);
        }

        public override void OnCampaignStart(Game game, object starterObject) // Called once any game mode is started
        {
            base.OnCampaignStart(game, starterObject);
        }

        public override void OnGameEnd(Game game) // Called on exiting out of a mission/campaign
        {
            base.OnGameEnd(game);
        }

        public override void OnGameInitializationFinished(Game game) // Called once the initialisation for a game mode has finished
        {
            base.OnGameInitializationFinished(game);
        }

        public override void OnGameLoaded(Game game, object initializerObject) // Called only after loading a save
        {
            base.OnGameLoaded(game, initializerObject);
        }

        public override void OnMissionBehaviourInitialize(Mission mission) // Called once a mission is started and behaviours are to be initialized
        {
            base.OnMissionBehaviourInitialize(mission);
        }

        public override void OnMultiplayerGameStart(Game game, object starterObject)
        {
            base.OnMultiplayerGameStart(game, starterObject);
        }

        public override void OnNewGameCreated(Game game, object initializerObject) // Called when starting a new save in the campaign mode specifically
        {
            base.OnNewGameCreated(game, initializerObject);
        }

        /// <summary>
        /// This is called once every frame, you should avoid expensive operations being called directly here and instead do as little work as possible for performance reasons.
        /// </summary>
        /// <param name="dt">The time in milliseconds the frame took to complete</param> 
        protected override void OnApplicationTick(float dt)
        {
            base.OnApplicationTick(dt);
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot() // Called just before the main menu first appears, helpful if your mod depends on other things being set up during the initial load
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject) // Called immediately upon loading after selecting a game mode (submodule) from the main menu
        {
            base.OnGameStart(game, gameStarterObject);
        }

        protected override void OnSubModuleUnloaded() // Called when exiting Bannerlord entirely
        {
            base.OnSubModuleUnloaded();
        }
    }
}
