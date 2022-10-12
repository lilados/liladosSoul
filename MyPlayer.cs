using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Player = Terraria.Player;

namespace liladossoul
{
    public class MyPlayer : ModPlayer
    {
        public static MyPlayer ModPlayer(Player player)
        {
            return player.GetModPlayer<MyPlayer>();
        }
    }

}