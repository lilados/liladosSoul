using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
    public class AncientGoldEnchant : ModItem
    {
        Mod soulDLC = ModLoader.GetMod("FargowiltasSoulsDLC");
        Mod lilados = ModLoader.GetMod("liladosSoul");


        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.value = 0;
            item.rare = ItemRarityID.LightPurple;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (soulDLC != null)
            {
                lilados.GetItem("").UpdateAccessory(player, hideVisual);
            }

        }

        public override void AddRecipes()
        {
            if (lilados != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(lilados.ItemType(""), 1);
                recipe.AddTile(TileID.DemonAltar);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }




    }
}