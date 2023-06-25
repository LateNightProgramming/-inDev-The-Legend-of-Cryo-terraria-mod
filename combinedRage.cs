using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace cryoMod.Items
{
	public class combinedRage : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Combined Rage"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("the combined rage of two unleashed elements combined");
		}

		public override void SetDefaults()
		{
			Item.damage = 19;
			Item.DamageType = DamageClass.Melee;
			Item.width = 160;
			Item.height = 190;
			Item.useTime = 19;
			Item.useAnimation = 19;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 3000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BloodButcherer, 1);
			recipe.AddIngredient(ItemID.LightsBane, 1);
			recipe.AddIngredient(ItemID.JungleSpores, 15);
			recipe.AddIngredient(ItemID.CopperBar, 45);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}