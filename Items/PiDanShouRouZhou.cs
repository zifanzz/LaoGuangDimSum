using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.Items
{
    public class PiDanShouRouZhou : ModItem
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
            Item.value = Item.buyPrice(silver: 3);
            Item.buffType = BuffID.WellFed2;
            Item.buffTime = 43200; // 12 minutes
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Rice>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Egg>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Meat>(), 1);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddTile(ModContent.TileType<Tiles.ChineseKitchenTile>());
            recipe.Register();
        }

        public override bool? UseItem(Player player)
        {
            player.AddBuff(BuffID.WellFed2, Item.buffTime);
            player.statLife += 45;
            if (player.statLife > player.statLifeMax2)
                player.statLife = player.statLifeMax2;
            return true;
        }
    }
} 