using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroWeapon.Items.Xyllium
{
	public class BaseWand : ModItem
    {
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xyllium Wand");
            Tooltip.SetDefault("Can be upgraded with a dark metal.");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.magic = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.buyPrice(0, 0, 75, 0);
            item.rare = 0;
            item.UseSound = SoundID.Item21;
            item.autoReuse = false;
            item.shoot = 124;
            item.shootSpeed = 7f;
            item.mana = 8;
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