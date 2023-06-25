using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace cryoMod.Items
{
	public class dirtSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirt Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A rather useless invention. Often used by kids to practice their skills.");
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
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}