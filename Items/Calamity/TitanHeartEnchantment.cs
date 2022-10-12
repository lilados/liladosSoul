using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
	public class TitanHeartEnchantment : ModItem
	{


		Mod cal = ModLoader.GetMod("CalamityMod");


		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Effects of Amalgamated Brain, Evasion Scarf\nEffects of The Bee, Grand Gelatin");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.value = 0;
			item.rare = ItemRarityID.Green;

		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (cal != null)
			{
				this.cal.GetItem("AmalgamatedBrain").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("EvasionScarf").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("TheBee").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("GrandGelatin").UpdateAccessory(player, hideVisual);
			}
		}

		public override void AddRecipes()
		{
			if (cal != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(cal.ItemType("TitanHeartMask"), 1);
				recipe.AddIngredient(cal.ItemType("TitanHeartMantle"), 1);
				recipe.AddIngredient(cal.ItemType("TitanHeartBoots"), 1);
				recipe.AddIngredient(cal.ItemType("AmalgamatedBrain"), 1);
				recipe.AddIngredient(cal.ItemType("EvasionScarf"), 1);
				recipe.AddIngredient(cal.ItemType("TheBee"), 1);
				recipe.AddIngredient(cal.ItemType("GrandGelatin"), 1);
				recipe.AddIngredient(cal.ItemType("Aftershock"), 1);
				recipe.AddIngredient(cal.ItemType("CursedCapper"), 1);
				recipe.AddIngredient(cal.ItemType("CorrodedCaustibow"), 1);
				recipe.AddIngredient(cal.ItemType("Avalanche"), 1);
				recipe.AddIngredient(cal.ItemType("KelvinCatalyst"), 1);
				recipe.AddIngredient(cal.ItemType("P90"), 1);
				recipe.AddIngredient(cal.ItemType("StarStruckWater"), 200);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}