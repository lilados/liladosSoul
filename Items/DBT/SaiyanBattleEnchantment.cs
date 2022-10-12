using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
public class SaiyanBattleEnchantment : ModItem
{
			

		Mod DBZMOD = ModLoader.GetMod("DbzMod");


		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("Effects of Baldur Essentia, Earthen Arcanium, Battle Kit");
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
				this.DBZMOD.GetItem("BaldurEssentia").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("BattleKit").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("EarthenArcanium").UpdateAccessory(player, hideVisual);
			}
		}

        public override void AddRecipes()
		{
			if (DBZMOD != null)
			{ 
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(DBZMOD.ItemType("SaiyanBreastplate"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("SaiyanLeggings"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("BaldurEssentia"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("BattleKit"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("EarthenArcanium"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("Kamehameha"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("GalickGun"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("HellzoneGrenade"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("BlightedFang"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("DirtyFireworks"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("KiFragment1"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("KiEssence1"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("KiStimulant"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("KaioFragment3"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}