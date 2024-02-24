using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baba_is_you
{
    internal class Name : ITile
    {

        private string name;
        private Point facing;
        private Control control;
        private Game.ObjectAction action;
        private int mapColumnIndex;
        private int mapRowIndex;
        
        public Name(string name, Control control, Game.ObjectAction action=null)
        {
            this.name = name;
            this.control = control;
            this.action = action;
            facing = new Point(1, 0);
            mapColumnIndex = 0;
            mapRowIndex = 0;
        }

        public int Column { get => mapColumnIndex; set => mapColumnIndex = value; }
        public int Row { get => mapRowIndex; set => mapRowIndex = value; }

        public int X { get => control.Left; set => control.Left = value; }
        public int Y { get => control.Top; set => control.Top = value; }

        public Point Facing { get => facing; set => facing = value; }


        public Game.ObjectAction Action { get => action; set => action = value; }
        public void ExecuteAction(ITile other)
        {
            if (action != null)
            {
                action(this, other);
            }
        }

        public void ChangePosition(int x, int y)
        {
            Game.Map[Row, Column] = null;
            Game.Map[y, x] = this;

            Row = y;
            Column = x;
            Y = Row * Game.TileSize;
            X = Column * Game.TileSize;
            
        }
    }
}
