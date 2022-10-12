using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
	public class DesertProwlerEnchantment : ModItem
	{
		Mod cal = ModLoader.GetMod("CalamityMod");

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Effects of Amidias' Spark, Amidias' Pendant\nEffects of Raider's Talisman, Rotten Dogtooth");
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
			if (cal != null)
			{
				this.cal.GetItem("AmidiasSpark").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("AmidiasPendant").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("RottenDogtooth").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("ShieldoftheOcean").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("OceanCrest").UpdateAccessory(player, hideVisual);
				this.cal.Call(new object[4] { "SetSetBonus", player, "desertprowler", true });
			}
		}

		public override void AddRecipes()
		{
			if (cal != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(cal.ItemType("DesertProwlerHat"), 1);
				recipe.AddIngredient(cal.ItemType("DesertProwlerShirt"), 1);
				recipe.AddIngredient(cal.ItemType("DesertProwlerPants"), 1);
				recipe.AddIngredient(cal.ItemType("AmidiasSpark"), 1);
				recipe.AddIngredient(cal.ItemType("AmidiasPendant"), 1);
				recipe.AddIngredient(cal.ItemType("RottenDogtooth"), 1);
				recipe.AddIngredient(cal.ItemType("ShieldoftheOcean"), 1);
				recipe.AddIngredient(cal.ItemType("OceanCrest"), 1);
				recipe.AddIngredient(cal.ItemType("ManaRose"), 1);
				recipe.AddIngredient(cal.ItemType("SunSpiritStaff"), 1);
				recipe.AddIngredient(cal.ItemType("Basher"), 1);
				recipe.AddIngredient(cal.ItemType("AmidiasTrident"), 1);
				recipe.AddIngredient(cal.ItemType("MonstrousKnives"), 1);
				recipe.AddIngredient(cal.ItemType("OpalStriker"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}