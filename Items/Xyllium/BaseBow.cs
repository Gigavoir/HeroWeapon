using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroWeapon.Items.Xyllium
{
    public class BaseBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xyllium Bow");
            Tooltip.SetDefault("Can be upgraded with a dark metal.");
        }

        public override void SetDefaults()
        {
            item.damage = 6;
            item.ranged = true;
            item.width = 22;
            item.height = 32;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = Item.buyPrice(0, 0, 75, 0);
            item.rare = 0;
            item.UseSound = SoundID.Item5;
            item.autoReuse = false;
            item.shoot = 1;
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Arrow;
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