using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using LaoGuangDimSum.Items;

namespace LaoGuangDimSum.GlobalNPCs
{
    public class EggDrops : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Bird || 
                npc.type == NPCID.GoldBird || 
                npc.type == NPCID.BirdRed || 
                npc.type == NPCID.BirdBlue || 
                npc.type == NPCID.Penguin)
            {
                Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<Egg>());
            }
        }
    }
} 