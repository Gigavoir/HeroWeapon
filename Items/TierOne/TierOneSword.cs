using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroWeapon.Items.TierOne
{
	public class TierOneSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Xyllium Longsword");
			Tooltip.SetDefault("Can be upgraded with a molten metal");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 8;
            item.value = Item.buyPrice(0, 2, 0, 0);
            item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"BaseSword");
            recipe.AddIngredient(ItemID.DemoniteBar, 35);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

            recipe.AddIngredient(null, "BaseSword");
            recipe.AddIngredient(ItemID.CrimtaneBar, 35);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
