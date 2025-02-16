using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.Items
{
    public class JianDui : ModItem
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
            Item.buffType = BuffID.WellFed2;
            Item.buffTime = 36000; // 10 minutes
        }

        public override void AddRecipes()
        {
            // All possible seed types
            var seedTypes = new int[]
            {
                ItemID.GrassSeeds,
                ItemID.BlinkrootSeeds,
                ItemID.WaterleafSeeds,
                ItemID.FireblossomSeeds,
                ItemID.DaybloomSeeds,
                ItemID.MoonglowSeeds,
                ItemID.ShiverthornSeeds,
                ItemID.DeathweedSeeds
            };

            // Create a recipe variant for each seed type
            foreach (int seedType in seedTypes)
            {
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(ModContent.ItemType<Flour>(), 1);
                recipe.AddIngredient(ModContent.ItemType<Oil>(), 1);
                recipe.AddIngredient(seedType, 1);
                recipe.AddTile(ModContent.TileType<Tiles.ChineseKitchenTile>());
                recipe.Register();
            }
        }

        public override bool? UseItem(Player player)
        {
            player.AddBuff(BuffID.WellFed2, Item.buffTime);
            player.statLife += 35;
            if (player.statLife > player.statLifeMax2)
                player.statLife = player.statLifeMax2;
            return true;
        }
    }
}
