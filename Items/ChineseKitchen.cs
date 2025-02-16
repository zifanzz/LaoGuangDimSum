using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.Items
{
    public class ChineseKitchen : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 14;
            Item.maxStack = 1;
            Item.value = Item.buyPrice(silver: 5);
            Item.rare = ItemRarityID.Cyan;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
		    Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.ChineseKitchenTile>(), 0);
        }
    }
}