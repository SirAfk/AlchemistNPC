using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items
{
    public class ReversivityCoinTier6 : ModItem
    {
        public override bool Autoload(ref string name)
		{
		return ModLoader.GetMod("CalamityMod") != null;
		}

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reversivity Coin Tier 6");
			DisplayName.AddTranslation(GameCulture.Russian, "Монета реверсии Тир Шестой");
            Tooltip.SetDefault("Some Tooltip");
			Tooltip.AddTranslation(GameCulture.Russian, "Тоже еще не придумал описание"); 
        }

        public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = 10000;
			item.rare = 8;
		}
    }
}