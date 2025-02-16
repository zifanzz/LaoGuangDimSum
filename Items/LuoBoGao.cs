using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.Items
{
    public class LuoBoGao : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useTime = 17;
            Item.useAnimation = 17;
            Item.useTurn = true;
            Item.maxStack = 30;
            Item.consumable = true;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(silver: 2);
            Item.buffType = BuffID.WellFed;
            Item.buffTime = 32400; // 9 minutes
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Flour>(), 1);
            recipe.AddIngredient(ModContent.ItemType<LuoBo>(), 1);
            recipe.AddTile(ModContent.TileType<Tiles.ChineseKitchenTile>());
            recipe.Register();
        }

        public override bool? UseItem(Player player)
        {
            player.AddBuff(BuffID.WellFed, Item.buffTime);
            player.statLife += 30;
            if (player.statLife > player.statLifeMax2)
                player.statLife = player.statLifeMax2;
            return true;
        }
    }
} 