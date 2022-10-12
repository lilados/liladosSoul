using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
public class EliteSaiyanEnchantment : ModItem
{
			

		Mod DBZMOD = ModLoader.GetMod("DbzMod");


		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("Effects of Ancient Legend Necklace, Metamoran Sash \nEffects of Black Diamond Shell, Majin Nucleus");
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
				this.DBZMOD.GetItem("AncientLegendNecklace").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("MetamoranSash").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("BlackDiamondShell").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("MajinNucleus").UpdateAccessory(player, hideVisual);
			}
		}

        public override void AddRecipes()
		{
			if (DBZMOD != null)
			{ 
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(DBZMOD.ItemType("EliteSaiyanBreastplate"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("EliteSaiyanLeggings"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("AncientLegendNecklace"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("BlackDiamondShell"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("MetamoranSash"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("MajinNucleus"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("TransmissionTeleport"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("CandyLaser"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("BlindingBlade"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("RadialJavelin"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("BlackBlitz"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("HolyWrath"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("SuperSpiritBomb"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("FinalShine"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}