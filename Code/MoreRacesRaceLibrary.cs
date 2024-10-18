using HarmonyLib;
using System;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using ReflectionUtility;
using System.Threading;
using System.Text;
using System.IO;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using System.Reflection.Emit;
using ai;

namespace MoreRaces{
    class MoreRacesRaceLibrary
    {
        // No modifcar estas variables
        internal static List<string> defaultRaces = new List<string>(){
            "human", "elf", "orc", "dwarf"
        };

        internal static List<string> human = new List<string>(){
            "human"
        };

        //Aqui agregar los nombres clave de las unidades en minusculas y separadas por , (coma)
        internal static List<string> additionalRaces = new List<string>(){
            "orange_slime", "royal_slime"//Seguir el ejemplo
        };
        
        internal void init(){

            var orange_slime = AssetManager.raceLibrary.clone("orange_slime", "human"); //orange_slime es el ID es el asset ID
            //Estadisticas de su raza i imperio
            orange_slime.civ_baseCities =  5;
            orange_slime.civ_base_army_mod  = 0.9f;
            orange_slime.civ_base_zone_range = 4;
            orange_slime.culture_rate_tech_limit = 5;
            orange_slime.culture_knowledge_gain_per_intelligence = 2.0f;
            //No modificar
            orange_slime.build_order_id = "kingdom_base";
            orange_slime.path_icon = "ui/Icons/iconorange_slime";
            orange_slime.nameLocale = "orange_slime";
            orange_slime.banner_id= "elf";
            orange_slime.main_texture_path = "races/orange_slime/";
            orange_slime.name_template_city = "elf_city";
            orange_slime.name_template_kingdom = "elf_kingdom";
            orange_slime.name_template_culture = "elf_culture";
            orange_slime.name_template_clan = "elf_clan";
            orange_slime.production = new string[] { "jam","pie","tea" }; // Posibles items que produce
            //No modificar
            orange_slime.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1"});
            orange_slime.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1"});
            orange_slime.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1"});
            orange_slime.nomad_kingdom_id = $"nomads_{orange_slime.id}";

            //Armas preferidas, comida y estadisticas
            orange_slime.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#3,warfare#5,stewardship#4,intelligence#2");
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "meat#5,fish#4,berries#1");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "sword", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "bow", 5);

            //Añade los archivo pn de las estructuras
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_orange_slime");
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_orange_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_orange_slime");
            // Agrega los archivos default de las estructuras miscelaneas
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);

             var royal_slime = AssetManager.raceLibrary.clone("royal_slime", "human");
            royal_slime.civ_baseCities =  6;
            royal_slime.civ_base_army_mod  = 0.9f;
            royal_slime.civ_base_zone_range = 5;
            royal_slime.culture_rate_tech_limit = 4;
            royal_slime.culture_knowledge_gain_per_intelligence = 2.0f;
            royal_slime.build_order_id = "kingdom_base";
            royal_slime.path_icon = "ui/Icons/iconroyal_slime";
            royal_slime.nameLocale = "royal_slime";
            royal_slime.banner_id= "elf";
            royal_slime.main_texture_path = "races/royal_slime/";
            royal_slime.name_template_city = "elf_city";
            royal_slime.name_template_kingdom = "elf_kingdom";
            royal_slime.name_template_culture = "elf_culture";
            royal_slime.name_template_clan = "elf_clan";
            royal_slime.production = new string[] { "jam","pie","tea" };
            royal_slime.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1"});
            royal_slime.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1"});
            royal_slime.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1"});
            royal_slime.nomad_kingdom_id = $"nomads_{royal_slime.id}";
            royal_slime.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#3,warfare#5,stewardship#4,intelligence#2");
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "meat#5,fish#4,berries#1");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "spear", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "sword", 5);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_royal_slime");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(ActorAnimationLoader), "loadAnimationBoat")]
        public static bool loadAnimationBoat_Prefix(ref string pTexturePath, ActorAnimationLoader __instance)
        {
        if (pTexturePath.EndsWith("_"))
        {
         pTexturePath = pTexturePath + "human";
         return true;
        }
        foreach (string race in Main.instance.addRaces)
        {
        if (race == "orange_slime") //Aarega aqui tambien tu unidad cuando la crees
         {
          pTexturePath = pTexturePath.Replace(race, "orange_slime");
         }
         
         else if (race == "royal_slime")
         {
          pTexturePath = pTexturePath.Replace(race, "royal_slime");
         }
        }
        return true;
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(ActorAnimationLoader), "generateFrameData")]
        
        public static void generateFrameData_post(ActorAnimationLoader __instance,string pFrameString, AnimationContainerUnit pAnimContainer, Dictionary<string, Sprite> pFrames, string pFramesIDs)
        {

        }
//Funcion de sprites, modificar si sabes lo que haces a la hora de cargar los sprites
        public static Sprite[] loadAllSprite(string path, bool withFolders = false)
        {
            string p = $"{Main.mainPath}/EmbededResources/{path}";
            DirectoryInfo folder = new DirectoryInfo(p);
            List<Sprite> res = new List<Sprite>();
            foreach (FileInfo file in folder.GetFiles("*.png"))
            {
                Sprite sprite = Sprites.LoadSprite($"{file.FullName}");
                sprite.name = file.Name.Replace(".png", "");
                res.Add(sprite);
            }
            foreach (DirectoryInfo cFolder in folder.GetDirectories())
            {
                foreach (FileInfo file in cFolder.GetFiles("*.png"))
                {
                    Sprite sprite = Sprites.LoadSprite($"{file.FullName}");
                    sprite.name = file.Name.Replace(".png", "");
                    res.Add(sprite);
                }
            }
            return res.ToArray();
        }
    }
}