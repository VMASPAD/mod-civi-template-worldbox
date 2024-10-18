using System;
using System.Linq;
using System.Collections.Generic;
using NCMS.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using ReflectionUtility;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Beebyte.Obfuscator;
using HarmonyLib;

namespace MoreRaces{
    class MoreRacesRaces
    {
        public static void init(){

            var orange_slime = AssetManager.actor_library.clone("unit_orange_slime", "unit_human"); //Solo modificar si unit_orange_slime cambias la key de addRaces en Main.cs, modifica apartir desde unit_
            // Estos valores son los valores base de la unidad, si quieres modificarlos, puedes hacerlo aquí.
            orange_slime.base_stats[S.max_age] = 60;
            orange_slime.base_stats[S.max_children] = 40f;
            // Estadisticas base de cada unidad
            orange_slime.setBaseStats(158, 41, 10, 0, 12, 85, 0);

            //Datos de efectos de sonido NO MODIFICAR
            orange_slime.nameLocale = "orange_slime";
            orange_slime.nameTemplate = "elf_name";
            orange_slime.race = "orange_slime";
            orange_slime.icon = "iconorange_slime";
            orange_slime.zombieID = "zombie";
            orange_slime.fmod_spawn = "event:/SFX/UNITS/Elf/ElfSpawn";
		    orange_slime.fmod_attack = "event:/SFX/UNITS/Orc/OrcAttack";
		    orange_slime.fmod_idle = "event:/SFX/UNITS/Orc/OrcIdle";
		    orange_slime.fmod_death = "event:/SFX/UNITS/Orc/OrcDeath";
            //Color de la unidad en la vista satelital
            orange_slime.color = Toolbox.makeColor("#15918F");
            //Animacion de saltar, modificar si lo requieres
            orange_slime.disableJumpAnimation = true;
            //La cabeza seperada del cuerpo, no modificar
            orange_slime.body_separate_part_head = false;
            //Rasgos iniciales cuando aparece el slime
            AssetManager.actor_library.CallMethod("addTrait", "acid_blood");
            AssetManager.actor_library.CallMethod("addTrait", "acid_proof");
	        AssetManager.actor_library.CallMethod("addTrait", "acid_touch");
            AssetManager.actor_library.CallMethod("addTrait", "regeneration");
	        AssetManager.actor_library.CallMethod("addTrait", "immortal");
            //Crea la sombra de la unidad
            AssetManager.actor_library.CallMethod("loadShadow", orange_slime); // NO MODIFICAR, solo cambiar la variable
            Localization.addLocalization(orange_slime.nameLocale, orange_slime.nameLocale);

            var babyorange_slime = AssetManager.actor_library.clone("baby_orange_slime", "unit_orange_slime");//Solo modificar si unit_orange_slime cambias la key de addRaces en Main.cs, modifica apartir desde baby_ Y TENER EN CUENTA QUE SON MODIFICAIONES DEL BEBE
            // Estos valores son los valores base de la unidad, si quieres modificarlos, puedes hacerlo aquí.
            babyorange_slime.base_stats[S.speed] = 12f;
            //Separa la cabeza de cuerpo al igual que las manos, modificar dependiendo de tu sprite, aunque todavia no hay otro metodo para usar su funcion, si la tienes entonces puedes modificarla
            babyorange_slime.body_separate_part_head = false;
            babyorange_slime.body_separate_part_hands = false;
            // Si puede usar items
            babyorange_slime.take_items = false;
            // Define si es un bebe
            babyorange_slime.baby = true;
            //Si se convierte en un demonio en la epoca del caos
            babyorange_slime.can_turn_into_demon_in_age_of_chaos = false;
            babyorange_slime.canTurnIntoIceOne = true;
            // Desabilita la funcion de saltar en la animacion
            babyorange_slime.disableJumpAnimation = true;
            
            //Animacion de camninar, nombre de archivo
            babyorange_slime.animation_idle = "walk_3";
            //ID DE LA UNIDAD, SI MODIFICAS ESTE VALOR, TIENES QUE MODIFICARLO EN TODOS LOS LUGARES QUE SE REPITE
            babyorange_slime.growIntoID = "unit_orange_slime";
            //Desconocido, NO MODIFICAR, se entiende que que se aplican los colores o la unidad cuando crece o pasa la siguiente etapa
            babyorange_slime.color_sets = orange_slime.color_sets;
            //Estadisticas base de la unidad
            AssetManager.actor_library.CallMethod("addTrait", "peaceful");
            AssetManager.actor_library.CallMethod("addTrait", "acid_blood");
            AssetManager.actor_library.CallMethod("addTrait", "acid_proof");
	        AssetManager.actor_library.CallMethod("addTrait", "acid_touch");
            AssetManager.actor_library.CallMethod("addTrait", "regeneration");
	        AssetManager.actor_library.CallMethod("addTrait", "immortal");
            //Crea la sombra de la unidad
            AssetManager.actor_library.CallMethod("loadShadow", babyorange_slime);

var royal_slime = AssetManager.actor_library.clone("unit_royal_slime", "unit_human");
            royal_slime.base_stats[S.max_age] = 60;
            royal_slime.base_stats[S.max_children] = 40f;
            royal_slime.setBaseStats(765, 224, 10, 0, 12, 85, 0);
            royal_slime.nameLocale = "royal_slime";
            royal_slime.nameTemplate = "human_name";
            royal_slime.race = "royal_slime";
            royal_slime.icon = "iconroyal_slime";
            royal_slime.zombieID = "zombie";
            royal_slime.fmod_spawn = "event:/SFX/UNITS/Orc/OrcSpawn";
		    royal_slime.fmod_attack = "event:/SFX/UNITS/Orc/OrcAttack";
		    royal_slime.fmod_idle = "event:/SFX/UNITS/Orc/OrcIdle";
		    royal_slime.fmod_death = "event:/SFX/UNITS/Orc/OrcDeath";
            royal_slime.color = Toolbox.makeColor("#3D251E");
            royal_slime.disableJumpAnimation = true;
            royal_slime.body_separate_part_head = false;
            AssetManager.actor_library.CallMethod("addTrait", "acid_blood");
            AssetManager.actor_library.CallMethod("addTrait", "acid_proof");
	        AssetManager.actor_library.CallMethod("addTrait", "acid_touch");
            AssetManager.actor_library.CallMethod("addTrait", "regeneration");
            AssetManager.actor_library.CallMethod("addTrait", "immortal");
            AssetManager.actor_library.CallMethod("loadShadow", royal_slime);
            Localization.addLocalization(royal_slime.nameLocale, royal_slime.nameLocale);

            var babyroyal_slime = AssetManager.actor_library.clone("baby_royal_slime", "unit_royal_slime");
            babyroyal_slime.base_stats[S.speed] = 12f;
            babyroyal_slime.body_separate_part_head = false;
            babyroyal_slime.body_separate_part_hands = false;
            babyroyal_slime.take_items = false;
            babyroyal_slime.baby = true;
            babyroyal_slime.can_turn_into_demon_in_age_of_chaos = false;
            babyroyal_slime.canTurnIntoIceOne = true;
            babyroyal_slime.disableJumpAnimation = true;
            babyroyal_slime.animation_idle = "walk_3";
            babyroyal_slime.growIntoID = "unit_royal_slime";
            babyroyal_slime.color_sets = royal_slime.color_sets;
            AssetManager.actor_library.CallMethod("addTrait", "peaceful");
            AssetManager.actor_library.CallMethod("addTrait", "acid_blood");
            AssetManager.actor_library.CallMethod("addTrait", "acid_proof");
	        AssetManager.actor_library.CallMethod("addTrait", "acid_touch");
            AssetManager.actor_library.CallMethod("addTrait", "regeneration");
            AssetManager.actor_library.CallMethod("addTrait", "immortal");
            AssetManager.actor_library.CallMethod("loadShadow", babyroyal_slime);
        
        }
    }
}