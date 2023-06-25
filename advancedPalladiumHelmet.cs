using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace cryoMod.Armour
{
    [AutoloadEquip(EquipType.Head)]
    public class advancedPalladiumHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("advanced palladium helmet");
            Tooltip.SetDefault("5% increase to melee, ranged, magic and summon damage. 15% increase to throwing damage");
        }
        public override void SetDefaults()
        {
            Item.defense = 17;
            Item.value = 2500;
            Item.rare = 3;
        }
        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Melee) += 0.05f;
            player.GetDamage(DamageClass.Ranged) += 0.05f;
            player.GetDamage(DamageClass.Magic) += 0.05f;
            player.GetDamage(DamageClass.Summon) += 0.05f;
            player.GetDamage(DamageClass.Throwing) += 0.15f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CopperHelmet, 1);
            recipe.AddIngredient(ItemID.PalladiumHelmet, 1);
            recipe.AddIngredient(ItemID.TitaniumBar, 5);
			recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}