using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace liladossoul.Items
{
public class ForceOfDragonPower : ModItem
{
			


		Mod lilados = ModLoader.GetMod("liladosSoul");
		Mod souls = ModLoader.GetMod("FargowiltasSouls");

		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("Effects of Saiyan Scout Enchantment\nEffects of Turtle Hermit Enchantment\nEffects of Saiyan Battle Enchantment\nEffects of Demon Enchantment\nEffects of Black Fusion Enchantment\nEffects of Elite Saiyan Enchantment\nEffects of Radiant Enchantment\n\nI'm feelin' like a dragon today");
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
			if (lilados != null)
			{
				
				this.lilados.GetItem("SaiyanScoutEnchantment").UpdateAccessory(player, hideVisual);
				this.lilados.GetItem("TurtleHermitEnchantment").UpdateAccessory(player, hideVisual);
				this.lilados.GetItem("SaiyanBattleEnchantment").UpdateAccessory(player, hideVisual);
				this.lilados.GetItem("DemonEnchantment").UpdateAccessory(player, hideVisual);
				this.lilados.GetItem("BlackFusionEnchantment").UpdateAccessory(player, hideVisual);
				this.lilados.GetItem("EliteSaiyanEnchantment").UpdateAccessory(player, hideVisual);
				this.lilados.GetItem("RadiantEnchantment").UpdateAccessory(player, hideVisual);
			}
			if(lilados !=null && souls != null){

			}
		}

        public override void AddRecipes()
		{
			if (lilados != null)
			{ 
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(lilados.ItemType("SaiyanScoutEnchantment"), 1);
				recipe.AddIngredient(lilados.ItemType("TurtleHermitEnchantment"), 1);
				recipe.AddIngredient(lilados.ItemType("SaiyanBattleEnchantment"), 1);
				recipe.AddIngredient(lilados.ItemType("DemonEnchantment"), 1);
				recipe.AddIngredient(lilados.ItemType("BlackFusionEnchantment"), 1);
				recipe.AddIngredient(lilados.ItemType("EliteSaiyanEnchantment"), 1);
				recipe.AddIngredient(lilados.ItemType("RadiantEnchantment"), 1);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}




	}
}