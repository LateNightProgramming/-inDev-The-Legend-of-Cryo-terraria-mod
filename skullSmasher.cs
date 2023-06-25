using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace cryoMod.Items
{
	public class skullSmasher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("skull smasher"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("created to fuck up the dungeon guardian, go wild");
		}

		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 160;
			Item.height = 190;
			Item.useTime = 1;
			Item.useAnimation = 1;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 45000;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
			Item.shoot = 1;
			Item.shootSpeed = 10f;
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBAck, bool crit) {
			target.AddBuff(BuffID.Ichor, 50);
			target.AddBuff(BuffID.Venom, 50);
			target.AddBuff(BuffID.Poisoned, 50);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 95);
			recipe.AddIngredient(ItemID.LunarBar, 65);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.SolarEruption, 1);
			recipe.AddIngredient(ItemID.NightsEdge, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}