using System;
using System.Linq;
using System.Collections.Generic;
using NCMS.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using ReflectionUtility;
using DG.Tweening;
using MoreRaces;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HarmonyLib;

namespace MoreRaces
{
    class MoreRacesBuilds
    {
     private List<BuildingAsset> humanBuildings = new List<BuildingAsset>();
     public void init()
     {               
     foreach (BuildingAsset humanBuilding in AssetManager.buildings.list)
     {
      if (humanBuilding.race == "human")
        {
         humanBuildings.Add(humanBuilding);
        }
     }
     foreach(var race in MoreRacesRaceLibrary.additionalRaces){
     if(race == "orange_slime")
     {
     initorange_slime();
     }
     if(race == "royal_slime")
     {
     initroyal_slime();
     }
     }
    }
         //Cuando creemos nuevas debemos inicializarlas en como esta funcion
        private static void initorange_slime()
        {
            //No moficiar ningun valor, a menos que agregues nuevas imagenes en su lugar correspondiente
            RaceBuildOrderAsset pAsset = new RaceBuildOrderAsset();
            pAsset.id = "orange_slime";
            AssetManager.race_build_orders.add(pAsset);
            pAsset.addBuilding("bonfire", 1);
            pAsset.addBuilding("tent_orange_slime", pHouseLimit: true);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire");
            pAsset.addUpgrade("tent_orange_slime");
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("tent_orange_slime");
            addVariantsUpgrade(pAsset, "house_orange_slime", List.Of<string>("hall_orange_slime")); //AQUI CAMBIAR IMAGEN
            addVariantsUpgrade(pAsset, "1house_orange_slime", List.Of<string>("1hall_orange_slime"));//AQUI CAMBIAR IMAGEN
            addVariantsUpgrade(pAsset, "2house_orange_slime", List.Of<string>("1hall_orange_slime"));//AQUI CAMBIAR IMAGEN
            addVariantsUpgrade(pAsset, "3house_orange_slime", List.Of<string>("2hall_orange_slime"));//AQUI CAMBIAR IMAGEN
            addVariantsUpgrade(pAsset, "4house_orange_slime", List.Of<string>("2hall_orange_slime"));//AQUI CAMBIAR IMAGEN
            pAsset.addUpgrade("hall_orange_slime", pPop: 30, pBuildings: 8);//AQUI CAMBIAR IMAGEN
            pAsset.addUpgrade("1hall_orange_slime", pPop: 100, pBuildings: 20);//AQUI CAMBIAR IMAGEN
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("statue", "mine", "barracks_orange_slime");//AQUI CAMBIAR IMAGEN
            pAsset.addUpgrade("fishing_docks_orange_slime");//AQUI CAMBIAR IMAGEN
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("fishing_docks_orange_slime");//AQUI CAMBIAR IMAGEN
            pAsset.addBuilding("windmill_orange_slime", 1, pPop: 6, pBuildings: 5);//AQUI CAMBIAR IMAGEN
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire");
            pAsset.addUpgrade("windmill_orange_slime", pPop: 40, pBuildings: 10);//AQUI CAMBIAR IMAGEN
            pAsset.addBuilding("fishing_docks_orange_slime", 5, pBuildings: 2);//AQUI CAMBIAR IMAGEN
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire");
            pAsset.addBuilding("well", 1, pPop: 20, pBuildings: 10);
            BuildOrderLibrary.b.requirements_types = List.Of<string>("hall");
            pAsset.addBuilding("hall_orange_slime", 1, pPop: 10, pBuildings: 6);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire");
            BuildOrderLibrary.b.requirements_types = List.Of<string>("house");
            pAsset.addBuilding("mine", 1, pPop: 20, pBuildings: 10);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire", "hall_orange_slime");//AQUI CAMBIAR IMAGEN
            pAsset.addBuilding("barracks_orange_slime", 1, pPop: 50, pBuildings: 16, pMinZones: 20);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("1hall_orange_slime");//AQUI CAMBIAR IMAGEN
            pAsset.addBuilding("watch_tower_orange_slime", 1, pPop: 30, pBuildings: 10);//AQUI CAMBIAR IMAGEN
            pAsset.addUpgrade("watch_tower_orange_slime" , 0, 0, 3, 3, false, false, 0);//AQUI CAMBIAR IMAGEN
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire", "hall_orange_slime");//AQUI CAMBIAR IMAGEN
            pAsset.addBuilding("temple_orange_slime", 1, pPop: 90, pBuildings: 20, pMinZones: 20);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire", "1hall_orange_slime", "statue");//AQUI CAMBIAR IMAGEN
            pAsset.addBuilding("statue", 1, pPop: 70, pBuildings: 15);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("1hall_orange_slime");//AQUI CAMBIAR IMAGEN
        }
//No modificar esta funcion

 private static void initroyal_slime()
        {
            RaceBuildOrderAsset pAsset = new RaceBuildOrderAsset();
            pAsset.id = "royal_slime";
            AssetManager.race_build_orders.add(pAsset);
            pAsset.addBuilding("bonfire", 1);
            pAsset.addBuilding("tent_royal_slime", pHouseLimit: true);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire");
            pAsset.addUpgrade("tent_royal_slime");
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("tent_royal_slime");
            addVariantsUpgrade(pAsset, "house_royal_slime", List.Of<string>("hall_royal_slime"));
            addVariantsUpgrade(pAsset, "1house_royal_slime", List.Of<string>("1hall_royal_slime"));
            addVariantsUpgrade(pAsset, "2house_royal_slime", List.Of<string>("1hall_royal_slime"));
            addVariantsUpgrade(pAsset, "3house_royal_slime", List.Of<string>("2hall_royal_slime"));
            addVariantsUpgrade(pAsset, "4house_royal_slime", List.Of<string>("2hall_royal_slime"));
            pAsset.addUpgrade("hall_royal_slime", pPop: 30, pBuildings: 8);
            pAsset.addUpgrade("1hall_royal_slime", pPop: 100, pBuildings: 20);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("statue", "mine", "barracks_royal_slime");
            pAsset.addUpgrade("fishing_docks_royal_slime");
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("fishing_docks_royal_slime");
            pAsset.addBuilding("windmill_royal_slime", 1, pPop: 6, pBuildings: 5);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire");
            pAsset.addUpgrade("windmill_royal_slime", pPop: 40, pBuildings: 10);
            pAsset.addBuilding("fishing_docks_royal_slime", 5, pBuildings: 2);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire");
            pAsset.addBuilding("well", 1, pPop: 20, pBuildings: 10);
            BuildOrderLibrary.b.requirements_types = List.Of<string>("hall");
            pAsset.addBuilding("hall_royal_slime", 1, pPop: 10, pBuildings: 6);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire");
            BuildOrderLibrary.b.requirements_types = List.Of<string>("house");
            pAsset.addBuilding("mine", 1, pPop: 20, pBuildings: 10);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire", "hall_royal_slime");
            pAsset.addBuilding("barracks_royal_slime", 1, pPop: 50, pBuildings: 16, pMinZones: 20);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("1hall_royal_slime");
            pAsset.addBuilding("watch_tower_royal_slime", 1, pPop: 30, pBuildings: 10);
            pAsset.addUpgrade("watch_tower_royal_slime" , 0, 0, 3, 3, false, false, 0);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire", "hall_royal_slime");
            pAsset.addBuilding("temple_royal_slime", 1, pPop: 90, pBuildings: 20, pMinZones: 20);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("bonfire", "1hall_royal_slime", "statue");
            pAsset.addBuilding("statue", 1, pPop: 70, pBuildings: 15);
            BuildOrderLibrary.b.requirements_orders = List.Of<string>("1hall_royal_slime");
        }

        private void loadSprites(BuildingAsset pTemplate)
        {
            string folder = pTemplate.race;
            if (folder == string.Empty)
            {
                folder = "Others";
            }
            folder = folder + "/" + pTemplate.id;
            Sprite[] array = Utils.ResourcesHelper.loadAllSprite("buildings/" + folder, 0.5f, 0.0f);

            pTemplate.sprites = new BuildingSprites();
            foreach (Sprite sprite in array)
            {
                string[] array2 = sprite.name.Split(new char[] { '_' });
                string text = array2[0];
                int num = int.Parse(array2[1]);

                if (array2.Length == 3)
                {
                    int.Parse(array2[2]);
                }
                while (pTemplate.sprites.animationData.Count < num + 1)
                {
                    pTemplate.sprites.animationData.Add(null);
                }
                if (pTemplate.sprites.animationData[num] == null)
                {
                    pTemplate.sprites.animationData[num] = new BuildingAnimationDataNew();
                }
                BuildingAnimationDataNew buildingAnimationDataNew = pTemplate.sprites.animationData[num];
                if (text.Equals("main"))
                {
                    buildingAnimationDataNew.list_main.Add(sprite);
                    if (buildingAnimationDataNew.list_main.Count > 1)
                    {
                        buildingAnimationDataNew.animated = true;
                    }
                }
                else if (text.Equals("ruin"))
                {
                    buildingAnimationDataNew.list_ruins.Add(sprite);
                }
                else if (text.Equals("special"))
                {
                    buildingAnimationDataNew.list_special.Add(sprite);
                }
                else if (text.Equals("mini"))
                {
                    pTemplate.sprites.mapIcon = new BuildingMapIcon(sprite);
                }
            }
            foreach (BuildingAnimationDataNew buildingAnimationDataNew2 in pTemplate.sprites.animationData)
            {
                buildingAnimationDataNew2.main = buildingAnimationDataNew2.list_main.ToArray();
                buildingAnimationDataNew2.ruins = buildingAnimationDataNew2.list_ruins.ToArray();
                buildingAnimationDataNew2.special = buildingAnimationDataNew2.list_special.ToArray();
            }
           
        }
        private static void addVariantsUpgrade(RaceBuildOrderAsset pAsset, string name, List<string> requirementsBuildings){
            foreach(var race in MoreRacesRaceLibrary.defaultRaces){
                pAsset.addUpgrade($"{name}_{race}");
                BuildOrderLibrary.b.requirements_orders = requirementsBuildings;
            }
        }
    }
}