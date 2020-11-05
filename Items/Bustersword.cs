using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonsterHunterWeapons.Items
{
    public class Bustersword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("[c/0095ff:Weapon Class: Greatsword.] \n A crude iron great sword that, despite its mass-produced quality, packs quite a punch. Press <right> for a different attack!");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.width = 1;
            item.height = 1;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 1;
            item.knockBack = 20;
            item.value = 10000;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 7);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        //Right click functionality
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 1;
                item.useTime = 20;
                item.useAnimation = 100;
                item.damage = 50;
            }
            else
            {
                item.useStyle = 1;
                item.useTime = 40;
                item.useAnimation = 40;
                item.damage = 30;
                item.shoot = ProjectileID.None;
            }
            return base.CanUseItem(player);
        }
    }
}







