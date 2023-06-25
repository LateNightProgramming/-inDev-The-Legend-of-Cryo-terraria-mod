using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace cryoMod.Enemies
{
    public class theChallenger : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("the Challenger");
        }

        public override void SetDefaults()
        {
            NPC.width = 450;
            NPC.height = 110;
            NPC.damage = 162;
            NPC.lifeMax = 1250;
            NPC.value = 50f;
            NPC.aiStyle = 1;
            NPC.defense = 5;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.GreenSlime;
        }
    }
}