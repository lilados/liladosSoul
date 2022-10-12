using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
	public class ChaosSlayerEnchant : ModItem
	{


		Mod AA = ModLoader.GetMod("AAMod");


		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");
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
			if (AA != null)
			{
				this.AA.GetItem("").UpdateAccessory(player, hideVisual);
			}
		}

		public override void AddRecipes()
		{
			if (AA != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddIngredient(AA.ItemType(""), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}