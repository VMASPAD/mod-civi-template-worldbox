using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ReflectionUtility;
using System.Reflection;
using HarmonyLib;
using Newtonsoft.Json;
using static Config;

namespace MoreRaces
{
    class MoreRacesButtons
    {
        // Crea la funcion para crear el Tab con el id del boton y que contenido debe mostrar
        public static void init()
        {
            MoreRacesTab.createTab("Button Tab_MoreRaces", "Tab_MoreRaces", "ExampleCivilizationAnimal", "ExampleCivilizationAnimal", -150);
            loadButtons();
        }

// funcion que carga los botones,
        private static void loadButtons()
        {
            PowersTab MoreRacesTab = getPowersTab("MoreRaces");

            #region races

// Crea las variables de los botones, con su respectivo id, nombre, descripcion, imagen, tamaño, tipo de boton y donde se mostrara, no se recomienda modificar, solo copiar
            var orange_slime = new GodPower();
            orange_slime.id = "spawnorange_slime";
            orange_slime.showSpawnEffect = true;
            orange_slime.multiple_spawn_tip = true;
            orange_slime.actorSpawnHeight = 3f;
            orange_slime.name = "spawnorange_slime";
            orange_slime.spawnSound = "spawnelf";
            orange_slime.actor_asset_id = "unit_orange_slime";
            orange_slime.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(orange_slime);

            var buttonorange_slime = NCMS.Utils.PowerButtons.CreateButton(
            "spawnorange_slime",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconorange_slime.png"),
            "The Orange Slime",
            "Cute little fellas",
            new Vector2(72, 18),
            ButtonType.GodPower, 
            MoreRacesTab.transform,
            null
            );


            var royal_slime = new GodPower();
            royal_slime.id = "spawnroyal_slime";
            royal_slime.showSpawnEffect = true;
            royal_slime.multiple_spawn_tip = true;
            royal_slime.actorSpawnHeight = 3f;
            royal_slime.name = "spawnroyal_slime";
            royal_slime.spawnSound = "spawnhuman";
            royal_slime.actor_asset_id = "unit_royal_slime";
            royal_slime.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(royal_slime);

            var buttonroyal_slime = NCMS.Utils.PowerButtons.CreateButton(
            "spawnroyal_slime",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconroyal_slime.png"),
            "The royal Slime",
            "Royal little fellas",           
            new Vector2(108, 18),
            ButtonType.GodPower, 
            MoreRacesTab.transform,
            null
            );
            #endregion

        }

        //No modificar nada de esta funcion ni la siguiente
        public static bool callSpawnUnit(WorldTile pTile, string pPowerID)
        {
            AssetManager.powers.CallMethod("spawnUnit", pTile, pPowerID);
            return true;
        }
        private static PowersTab getPowersTab(string id)
		{
		GameObject gameObject = GameObjects.FindEvenInactive("Tab_" + id);
		return gameObject.GetComponent<PowersTab>();
        }
    }
}