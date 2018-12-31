using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace HeroWeapon.Tiles
{
    public class XylliumOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;  //true for block to emit light
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("XylliumOre");   //put your CustomBlock name
			minPick = 0;
			mineResist = 3f;
			soundType = 21;
            soundStyle = 2;
            AddMapEntry(new Color(100, 100, 120));
        }
      
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
            r = 0.2f;
            g = 0.2f;
            b = 0.35f;
        }
    }
}