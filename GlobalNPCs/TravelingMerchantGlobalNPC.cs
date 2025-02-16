using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LaoGuangDimSum.GlobalNPCs
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
                shop.Add(new Item(ModContent.ItemType<Items.ChineseKitchen>()));
                shop.Add(new Item(ModContent.ItemType<Items.Tea>()) { shopCustomPrice = Item.buyPrice(silver: 5) });
                shop.Add(new Item(ModContent.ItemType<Items.Rice>()) { shopCustomPrice = Item.buyPrice(silver: 5) });
                shop.Add(new Item(ModContent.ItemType<Items.TiaoLiaoBao>()) { shopCustomPrice = Item.buyPrice(silver: 5) });
                shop.Add(new Item(ModContent.ItemType<Items.LuoBo>()) { shopCustomPrice = Item.buyPrice(silver: 5) });
                // Add all food items for testing
                shop.Add(new Item(ModContent.ItemType<Items.BaiZhou>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.BoLuoBao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.ChangFen>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.ChaShaoBao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.ChiZhiPaiGu>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.DanTa>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.Egg>()) { shopCustomPrice = Item.buyPrice(silver: 5) });
                shop.Add(new Item(ModContent.ItemType<Items.FenGuo>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.FengZhua>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.Flour>()) { shopCustomPrice = Item.buyPrice(silver: 5) });
                shop.Add(new Item(ModContent.ItemType<Items.GuiHuaYeZhiGao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.GuiLingGao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.HongMiChang>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.JianDui>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.JiuCaiJiao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.LiuShaBao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.LunJiaoGao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.LuoBoGao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.MaLaGao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.MaTiGao>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.Meat>()) { shopCustomPrice = Item.buyPrice(silver: 5) });
                shop.Add(new Item(ModContent.ItemType<Items.NiuZa>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.Oil>()) { shopCustomPrice = Item.buyPrice(silver: 5) });
                shop.Add(new Item(ModContent.ItemType<Items.PiDanShouRouZhou>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.YouCai>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.YouZhaGui>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.ZhaLiang>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
                shop.Add(new Item(ModContent.ItemType<Items.ZhaXianNai>()) { shopCustomPrice = Item.buyPrice(silver: 10) });
            }
        }
    }
}
