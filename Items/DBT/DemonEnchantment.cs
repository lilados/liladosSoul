using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
public class DemonEnchantment : ModItem
{
			

		Mod DBZMOD = ModLoader.GetMod("DbzMod");


		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("Effects of Senzu Bag, Bloodstained Bandana, Kaio Crystal\nEffects of Pure Energy Circlet, Spiritualist Emblem");
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
                
				this.DBZMOD.GetItem("SenzuBag").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("BloodstainedBandana").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("KaioCrystal").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("PureEnergyCirclet").UpdateAccessory(player, hideVisual);
				this.DBZMOD.GetItem("SpiritualEmblem").UpdateAccessory(player, hideVisual);
            }
            
		}

        public override void AddRecipes()
		{
			if (DBZMOD != null)
			{ 
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(DBZMOD.ItemType("CanadianDemonShirt"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("CanadianDemonLeggings"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("SenzuBag"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("BloodstainedBandana"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("KaioCrystal"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("PureEnergyCirclet"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("SpiritualEmblem"), 1);
				recipe.AddIngredient(DBZMOD.ItemType("BigBangAttack"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("SpiritBomb"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("SuperKamehameha"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("SpecialBeamCannon"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("TrapShooter"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("Scattershot"), 1);
                recipe.AddIngredient(DBZMOD.ItemType("EnergyShot"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}