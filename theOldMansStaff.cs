using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using cryoMod.Projectiles;

namespace cryoMod.Items
{
	public class theOldMansStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Old Mans Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A strangely powerful staff seized by authorities from an old man.");
			Item.staff[Item.type] = true;
		}

		public override void SetDefaults()
		{
			Item.damage = 14;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 10;
			Item.width = 160;
			Item.height = 190;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 1000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item8;
			Item.shoot = ModContent.ProjectileType<oldShot>();
			Item.shootSpeed = 7f;
			Item.noMelee = true;
			Item.autoReuse = true;
			Item.useTurn = true;
		}
		
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}