using System;
using System.Linq;
using System.Collections.Generic;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using ReflectionUtility;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HarmonyLib;

namespace MoreRaces{
    class MoreRacesKingdoms
    {
        public static void init(){

//Obtiene los ID de los reinos de cada raza en sus dos estados
            KingdomAsset human = AssetManager.kingdoms.get("human");
			KingdomAsset elf = AssetManager.kingdoms.get("elf");
			KingdomAsset orc = AssetManager.kingdoms.get("orc");
			KingdomAsset dwarf = AssetManager.kingdoms.get("dwarf");
            KingdomAsset nomads_human = AssetManager.kingdoms.get("nomads_human");
			KingdomAsset nomads_elf = AssetManager.kingdoms.get("nomads_elf");
			KingdomAsset nomads_orc = AssetManager.kingdoms.get("nomads_orc");
			KingdomAsset nomads_dwarf = AssetManager.kingdoms.get("nomads_dwarf");

//Aqui define su hacia tu raza que creaste, repite el mismo proceso para cada raza que creaste
            human.addEnemyTag("orange_slime");
            human.addEnemyTag("nomads_orange_slime");
            nomads_human.addEnemyTag("orange_slime");
            nomads_human.addEnemyTag("nomads_orange_slime");
            nomads_human.addEnemyTag("nomads_royal_slime");
            nomads_human.addEnemyTag("royal_slime");
            human.addEnemyTag("nomads_royal_slime");
            human.addEnemyTag("royal_slime");

            elf.addEnemyTag("orange_slime");
            elf.addEnemyTag("nomads_orange_slime");
            elf.addEnemyTag("nomads_royal_slime");
            elf.addEnemyTag("royal_slime");
           
          
            nomads_elf.addEnemyTag("orange_slime");
            nomads_elf.addEnemyTag("nomads_orange_slime");
            nomads_elf.addEnemyTag("nomads_royal_slime");
            nomads_elf.addEnemyTag("royal_slime");
    



            dwarf.addEnemyTag("orange_slime");
            dwarf.addEnemyTag("nomads_orange_slime");
            dwarf.addEnemyTag("royal_slime");
            dwarf.addEnemyTag("nomads_royal_slime");
    
            nomads_dwarf.addEnemyTag("orange_slime");
            nomads_dwarf.addEnemyTag("nomads_orange_slime");
            nomads_dwarf.addEnemyTag("royal_slime");
            nomads_dwarf.addEnemyTag("nomads_royal_slime");
    


            orc.addEnemyTag("orange_slime");
            orc.addEnemyTag("nomads_orange_slime");
            orc.addEnemyTag("royal_slime");
            orc.addEnemyTag("nomads_royal_slime");
         
            nomads_orc.addEnemyTag("orange_slime");
            nomads_orc.addEnemyTag("nomads_orange_slime");
            nomads_orc.addEnemyTag("royal_slime");
            nomads_orc.addEnemyTag("nomads_royal_slime");
     

//Aqui define su ID, y los estados que tiene contra las demas razas
            var orange_slime = new KingdomAsset();
            orange_slime.id = "orange_slime";
            orange_slime.civ = true;
            orange_slime.addTag("orange_slime");
            orange_slime.addFriendlyTag("orange_slime");
            orange_slime.addFriendlyTag("red_slime");
            orange_slime.addFriendlyTag("royal_slime");
            orange_slime.addEnemyTag("shrooman");
            orange_slime.addEnemyTag("neutral");
            orange_slime.addEnemyTag("good");
            orange_slime.addEnemyTag("bandits");
            orange_slime.addEnemyTag("human");
            orange_slime.addEnemyTag("elf");
            orange_slime.addEnemyTag("dwarf");
            orange_slime.addEnemyTag("orc");
    //Aqui define el reino de la raza
            AssetManager.kingdoms.add(orange_slime);
            World.world.kingdoms.CallMethod("newHiddenKingdom", orange_slime);

//Aqui cuando todavia no son parte de algun reino define su otro estado hasta encontrar otro, cuando encuentran otro obtienen las estadisticas cuando estan dentro del reino
            var nomadsorange_slime = new KingdomAsset();
            nomadsorange_slime.id = "nomads_orange_slime";
            nomadsorange_slime.nomads = true;
            nomadsorange_slime.mobs = true;
            nomadsorange_slime.addTag("orange_slime");
            nomadsorange_slime.addFriendlyTag("orange_slime");
            nomadsorange_slime.addFriendlyTag("red_slime");
            nomadsorange_slime.addFriendlyTag("royal_slime");
            nomadsorange_slime.addEnemyTag("shrooman");
            nomadsorange_slime.addEnemyTag("neutral");
            nomadsorange_slime.addEnemyTag("good");
            nomadsorange_slime.addEnemyTag("bandits");
            nomadsorange_slime.addEnemyTag("human");
            nomadsorange_slime.addEnemyTag("dwarf");
            nomadsorange_slime.addEnemyTag("elf");
            nomadsorange_slime.addEnemyTag("orc");
            nomadsorange_slime.default_kingdom_color = new ColorAsset("#808080", "#808080", "#808080");
            AssetManager.kingdoms.add(nomadsorange_slime);
            World.world.kingdoms.CallMethod("newHiddenKingdom", nomadsorange_slime);

 var royal_slime = new KingdomAsset();
            royal_slime.id = "royal_slime";
            royal_slime.civ = true;
            royal_slime.addTag("royal_slime");
            royal_slime.addFriendlyTag("orange_slime");
            royal_slime.addFriendlyTag("red_slime");
            royal_slime.addFriendlyTag("royal_slime");
            royal_slime.addEnemyTag("shrooman");
            royal_slime.addEnemyTag("neutral");
            royal_slime.addEnemyTag("good");
            royal_slime.addEnemyTag("bandits");
            royal_slime.addEnemyTag("human");
            royal_slime.addEnemyTag("elf");
            royal_slime.addEnemyTag("dwarf");
            royal_slime.addEnemyTag("orc");
            AssetManager.kingdoms.add(royal_slime);
            World.world.kingdoms.CallMethod("newHiddenKingdom", royal_slime);

            var nomadsroyal_slime = new KingdomAsset();
            nomadsroyal_slime.id = "nomads_royal_slime";
            nomadsroyal_slime.nomads = true;
            nomadsroyal_slime.mobs = true;
            nomadsroyal_slime.addTag("royal_slime");
            nomadsroyal_slime.addFriendlyTag("orange_slime");
            nomadsroyal_slime.addFriendlyTag("red_slime");
            nomadsroyal_slime.addFriendlyTag("royal_slime");
            nomadsroyal_slime.addEnemyTag("shrooman");
            nomadsroyal_slime.addEnemyTag("neutral");
            nomadsroyal_slime.addEnemyTag("good");
            nomadsroyal_slime.addEnemyTag("bandits");
            nomadsroyal_slime.addEnemyTag("human");
            nomadsroyal_slime.addEnemyTag("dwarf");
            nomadsroyal_slime.addEnemyTag("elf");
            nomadsroyal_slime.default_kingdom_color = new ColorAsset("#3D251E", "#3D251E", "#3D251E");
            AssetManager.kingdoms.add(nomadsroyal_slime);
            World.world.kingdoms.CallMethod("newHiddenKingdom", nomadsroyal_slime);
            
        }
    }
}