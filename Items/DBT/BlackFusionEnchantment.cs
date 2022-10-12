using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
public class BlackFusionEnchantment : ModItem
{
			

		Mod DBZMOD = ModLoader.GetMod("DbzMod");


		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("Effects of Time Ring, Ancient Legend Waist Cape\nEffects of Rainbow Infuser, Luminous Sectum\nEffects Of Zenkai Charm, Spirit Charm");
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
				this.DBZMOD.GetItem("TimeRing").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("AncientLegendWaistCape").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("InfuserRainbow").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("LuminousSectum").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("ZenkaiCharm").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("SpiritCharm").UpdateAccessory(player, hideVisual);
			}
		}

        public override void AddRecipes()
		{
			if (DBZMOD != null)
			{ 
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(DBZMOD.ItemType("BlackFusionShirt"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("BlackFusionPants"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("TimeRing"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("AncientLegendWaistCape"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("InfuserRainbow"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("LuminousSectum"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("ZenkaiCharm"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("SpiritCharm"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("BukuujutsuVol3"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("Kamehamehax10"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("Supernova"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("FinalFlash"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("DestructoDiskAssault"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("SuperEnergyBarrage"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}