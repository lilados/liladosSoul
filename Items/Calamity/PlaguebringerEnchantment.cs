using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
	public class PlaguebringerEnchantment : ModItem
	{


		Mod cal = ModLoader.GetMod("CalamityMod");


		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Effects of Toxic Heart and Plague Hive\nEffects of Glove Of Precision, Glove Of Recklessness");
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
				this.cal.GetItem("GloveOfPrecision").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("GloveOfRecklessness").UpdateAccessory(player, hideVisual); 
				this.cal.GetItem("PlagueHive").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("ToxicHeart").UpdateAccessory(player, hideVisual);
			}

		}

		public override void AddRecipes()
		{
			if (cal != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(cal.ItemType("PlaguebringerVisor"), 1);
				recipe.AddIngredient(cal.ItemType("PlaguebringerCarapace"), 1);
				recipe.AddIngredient(cal.ItemType("PlaguebringerPistons"), 1);
				recipe.AddIngredient(cal.ItemType("GloveOfPrecision"), 1);
				recipe.AddIngredient(cal.ItemType("GloveOfRecklessness"), 1);
				recipe.AddIngredient(cal.ItemType("ToxicHeart"), 1);
				recipe.AddIngredient(cal.ItemType("PlagueHive"), 1);
				recipe.AddIngredient(cal.ItemType("Malachite"), 1);
				recipe.AddIngredient(cal.ItemType("GalvanizingGlaive"), 1);
				recipe.AddIngredient(cal.ItemType("GaussRifle"), 1);
				recipe.AddIngredient(cal.ItemType("GatlingLaser"), 1);
				recipe.AddIngredient(cal.ItemType("PulseTurretRemote"), 1);
				recipe.AddIngredient(cal.ItemType("SystemBane"), 1);
				recipe.AddIngredient(cal.ItemType("TrueForbiddenOathblade"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}