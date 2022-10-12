using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace liladosSoul.Recipe_Changes.Recipes
{
    public class Recipes : GlobalItem
    {
        public override void AddRecipes()
        {
            RecipesEdit();
        }

        private static void RecipesEdit()
        {
            Mod lilados = ModLoader.GetMod("liladosSoul");
            Mod Tho = ModLoader.GetMod("ThoriumMod");
            Mod souls = ModLoader.GetMod("FargowiltasSouls");
            Mod soulDlc = ModLoader.GetMod("FargowiltasSoulsDLC");
            if (souls != null)
            {
                (from x in Main.recipe.ToList()
                 where x.createItem.type == souls.ItemType("AnglerEnchantment")
                 select x).ToList().ForEach(delegate (Recipe s)
                 {
                     s.requiredItem[0].SetDefaults(2367);
                     s.requiredItem[0].stack = 1;
                     s.requiredItem[1].SetDefaults(2368);
                     s.requiredItem[1].stack = 1;
                     s.requiredItem[2].SetDefaults(2369);
                     s.requiredItem[2].stack = 1;
                     s.requiredItem[3].SetDefaults(3721);
                     s.requiredItem[3].stack = 1;
                     s.requiredItem[4].SetDefaults(2289);
                     s.requiredItem[4].stack = 1;
                     s.requiredItem[5].SetDefaults(2291);
                     s.requiredItem[5].stack = 1;
                     s.requiredItem[6].SetDefaults(2292);
                     s.requiredItem[6].stack = 1;
                     s.requiredItem[7].SetDefaults(2355);
                     s.requiredItem[7].stack = 10;
                     s.requiredItem[8].SetDefaults(2354);
                     s.requiredItem[8].stack = 10;
                     s.requiredItem[9].SetDefaults(2356);
                     s.requiredItem[9].stack = 10;
                     s.requiredItem[10].SetDefaults(2674);
                     s.requiredItem[10].stack = 10;
                     s.requiredItem[11].SetDefaults(2675);
                     s.requiredItem[11].stack = 8;
                     s.requiredItem[12].SetDefaults(2676);
                     s.requiredItem[12].stack = 5;
                     s.requiredItem[13].SetDefaults(2002);
                     s.requiredItem[13].stack = 5;
                 });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("MinerEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(88);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(410);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(411);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(2322);
                    s.requiredItem[3].stack = 10;
                    s.requiredItem[4].SetDefaults(296);
                    s.requiredItem[4].stack = 10;
                    s.requiredItem[5].SetDefaults(2329);
                    s.requiredItem[5].stack = 10;
                    s.requiredItem[6].SetDefaults(3509);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(1);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(1320);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(1917);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(3521);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(122);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(2341);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(469);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("WoodEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(727);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(728);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(729);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(36);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(2633);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(34);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(32);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(3278);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(284);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(196);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(24);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(39);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(9);
                    s.requiredItem[12].stack = 250;
                    s.requiredItem[13].SetDefaults(313);
                    s.requiredItem[13].stack = 3;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("BorealWoodEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(2509);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(2510);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(2511);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(673);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(2553);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(858);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(2558);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(1487);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(949);
                    s.requiredItem[8].stack = 300;
                    s.requiredItem[9].SetDefaults(2746);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(2745);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(2747);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(2503);
                    s.requiredItem[12].stack = 500;
                    s.requiredItem[13].SetDefaults(2358);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("RichMahoganyEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(733);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(734);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(735);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(651);
                    s.requiredItem[3].stack = 3;
                    s.requiredItem[4].SetDefaults(2060);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(185);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(656);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(657);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(658);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(3360);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(3361);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(1486);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(620);
                    s.requiredItem[12].stack = 250;
                    s.requiredItem[13].SetDefaults(314);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("PalmWoodEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(2512);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(2513);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(2514);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(186);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(2438);
                    s.requiredItem[4].stack = 3;
                    s.requiredItem[5].SetDefaults(2481);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(2300);
                    s.requiredItem[6].stack = 10;
                    s.requiredItem[7].SetDefaults(2301);
                    s.requiredItem[7].stack = 10;
                    s.requiredItem[8].SetDefaults(2517);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(2516);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(2515);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(2316);
                    s.requiredItem[11].stack = 10;
                    s.requiredItem[12].SetDefaults(2297);
                    s.requiredItem[12].stack = 10;
                    s.requiredItem[13].SetDefaults(859);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("EbonwoodEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(730);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(731);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(732);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(2318);
                    s.requiredItem[3].stack = 2;
                    s.requiredItem[4].SetDefaults(370);
                    s.requiredItem[4].stack = 200;
                    s.requiredItem[5].SetDefaults(61);
                    s.requiredItem[5].stack = 200;
                    s.requiredItem[6].SetDefaults(1488);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(60);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(653);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(654);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(655);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(2485);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(2457);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(68);
                    s.requiredItem[13].stack = 8;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("ShadewoodEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(924);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(925);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(926);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(1330);
                    s.requiredItem[3].stack = 5;
                    s.requiredItem[4].SetDefaults(2305);
                    s.requiredItem[4].stack = 5;
                    s.requiredItem[5].SetDefaults(2319);
                    s.requiredItem[5].stack = 2;
                    s.requiredItem[6].SetDefaults(1492);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(2887);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(921);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(922);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(923);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(2477);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(310);
                    s.requiredItem[12].stack = 4;
                    s.requiredItem[13].SetDefaults(316);
                    s.requiredItem[13].stack = 2;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("CopperEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(89);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(80);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(76);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(3508);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(3507);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(3504);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(71);
                    s.requiredItem[6].stack = 100;
                    s.requiredItem[7].SetDefaults(3506);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(3505);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(15);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(3553);
                    s.requiredItem[10].stack = 3;
                    s.requiredItem[11].SetDefaults(739);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(1481);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(2290);
                    s.requiredItem[13].stack = 10;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("TinEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(687);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(688);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(689);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(3502);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(3501);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(3498);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(3499);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(3500);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(2339);
                    s.requiredItem[8].stack = 2;
                    s.requiredItem[9].SetDefaults(707);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(740);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(1237);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(203);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(1490);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("CactusEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(894);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(895);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(896);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(881);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(882);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(2020);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(276);
                    s.requiredItem[6].stack = 100;
                    s.requiredItem[7].SetDefaults(2092);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(1113);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(2157);
                    s.requiredItem[9].stack = 5;
                    s.requiredItem[10].SetDefaults(2156);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(1491);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(317);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(206);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("SnowEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(803);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(804);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(805);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(981);
                    s.requiredItem[3].stack = 3;
                    s.requiredItem[4].SetDefaults(967);
                    s.requiredItem[4].stack = 4;
                    s.requiredItem[5].SetDefaults(968);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(969);
                    s.requiredItem[6].stack = 4;
                    s.requiredItem[7].SetDefaults(670);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(988);
                    s.requiredItem[8].stack = 200;
                    s.requiredItem[9].SetDefaults(2299);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(2306);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(3197);
                    s.requiredItem[11].stack = 50;
                    s.requiredItem[12].SetDefaults(2470);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(1643);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("SilverEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(91);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(82);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(78);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(3514);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(3513);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(3512);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(3511);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(3510);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(741);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(1238);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(198);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(1059);
                    s.requiredItem[11].stack = 3;
                    s.requiredItem[12].SetDefaults(107);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(16);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("TungstenEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(693);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(694);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(695);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(3490);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(3489);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(3488);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(3487);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(3486);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(1909);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(1915);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(1239);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(742);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(200);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(2330);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("FossilEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(3374);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(3375);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(3376);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(3377);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(3643);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(1242);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(3380);
                    s.requiredItem[6].stack = 20;
                    s.requiredItem[7].SetDefaults(3347);
                    s.requiredItem[7].stack = 10;
                    s.requiredItem[8].SetDefaults(3378);
                    s.requiredItem[8].stack = 200;
                    s.requiredItem[9].SetDefaults(3379);
                    s.requiredItem[9].stack = 250;
                    s.requiredItem[10].SetDefaults(3772);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(266);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(357);
                    s.requiredItem[12].stack = 3;
                    s.requiredItem[13].SetDefaults(2267);
                    s.requiredItem[13].stack = 3;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("PumpkinEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(1731);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(1732);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(1733);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(1799);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(1754);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(1755);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(1756);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(1828);
                    s.requiredItem[7].stack = 5;
                    s.requiredItem[8].SetDefaults(1787);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(1786);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(2590);
                    s.requiredItem[10].stack = 50;
                    s.requiredItem[11].SetDefaults(2425);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(2426);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(1920);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("IronEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(90);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(81);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(77);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(954);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(1098);
                    s.requiredItem[4].stack = 100;
                    s.requiredItem[5].SetDefaults(1994);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(2000);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(1997);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(4);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(6);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(7);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(10);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(35);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(205);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("LeadEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(690);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(691);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(692);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(336);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(1099);
                    s.requiredItem[4].stack = 100;
                    s.requiredItem[5].SetDefaults(1998);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(2001);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(1996);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(3495);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(3496);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(3492);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(3494);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(716);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(3652);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("GladiatorEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(3187);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(3188);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(3189);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(280);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(2117);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(279);
                    s.requiredItem[5].stack = 100;
                    s.requiredItem[6].SetDefaults(3094);
                    s.requiredItem[6].stack = 200;
                    s.requiredItem[7].SetDefaults(168);
                    s.requiredItem[7].stack = 20;
                    s.requiredItem[8].SetDefaults(2586);
                    s.requiredItem[8].stack = 20;
                    s.requiredItem[9].SetDefaults(3116);
                    s.requiredItem[9].stack = 20;
                    s.requiredItem[10].SetDefaults(3548);
                    s.requiredItem[10].stack = 20;
                    s.requiredItem[11].SetDefaults(457);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(3717);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(3406);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("NinjaEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(256);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(257);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(258);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(2273);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(42);
                    s.requiredItem[4].stack = 300;
                    s.requiredItem[5].SetDefaults(1168);
                    s.requiredItem[5].stack = 40;
                    s.requiredItem[6].SetDefaults(2258);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(998);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(2493);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(2489);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(440);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(1309);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(2487);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(2585);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("ShadowEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(100);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(101);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(102);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(96);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(46);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(115);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(44);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(45);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(64);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(2293);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(3279);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(2111);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(994);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(1361);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("CrimsonEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(792);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(793);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(794);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(1825);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(795);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(799);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(801);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(1325);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(1256);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(2421);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(3280);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(2104);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(3060);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(1362);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("JungleEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(228);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(229);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(230);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(208);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(3208);
                    s.requiredItem[4].stack = 3;
                    s.requiredItem[5].SetDefaults(191);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(3349);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(3281);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(680);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(964);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(3017);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(753);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(2313);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(2486);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("AncientCobaltEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(960);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(961);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(962);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(251);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(252);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(253);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(2302);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(2452);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(2488);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(223);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(1109);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(3192);
                    s.requiredItem[11].stack = 10;
                    s.requiredItem[12].SetDefaults(3193);
                    s.requiredItem[12].stack = 7;
                    s.requiredItem[13].SetDefaults(3194);
                    s.requiredItem[13].stack = 4;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("PlatinumEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(696);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(697);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(698);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(715);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(709);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(202);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(3485);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(3484);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(3482);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(3480);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(1241);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(744);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(1527);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(74);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("BeeEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(2361);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(2362);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(2363);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(2108);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(842);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(843);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(844);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(1123);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(2888);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(1121);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(1364);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(1170);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(2502);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(1130);
                    s.requiredItem[13].stack = 250;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("NecroEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(151);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(152);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(153);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(959);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(1499);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(1375);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(1417);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(1313);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(932);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(1421);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(1425);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(1424);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(2478);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(2460);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("ObsidianEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(3266);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(3267);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(3268);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(193);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(3554);
                    s.requiredItem[4].stack = 3;
                    s.requiredItem[5].SetDefaults(3282);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(1493);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(1422);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(1323);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(112);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(163);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(318);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(1501);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(2315);
                    s.requiredItem[13].stack = 3;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == souls.ItemType("MoltenEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(231);
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(232);
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(233);
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(197);
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(120);
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(217);
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(3317);
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(119);
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(220);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(219);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(272);
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(3368);
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(274);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(273);
                    s.requiredItem[13].stack = 1;
                });
            }
            
            
            
            if (lilados != null && Tho != null && soulDlc != null)
            {
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("CrierEnchant")
                 select x).ToList().ForEach(delegate (Recipe s)
                 {
                     s.requiredItem[0].SetDefaults(Tho.ItemType("BardCap"));
                     s.requiredItem[0].stack = 1;
                     s.requiredItem[1].SetDefaults(Tho.ItemType("BardChest"));
                     s.requiredItem[1].stack = 1;
                     s.requiredItem[2].SetDefaults(Tho.ItemType("BardLeggings"));
                     s.requiredItem[2].stack = 1;
                     s.requiredItem[3].SetDefaults(Tho.ItemType("LuckyRabbitsFoot"));
                     s.requiredItem[3].stack = 1;
                     s.requiredItem[4].SetDefaults(Tho.ItemType("MarchingBoots"));
                     s.requiredItem[4].stack = 1;
                     s.requiredItem[5].SetDefaults(Tho.ItemType("PadPaper"));
                     s.requiredItem[5].stack = 1;
                     s.requiredItem[6].SetDefaults(Tho.ItemType("WoodenWhistle"));
                     s.requiredItem[6].stack = 1;
                     s.requiredItem[7].SetDefaults(Tho.ItemType("GoldenBugleHorn"));
                     s.requiredItem[7].stack = 1;
                     s.requiredItem[8].SetDefaults(Tho.ItemType("PlatinumBugle"));
                     s.requiredItem[8].stack = 1;
                     s.requiredItem[9].SetDefaults(Tho.ItemType("Tambourine"));
                     s.requiredItem[9].stack = 1;
                     s.requiredItem[10].SetDefaults(Tho.ItemType("DrumMallet"));
                     s.requiredItem[10].stack = 1;
                     s.requiredItem[11].SetDefaults(Tho.ItemType("Piano"));
                     s.requiredItem[11].stack = 1;
                     s.requiredItem[12].SetDefaults(Tho.ItemType("Harmonica"));
                     s.requiredItem[12].stack = 1;
                     s.requiredItem[13].SetDefaults(Tho.ItemType("Flute"));
                     s.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("IcyEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("IcyBandana"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("IcyMail"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("IcyGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("FrostburnPouch"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("Blizzard"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("FrostFury"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(3197);
                    s.requiredItem[6].stack = 200;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("IceShard"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("IceCube"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("IceBreaker"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("IcyPickaxe"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("IcyAxe"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("IcyCaltrop"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("IcyArrow"));
                    s.requiredItem[13].stack = 100;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("NoviceClericEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("NoviceClericCowl"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("NoviceClericTabard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("NoviceClericPants"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("NursePurse"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("FortifyingWand"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("GoodBook"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("Renew"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("HeartWand"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("GigaNeedle"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("Cure"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("WoodenBaton"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ThePill"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("ClericsCross"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("PalmCross"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("SandstoneEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("hSandStoneHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("iSandStoneMail"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("jSandStoneGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("Boots"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("gSandStoneThrowingKnife"));
                    s.requiredItem[4].stack = 250;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("EnchantedKnife"));
                    s.requiredItem[5].stack = 250;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("StoneThrowingSpear"));
                    s.requiredItem[6].stack = 250;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("IronTomahawk"));
                    s.requiredItem[7].stack = 100;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("LeadTomahawk"));
                    s.requiredItem[8].stack = 100;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("CactusNeedle"));
                    s.requiredItem[9].stack = 150;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("SeveredHand"));
                    s.requiredItem[10].stack = 250;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("BaseballBat"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("Baseball"));
                    s.requiredItem[12].stack = 100;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("TechniqueSprint"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("LivingWoodEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("LivingWoodMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("LivingWoodChestguard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("LivingWoodBoots"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("HealthyBoots"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("PotionChaser"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("TheRing"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("LivingWoodSprout"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("EnchantedBar"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("ButterflyStaff"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("AntlionStaff"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("SpittingFish"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("HatchlingStaff"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("ChiTea"));
                    s.requiredItem[12].stack = 5;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Lantern"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("DangerEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("DangerHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("DangerMail"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("DangerGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("NightShadePetal"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("LeatherSheath"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("TrackerBlade"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("TrackerBoard"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("RedHourglass"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("DangerDuelShot"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("DangerDaikatana"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("MagikStaff"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("EnchantedStaff"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("DangerDagger"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("OceanPolearm"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("EbonEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("EbonHood"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("EbonCloak"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("EbonLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("DarkHeart"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("LeechBolt"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("ShadowWand"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("EighthPlagueStaff"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("FeatherBarrierRod"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("PurifiedWater"));
                    s.requiredItem[8].stack = 75;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("TheDigester"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("SweetBeet"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("BalloonBall"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("PinkSludge"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("DynastyGuzheng"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("YewWoodEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("YewWoodaHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("YewWoodBreastgaurd"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("YewWoodLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("GoblinWarshield"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("ThumbRing"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("YewWoodBow"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("FalconeerCane"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("Lute"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("YewGun"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("Sitar"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("Alphorn"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ViciousMockery"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("ShinyObject"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("SimpleBroom"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("TideHunterEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("TideHunterCap"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("TideHunterChestpiece"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("TideHunterLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("YewWoodEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("AnglerBowl"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("SpiritPouch"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("HydroCannon"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("AquaiteScythe"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("AquaticParadisePaint"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("AquaiteKnife"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("AquamarineWineGlass"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ScubaCurva"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("DrenchedDirk"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("CalmingSpirit"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("JesterEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("JestersMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("JestersShirt"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("JestersLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("FanLetter"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("BleedingHeartStaff"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("DevourerStaff"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("CrimtaneTomahawk"));
                    s.requiredItem[6].stack = 250;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("DemoniteTomahawk"));
                    s.requiredItem[7].stack = 250;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("CrimsonScythe"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("DarkScythe"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("ShadeWoodTambourine"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("EbonWoodTambourine"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("SkywareLute"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("MoltenKnife"));
                    s.requiredItem[13].stack = 300;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("ThoriumEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("ThoriumHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("ThoriumMail"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("ThoriumGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("JesterEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("Crietz"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("BandofReplenishment"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("ThoriumPax"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("ThoriumBlade"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("ThoriumRevolver"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("ThoriumDagger"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("ThoriumBow"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ThoriumBoomerang"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("ThoriumStaff"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("ThoriumSpear"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("OceanEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("OceanHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("OceanChestGuard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("OceanGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("SeaBreezePendant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("BubbleMagnet"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("OceanTomahawk"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("OceanPickaxe"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("OceanHamaxe"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("OceanCrossbow"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("CoralPurifier"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("CrabClaw"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("SubterraneanBulb"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("FishEgg"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Ukulele"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("DepthDiverEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("DepthDiverHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("DepthDiverChestplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("DepthDiverGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("OceanEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("DrownedDoubloon"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("Bellerose"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("MagicConch"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("Illustrious"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("Whip"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("Trapper"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("LargePrismite"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("LargeOnyx"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("LargeOpal"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("LargePearl"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("BulbEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("BloomingCrown"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("BloomingTabard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("BloomingLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("PetalShield"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("FragrantCorsage"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("KickPetal"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("BloomingBlade"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("BloomingBow"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("PetalWand"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("TulipStaff"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("BloomerBell"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("AncientBulbHood"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("AncientBulbChestplate"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("AncientBulbLeggings"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("DarksteelEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("hDarksteelFaceGuard"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("iDarksteelBreastPlate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("jDarksteelGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("SteelEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("BallnChain"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("ManHacker"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("PhantomCamera"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("PocketFusionGenerator"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("Webgun"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("bDarksteelPickaxe"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("gDarkSteelCrossBow"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ArsenalStaff"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("BoneTrumpet"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Sawblade"));
                    s.requiredItem[13].stack = 500;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("MagmaEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("MagmaHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("MagmaChestGuard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("MagmaGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("SpringSteps"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("SlagStompers"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("MoltenSpearTip"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("SpringHook"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("aObsidianHelmet"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("bObsidianChestGuard"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("cObsidianGreaves"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("MagmaShiv"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("MagmaFlail"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("MaggotItem"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("AntagonizingSpirit"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("NobleEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("NoblesHat"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("NoblesJerkin"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("NoblesLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("RingofUnity"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("BrassCap"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("WaxyRosin"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("BeeBoots"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("HotHorn"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("InspirationCrystal"));
                    s.requiredItem[8].stack = 5;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("Bongos"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("HoneyRecorder"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("HoneySuckle"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("TuningFork"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Microphone"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("SpiritTrapperEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("SpiritTrapperHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("SpiritTrapperCuirass"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("SpiritTrapperGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("SpiritFlame"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("ScryingGlass"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("Calaveras"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("Moonlight"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("StrangeSkull"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("MarrowScepter"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("Nocturne"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("Nocturnal"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("TechniqueSoulPulse"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("PhaseDart"));
                    s.requiredItem[12].stack = 250;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("PhaseChopper"));
                    s.requiredItem[13].stack = 250;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("SteelEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("SteelHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("SteelChestplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("SteelGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("ThoriumShield"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("SpikedBracer"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("GraveGoods"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("SteelPickaxe"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("SteelAxe"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("SteelBlade"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("SteelBow"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("SteelMallet"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("WarForger"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("SteelBattleAxe"));
                    s.requiredItem[12].stack = 250;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("SteelArrow"));
                    s.requiredItem[13].stack = 250;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("TemplarEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("TemplarsCirclet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("TemplarsTabard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("TemplarsLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("BatScythe"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("TemplarsGrace"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("TemplarJudgment"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("LifeDisperser"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("LifesGift"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("LifeQuartzClaymore"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("Prophecy"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("DivineLotus"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ChiLantern"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("DarkMageStaff"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("DarkGate"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("GraniteEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("GraniteHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("GraniteChestGuard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("GraniteGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("HeartOfStone"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("ShockAbsorber"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("HellfireMinigun"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("Slugger"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("BlunderBuss"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("GuanoGunner"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("EnergyStormBolter"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("GraniteCrossbow"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("EnergyStormPartisan"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("GraniteControlRod"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("GraniteIonStaff"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("BronzeEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("BronzeHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("BronzeBreastplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("BronzeGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("OlympicTorch"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("ChampionsBarrier"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("SpartanSandles"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("RodAsclepius"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("BronzeGladius"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("BronzeSpear"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("BronzeThrowing"));
                    s.requiredItem[9].stack = 250;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("ChampionsGodHand"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ChampionBlade"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("HeroTripleBow"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("ChampionBomberStaff"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("FlightEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("FlightMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("FlightMail"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("FlightBoots"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("ChampionWing"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("FabergeEgg"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("MeleeThorHammer"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("BentZombieArm"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("ElephantGun"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("SpineBreaker"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("DetachedUFOBlaster"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("DarkTome"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("Omen"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("HitScanner"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("CartlidgedCatcher"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("FleshEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("FleshMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("FleshBody"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("FleshLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("VampireGland"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("FleshWings"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("FleshMace"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("FleshPickAxe"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("FleshAxe"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("FleshHammer"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("FleshSkewer"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("FleshBow"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("FleshJackHammer"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("FleshHorn"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("HungerStaff"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("GeodeEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("GeodeHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("GeodeChestplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("GeodeGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("CrystalineCharm"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("CrystalSpearTip"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("DridersGrace"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("GeodeSaber"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("GeodePickaxe"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("GeodeBoomerang"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("GeodeSpear"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("GeodeMallet"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("Saba"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("BlizzardsEdge"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("IntactGeode"));
                    s.requiredItem[13].stack = 5;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("IridescentEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("IridescentHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("IridescentMail"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("IridescentGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("Equalizer"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("LifeQuartzShield"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("GrimFlayer"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("Arthropod"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("RifleSpear"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("BoneFlayerTail"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("TranquilLyre"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("HealingRain"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("LustrousBaton"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("BoneBaton"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("FallingTwilight"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("MarchingBandEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("MarchingBandCap"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("MarchingBandUniform"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("MarchingBandLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("FullScore"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("LeechingSheath"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("Tuba"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("VinylRecord"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("HellBell"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("Cymbals"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("SummonerWarhorn"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("Xylophone"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("Chimes"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("RiffWeaver"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Ocarina"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("PlagueDoctorEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("PlagueDoctersMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("PlagueDoctersGarb"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("PlagueDoctersLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("MetabolicPills"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("ShipsHelm"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("CobaltThrowingSpear"));
                    s.requiredItem[5].stack = 500;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("PalladiumThrowingSpear"));
                    s.requiredItem[6].stack = 500;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("AphrodisiacVial"));
                    s.requiredItem[7].stack = 500;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("CorrosionBeaker"));
                    s.requiredItem[8].stack = 500;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("NitrogenVial"));
                    s.requiredItem[9].stack = 500;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("CombustionFlask"));
                    s.requiredItem[10].stack = 500;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("GasContainer"));
                    s.requiredItem[11].stack = 500;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("VoltHatchet"));
                    s.requiredItem[12].stack = 500;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("HotPot"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("SacredEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("HallowedPaladinHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("HallowedPaladinBreastplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("HallowedPaladinLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("NoviceClericEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("KarmicHolder"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("WrithingSheath"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("HallowedBludgeon"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("SacredCharge"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("Liberation"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("AxeBlade"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("WhisperRa"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("HeavensGate"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("ShusWrath"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Trombone"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("WhiteKnightEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("WhiteKnightMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("WhiteKnightTabard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("WhiteKnightLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("ShadeBand"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("PrismiteStaff"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("FrostFang"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("FrostPlagueStaff"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("NightStaff"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("ShadowStaff"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("CobaltStaff"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("PalladiumStaff"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("VileSpitter"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("DutchmansAvarice"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("NagaSpitStaff"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("LodestoneEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("LodeStoneFaceGuard"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("LodeStoneChestGaurd"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("LodeStoneShinGaurds"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("AstroBeetleHusk"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("ObsidianScale"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("SandweaversTiara"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("BlizzardPouch"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("LodeStoneClaymore"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("LodeStoneBow"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("LodeStonePickaxe"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("LodestoneJavelin"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("LodeStoneGreatAxe"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("LodeStoneQuickDraw"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("LodeStoneMace"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("ValadiumEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("ValadiumHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("ValadiumBreastPlate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("ValadiumGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("EyeofBeholder"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("LichGaze"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("ValadiumAxe"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("ValadiumBattleAxe"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("ValadiumSlicer"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("ValadiumHammer"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("ValadiumStaff"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("ValadiumSpear"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ValadiumFoeBlaster"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("ValadiumBow"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("ValadiumPickaxe"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("DragonEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("DragonMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("DragonBreastplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("DragonGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("DragonTalonNecklace"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("TunePlayerMovementSpeed"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("DragonWings"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("EbonyTail"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("DragonsGaze"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("DragonsWail"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("DragonTooth"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("DragonsBreath"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("AncientDragonMask"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("AncientDragonBreastplate"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("AncientDragonGreaves"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("DurasteelEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("DurasteelHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("DurasteelChestplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("DurasteelGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("DarksteelEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("IncandescentSpark"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("TheJuggernaut"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("DurasteelBlade"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("DurasteelDrill"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("DurasteelJackhammer"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("DurasteelRepeater"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("DurasteelJavelin"));
                    s.requiredItem[10].stack = 500;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("Schmelze"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("PoseidonCharge"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("BackStabber"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("BiotechEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("LifeWeaverHood"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("LifeWeaverGarment"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("LifeWeaverLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("Firestormboots"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("SubspaceWings"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("AirStrikeShield"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("PlasmaStaff"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("LifeEssenceApparatus"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("LifeSurgeStaff"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("PocketGaurdian"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("BarrierGenerator"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("NullZoneStaff"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("SerpentsCry"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("HolyFire"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("LifeBinderEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("DewBinderMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("DewBinderBreastplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("DewBinderGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("IridescentEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("DewCollector"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("CursedHammer"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("HallowedScythe"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("HallowedBlessing"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("HallowedMegaphone"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("SmitingHammer"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("DarkContagionBook"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("MidasMallet"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("MorningDew"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Effuser"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("LifeBloomEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("LifeBloomMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("LifeBloomMail"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("LifeBloomLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("LivingWoodEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soulDlc.ItemType("BulbEnchant"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("HeartOfTheJungle"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("MistWeaver"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("LifeFruitPlatter"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("GlowingSouffle"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("EtherianGrog"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("ManaDelight"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("FreshPickle"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("AromaticBiscuit"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("TerraScythe"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("CyberPunkEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("CyberPunkHeadset"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("CyberPunkSuit"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("CyberPunkLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("AutoTuner"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("TunePlayerDamage"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("DissTrack"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("PrimeRoar"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("Zunpet"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("PortableWintergatan"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("TurtleDrum"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("SteamFlute"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("CadaverCornet"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("MythrilMelodica"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("OrichalcumSlideWhistle"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("LichEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("LichCowl"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("LichCarapace"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("LichTalon"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("PlagueDoctorEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("Phylactery"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("TheLostCross"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("DeathEmbrace"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("SoulRender"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("SoulBomb"));
                    s.requiredItem[8].stack = 350;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("BloodyPaganStaff"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("DecayingSorrow"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("AdamantiteGlaive"));
                    s.requiredItem[11].stack = 250;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("TitaniumGlaive"));
                    s.requiredItem[12].stack = 250;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("ClockWorkBomb"));
                    s.requiredItem[13].stack = 250;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("WarlockEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("WarlockHood"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("WarlockGarb"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("WarlockLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("EbonEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("DemonTongue"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("Effigy"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("Scalper"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("Rapier"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("EyeofDestroy"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("IceAxe"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("BlazingGold"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("DestroyersRage"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("TrueHallowedRepeater"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("PrismaticSpray"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("CryomancerEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("CryomancersCrown"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("CryomancersTabard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("CryomancersLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("IcyEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("IceBoundStriderHide"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("BlackholeCannon"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("GodKiller"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("BassBooster"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("StalagmiteBook"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("CycloneBook"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("DarkFlame"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("HydromancerCatalyst"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("GeomancersBrush"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("DynastyWarFan"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("DemonBloodEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("DemonBloodHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("DemonBloodBreastPlate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("DemonBloodGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("FleshEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("VileCore"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("DemonBloodWings"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("DemonBloodSword"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("DemonBloodPickAxe"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("DemonBloodHamaxe"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("DemonBloodSpear"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("DemonBloodStaff"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("DemonBloodRipper"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("DemonBloodChainSaw"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("DemonBloodCrossBow"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("DreadEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("DreadSkull"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("DreadChestPlate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("DreadGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("DragonEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("CrashBoots"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("CursedCore"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("DreadWings"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("HungryBloom"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("BlackBlade"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("DreadRazor"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("DreadPick"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("DreadTearer"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("DreadStaff"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("DreadFork"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("FallenPaladinEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("FallenPaladinFacegaurd"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("FallenPaladinCuirass"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("FallenPaladinGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("TemplarEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("Wynebgwrthucher"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("NirvanaStatuette"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("BlackScythe"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("LightBringerWarhammer"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("Buisine"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("HolyHammer"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("LingeringWill"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("BulwarkStaff"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("SerpentsBubbleWand"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("StellarSystem"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("FungusEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("FungusHat"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("FungusGuard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("FungusLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("KeyofFungus"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("FungalHook"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("FungalCane"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("FungalPopper"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("MagicCard"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("FireAxe"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("StalkersSnippers"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("Omniwrench"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("SmitingHammer"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("EskimoBanjo"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Kazoo"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("HarbingerEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("HarbingerHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("HarbingerChestGuard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("HarbingerGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("WhiteKnightEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("HarbingerWings"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("BlackStaff"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("HarbingerPickAxe"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("HarbingerSpear"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("HarbingerBlade"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("HarbingerBow"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("HarbingerSurgeWand"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("HarbingerHamaxe"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("HailBomber"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("MastersLibram"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("IllumiteEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("IllumiteMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("IllumiteChestplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("IllumiteGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("TheNuclearOption"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("TunePlayerLifeRegen"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("BlackBow"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("IllumiteBlade"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("IllumitePick"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("IllumiteScythe"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("IllumiteJackhammer"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("IllumiteChainsaw"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("IllumiteBow"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("IllumiteDrill"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("IllumiteBlaster"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("MaestroEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("MaestroWig"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("MaestroSuit"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("MaestroLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("MarchingBandEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("Metronome"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("ConductorsBaton"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("StrawberryHeart"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("HauntingBassDrum"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("Acoustic"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("BlackOtamatone"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("VuvuzelaBlue"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("VuvuzelaGreen"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("VuvuzelaRed"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("VuvuzelaYellow"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("OrnateEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("OrnateHat"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("OrnateJerkin"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("OrnateLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("ConcertTickets"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("GreenTambourine"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("SunflareGuitar"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("TheMaw"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("SirensAllure"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("Clarinet"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("Pungi"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("TheBopper"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("CadaverCornet"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("FrenchHorn"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Organ"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("ShadeMasterEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("ShadeMasterMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("ShadeMasterGarb"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("ShadeMasterTreads"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("ShinobiSigil"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("PharaohsSlab"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("Witchblade"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("TerraKnife"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("ShadowTippedJavelin"));
                    s.requiredItem[7].stack = 500;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("ShadowPurgeCaltrop"));
                    s.requiredItem[8].stack = 500;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("BugenkaiShuriken"));
                    s.requiredItem[9].stack = 500;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("ShadeKunai"));
                    s.requiredItem[10].stack = 500;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ShadeKusarigama"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("BlackDagger"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("SparkTaser"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("BerserkerEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("BerserkerMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("BerserkerBreastplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("BerserkerGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("MagmaEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("RapierBadge"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("GutWrenchersGauntlet"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("WyvernSlayer"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("BerserkBlade"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("BerserkPickaxe"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("BerserkSoulStaff"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("BerserkerHamaxe"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("BerserkBow"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("BerserkBreaker"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("SolScorchedSlab"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("NagaSkinEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("NagaSkinMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("NagaSkinSuit"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("NagaSkinTail"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("OceanRetaliation"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("TitanSlayerSheath"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("SolStaff"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("EruptingFlare"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("CharonsBeacon"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("MermaidCanteen"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("NagaRecurve"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("BlobhornCoralStaff"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("SerpentsBubbleWand"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(2418);
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(2419);
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("TitanEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("TitanHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("TitanBreastplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("TitanGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("CrystalEyeMask"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("AbyssalShell"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("TunePlayerDamageReduction"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("TitanWings"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("TitanSword"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("TitanScythe"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("TitanPax"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("TitanJavelin"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("TitanHammer"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("TitanBoomerang"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("TitanBow"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("WhisperingEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("WhisperingHood"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("WhisperingTabard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("WhisperingLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("WhisperingDagger"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("DMR"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("TommyGun"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("Trigun"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("Scorn"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("BulletStorm"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("SharkStormMK"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("PhantomCannon"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("OreLauncher"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("TimeBook"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("PillPopper"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("ConduitEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("ConduitHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("ConduitSuit"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("ConduitLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(lilados.ItemType("AstroEnchantment"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("Triangle"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("Turntable"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("IcyGaze"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("WhirlPool"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("LivewireCrasher"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("TrenchSpitter"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("SpectrelBlade"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("PaganGrasp"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("VoltModule"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("ElectroRebounder"));
                    s.requiredItem[13].stack = 500;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("TerrariumEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("TerrariumHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("TerrariumBreastPlate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("TerrariumGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("ThoriumEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("TerrariumSubwoofer"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("TerrariumDefender"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("TerrariumBoots"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("TerrariumWings"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("TerrariumFisher"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("TerrariumSaber"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("TerrariumBomber"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("TerrariumSageStaff"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("TerrariumSummon"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("ThoriumCube"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("CelestialEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("CelestialCrown"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("CelestialVestment"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("CelestialLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("CelestialTrinity"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("DivineStaff"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("CelestialPickaxe"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("CelestialHamaxe"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("MiracleWand"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("ChristmasCheer"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("Kinetoscythe"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("CelestialNova"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("LifeAndDeath"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("SpiritFireWand"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("RecipeCatalog"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("ShootingStarEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("BalladeerHat"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("BalladeerShirt"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("BalladeerBoots"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("Headset"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("BalladeersTurboTuba"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("RockstarsDoubleBassBlastGuitar"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("BlackMIDI"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("DukesRegalCarnyx"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("BetsysBellow"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("CallofCthulhu"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("Accordion"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("SonicAmplifier"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("KillCounter"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("EmperorsWill"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("WhiteDwarfEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("WhiteDwarfMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("WhiteDwarfGuard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("WhiteDwarfGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("WhiteDwarfThrusters"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("TechniqueLastStand"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("TechniqueStonePalm"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("TechniqueShadowDance"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("TechniqueShadowClone"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("TechniquePaperExplosive"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("TechniqueBlindingDash"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("TechniqueDecoy"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("TechniqueCobraBite"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("TechniqueAbsoluteZero"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("TechniqueMeteorStomp"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("AssassinEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("OmniMarkHead"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("OmniBody"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("OmniGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("DartPouch"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("CelestialBow"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("OmniBow"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("OmniCannon"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("TheJavelin"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("WyrmDecimator"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("BeetleBlaster"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("RedFragmentBlaster"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("TerraBow"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("RejectsBlowpipe"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("HydroPump"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("DreamWeaverEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("DreamWeaversHood"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("DreamWeaversTabard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("DreamWeaversTreads"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("WarpCore"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("RealitySlasher"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("Lucidity"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("UnboundFantasy"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("DreamCatcher"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("AncientFlame"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("AncientFrost"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("AncientLight"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("AncientSpark"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("PLG"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("OtherworldlyRune"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("PyromancerEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("PyroSummonHat"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("PyromancerTabard"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("PyromancerLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("PlasmaGenerator"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("NorthLight"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("AlmanacofDespair"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("DevilsClaw"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("EmberStaff"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("PrometheanStaff"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("RudeWand"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("CatsEye"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("NebulaReflection"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("ShadowOrbStaff"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("BowofLight"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("RhapsodistEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("SoloistHat"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("RhapsodistChestWoofer"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("RhapsodistBoots"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("Holophonor"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("Sousaphone"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("Drum"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("EdgeofImagination"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("Bassoon"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("JingleBells"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("Didgeridoo"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("FlanPlatter"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("ChaosMirror"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("JarOMayo"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("Mjolnir"));
                    s.requiredItem[13].stack = 1;
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("TideTurnerEnchant")
                    select x).ToList().ForEach(delegate (Recipe s)
                {
                    s.requiredItem[0].SetDefaults(Tho.ItemType("TideTurnersGaze"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(Tho.ItemType("TideTurnerBreastplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(Tho.ItemType("TideTurnerGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(Tho.ItemType("PlagueLordFlask"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(Tho.ItemType("TerrariansKnife"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(Tho.ItemType("OceansJudgment"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(Tho.ItemType("SevenSeasBreaker"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(Tho.ItemType("TidalWave"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Tho.ItemType("Trefork"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(Tho.ItemType("AstralFang"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(Tho.ItemType("EssenceofFlame"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(Tho.ItemType("Skadoosh"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(Tho.ItemType("WhiteDwarfKunai"));
                    s.requiredItem[12].stack = 1000;
                    s.requiredItem[13].SetDefaults(Tho.ItemType("AngelsEnd"));
                    s.requiredItem[13].stack = 1;
                });
            }
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if (lilados != null && calamityMod != null && soulDlc != null)
            {

                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("SnowRuffianEnchant")
                 select x).ToList().ForEach(delegate (Recipe s)
                 {
                         s.requiredItem[0].SetDefaults(calamityMod.ItemType("SnowRuffianMask"));
                         s.requiredItem[0].stack = 1;
                     s.requiredItem[1].SetDefaults(calamityMod.ItemType("SnowRuffianChestplate"));
                     s.requiredItem[1].stack = 1;
                     s.requiredItem[2].SetDefaults(calamityMod.ItemType("SnowRuffianGreaves"));
                     s.requiredItem[2].stack = 1;
                     s.requiredItem[3].SetDefaults(calamityMod.ItemType("ScuttlersJewel"));
                     s.requiredItem[3].stack = 1;
                     s.requiredItem[4].SetDefaults(calamityMod.ItemType("AncientFossil"));
                     s.requiredItem[4].stack = 1;
                     s.requiredItem[5].SetDefaults(calamityMod.ItemType("BelladonnaSpiritStaff"));
                     s.requiredItem[5].stack = 1;
                     s.requiredItem[6].SetDefaults(calamityMod.ItemType("FrostBlossomStaff"));
                     s.requiredItem[6].stack = 1;
                     s.requiredItem[7].SetDefaults(calamityMod.ItemType("IcicleStaff"));
                     s.requiredItem[7].stack = 1;
                     s.requiredItem[8].SetDefaults(calamityMod.ItemType("FrostBolt"));
                     s.requiredItem[8].stack = 1;
                     s.requiredItem[9].SetDefaults(calamityMod.ItemType("SparkSpreader"));
                     s.requiredItem[9].stack = 1;
                     s.requiredItem[10].SetDefaults(calamityMod.ItemType("HarvestStaff"));
                     s.requiredItem[10].stack = 1;
                     s.requiredItem[11].SetDefaults(calamityMod.ItemType("SkyGlaze"));
                     s.requiredItem[11].stack = 1;
                     s.requiredItem[12].SetDefaults(calamityMod.ItemType("GildedDagger"));
                     s.requiredItem[12].stack = 1;
                     s.requiredItem[13].SetDefaults(calamityMod.ItemType("Crystalline"));
                     s.requiredItem[13].stack = 1;
                 });


                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("WulfrumEnchant")
                 select x).ToList().ForEach(delegate (Recipe w)
                 {
                     w.requiredItem[0].SetDefaults(calamityMod.ItemType("WulfrumHelm"));
                     w.requiredItem[0].stack = 1;
                     w.requiredItem[1].SetDefaults(calamityMod.ItemType("WulfrumArmor"));
                     w.requiredItem[1].stack = 1;
                     w.requiredItem[2].SetDefaults(calamityMod.ItemType("WulfrumLeggings"));
                     w.requiredItem[2].stack = 1;
                     w.requiredItem[3].SetDefaults(calamityMod.ItemType("WulfrumBattery"));
                     w.requiredItem[3].stack = 1;
                     w.requiredItem[4].SetDefaults(calamityMod.ItemType("RoverDrive"));
                     w.requiredItem[4].stack = 1;
                     w.requiredItem[5].SetDefaults(calamityMod.ItemType("TrinketofChi"));
                     w.requiredItem[5].stack = 1;
                     w.requiredItem[6].SetDefaults(calamityMod.ItemType("UnstablePrism"));
                     w.requiredItem[6].stack = 1;
                     w.requiredItem[7].SetDefaults(calamityMod.ItemType("WulfrumBlade"));
                     w.requiredItem[7].stack = 1;
                     w.requiredItem[8].SetDefaults(calamityMod.ItemType("WulfrumPickaxe"));
                     w.requiredItem[8].stack = 1;
                     w.requiredItem[9].SetDefaults(calamityMod.ItemType("WulfrumRod"));
                     w.requiredItem[9].stack = 1;
                     w.requiredItem[10].SetDefaults(calamityMod.ItemType("WulfrumController"));
                     w.requiredItem[10].stack = 1;
                     w.requiredItem[11].SetDefaults(calamityMod.ItemType("ThrowingBrick"));
                     w.requiredItem[11].stack = 300;
                     w.requiredItem[12].SetDefaults(calamityMod.ItemType("Pumpler"));
                     w.requiredItem[12].stack = 1;
                     w.requiredItem[13].SetDefaults(calamityMod.ItemType("Baguette"));
                     w.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("VictideEnchant")
                 select x).ToList().ForEach(delegate (Recipe v)
                 {
                     v.requiredItem[0].SetDefaults(calamityMod.ItemType("VictideHelm"));
                     v.requiredItem[0].stack = 1;
                     v.requiredItem[1].SetDefaults(calamityMod.ItemType("VictideBreastplate"));
                     v.requiredItem[1].stack = 1;
                     v.requiredItem[2].SetDefaults(calamityMod.ItemType("VictideLeggings"));
                     v.requiredItem[2].stack = 1;
                     v.requiredItem[3].SetDefaults(calamityMod.ItemType("AeroStone"));
                     v.requiredItem[3].stack = 1;
                     v.requiredItem[4].SetDefaults(calamityMod.ItemType("SandCloak"));
                     v.requiredItem[4].stack = 1;
                     v.requiredItem[5].SetDefaults(calamityMod.ItemType("LuxorsGift"));
                     v.requiredItem[5].stack = 1;
                     v.requiredItem[6].SetDefaults(calamityMod.ItemType("Magnum"));
                     v.requiredItem[6].stack = 1;
                     v.requiredItem[7].SetDefaults(calamityMod.ItemType("AquashardShotgun"));
                     v.requiredItem[7].stack = 1;
                     v.requiredItem[8].SetDefaults(calamityMod.ItemType("MagicalConch"));
                     v.requiredItem[8].stack = 1;
                     v.requiredItem[9].SetDefaults(calamityMod.ItemType("Seabow"));
                     v.requiredItem[9].stack = 1;
                     v.requiredItem[10].SetDefaults(calamityMod.ItemType("SeashellBoomerang"));
                     v.requiredItem[10].stack = 1;
                     v.requiredItem[11].SetDefaults(calamityMod.ItemType("CoralSpout"));
                     v.requiredItem[11].stack = 1;
                     v.requiredItem[12].SetDefaults(calamityMod.ItemType("CoralCannon"));
                     v.requiredItem[12].stack = 1;
                     v.requiredItem[13].SetDefaults(calamityMod.ItemType("YateveoBloom"));
                     v.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("SulphurousEnchant")
                 select x).ToList().ForEach(delegate (Recipe su)
                 {
                     su.requiredItem[0].SetDefaults(calamityMod.ItemType("SulfurHelmet"));
                     su.requiredItem[0].stack = 1;
                     su.requiredItem[1].SetDefaults(calamityMod.ItemType("SulfurBreastplate"));
                     su.requiredItem[1].stack = 1;
                     su.requiredItem[2].SetDefaults(calamityMod.ItemType("SulfurLeggings"));
                     su.requiredItem[2].stack = 1;
                     su.requiredItem[3].SetDefaults(calamityMod.ItemType("CoinofDeceit"));  
                     su.requiredItem[3].stack = 1;
                     su.requiredItem[4].SetDefaults(calamityMod.ItemType("AbyssalAmulet"));
                     su.requiredItem[4].stack = 1;
                     su.requiredItem[5].SetDefaults(calamityMod.ItemType("AlluringBait"));
                     su.requiredItem[5].stack = 1;
                     su.requiredItem[6].SetDefaults(calamityMod.ItemType("GladiatorsLocket"));
                     su.requiredItem[6].stack = 1;
                     su.requiredItem[7].SetDefaults(calamityMod.ItemType("RustyMedallion"));
                     su.requiredItem[7].stack = 1;
                     su.requiredItem[8].SetDefaults(calamityMod.ItemType("RadiatingCrystal"));
                     su.requiredItem[8].stack = 1;
                     su.requiredItem[9].SetDefaults(calamityMod.ItemType("BouncySpikyBall"));
                     su.requiredItem[9].stack = 500;
                     su.requiredItem[10].SetDefaults(calamityMod.ItemType("BouncingEyeball"));
                     su.requiredItem[10].stack = 1;
                     su.requiredItem[11].SetDefaults(calamityMod.ItemType("ContaminatedBile"));
                     su.requiredItem[11].stack = 1;
                     su.requiredItem[12].SetDefaults(calamityMod.ItemType("RustyBeaconPrototype"));
                     su.requiredItem[12].stack = 1;
                     su.requiredItem[13].SetDefaults(calamityMod.ItemType("EffigyOfDecay"));
                     su.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("AerospecEnchant")
                 select x).ToList().ForEach(delegate (Recipe ae)
                 {
                     ae.requiredItem[0].SetDefaults(calamityMod.ItemType("AerospecHelm"));
                     ae.requiredItem[0].stack = 1;
                     ae.requiredItem[1].SetDefaults(calamityMod.ItemType("AerospecBreastplate"));
                     ae.requiredItem[1].stack = 1;
                     ae.requiredItem[2].SetDefaults(calamityMod.ItemType("AerospecLeggings"));
                     ae.requiredItem[2].stack = 1;
                     ae.requiredItem[3].SetDefaults(calamityMod.ItemType("FrostBarrier"));
                     ae.requiredItem[3].stack = 1;
                     ae.requiredItem[4].SetDefaults(calamityMod.ItemType("FeatherCrown"));
                     ae.requiredItem[4].stack = 1;
                     ae.requiredItem[5].SetDefaults(calamityMod.ItemType("HarpyRing"));
                     ae.requiredItem[5].stack = 1;
                     ae.requiredItem[6].SetDefaults(calamityMod.ItemType("SkylineWings"));
                     ae.requiredItem[6].stack = 1;
                     ae.requiredItem[7].SetDefaults(calamityMod.ItemType("CrimsonEffigy"));
                     ae.requiredItem[7].stack = 1;
                     ae.requiredItem[8].SetDefaults(calamityMod.ItemType("CorruptionEffigy"));
                     ae.requiredItem[8].stack = 1;
                     ae.requiredItem[9].SetDefaults(calamityMod.ItemType("AirSpinner"));
                     ae.requiredItem[9].stack = 1;
                     ae.requiredItem[10].SetDefaults(calamityMod.ItemType("Turbulance"));
                     ae.requiredItem[10].stack = 1;
                     ae.requiredItem[11].SetDefaults(calamityMod.ItemType("Tradewinds"));
                     ae.requiredItem[11].stack = 1;
                     ae.requiredItem[12].SetDefaults(calamityMod.ItemType("WindBlade"));
                     ae.requiredItem[12].stack = 1;
                     ae.requiredItem[13].SetDefaults(calamityMod.ItemType("Aestheticus"));
                     ae.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("StatigelEnchant")
                 select x).ToList().ForEach(delegate (Recipe stati)
                 {
                     stati.requiredItem[0].SetDefaults(calamityMod.ItemType("StatigelHelm"));
                     stati.requiredItem[0].stack = 1;
                     stati.requiredItem[1].SetDefaults(calamityMod.ItemType("StatigelArmor"));
                     stati.requiredItem[1].stack = 1;
                     stati.requiredItem[2].SetDefaults(calamityMod.ItemType("StatigelGreaves"));
                     stati.requiredItem[2].stack = 1;
                     stati.requiredItem[3].SetDefaults(calamityMod.ItemType("EnchantedPearl"));
                     stati.requiredItem[3].stack = 1;
                     stati.requiredItem[4].SetDefaults(calamityMod.ItemType("FungalSymbiote"));
                     stati.requiredItem[4].stack = 1;
                     stati.requiredItem[5].SetDefaults(calamityMod.ItemType("ManaOverloader"));
                     stati.requiredItem[5].stack = 1;
                     stati.requiredItem[6].SetDefaults(calamityMod.ItemType("JellyChargedBattery"));
                     stati.requiredItem[6].stack = 1;
                     stati.requiredItem[7].SetDefaults(calamityMod.ItemType("CounterScarf"));
                     stati.requiredItem[7].stack = 1;
                     stati.requiredItem[8].SetDefaults(calamityMod.ItemType("BlackAnurian"));
                     stati.requiredItem[8].stack = 1;
                     stati.requiredItem[9].SetDefaults(calamityMod.ItemType("Lionfish"));
                     stati.requiredItem[9].stack = 1;
                     stati.requiredItem[10].SetDefaults(calamityMod.ItemType("EnchantedAxe"));
                     stati.requiredItem[10].stack = 1;
                     stati.requiredItem[11].SetDefaults(calamityMod.ItemType("AbyssShocker"));
                     stati.requiredItem[11].stack = 1;
                     stati.requiredItem[12].SetDefaults(calamityMod.ItemType("HellwingStaff"));
                     stati.requiredItem[12].stack = 1;
                     stati.requiredItem[13].SetDefaults(calamityMod.ItemType("FlurrystormCannon"));
                     stati.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("MolluskEnchant")
                 select x).ToList().ForEach(delegate (Recipe mull)
                 {
                     mull.requiredItem[0].SetDefaults(calamityMod.ItemType("MolluskShellmet"));
                     mull.requiredItem[0].stack = 1;
                     mull.requiredItem[1].SetDefaults(calamityMod.ItemType("MolluskShellplate"));
                     mull.requiredItem[1].stack = 1;
                     mull.requiredItem[2].SetDefaults(calamityMod.ItemType("MolluskShelleggings"));
                     mull.requiredItem[2].stack = 1;
                     mull.requiredItem[3].SetDefaults(soulDlc.ItemType("VictideEnchant"));
                     mull.requiredItem[3].stack = 1;
                     mull.requiredItem[4].SetDefaults(calamityMod.ItemType("AquaticEmblem"));
                     mull.requiredItem[4].stack = 1;
                     mull.requiredItem[5].SetDefaults(calamityMod.ItemType("DeepDiver"));
                     mull.requiredItem[5].stack = 1;
                     mull.requiredItem[6].SetDefaults(calamityMod.ItemType("FungalClump"));
                     mull.requiredItem[6].stack = 1;
                     mull.requiredItem[7].SetDefaults(calamityMod.ItemType("GiantPearl"));
                     mull.requiredItem[7].stack = 1;
                     mull.requiredItem[8].SetDefaults(calamityMod.ItemType("RogueEmblem"));
                     mull.requiredItem[8].stack = 1;
                     mull.requiredItem[9].SetDefaults(calamityMod.ItemType("LunicEye"));
                     mull.requiredItem[9].stack = 1;
                     mull.requiredItem[10].SetDefaults(calamityMod.ItemType("GoldenGun"));
                     mull.requiredItem[10].stack = 1;
                     mull.requiredItem[11].SetDefaults(calamityMod.ItemType("DuneHopper"));
                     mull.requiredItem[11].stack = 1;
                     mull.requiredItem[12].SetDefaults(calamityMod.ItemType("CrystalBlade"));
                     mull.requiredItem[12].stack = 1;
                     mull.requiredItem[13].SetDefaults(calamityMod.ItemType("StormfrontRazor"));
                     mull.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("DaedalusEnchant")
                 select x).ToList().ForEach(delegate (Recipe dae)
                 {
                     dae.requiredItem[0].SetDefaults(calamityMod.ItemType("DaedalusHelm"));
                     dae.requiredItem[0].stack = 1;
                     dae.requiredItem[1].SetDefaults(calamityMod.ItemType("DaedalusBreastplate"));
                     dae.requiredItem[1].stack = 1;
                     dae.requiredItem[2].SetDefaults(calamityMod.ItemType("DaedalusLeggings"));
                     dae.requiredItem[2].stack = 1;
                     dae.requiredItem[3].SetDefaults(calamityMod.ItemType("ArchaicPowder"));
                     dae.requiredItem[3].stack = 1;
                     dae.requiredItem[4].SetDefaults(calamityMod.ItemType("ChaosAmulet"));
                     dae.requiredItem[4].stack = 1;
                     dae.requiredItem[5].SetDefaults(calamityMod.ItemType("AmbrosialAmpoule"));
                     dae.requiredItem[5].stack = 1;
                     dae.requiredItem[6].SetDefaults(calamityMod.ItemType("FrostFlare"));
                     dae.requiredItem[6].stack = 1;
                     dae.requiredItem[7].SetDefaults(calamityMod.ItemType("PermafrostsConcoction"));
                     dae.requiredItem[7].stack = 1;
                     dae.requiredItem[8].SetDefaults(calamityMod.ItemType("CryoStone"));
                     dae.requiredItem[8].stack = 1;
                     dae.requiredItem[9].SetDefaults(calamityMod.ItemType("CometShard"));
                     dae.requiredItem[9].stack = 1;
                     dae.requiredItem[10].SetDefaults(calamityMod.ItemType("Poseidon"));
                     dae.requiredItem[10].stack = 1;
                     dae.requiredItem[11].SetDefaults(calamityMod.ItemType("FrigidflashBolt"));
                     dae.requiredItem[11].stack = 1;
                     dae.requiredItem[12].SetDefaults(calamityMod.ItemType("DaedalusGolemStaff"));
                     dae.requiredItem[12].stack = 1;
                     dae.requiredItem[13].SetDefaults(calamityMod.ItemType("SoulofCryogen"));
                     dae.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("BrimflameEnchant")
                 select x).ToList().ForEach(delegate (Recipe brimflame)
                 {
                     brimflame.requiredItem[0].SetDefaults(calamityMod.ItemType("BrimflameScowl"));
                     brimflame.requiredItem[0].stack = 1;
                     brimflame.requiredItem[1].SetDefaults(calamityMod.ItemType("BrimflameRobes"));
                     brimflame.requiredItem[1].stack = 1;
                     brimflame.requiredItem[2].SetDefaults(calamityMod.ItemType("BrimflameBoots"));
                     brimflame.requiredItem[2].stack = 1;
                     brimflame.requiredItem[3].SetDefaults(calamityMod.ItemType("AngelTreads"));
                     brimflame.requiredItem[3].stack = 1;
                     brimflame.requiredItem[4].SetDefaults(calamityMod.ItemType("Abaddon"));
                     brimflame.requiredItem[4].stack = 1;
                     brimflame.requiredItem[5].SetDefaults(calamityMod.ItemType("AbyssalMirror"));
                     brimflame.requiredItem[5].stack = 1;
                     brimflame.requiredItem[6].SetDefaults(calamityMod.ItemType("StatisBlessing"));
                     brimflame.requiredItem[6].stack = 1;
                     brimflame.requiredItem[7].SetDefaults(calamityMod.ItemType("BloodOrange"));
                     brimflame.requiredItem[7].stack = 1;
                     brimflame.requiredItem[8].SetDefaults(calamityMod.ItemType("CharredRelic"));
                     brimflame.requiredItem[8].stack = 1;
                     brimflame.requiredItem[9].SetDefaults(calamityMod.ItemType("MountedScanner"));
                     brimflame.requiredItem[9].stack = 1;
                     brimflame.requiredItem[10].SetDefaults(calamityMod.ItemType("ArtAttack"));
                     brimflame.requiredItem[10].stack = 1;
                     brimflame.requiredItem[11].SetDefaults(calamityMod.ItemType("Brimlash"));
                     brimflame.requiredItem[11].stack = 1;
                     brimflame.requiredItem[12].SetDefaults(calamityMod.ItemType("Butcher"));
                     brimflame.requiredItem[12].stack = 1;
                     brimflame.requiredItem[13].SetDefaults(calamityMod.ItemType("IgneousExaltation"));
                     brimflame.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("ReaverEnchant")
                 select x).ToList().ForEach(delegate (Recipe reaver)
                 {
                     reaver.requiredItem[0].SetDefaults(calamityMod.ItemType("ReaverHelm"));
                     reaver.requiredItem[0].stack = 1;
                     reaver.requiredItem[1].SetDefaults(calamityMod.ItemType("ReaverScaleMail"));
                     reaver.requiredItem[1].stack = 1;
                     reaver.requiredItem[2].SetDefaults(calamityMod.ItemType("ReaverCuisses"));
                     reaver.requiredItem[2].stack = 1;
                     reaver.requiredItem[3].SetDefaults(calamityMod.ItemType("BloomStone"));
                     reaver.requiredItem[3].stack = 1;
                     reaver.requiredItem[4].SetDefaults(calamityMod.ItemType("HoneyDew"));
                     reaver.requiredItem[4].stack = 1;
                     reaver.requiredItem[5].SetDefaults(calamityMod.ItemType("HowlsHeart"));
                     reaver.requiredItem[5].stack = 1;
                     reaver.requiredItem[6].SetDefaults(calamityMod.ItemType("NecklaceofVexation"));
                     reaver.requiredItem[6].stack = 1;
                     reaver.requiredItem[7].SetDefaults(calamityMod.ItemType("Hellkite"));
                     reaver.requiredItem[7].stack = 1;
                     reaver.requiredItem[8].SetDefaults(calamityMod.ItemType("TerraShiv"));
                     reaver.requiredItem[8].stack = 1;
                     reaver.requiredItem[9].SetDefaults(calamityMod.ItemType("TerraLance"));
                     reaver.requiredItem[9].stack = 1;
                     reaver.requiredItem[10].SetDefaults(calamityMod.ItemType("TerraDisk"));
                     reaver.requiredItem[10].stack = 1;
                     reaver.requiredItem[11].SetDefaults(calamityMod.ItemType("TerraFlameburster"));
                     reaver.requiredItem[11].stack = 1;
                     reaver.requiredItem[12].SetDefaults(calamityMod.ItemType("TerraRay"));
                     reaver.requiredItem[12].stack = 1;
                     reaver.requiredItem[13].SetDefaults(calamityMod.ItemType("ViralSprout"));
                     reaver.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("UmbraphileEnchant")
                 select x).ToList().ForEach(delegate (Recipe umbra)
                 {
                     umbra.requiredItem[0].SetDefaults(calamityMod.ItemType("UmbraphileHood"));
                     umbra.requiredItem[0].stack = 1;
                     umbra.requiredItem[1].SetDefaults(calamityMod.ItemType("UmbraphileRegalia"));
                     umbra.requiredItem[1].stack = 1;
                     umbra.requiredItem[2].SetDefaults(calamityMod.ItemType("UmbraphileBoots"));
                     umbra.requiredItem[2].stack = 1;
                     umbra.requiredItem[3].SetDefaults(lilados.ItemType("DesertProwlerEnchantment"));
                     umbra.requiredItem[3].stack = 1;
                     umbra.requiredItem[4].SetDefaults(calamityMod.ItemType("ChaosStone"));
                     umbra.requiredItem[4].stack = 1;
                     umbra.requiredItem[5].SetDefaults(calamityMod.ItemType("OldDie"));
                     umbra.requiredItem[5].stack = 1;
                     umbra.requiredItem[6].SetDefaults(calamityMod.ItemType("MomentumCapacitor"));
                     umbra.requiredItem[6].stack = 1;
                     umbra.requiredItem[7].SetDefaults(calamityMod.ItemType("VampiricTalisman"));
                     umbra.requiredItem[7].stack = 1;
                     umbra.requiredItem[8].SetDefaults(calamityMod.ItemType("AbyssBlade"));
                     umbra.requiredItem[8].stack = 1;
                     umbra.requiredItem[9].SetDefaults(calamityMod.ItemType("TotalityBreakers"));
                     umbra.requiredItem[9].stack = 1;
                     umbra.requiredItem[10].SetDefaults(calamityMod.ItemType("PenumbraPotion"));
                     umbra.requiredItem[10].stack = 10;
                     umbra.requiredItem[11].SetDefaults(calamityMod.ItemType("Exorcism"));
                     umbra.requiredItem[11].stack = 1;
                     umbra.requiredItem[12].SetDefaults(calamityMod.ItemType("FantasyTalisman"));
                     umbra.requiredItem[12].stack = 1000;
                     umbra.requiredItem[13].SetDefaults(calamityMod.ItemType("ValkyrieRay"));
                     umbra.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("FathomSwarmerEnchant")
                 select x).ToList().ForEach(delegate (Recipe fathom)
                 {
                     fathom.requiredItem[0].SetDefaults(calamityMod.ItemType("FathomSwarmerVisage"));
                     fathom.requiredItem[0].stack = 1;
                     fathom.requiredItem[1].SetDefaults(calamityMod.ItemType("FathomSwarmerBreastplate"));
                     fathom.requiredItem[1].stack = 1;
                     fathom.requiredItem[2].SetDefaults(calamityMod.ItemType("FathomSwarmerBoots"));
                     fathom.requiredItem[2].stack = 1;
                     fathom.requiredItem[3].SetDefaults(soulDlc.ItemType("SulphurousEnchant"));
                     fathom.requiredItem[3].stack = 1;
                     fathom.requiredItem[4].SetDefaults(calamityMod.ItemType("AbyssalDivingGear"));
                     fathom.requiredItem[4].stack = 1;
                     fathom.requiredItem[5].SetDefaults(calamityMod.ItemType("SupremeBaitTackleBoxFishingStation"));
                     fathom.requiredItem[5].stack = 1;
                     fathom.requiredItem[6].SetDefaults(calamityMod.ItemType("CorrosiveSpine"));
                     fathom.requiredItem[6].stack = 1;
                     fathom.requiredItem[7].SetDefaults(calamityMod.ItemType("LeviathanAmbergris"));
                     fathom.requiredItem[7].stack = 1;
                     fathom.requiredItem[8].SetDefaults(calamityMod.ItemType("LumenousAmulet"));
                     fathom.requiredItem[8].stack = 1;
                     fathom.requiredItem[9].SetDefaults(calamityMod.ItemType("BallisticPoisonBomb"));
                     fathom.requiredItem[9].stack = 1;
                     fathom.requiredItem[10].SetDefaults(calamityMod.ItemType("Megalodon"));
                     fathom.requiredItem[10].stack = 1;
                     fathom.requiredItem[11].SetDefaults(calamityMod.ItemType("FlakKraken"));
                     fathom.requiredItem[11].stack = 1;
                     fathom.requiredItem[12].SetDefaults(calamityMod.ItemType("Floodtide"));
                     fathom.requiredItem[12].stack = 1;
                     fathom.requiredItem[13].SetDefaults(calamityMod.ItemType("Mariana"));
                     fathom.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("AtaxiaEnchant")
                 select x).ToList().ForEach(delegate (Recipe ataxia)
                 {
                     ataxia.requiredItem[0].SetDefaults(calamityMod.ItemType("AtaxiaHelm"));
                     ataxia.requiredItem[0].stack = 1;
                     ataxia.requiredItem[1].SetDefaults(calamityMod.ItemType("AtaxiaArmor"));
                     ataxia.requiredItem[1].stack = 1;
                     ataxia.requiredItem[2].SetDefaults(calamityMod.ItemType("AtaxiaSubligar"));
                     ataxia.requiredItem[2].stack = 1;
                     ataxia.requiredItem[3].SetDefaults(calamityMod.ItemType("DiscordianWings"));
                     ataxia.requiredItem[3].stack = 1;
                     ataxia.requiredItem[4].SetDefaults(calamityMod.ItemType("DaedalusEmblem"));
                     ataxia.requiredItem[4].stack = 1;
                     ataxia.requiredItem[5].SetDefaults(calamityMod.ItemType("TheAbsorber"));
                     ataxia.requiredItem[5].stack = 1;
                     ataxia.requiredItem[6].SetDefaults(calamityMod.ItemType("SigilofCalamitas"));
                     ataxia.requiredItem[6].stack = 1;
                     ataxia.requiredItem[7].SetDefaults(calamityMod.ItemType("ThiefsDime"));
                     ataxia.requiredItem[7].stack = 1;
                     ataxia.requiredItem[8].SetDefaults(calamityMod.ItemType("MOAB"));
                     ataxia.requiredItem[8].stack = 1;
                     ataxia.requiredItem[9].SetDefaults(calamityMod.ItemType("Impaler"));
                     ataxia.requiredItem[9].stack = 1;
                     ataxia.requiredItem[10].SetDefaults(calamityMod.ItemType("TruePaladinsHammerMelee"));
                     ataxia.requiredItem[10].stack = 1;
                     ataxia.requiredItem[11].SetDefaults(calamityMod.ItemType("ForbiddenSun"));
                     ataxia.requiredItem[11].stack = 1;
                     ataxia.requiredItem[12].SetDefaults(calamityMod.ItemType("ChaoticSpreadRod"));
                     ataxia.requiredItem[12].stack = 1;
                     ataxia.requiredItem[13].SetDefaults(calamityMod.ItemType("InfernalRift"));
                     ataxia.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("PlagueReaperEnchant")
                 select x).ToList().ForEach(delegate (Recipe plaguereaper)
                 {
                     plaguereaper.requiredItem[0].SetDefaults(calamityMod.ItemType("PlagueReaperMask"));
                     plaguereaper.requiredItem[0].stack = 1;
                     plaguereaper.requiredItem[1].SetDefaults(calamityMod.ItemType("PlagueReaperVest"));
                     plaguereaper.requiredItem[1].stack = 1;
                     plaguereaper.requiredItem[2].SetDefaults(calamityMod.ItemType("PlagueReaperStriders"));
                     plaguereaper.requiredItem[2].stack = 1;
                     plaguereaper.requiredItem[3].SetDefaults(calamityMod.ItemType("AlchemicalFlask"));
                     plaguereaper.requiredItem[3].stack = 1;
                     plaguereaper.requiredItem[4].SetDefaults(calamityMod.ItemType("EtherealExtorter"));
                     plaguereaper.requiredItem[4].stack = 1;
                     plaguereaper.requiredItem[5].SetDefaults(calamityMod.ItemType("TheCamper"));
                     plaguereaper.requiredItem[5].stack = 1;
                     plaguereaper.requiredItem[6].SetDefaults(calamityMod.ItemType("TheCommunity"));
                     plaguereaper.requiredItem[6].stack = 1;
                     plaguereaper.requiredItem[7].SetDefaults(calamityMod.ItemType("VoidofExtinction"));
                     plaguereaper.requiredItem[7].stack = 1;
                     plaguereaper.requiredItem[8].SetDefaults(calamityMod.ItemType("MiracleFruit"));
                     plaguereaper.requiredItem[8].stack = 1;
                     plaguereaper.requiredItem[9].SetDefaults(calamityMod.ItemType("YanmeisKnife"));
                     plaguereaper.requiredItem[9].stack = 1;
                     plaguereaper.requiredItem[10].SetDefaults(calamityMod.ItemType("SoulHarvester"));
                     plaguereaper.requiredItem[10].stack = 1;
                     plaguereaper.requiredItem[11].SetDefaults(calamityMod.ItemType("EpidemicShredder"));
                     plaguereaper.requiredItem[11].stack = 1;
                     plaguereaper.requiredItem[12].SetDefaults(calamityMod.ItemType("TacticalPlagueEngine"));
                     plaguereaper.requiredItem[12].stack = 1;
                     plaguereaper.requiredItem[13].SetDefaults(calamityMod.ItemType("WitherBlossomsStaff"));
                     plaguereaper.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("XerocEnchant")
                 select x).ToList().ForEach(delegate (Recipe xeroc)
                 {
                     xeroc.requiredItem[0].SetDefaults(calamityMod.ItemType("XerocMask"));
                     xeroc.requiredItem[0].stack = 1;
                     xeroc.requiredItem[1].SetDefaults(calamityMod.ItemType("XerocPlateMail"));
                     xeroc.requiredItem[1].stack = 1;
                     xeroc.requiredItem[2].SetDefaults(calamityMod.ItemType("XerocCuisses"));
                     xeroc.requiredItem[2].stack = 1;
                     xeroc.requiredItem[3].SetDefaults(calamityMod.ItemType("XerocWings"));
                     xeroc.requiredItem[3].stack = 1;
                     xeroc.requiredItem[4].SetDefaults(calamityMod.ItemType("ArchAmaryllis"));
                     xeroc.requiredItem[4].stack = 1;
                     xeroc.requiredItem[5].SetDefaults(calamityMod.ItemType("TomeofFates"));
                     xeroc.requiredItem[5].stack = 1;
                     xeroc.requiredItem[6].SetDefaults(calamityMod.ItemType("GallantPickaxe"));
                     xeroc.requiredItem[6].stack = 1;
                     xeroc.requiredItem[7].SetDefaults(calamityMod.ItemType("StarofDestruction"));
                     xeroc.requiredItem[7].stack = 1;
                     xeroc.requiredItem[8].SetDefaults(calamityMod.ItemType("LuminousStriker"));
                     xeroc.requiredItem[8].stack = 1;
                     xeroc.requiredItem[9].SetDefaults(calamityMod.ItemType("CosmicRainbow"));
                     xeroc.requiredItem[9].stack = 1;
                     xeroc.requiredItem[10].SetDefaults(calamityMod.ItemType("XerocsGreatsword"));
                     xeroc.requiredItem[10].stack = 1;
                     xeroc.requiredItem[11].SetDefaults(calamityMod.ItemType("TheEmpyrean"));
                     xeroc.requiredItem[11].stack = 1;
                     xeroc.requiredItem[12].SetDefaults(calamityMod.ItemType("XerocPitchfork"));
                     xeroc.requiredItem[12].stack = 1;
                     xeroc.requiredItem[13].SetDefaults(calamityMod.ItemType("PrideHuntersPlanarRipper"));
                     xeroc.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("AstralEnchant")
                 select x).ToList().ForEach(delegate (Recipe astral)
                 {
                     astral.requiredItem[0].SetDefaults(calamityMod.ItemType("AstralHelm"));
                     astral.requiredItem[0].stack = 1;
                     astral.requiredItem[1].SetDefaults(calamityMod.ItemType("AstralBreastplate"));
                     astral.requiredItem[1].stack = 1;
                     astral.requiredItem[2].SetDefaults(calamityMod.ItemType("AstralLeggings"));
                     astral.requiredItem[2].stack = 1;
                     astral.requiredItem[3].SetDefaults(calamityMod.ItemType("AstralArcanum"));
                     astral.requiredItem[3].stack = 1;
                     astral.requiredItem[4].SetDefaults(calamityMod.ItemType("Affliction"));
                     astral.requiredItem[4].stack = 1;
                     astral.requiredItem[5].SetDefaults(calamityMod.ItemType("HideofAstrumDeus"));
                     astral.requiredItem[5].stack = 1;
                     astral.requiredItem[6].SetDefaults(calamityMod.ItemType("GravistarSabaton"));
                     astral.requiredItem[6].stack = 1;
                     astral.requiredItem[7].SetDefaults(calamityMod.ItemType("HadarianWings"));
                     astral.requiredItem[7].stack = 1;
                     astral.requiredItem[8].SetDefaults(calamityMod.ItemType("EtherealCore"));
                     astral.requiredItem[8].stack = 1;
                     astral.requiredItem[9].SetDefaults(calamityMod.ItemType("ChromaticOrb"));
                     astral.requiredItem[9].stack = 1;
                     astral.requiredItem[10].SetDefaults(calamityMod.ItemType("RadiantStar"));
                     astral.requiredItem[10].stack = 1;
                     astral.requiredItem[11].SetDefaults(calamityMod.ItemType("Starfleet"));
                     astral.requiredItem[11].stack = 1;
                     astral.requiredItem[12].SetDefaults(calamityMod.ItemType("Devastation"));
                     astral.requiredItem[12].stack = 1;
                     astral.requiredItem[13].SetDefaults(calamityMod.ItemType("SolsticeClaymore"));
                     astral.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("OmegaBlueEnchant")
                 select x).ToList().ForEach(delegate (Recipe omegaBlue)
                 {
                     omegaBlue.requiredItem[0].SetDefaults(calamityMod.ItemType("OmegaBlueHelmet"));
                     omegaBlue.requiredItem[0].stack = 1;
                     omegaBlue.requiredItem[1].SetDefaults(calamityMod.ItemType("OmegaBlueChestplate"));
                     omegaBlue.requiredItem[1].stack = 1;
                     omegaBlue.requiredItem[2].SetDefaults(calamityMod.ItemType("OmegaBlueLeggings"));
                     omegaBlue.requiredItem[2].stack = 1;
                     omegaBlue.requiredItem[3].SetDefaults(calamityMod.ItemType("AbyssalDivingSuit"));
                     omegaBlue.requiredItem[3].stack = 1;
                     omegaBlue.requiredItem[4].SetDefaults(calamityMod.ItemType("DukeScales"));
                     omegaBlue.requiredItem[4].stack = 1;
                     omegaBlue.requiredItem[5].SetDefaults(calamityMod.ItemType("MutatedTruffle"));
                     omegaBlue.requiredItem[5].stack = 1;
                     omegaBlue.requiredItem[6].SetDefaults(calamityMod.ItemType("ReaperToothNecklace"));
                     omegaBlue.requiredItem[6].stack = 1;
                     omegaBlue.requiredItem[7].SetDefaults(calamityMod.ItemType("StatisNinjaBelt"));
                     omegaBlue.requiredItem[7].stack = 1;
                     omegaBlue.requiredItem[8].SetDefaults(calamityMod.ItemType("CrescentMoon"));
                     omegaBlue.requiredItem[8].stack = 1;
                     omegaBlue.requiredItem[9].SetDefaults(calamityMod.ItemType("TheLastMourning"));
                     omegaBlue.requiredItem[9].stack = 1;
                     omegaBlue.requiredItem[10].SetDefaults(calamityMod.ItemType("HalleysInferno"));
                     omegaBlue.requiredItem[10].stack = 1;
                     omegaBlue.requiredItem[11].SetDefaults(calamityMod.ItemType("JawsOfOblivion"));
                     omegaBlue.requiredItem[11].stack = 1;
                     omegaBlue.requiredItem[12].SetDefaults(calamityMod.ItemType("Sirius"));
                     omegaBlue.requiredItem[12].stack = 1;
                     omegaBlue.requiredItem[13].SetDefaults(calamityMod.ItemType("Brimrose"));
                     omegaBlue.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("FearmongerEnchant")
                 select x).ToList().ForEach(delegate (Recipe fearmonger)
                 {
                     fearmonger.requiredItem[0].SetDefaults(calamityMod.ItemType("FearmongerGreathelm"));
                     fearmonger.requiredItem[0].stack = 1;
                     fearmonger.requiredItem[1].SetDefaults(calamityMod.ItemType("FearmongerPlateMail"));
                     fearmonger.requiredItem[1].stack = 1;
                     fearmonger.requiredItem[2].SetDefaults(calamityMod.ItemType("FearmongerGreaves"));
                     fearmonger.requiredItem[2].stack = 1;
                     fearmonger.requiredItem[3].SetDefaults(calamityMod.ItemType("SpectralVeil"));
                     fearmonger.requiredItem[3].stack = 1;
                     fearmonger.requiredItem[4].SetDefaults(calamityMod.ItemType("StatisBeltOfCurses"));
                     fearmonger.requiredItem[4].stack = 1;
                     fearmonger.requiredItem[5].SetDefaults(calamityMod.ItemType("TheAmalgam"));
                     fearmonger.requiredItem[5].stack = 1;
                     fearmonger.requiredItem[6].SetDefaults(calamityMod.ItemType("StatisCurse"));
                     fearmonger.requiredItem[6].stack = 1;
                     fearmonger.requiredItem[7].SetDefaults(calamityMod.ItemType("ElephantKiller"));
                     fearmonger.requiredItem[7].stack = 1;
                     fearmonger.requiredItem[8].SetDefaults(calamityMod.ItemType("PhantasmalRuin"));
                     fearmonger.requiredItem[8].stack = 1;
                     fearmonger.requiredItem[9].SetDefaults(calamityMod.ItemType("Nadir"));
                     fearmonger.requiredItem[9].stack = 1;
                     fearmonger.requiredItem[10].SetDefaults(calamityMod.ItemType("FaceMelter"));
                     fearmonger.requiredItem[10].stack = 1;
                     fearmonger.requiredItem[11].SetDefaults(calamityMod.ItemType("PrismaticBreaker"));
                     fearmonger.requiredItem[11].stack = 1;
                     fearmonger.requiredItem[12].SetDefaults(calamityMod.ItemType("CosmicShiv"));
                     fearmonger.requiredItem[12].stack = 1;
                     fearmonger.requiredItem[13].SetDefaults(calamityMod.ItemType("PlagueKeeper"));
                     fearmonger.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("TarragonEnchant")
                 select x).ToList().ForEach(delegate (Recipe tarragon)
                 {
                     tarragon.requiredItem[0].SetDefaults(calamityMod.ItemType("TarragonHelm"));
                     tarragon.requiredItem[0].stack = 1;
                     tarragon.requiredItem[1].SetDefaults(calamityMod.ItemType("TarragonBreastplate"));
                     tarragon.requiredItem[1].stack = 1;
                     tarragon.requiredItem[2].SetDefaults(calamityMod.ItemType("TarragonLeggings"));
                     tarragon.requiredItem[2].stack = 1;
                     tarragon.requiredItem[3].SetDefaults(calamityMod.ItemType("TarragonWings"));
                     tarragon.requiredItem[3].stack = 1;
                     tarragon.requiredItem[4].SetDefaults(calamityMod.ItemType("YharimsInsignia"));
                     tarragon.requiredItem[4].stack = 1;
                     tarragon.requiredItem[5].SetDefaults(calamityMod.ItemType("ElysianAegis"));
                     tarragon.requiredItem[5].stack = 1;
                     tarragon.requiredItem[6].SetDefaults(calamityMod.ItemType("BlazingCore"));
                     tarragon.requiredItem[6].stack = 1;
                     tarragon.requiredItem[7].SetDefaults(calamityMod.ItemType("BadgeofBravery"));
                     tarragon.requiredItem[7].stack = 1;
                     tarragon.requiredItem[8].SetDefaults(calamityMod.ItemType("SamuraiBadge"));
                     tarragon.requiredItem[8].stack = 1;
                     tarragon.requiredItem[9].SetDefaults(calamityMod.ItemType("Elderberry"));
                     tarragon.requiredItem[9].stack = 1;
                     tarragon.requiredItem[10].SetDefaults(calamityMod.ItemType("ThePrince"));
                     tarragon.requiredItem[10].stack = 1;
                     tarragon.requiredItem[11].SetDefaults(calamityMod.ItemType("Grax"));
                     tarragon.requiredItem[11].stack = 1;
                     tarragon.requiredItem[12].SetDefaults(calamityMod.ItemType("TrueTyrantYharimsUltisword"));
                     tarragon.requiredItem[12].stack = 1;
                     tarragon.requiredItem[13].SetDefaults(calamityMod.ItemType("DivineRetribution"));
                     tarragon.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("BloodflareEnchant")
                 select x).ToList().ForEach(delegate (Recipe bloodflare)
                 {
                     bloodflare.requiredItem[0].SetDefaults(calamityMod.ItemType("BloodflareMask"));
                     bloodflare.requiredItem[0].stack = 1;
                     bloodflare.requiredItem[1].SetDefaults(calamityMod.ItemType("BloodflareBodyArmor"));
                     bloodflare.requiredItem[1].stack = 1;
                     bloodflare.requiredItem[2].SetDefaults(calamityMod.ItemType("BloodflareCuisses"));
                     bloodflare.requiredItem[2].stack = 1;
                     bloodflare.requiredItem[3].SetDefaults(soulDlc.ItemType("BrimflameEnchant"));
                     bloodflare.requiredItem[3].stack = 1;
                     bloodflare.requiredItem[4].SetDefaults(calamityMod.ItemType("CoreOfTheBloodGod"));
                     bloodflare.requiredItem[4].stack = 1;
                     bloodflare.requiredItem[5].SetDefaults(calamityMod.ItemType("EldritchSoulArtifact"));
                     bloodflare.requiredItem[5].stack = 1;
                     bloodflare.requiredItem[6].SetDefaults(calamityMod.ItemType("BloodflareCore"));
                     bloodflare.requiredItem[6].stack = 1;
                     bloodflare.requiredItem[7].SetDefaults(calamityMod.ItemType("LightGodsBrilliance"));
                     bloodflare.requiredItem[7].stack = 1;
                     bloodflare.requiredItem[8].SetDefaults(calamityMod.ItemType("MagneticMeltdown"));
                     bloodflare.requiredItem[8].stack = 1;
                     bloodflare.requiredItem[9].SetDefaults(calamityMod.ItemType("DevilsSunrise"));
                     bloodflare.requiredItem[9].stack = 1;
                     bloodflare.requiredItem[10].SetDefaults(calamityMod.ItemType("FlowersOfMortality"));
                     bloodflare.requiredItem[10].stack = 1;
                     bloodflare.requiredItem[11].SetDefaults(calamityMod.ItemType("Vesuvius"));
                     bloodflare.requiredItem[11].stack = 1;
                     bloodflare.requiredItem[12].SetDefaults(calamityMod.ItemType("Viscera"));
                     bloodflare.requiredItem[12].stack = 1;
                     bloodflare.requiredItem[13].SetDefaults(calamityMod.ItemType("BloodyVein"));
                     bloodflare.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("GodSlayerEnchant")
                 select x).ToList().ForEach(delegate (Recipe godslayer)
                 {
                     godslayer.requiredItem[0].SetDefaults(calamityMod.ItemType("GodSlayerHelm"));
                     godslayer.requiredItem[0].stack = 1;
                     godslayer.requiredItem[1].SetDefaults(calamityMod.ItemType("GodSlayerChestplate"));
                     godslayer.requiredItem[1].stack = 1;
                     godslayer.requiredItem[2].SetDefaults(calamityMod.ItemType("GodSlayerLeggings"));
                     godslayer.requiredItem[2].stack = 1;
                     godslayer.requiredItem[3].SetDefaults(calamityMod.ItemType("DaawnlightSpiritOrigin"));
                     godslayer.requiredItem[3].stack = 1;
                     godslayer.requiredItem[4].SetDefaults(calamityMod.ItemType("AsgardianAegis"));
                     godslayer.requiredItem[4].stack = 1;
                     godslayer.requiredItem[5].SetDefaults(calamityMod.ItemType("DimensionalSoulArtifact"));
                     godslayer.requiredItem[5].stack = 1;
                     godslayer.requiredItem[6].SetDefaults(calamityMod.ItemType("NebulousCore"));
                     godslayer.requiredItem[6].stack = 1;
                     godslayer.requiredItem[7].SetDefaults(calamityMod.ItemType("VeneratedLocket"));
                     godslayer.requiredItem[7].stack = 1;
                     godslayer.requiredItem[8].SetDefaults(calamityMod.ItemType("GazeOfCrysthamyr"));
                     godslayer.requiredItem[8].stack = 1;
                     godslayer.requiredItem[9].SetDefaults(calamityMod.ItemType("Dragonfruit"));
                     godslayer.requiredItem[9].stack = 1;
                     godslayer.requiredItem[10].SetDefaults(calamityMod.ItemType("DevilsDevastation"));
                     godslayer.requiredItem[10].stack = 1;
                     godslayer.requiredItem[11].SetDefaults(calamityMod.ItemType("EventHorizon"));
                     godslayer.requiredItem[11].stack = 1;
                     godslayer.requiredItem[12].SetDefaults(calamityMod.ItemType("DoGCart"));
                     godslayer.requiredItem[12].stack = 1;
                     godslayer.requiredItem[13].SetDefaults(calamityMod.ItemType("CosmicPlushie"));
                     godslayer.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("SilvaEnchant")
                 select x).ToList().ForEach(delegate (Recipe silva)
                 {
                     silva.requiredItem[0].SetDefaults(calamityMod.ItemType("SilvaHelmet"));
                     silva.requiredItem[0].stack = 1;
                     silva.requiredItem[1].SetDefaults(calamityMod.ItemType("SilvaArmor"));
                     silva.requiredItem[1].stack = 1;
                     silva.requiredItem[2].SetDefaults(calamityMod.ItemType("SilvaLeggings"));
                     silva.requiredItem[2].stack = 1;
                     silva.requiredItem[3].SetDefaults(calamityMod.ItemType("BlunderBooster"));
                     silva.requiredItem[3].stack = 1;
                     silva.requiredItem[4].SetDefaults(calamityMod.ItemType("DragonScales"));
                     silva.requiredItem[4].stack = 1;
                     silva.requiredItem[5].SetDefaults(calamityMod.ItemType("DynamoStemCells"));
                     silva.requiredItem[5].stack = 1;
                     silva.requiredItem[6].SetDefaults(calamityMod.ItemType("GodlySoulArtifact"));
                     silva.requiredItem[6].stack = 1;
                     silva.requiredItem[7].SetDefaults(calamityMod.ItemType("DrewsWings"));
                     silva.requiredItem[7].stack = 1;
                     silva.requiredItem[8].SetDefaults(calamityMod.ItemType("BirdSeed"));
                     silva.requiredItem[8].stack = 1;
                     silva.requiredItem[9].SetDefaults(calamityMod.ItemType("McNuggets"));
                     silva.requiredItem[9].stack = 1;
                     silva.requiredItem[10].SetDefaults(calamityMod.ItemType("PineapplePet"));
                     silva.requiredItem[10].stack = 1;
                     silva.requiredItem[11].SetDefaults(calamityMod.ItemType("RougeSlash"));
                     silva.requiredItem[11].stack = 1;
                     silva.requiredItem[12].SetDefaults(calamityMod.ItemType("PulseDragon"));
                     silva.requiredItem[12].stack = 1;
                     silva.requiredItem[13].SetDefaults(calamityMod.ItemType("AlphaRay"));
                     silva.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("AuricEnchant")
                 select x).ToList().ForEach(delegate (Recipe auric)
                 {
                     auric.requiredItem[0].SetDefaults(calamityMod.ItemType("AuricTeslaHelm"));
                     auric.requiredItem[0].stack = 1;
                     auric.requiredItem[1].SetDefaults(calamityMod.ItemType("AuricTeslaBodyArmor"));
                     auric.requiredItem[1].stack = 1;
                     auric.requiredItem[2].SetDefaults(calamityMod.ItemType("AuricTeslaCuisses"));
                     auric.requiredItem[2].stack = 1;
                     auric.requiredItem[3].SetDefaults(calamityMod.ItemType("HeartoftheElements"));
                     auric.requiredItem[3].stack = 1;
                     auric.requiredItem[4].SetDefaults(calamityMod.ItemType("Sponge"));
                     auric.requiredItem[4].stack = 1;
                     auric.requiredItem[5].SetDefaults(calamityMod.ItemType("CelestialTracers"));
                     auric.requiredItem[5].stack = 1;
                     auric.requiredItem[6].SetDefaults(calamityMod.ItemType("ThaumaticChair"));
                     auric.requiredItem[6].stack = 1;
                     auric.requiredItem[7].SetDefaults(calamityMod.ItemType("AuricToilet"));
                     auric.requiredItem[7].stack = 1;
                     auric.requiredItem[8].SetDefaults(calamityMod.ItemType("ArkoftheCosmos"));
                     auric.requiredItem[8].stack = 1;
                     auric.requiredItem[9].SetDefaults(calamityMod.ItemType("Drataliornus"));
                     auric.requiredItem[9].stack = 1;
                     auric.requiredItem[10].SetDefaults(calamityMod.ItemType("TheWand"));
                     auric.requiredItem[10].stack = 1;
                     auric.requiredItem[11].SetDefaults(calamityMod.ItemType("MidnightSunBeacon"));
                     auric.requiredItem[11].stack = 1;
                     auric.requiredItem[12].SetDefaults(calamityMod.ItemType("Seraphim"));
                     auric.requiredItem[12].stack = 1;
                     auric.requiredItem[13].SetDefaults(calamityMod.ItemType("BossRush"));
                     auric.requiredItem[13].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("DemonShadeEnchant")
                 select x).ToList().ForEach(delegate (Recipe demonshade)
                 {
                     demonshade.requiredItem[0].SetDefaults(calamityMod.ItemType("DemonshadeHelm"));
                     demonshade.requiredItem[0].stack = 1;
                     demonshade.requiredItem[1].SetDefaults(calamityMod.ItemType("DemonshadeBreastplate"));
                     demonshade.requiredItem[1].stack = 1;
                     demonshade.requiredItem[2].SetDefaults(calamityMod.ItemType("DemonshadeGreaves"));
                     demonshade.requiredItem[2].stack = 1;
                     demonshade.requiredItem[3].SetDefaults(calamityMod.ItemType("AngelicAlliance"));
                     demonshade.requiredItem[3].stack = 1;
                     demonshade.requiredItem[4].SetDefaults(calamityMod.ItemType("Calamity"));
                     demonshade.requiredItem[4].stack = 1;
                     demonshade.requiredItem[5].SetDefaults(calamityMod.ItemType("ProfanedSoulCrystal"));
                     demonshade.requiredItem[5].stack = 1;
                     demonshade.requiredItem[6].SetDefaults(calamityMod.ItemType("ShatteredCommunity"));
                     demonshade.requiredItem[6].stack = 1;
                     demonshade.requiredItem[7].SetDefaults(calamityMod.ItemType("Eternity"));
                     demonshade.requiredItem[7].stack = 1;
                     demonshade.requiredItem[8].SetDefaults(calamityMod.ItemType("BrimstoneJewel"));
                     demonshade.requiredItem[8].stack = 1;
                     demonshade.requiredItem[9].SetDefaults(calamityMod.ItemType("CrystylCrusher"));
                     demonshade.requiredItem[9].stack = 1;
                     demonshade.requiredItem[10].SetDefaults(calamityMod.ItemType("TriactisTruePaladinianMageHammerofMightMelee"));
                     demonshade.requiredItem[10].stack = 1;
                     demonshade.requiredItem[11].SetDefaults(calamityMod.ItemType("RainbowPartyCannon"));
                     demonshade.requiredItem[11].stack = 1;
                     demonshade.requiredItem[12].SetDefaults(calamityMod.ItemType("PrototypeAndromechaRing"));
                     demonshade.requiredItem[12].stack = 1;
                     demonshade.requiredItem[13].SetDefaults(calamityMod.ItemType("NanoblackReaperRogue"));
                     demonshade.requiredItem[13].stack = 1;
                 });

                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("AnnihilationForce")
                 select x).ToList().ForEach(delegate (Recipe AF)
                 {
                     AF.requiredItem[5].SetDefaults(lilados.ItemType("PrismaticEnchantment"));
                     AF.requiredItem[5].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("DesolationForce")
                 select x).ToList().ForEach(delegate (Recipe DF)
                 {
                     DF.requiredItem[6].SetDefaults(lilados.ItemType("TitanHeartEnchantment"));
                     DF.requiredItem[6].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("DevastationForce")
                 select x).ToList().ForEach(delegate (Recipe DEVF)
                 {
                     DEVF.requiredItem[4].SetDefaults(lilados.ItemType("PlaguebringerEnchantment"));
                     DEVF.requiredItem[4].stack = 1;
                 });
                (from x in Main.recipe.ToList()
                 where x.createItem.type == soulDlc.ItemType("ExaltationForce")
                 select x).ToList().ForEach(delegate (Recipe EF)
                 {
                     EF.requiredItem[5].SetDefaults(lilados.ItemType("GemTechEnchantment"));
                     EF.requiredItem[5].stack = 1;
                 });
            }
 Mod soA = ModLoader.GetMod("SacredTools");
            if (lilados != null && soA != null && soulDlc != null)
            {
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("PrairieEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("PrairieHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("PrairieChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("PrairieLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("AncientCharm"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("GoldJavelin"));
                    s.requiredItem[4].stack = 500;
                    s.requiredItem[5].SetDefaults(soA.ItemType("PlatinumJavelin"));
                    s.requiredItem[5].stack = 500;
                    s.requiredItem[6].SetDefaults(soA.ItemType("WoodJavelin"));
                    s.requiredItem[6].stack = 500;
                    s.requiredItem[7].SetDefaults(soA.ItemType("Everbloom"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("Everglow"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("Needler"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("NeedlerCorruption"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("CommandingPotion"));
                    s.requiredItem[11].stack = 5;
                    s.requiredItem[12].SetDefaults(soA.ItemType("ThrownPotion"));
                    s.requiredItem[12].stack = 5;
                    s.requiredItem[13].SetDefaults(soA.ItemType("RobustMusclePotion"));
                    s.requiredItem[13].stack = 5;
                    //Praire Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("LapisEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("LapisHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("LapisChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("LapisLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("LapisPendant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("UpgradeGem0"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("LapisSword"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("LapisBow"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("LapisStaff"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("LapisPick"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("TheAegean"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("Haven"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("Duskshine"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("Seapalm"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("DuskPotion"));
                    s.requiredItem[13].stack = 5;
                    //Lapis Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("EerieEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("EerieHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("EerieChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("EerieLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("EerieCane"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("Hellebarde"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("GrassJavelin"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("ShadowJavelin"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("Bloodstain"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(797);
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(802);
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("RainbowHandgun"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("CharmOfH"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("TheCluster"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("EnergyRifle"));
                    s.requiredItem[13].stack = 1;
                    //Eerie Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("FrosthunterEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("FrosthunterHeaddress"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("FrosthunterWrappings"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("FrosthunterBoots"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("DecreeCharm"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("Evisceration"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("OmegaStrongbow"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("FrigidFusillade"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("FrostGlobeStaff"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("IceclawShuriken"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("FrostBeam"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("LapisJavelin"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("Pandolance"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("Pandolarra"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("PandolarPick"));
                    s.requiredItem[13].stack = 1;
                    //Frosthunter Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("DreadfireEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("PumpkinMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("PumpkinArmor"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("PumpkinBoots"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("PumpkinAmulet"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("PumpkinCarver"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("PumpkinFlare"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("HarvestStaff"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("FlamingPumpkinMask"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("VineSpear"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("Pumpnade"));
                    s.requiredItem[9].stack = 450;
                    s.requiredItem[10].SetDefaults(soA.ItemType("NaturesBetrayer"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("BluebelloftheHeavens"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("PumpYoyo"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("PandolarYoyo"));
                    s.requiredItem[13].stack = 1;
                    //Dreadfire Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("BlightboneEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("BlightMask"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("BlightChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("BlightLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("DreadflameEmblem"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("FeatherHairpin"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("Tonbogiri"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("DeathJavelin"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("PolarBramble"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("DevilsRose"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("Featherbook"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("TrophyHarpy"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("Ribarang"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("DeadVoxel"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(1419);
                    s.requiredItem[13].stack = 1;
                    //Blightbone Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("SpaceJunkEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("SpaceJunkHelm"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("SpaceJunkBody"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("SpaceJunk"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("OrbFlayer"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("OrbCobalt"));
                    s.requiredItem[4].stack = 300;
                    s.requiredItem[5].SetDefaults(soA.ItemType("OrbPalladium"));
                    s.requiredItem[5].stack = 300;
                    s.requiredItem[6].SetDefaults(soA.ItemType("OrbVenomite"));
                    s.requiredItem[6].stack = 300;
                    s.requiredItem[7].SetDefaults(soA.ItemType("HornetNeedle"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("GoldDoorHandle"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("SatelliteStaff"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("Bloodbath"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("EmperorScepter"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("CursedFlameMolotov"));
                    s.requiredItem[12].stack = 500;
                    s.requiredItem[13].SetDefaults(soA.ItemType("IchorMolotov"));
                    s.requiredItem[13].stack = 500;
                    //Space Junk Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("BismuthEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("BismuthHelm"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("BismuthChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("BismuthLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("GrandWings"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("DeathsGarden"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("VenomiteSword"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("VenomiteBow"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("VenomiteStaff"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("VenomiteDagger"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("GospelOfDismay"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("ArachnesGaze"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("GraniteEradicator"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("SanguineumVirgam"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("ArachnophobiaBox"));
                    s.requiredItem[13].stack = 1;
                    //Bismuth Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("MarstechEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("MarstechHelm"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("MarstechPlate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("MarstechLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soulDlc.ItemType("SpaceJunkEnchant"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("DevilWings"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("PrimordialCore"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("UpgradeGem3"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("UpgradeGem4"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("UpgradeGem5"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("UpgradeGem6"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("TeslaGauntlet"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("PhaseSlasher"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("SolMatrix"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("EnergyFlail"));
                    s.requiredItem[13].stack = 1;
                    //Mars Tech Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("QuasarEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("NovaHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("NovaBreastplate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("NovaLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("NovaWings"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("UpgradeGem7"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("TruePandolarra"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("NovaPickaxe"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("NovaHamaxe"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("NovaknifePack"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("BrinkOfDespair"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("Yakhudh"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("NovaLance"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("FairGame"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("GlassSoul"));
                    s.requiredItem[13].stack = 1;
                    //Quasar Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("VoidWardenEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("VoidHelm"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("VoidChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("VoidLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("TrueDemonWings"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("WarpTracers"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("UpgradeGem8"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("Skill_FuryForged"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("DarkRemnant"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("EdgeOfGehenna"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("DeathBreath"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("Marbas"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("Despair"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("MoonEdgedColdFront"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("Casey"));
                    s.requiredItem[13].stack = 1;
                    //Void Warden Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("VulcanReaperEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("VulcanHelm"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("VulcanChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("VulcanLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("SmolderingSpicyCurry"));
                    s.requiredItem[3].stack = 5;
                    s.requiredItem[4].SetDefaults(soA.ItemType("SerpentChain"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("Warmth"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("Evanescense"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("OblivionSpear"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("Armageddon"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("OblivionRod"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("Dawnfall"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("DespairObserverStaff"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("ShadowWrathSummonItem"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("SerpentSummon"));
                    s.requiredItem[13].stack = 1;
                    //Vulcan Reaper Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("ExitumLuxEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("ExodusHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("ExodusChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("ExodusLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("StoneOfResonance"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("LuxShardMelee"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("LuxShardRanged"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("LuxShardMagic"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("LuxShardSummon"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("LuxShardThrown"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("NightmarePotion"));
                    s.requiredItem[9].stack = 5;
                    s.requiredItem[10].SetDefaults(soA.ItemType("MoonlightPotion"));
                    s.requiredItem[10].stack = 5;
                    s.requiredItem[11].SetDefaults(soA.ItemType("LunaticWings"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("CelestialBox"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("LunarBox"));
                    s.requiredItem[13].stack = 1;
                    //Lux Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("FlariumEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("FlariumHelmet"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("FlariumChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("FlariumLeggings"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("FlariumWings"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("SerpentSceptre"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("AraghurScarf"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("FlariumEarring"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("FlariumShield"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("FlameBeamFish"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("UpgradeGem9"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("FlameBox"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("TrophySerpent_Lame"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("SerpentMask"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("SerpentTail"));
                    s.requiredItem[13].stack = 1;
                    //Flarium Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("BlazingBruteEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("BlazingBruteHelm"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("BlazingBrutePlate"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("BlazingBruteLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("SolarSigil"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("ReflectionShield"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("Nyanmere"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("StarShower"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("AsteroidShower"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("FlariumSword"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("FlariumYoyo"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("FlareFlail"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("FlariumPick"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("FlariumHamaxe"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("BanHammer"));
                    s.requiredItem[13].stack = 1;
                    //BlazingBrute Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("CosmicCommanderEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("VortexCommanderHat"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("VortexCommanderSuit"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("VortexCommanderGreaves"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("VortexSigil"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("DolphinGun"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("LightningRifle"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("PGMUltimaRatioHecateII"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("FlariumBow"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("NeedlerFlare"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("Gunblade"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("FlariumRocketLauncher"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("FlariumRifle"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("Soulhunter"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("VoidAim"));
                    s.requiredItem[13].stack = 1;
                    //Vortex Commander Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("NebulousApprenticeEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("NubaHood"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("NubaChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("NubaRobe"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("NebulaSigil"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("NubasBlessing"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("LunaticBurstStaff"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("AsthralStaff"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("CosmicCloudBracelet"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("HyperPrism"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("FatesLament"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("LampOfCinders"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("DragonDrill"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("MatterManipulator"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("SpookTome"));
                    s.requiredItem[13].stack = 1;
                    //Nebulous Apprentice Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("StellarPriestEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("StellarPriestHead"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("StellarPriestChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("StellarPriestLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("StardustSigil"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("StarScourge"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("GalaxyScepter"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("LunarCrystalStaff"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("MaxDesertStaff"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("FlariumSceptre"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("DespairObserverStaff"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("FlariumRod"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("SpookStaff"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("ManaPickaxe"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("NovanielMask"));
                    s.requiredItem[13].stack = 1;
                    //Stellar Priest Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("FallenPrinceEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("FallenPrinceHelm"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("FallenPrinceChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("FallenPrinceBoots"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("QuasarSigil"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("NovanielResolve"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("BlindJustice"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("ExitumRod"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("UpgradeGem10"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("CosmicDesolation"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("LunaticsGamble"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("SinisterKnives"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("DimensionalCrusher"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("SpookGrenade"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("FlariumFlask"));
                    s.requiredItem[13].stack = 1;
                    //Fallen Prince Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("AsthraltiteEnchant")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soA.ItemType("AsthralMelee"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soA.ItemType("AsthralChest"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soA.ItemType("AsthralLegs"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(soA.ItemType("AsthralRing"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soA.ItemType("MementoMori"));
                    s.requiredItem[4].stack = 1;
                    s.requiredItem[5].SetDefaults(soA.ItemType("CasterArcanum"));
                    s.requiredItem[5].stack = 1;
                    s.requiredItem[6].SetDefaults(soA.ItemType("Phaselash"));
                    s.requiredItem[6].stack = 1;
                    s.requiredItem[7].SetDefaults(soA.ItemType("AsthralBurster"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(soA.ItemType("AsthralTome"));
                    s.requiredItem[8].stack = 1;
                    s.requiredItem[9].SetDefaults(soA.ItemType("AsthralDroneStaff"));
                    s.requiredItem[9].stack = 1;
                    s.requiredItem[10].SetDefaults(soA.ItemType("AsthralSaber"));
                    s.requiredItem[10].stack = 1;
                    s.requiredItem[11].SetDefaults(soA.ItemType("UpgradeGem11"));
                    s.requiredItem[11].stack = 1;
                    s.requiredItem[12].SetDefaults(soA.ItemType("AsthraltiteHeadset"));
                    s.requiredItem[12].stack = 1;
                    s.requiredItem[13].SetDefaults(soA.ItemType("IDontExist"));
                    s.requiredItem[13].stack = 250;
                    //Asthraltite Enchantment
                });
                (from x in Main.recipe.ToList()
                    where x.createItem.type == soulDlc.ItemType("GenerationsForce")
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[0].SetDefaults(soulDlc.ItemType("EerieEnchant"));
                    s.requiredItem[0].stack = 1;
                    s.requiredItem[1].SetDefaults(soulDlc.ItemType("BismuthEnchant"));
                    s.requiredItem[1].stack = 1;
                    s.requiredItem[2].SetDefaults(soulDlc.ItemType("DreadfireEnchant"));
                    s.requiredItem[2].stack = 1;
                    s.requiredItem[3].SetDefaults(lilados.ItemType("CairoCrusaderEnchantment"));
                    s.requiredItem[3].stack = 1;
                    s.requiredItem[4].SetDefaults(soulDlc.ItemType("MarstechEnchant"));
                    s.requiredItem[4].stack = 1;
                    //Generations Force
                });
            }
        }
    }
}