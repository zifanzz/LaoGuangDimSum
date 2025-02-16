using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.Items
{
    public class FenGuo : ModItem
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
            Item.buffType = BuffID.WellFed2;
            Item.buffTime = 32400; // 9 minutes
        }

        public override void AddRecipes()
        {
            // Base ingredients that are common to all recipes
            var commonIngredients = new int[]
            {
                ModContent.ItemType<Meat>(),
                ModContent.ItemType<Flour>(),
                ItemID.Mushroom
            };

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
                foreach (int ingredient in commonIngredients)
                {
                    recipe.AddIngredient(ingredient, 1);
                }
                recipe.AddIngredient(seedType, 1);
                recipe.AddTile(ModContent.TileType<Tiles.ChineseKitchenTile>());
                recipe.Register();
            }
        }

        public override bool? UseItem(Player player)
        {
            player.AddBuff(BuffID.WellFed2, Item.buffTime);
            player.statLife += 30;
            if (player.statLife > player.statLifeMax2)
                player.statLife = player.statLifeMax2;
            return true;
        }
    }
} 