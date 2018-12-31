using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroWeapon.Items.Xyllium
{
	public class XylliumOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Xyllium Stone");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 1;
            item.value = Item.buyPrice(0, 0, 0, 7);
            item.rare = 0;
            item.maxStack = 999;
			item.autoReuse = true;
            item.useTurn = true;
            item.consumable = true;
            item.createTile = mod.TileType("XylliumOreTile");
		}
	}
}
