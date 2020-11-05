using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonsterHunterWeapons.Ore.Placeable
{
    public class MachaliteOreDrop : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Machalite Ore");
            Tooltip.SetDefault("A deep blue ore from a far away world.");
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 15;
            item.width = 12;
            item.height = 12;
            item.value = 2500;
            item.rare = ItemRarityID.Blue;
            item.autoReuse = true;
            item.useTurn = true;
            item.createTile = mod.TileType("MachaliteOre"); //Tile that will be created. Currently set to stone. Needs to be set to Modded ore.
            item.maxStack = 999;
            item.stack = 1;
            item.consumable = true;
        }
    }
}