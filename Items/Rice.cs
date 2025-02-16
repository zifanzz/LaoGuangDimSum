using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.Items
{
    public class Rice : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useTime = 17;
            Item.useAnimation = 17;
            Item.useTurn = true;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(copper: 20);
            Item.buffType = BuffID.WellFed;
            Item.buffTime = 18000; // 5 minutes
        }

        public override bool? UseItem(Player player)
        {
            player.AddBuff(BuffID.WellFed, Item.buffTime);
            player.statLife += 10;
            if (player.statLife > player.statLifeMax2)
                player.statLife = player.statLifeMax2;
            return true;
        }
    }
}