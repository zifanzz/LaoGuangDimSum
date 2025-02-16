using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using LaoGuangDimSum.Items;

namespace LaoGuangDimSum.GlobalNPCs
{
    public class MeatDrops : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (!npc.friendly && npc.lifeMax > 5) // Only from actual enemies, not critters
            {
                // During blood moon, 25% chance to drop 1-2 meat
                if (Main.bloodMoon)
                {
                    if (Main.rand.NextFloat() < .25f)
                    {
                        Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<Meat>(), Main.rand.Next(1, 3));
                    }
                }
            }
        }
    }
} 