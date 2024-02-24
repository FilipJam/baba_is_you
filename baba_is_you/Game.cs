using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baba_is_you
{
    internal static class Game
    {
        public delegate void ObjectAction(ITile tile1, ITile tile2);

        private static int tileSize = 20;

        private static ITile[,] map;

        public static int TileSize => tileSize;
        public static ITile[,] Map => map;

        public static void InitializeMap()
        {
            int columns = Form1.Main.MapBounds.Width / tileSize;
            int rows = Form1.Main.MapBounds.Height / tileSize;
            map = new ITile[columns, rows];
        }

        public static void PlayerMove(ITile player, ITile next)
        {

        }

        public static void Push(ITile collider, ITile receiverObj)
        {
            receiverObj.X += collider.Facing.X * tileSize;
            receiverObj.Y += collider.Facing.Y * tileSize;
        }
    }
}
