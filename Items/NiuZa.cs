using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.Items
{
    public class NiuZa : ModItem
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
            Item.value = Item.buyPrice(silver: 1);
            Item.buffType = BuffID.WellFed;
            Item.buffTime = 54000; // 15 minutes
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MilkCarton, 1);
            recipe.AddIngredient(ModContent.ItemType<Meat>(), 1);
            recipe.AddIngredient(ModContent.ItemType<TiaoLiaoBao>(), 1);
            recipe.AddIngredient(ModContent.ItemType<LuoBo>(), 1);
            recipe.Register();
        }

        public override bool? UseItem(Player player)
        {
            player.AddBuff(BuffID.WellFed, Item.buffTime);
            player.statLife += 40;
            if (player.statLife > player.statLifeMax2)
                player.statLife = player.statLifeMax2;
            return true;
        }
    }
}
