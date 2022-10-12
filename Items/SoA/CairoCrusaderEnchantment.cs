using liladossoul;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace liladosSoul.Items.SoA
{

	public class CairoCrusaderEnchantment : ModItem
	{

		Mod ST = ModLoader.GetMod("SacredTools");

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

		
		public override void AddRecipes()
		{
			if (ST == null) return;
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ST.ItemType("CairoCrusaderFaulds"), 1);
			recipe.AddIngredient(ST.ItemType("CairoCrusaderRobe"), 1);
			recipe.AddIngredient(ST.ItemType("CairoCrusaderTurban"), 1);
			recipe.AddIngredient(ST.ItemType("RoyalTreads"), 1);
			recipe.AddIngredient(ST.ItemType("WildGemstone"), 1);
			recipe.AddIngredient(ST.ItemType("RoyalGuard"), 1);
			recipe.AddIngredient(ST.ItemType("UpgradeGem1"), 1);
			recipe.AddIngredient(ST.ItemType("UpgradeGem2"), 1);
			recipe.AddIngredient(ST.ItemType("TrueDecapitator"), 1);
			recipe.AddIngredient(ST.ItemType("TrueNightSpear"), 1);
			recipe.AddIngredient(ST.ItemType("TerraLance"), 1);
			recipe.AddIngredient(ST.ItemType("ElementalFlinger"), 1);
			recipe.AddIngredient(ST.ItemType("RedSword"), 1);
			recipe.AddIngredient(ST.ItemType("RedBook"), 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}