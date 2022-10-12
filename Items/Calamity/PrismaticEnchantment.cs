using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
	public class PrismaticEnchantment : ModItem
	{


		Mod cal = ModLoader.GetMod("CalamityMod");


		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Boosts all classes\nEffects of Dark Sun Ring, Elemental Gauntlet, Elemental Quiver\nEffects of Ethereal Talisman, Phantomic Artifact, Eclipse Mirror");
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
				this.cal.GetItem("DarkSunRing").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("ElementalGauntlet").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("ElementalQuiver").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("EtherealTalisman").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("PhantomicArtifact").UpdateAccessory(player, hideVisual);
				this.cal.GetItem("EclipseMirror").UpdateAccessory(player, hideVisual);
			}

		}

		public override void AddRecipes()
		{
			if (cal != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(cal.ItemType("PrismaticHelmet"), 1);
				recipe.AddIngredient(cal.ItemType("PrismaticRegalia"), 1);
				recipe.AddIngredient(cal.ItemType("PrismaticGreaves"), 1);
				recipe.AddIngredient(cal.ItemType("DarkSunRing"), 1);
				recipe.AddIngredient(cal.ItemType("ElementalGauntlet"), 1);
				recipe.AddIngredient(cal.ItemType("ElementalQuiver"), 1);
				recipe.AddIngredient(cal.ItemType("EtherealTalisman"), 1);
				recipe.AddIngredient(cal.ItemType("PhantomicArtifact"), 1);
				recipe.AddIngredient(cal.ItemType("EclipseMirror"), 1);
				recipe.AddIngredient(cal.ItemType("PhantomHeart"), 1);
				recipe.AddIngredient(cal.ItemType("StratusSphere"), 1);
				recipe.AddIngredient(cal.ItemType("ThePack"), 1);
				recipe.AddIngredient(cal.ItemType("Seadragon"), 1);
				recipe.AddIngredient(cal.ItemType("TimeBolt"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}