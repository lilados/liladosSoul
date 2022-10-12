using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
public class SaiyanScoutEnchantment : ModItem
{
			

		Mod DBZMOD = ModLoader.GetMod("DbzMod");


		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("+50 hp \nEffects of Dragon Gem Necklace, Goblin Ki Enhancer, Ki Chip.");
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
			if (DBZMOD != null)
			{
				this.DBZMOD.GetItem("DragonGemNecklace").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("GoblinKiEnhancer").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("KiChip").UpdateAccessory(player, hideVisual);
			}
			player.allDamage += 0.05f;
		}

        public override void AddRecipes()
		{
			if (DBZMOD != null)
			{ 
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(DBZMOD.ItemType("SaiyanScoutScalemail"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("SaiyanScoutPants"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("DragonGemNecklace"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("GoblinKiEnhancer"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("KiChip"), 1);	
				recipe.AddIngredient(DBZMOD.ItemType("ZTableItem"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("KiBeam"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("EnergyWave"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("FarmerShotgun"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("MRE"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("DisgustingGoop"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("FourStarDB"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("DBNote"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("BukuujutsuVol1"), 1);
				recipe.AddTile(TileID.DemonAltar);	
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}