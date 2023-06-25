using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace cryoMod.Items
{
	public class CombinedFury : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Combined Fury"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The combined fury of both unleashed elements");
		}

		public override void SetDefaults()
		{
			Item.damage = 12;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 160;
			Item.height = 190;
			Item.useTime = 10;
			Item.useAnimation = 9;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 500;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Arrow;
			Item.shootSpeed = 10;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.TendonBow, 1);
			recipe.AddIngredient(ItemID.CopperBar, 45);
			recipe.AddIngredient(ItemID.DemonBow, 1);
			recipe.AddIngredient(ItemID.JungleSpores, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}