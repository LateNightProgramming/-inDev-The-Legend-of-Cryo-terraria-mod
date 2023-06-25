using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace cryoMod.Items
{
	public class TheBladeofChemicals : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Blade of Chemicals"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Created by the workings of a mad man combining a sword and a deadly toxin");
		}

		public override void SetDefaults()
		{
			Item.damage = 60;
			Item.DamageType = DamageClass.Melee;
			Item.width = 160;
			Item.height = 190;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 45000;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBAck, bool crit) {
			target.AddBuff(BuffID.Ichor, 50);
			target.AddBuff(BuffID.Venom, 50);
			target.AddBuff(BuffID.Poisoned, 50);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddIngredient(ItemID.IronBroadsword, 10);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.CursedFlames, 1);
			recipe.AddIngredient(ItemID.ChlorophyteClaymore, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}