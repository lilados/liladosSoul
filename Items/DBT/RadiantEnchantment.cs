using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
public class RadiantEnchantment : ModItem
{
			

		Mod DBZMOD = ModLoader.GetMod("DbzMod");


		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("Effects of Radiant Totem, Yellow Scouter, Crustallite Alleviate");
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
				this.DBZMOD.GetItem("RadiantTotem").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("ScouterT6").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("CrystalliteAlleviate").UpdateAccessory(player, hideVisual);
			}
		}

        public override void AddRecipes()
		{
			if (DBZMOD != null)
			{ 
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(DBZMOD.ItemType("RadiantVisor"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("RadiantScalepiece"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("RadiantGreaves"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("RadiantTotem"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("RadiantGlider"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("ScouterT6"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("CrystalliteAlleviate"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("TransmissionPura"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("DragonRadar3"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("GreenPotara"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("KaiTableItem"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("KiEssence5"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("KiFragment5"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("KaioFragment4"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}