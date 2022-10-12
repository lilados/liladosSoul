using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace liladossoul.Items
{
	public class TurtleHermitEnchantment : ModItem
	{

		Mod DBZMOD = ModLoader.GetMod("DbzMod");


		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Effects of Worn Gloves, Arm Cannon, Green Scouter\nEffects of Ice Talisman and Burning Energy Amulet ");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.value = 10000;
			item.rare = ItemRarityID.Green;

		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
			player.statLifeMax2 += 50;
			if (DBZMOD != null)
			{
				this.DBZMOD.GetItem("WornGloves").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("ArmCannon").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("ScouterT2").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("IceTalisman").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("BurningEnergyAmulet").UpdateAccessory(player, hideVisual);
			}
		}

		public override void AddRecipes()
		{
			if (DBZMOD != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(DBZMOD.ItemType("HermitGi"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("HermitPants"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("KiLanternItem"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("WornGloves"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("ArmCannon"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("ScouterT2"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("IceTalisman"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("BurningEnergyAmulet"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("YajirobesKatana"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("DestructoDisk"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("DoubleSunday"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("EnergyBlastBarrage"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("Masenko"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("SpiritBall"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}