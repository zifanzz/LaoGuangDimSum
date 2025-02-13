using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum
{
    // This class applies global changes to NPC behavior.
    public class TravelingMerchantGlobalNPC : GlobalNPC
    {
        // ModifyShop is called when an NPC's shop inventory is built.
        public override void ModifyShop(Terraria.ModLoader.NPCShop shop)
        {
            // Check if this NPC is the Traveling Merchant.
            if (shop.NpcType == NPCID.TravellingMerchant)
            {
                // Add each of your new items to the shop.
                shop.Add(new Item(ModContent.ItemType<Items.GuiLingGao>()));
            }
            // Check if this NPC is the Merchant.
            if (shop.NpcType == NPCID.Merchant)
            {
                // Add each of your new items to the shop.
                shop.Add(new Item(ModContent.ItemType<Items.GuiLingGao>()));
                shop.Add(new Item(ModContent.ItemType<Items.DanTa>()));
                shop.Add(new Item(ModContent.ItemType<Items.FengZhua>()));
                shop.Add(new Item(ModContent.ItemType<Items.JianDui>()));
                // shop.Add(new Item(ModContent.ItemType<Items.NiuZa>()));
                shop.Add(new Item(ModContent.ItemType<Items.NuoMiJi>()));
                shop.Add(new Item(ModContent.ItemType<Items.ShaoMai>()));
            }
        }
    }
}
