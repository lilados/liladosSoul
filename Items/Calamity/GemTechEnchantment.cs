using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
	public class GemTechEnchantment : ModItem
	{


		Mod cal = ModLoader.GetMod("CalamityMod");


		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Effects of Nucleogenesis, Occult Skull Crown\nEffects of Asgardian Aegis, Yharim's Gift");
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
				this.cal.GetItem("Nucleogenesis").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("OccultSkullCrown").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("AsgardianAegis").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("YharimsGift").UpdateAccessory(player, hideVisual);
				ModLoader.GetMod("CalamityMod").Call("SetSetBonus", player, "auric", true);
			}
		}

		public override void AddRecipes()
		{
			if (cal != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(cal.ItemType("GemTechHeadgear"), 1);
				recipe.AddIngredient(cal.ItemType("GemTechBodyArmor"), 1);
				recipe.AddIngredient(cal.ItemType("GemTechSchynbaulds"), 1);
				recipe.AddIngredient(cal.ItemType("ExoThrone"), 1);
				recipe.AddIngredient(cal.ItemType("Nucleogenesis"), 1);
				recipe.AddIngredient(cal.ItemType("OccultSkullCrown"), 1);
				recipe.AddIngredient(cal.ItemType("AsgardianAegis"), 1);
				recipe.AddIngredient(cal.ItemType("YharimsGift"), 1);
				recipe.AddIngredient(cal.ItemType("TheJailor"), 1);
				recipe.AddIngredient(cal.ItemType("PhotonRipper"), 1);
				recipe.AddIngredient(cal.ItemType("RefractionRotor"), 1);
				recipe.AddIngredient(cal.ItemType("AngryChickenStaff"), 1);
				recipe.AddIngredient(cal.ItemType("SpineOfThanatos"), 1);
				recipe.AddIngredient(cal.ItemType("T1000"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}