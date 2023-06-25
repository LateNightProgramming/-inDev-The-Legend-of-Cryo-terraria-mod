using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace cryoMod.Items
{
	public class dirtPick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirt Pickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("No.");
		}

		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 160;
			Item.height = 190;
			Item.useTime = 24;
			Item.useAnimation = 24;
			Item.useStyle = 1;
			Item.knockBack = 0;
			Item.value = 1;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.pick = 25;
			Item.useTurn = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}