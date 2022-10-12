using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace soe
{
    public class SOE : GlobalItem
    {


        public override void AddRecipes()
        {
            Mod lilados = ModLoader.GetMod("liladosSoul");
            Mod SoulDLC = ModLoader.GetMod("FargowiltasSoulsDLC");
            Mod Soul = ModLoader.GetMod("FargowiltasSouls");
            if (SoulDLC != null && Soul != null)
            {
                (from x in Main.recipe.ToList() 
                    where x.createItem.type == Soul.ItemType("EternitySoul") 
                    select x).ToList().ForEach(delegate(Recipe s)
                {
                    s.requiredItem[7].SetDefaults(lilados.ItemType("SoulOfTheProfanity"));
                    s.requiredItem[7].stack = 1;
                    s.requiredItem[8].SetDefaults(Soul.ItemType("Sadism"));
                    s.requiredItem[8].stack = 30;
                });
            }
        }
    }
}
