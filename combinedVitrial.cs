using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using cryoMod.Projectiles;

namespace cryoMod.Items
{
	public class combinedVitrial : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Combined Vitriol");
			Tooltip.SetDefault("True vitrial from the unleashed elements");
			Item.staff[Item.type] = true;
		}

		public override void SetDefaults()
		{
			Item.damage = 24;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 5;
			Item.width = 160;
			Item.height = 190;
			Item.useTime = 17;
			Item.useAnimation = 17;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 1500;
			Item.rare = 3;
			Item.UseSound = SoundID.Item8;
			Item.shoot = 173;
			Item.shootSpeed = 12f;
			Item.noMelee = true;
			Item.autoReuse = true;
			Item.useTurn = true;
		}
		
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.CopperBar, 45);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddIngredient(ItemID.Ruby, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}