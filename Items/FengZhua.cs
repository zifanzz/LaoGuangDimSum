using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.Items
{
    public class FengZhua : ModItem
    {
        public override void SetDefaults()
        {
            // Adjust these values to suit your item's size and function.
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 30;
            Item.value = Item.buyPrice(silver: 2);
            Item.rare = ItemRarityID.Blue;
            
            // Use properties: For food, you might want it to be consumable and grant a buff.
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useTime = 17;
            Item.useAnimation = 17;
            Item.useTurn = true;
            Item.consumable = true;

            // Optional: If you want to grant a buff (e.g., the Well Fed buff):
            Item.buffType = BuffID.WellFed;
            Item.buffTime = 21600; // duration in ticks (60 ticks = 1 second)
        }

        public override void AddRecipes()
        {
            // All possible bird types
            var birdTypes = new int[]
            {
                ItemID.Bird,
                ItemID.GoldBird,
                ItemID.BlueJay,
                ItemID.Cardinal,
                ItemID.Penguin
            };

            // Create a recipe variant for each bird type
            foreach (int birdType in birdTypes)
            {
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(birdType, 1);
                recipe.AddIngredient(ModContent.ItemType<TiaoLiaoBao>(), 1);
                recipe.AddTile(ModContent.TileType<Tiles.ChineseKitchenTile>());
                recipe.Register();
            }
        }

        public override bool? UseItem(Player player)
        {
            player.AddBuff(BuffID.WellFed, Item.buffTime);
            player.statLife += 20;
            if (player.statLife > player.statLifeMax2)
                player.statLife = player.statLifeMax2;
            return true;
        }
    }
}
