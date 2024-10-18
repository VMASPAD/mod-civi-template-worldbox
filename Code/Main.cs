using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using ReflectionUtility;
using HarmonyLib;
using System.Reflection;

namespace MoreRaces{
    [ModEntry]
    class Main : MonoBehaviour{
        #region
        public static Main instance;
        public MoreRacesRaceLibrary MoreRacesRaceLibrary = new MoreRacesRaceLibrary();
        #endregion
        internal const string id = "agriche.mods.worldbox.MoreRaces";
        internal static Harmony harmony;
        internal static Dictionary<string, UnityEngine.Object> modsResources;
        public List<string> addRaces = new List<string>(){"orange_slime", "royal_slime"}; //Los ID de tus razas
        public MoreRacesBuilds MoreRacesBuilds = new MoreRacesBuilds();
        public BuildingLibrary buildingLibrary = new BuildingLibrary();
        public const string mainPath = "Mods/MoreRaces";
//Inicializa la funcion y llama a las demas funciones para crear la unidad 
        void Awake(){
            modsResources = Reflection.GetField(typeof(ResourcesPatch), null, "modsResources") as Dictionary<string, UnityEngine.Object>;
            harmony = new Harmony(id);
            MoreRacesKingdoms.init();
            MoreRacesBuilds.init();
            buildingLibrary.init();
            MoreRacesRaces.init();
            MoreRacesRaceLibrary.init();
            MoreRacesTab.init();
            MoreRacesButtons.init();
            var dictItems = Reflection.GetField(typeof(ActorAnimationLoader), null, "dictItems") as Dictionary<string, Sprite>;
            ActorAnimationLoader.loadAnimationBoat($"boat_fishing");
            var fairy = AssetManager.actor_library.get("fairy");
            fairy.traits.Remove("energized");
            var bandit = AssetManager.actor_library.get("bandit");
            bandit.traits.Remove("energized");
            //Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "goblin");
            instance = this;
        }
        void Start()
        {
        Harmony.CreateAndPatchAll(typeof(MoreRacesRaceLibrary));
        }
    }
}