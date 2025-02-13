using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.Items
{
    public class JianDui : ModItem
    {
        public override void SetDefaults()
        {
            // Adjust these values to suit your item’s size and function.
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 99;
            Item.value = Item.buyPrice(silver: 5);
            Item.rare = ItemRarityID.Blue;
            
            // Use properties: For food, you might want it to be consumable and grant a buff.
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useTime = 17;
            Item.useAnimation = 17;
            Item.consumable = true;

            // Optional: If you want to grant a buff (e.g., the Well Fed buff):
            Item.buffType = BuffID.WellFed2;
            Item.buffTime = 36000; // duration in ticks (60 ticks = 1 second)
        }
    }
}
