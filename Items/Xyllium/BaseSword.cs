using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroWeapon.Items.Xyllium
{
	public class BaseSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Xyllium Sword");
			Tooltip.SetDefault("Can be upgraded with a dark metal");
		}
		public override void SetDefaults()
		{
			item.damage = 8;
			item.melee = true;
			item.width = 28;
			item.height = 29;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
            item.value = Item.buyPrice(0, 0, 75, 0);
            item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("XylliumOre"), 100);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
