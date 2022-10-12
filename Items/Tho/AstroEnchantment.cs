using System;
using System.Collections.Generic;
using liladossoul;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladosSoul.Items.Tho
{
		
    public class AstroEnchantment : ModItem 
    {
        private readonly Mod Tho = ModLoader.GetMod("ThoriumMod");
        public override void SetStaticDefaults()
        		{
        			Tooltip.SetDefault("Increases maximum sentries by 1");
        		}
        
        		public override void SetDefaults()
        		{
        			item.accessory = true;
        			item.value = 0;
        			item.rare = ItemRarityID.Green;
        
        		}

                public override void UpdateAccessory(Player player, bool hideVisual)
                {
	                MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
	                this.Tho.GetItem("IncubatedEgg").UpdateAccessory(player, hideVisual);
                }
                public override void UpdateEquip(Player player)
                {
	                player.maxTurrets++;
                }
                public override void AddRecipes()
                {
	                if (Tho == null) return;
	                ModRecipe recipe = new ModRecipe(Tho);
	                recipe.AddIngredient(Tho.ItemType("AstroHelmet"), 1);
	                recipe.AddIngredient(Tho.ItemType("AstroSuit"), 1);
	                recipe.AddIngredient(Tho.ItemType("AstroBoots"), 1);
	                recipe.AddIngredient(Tho.ItemType("MeteorMask"), 1);
	                recipe.AddIngredient(Tho.ItemType("Oboe"), 1);
	                recipe.AddIngredient(Tho.ItemType("MeteorStaff"), 1);
	                recipe.AddIngredient(Tho.ItemType("MeteoriteClusterBomb"), 250);
	                recipe.AddIngredient(Tho.ItemType("JellyPondWand"), 1);
	                recipe.AddIngredient(Tho.ItemType("Fork"), 1);
	                recipe.AddIngredient(Tho.ItemType("TechniqueSmokeBomb"), 1);
	                recipe.AddIngredient(Tho.ItemType("TechniqueHiddenBlade"), 1);
	                recipe.AddIngredient(Tho.ItemType("PinkPhaseblade"), 1);
	                recipe.AddIngredient(Tho.ItemType("BlackPhaseblade"), 1);
	                recipe.AddIngredient(Tho.ItemType("CyanPhaseblade"), 1);
	                recipe.AddTile(TileID.DemonAltar);
	                recipe.SetResult(this);
	                recipe.AddRecipe();
                }
    }
}