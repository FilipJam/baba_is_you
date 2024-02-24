using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baba_is_you
{
    public partial class Form1 : Form
    {
        public static Form1 Main { get; set; }
        public Rectangle MapBounds => pnlMain.Bounds;

        List<Point[]> moveHistory;

        Name player, rock1, rock2;
        private Point playerFacing;

        List<ITile> pushables;
        List<ITile> controllables;

        

        public Form1()
        {
            InitializeComponent();
            Main = this;

            moveHistory = new List<Point[]>();
            Game.InitializeMap();

            Label lblPlayer = CreateLabel(backColor: Color.HotPink);
            Label lblRock = CreateLabel(backColor: Color.DarkGoldenrod);

            player = new Name("Baba", lblPlayer, Game.PlayerMove);
            rock1 = new Name("Rock", lblRock, Game.Push);
            rock2 = new Name("Rock", lblRock, Game.Push);

            player.ChangePosition(9, 2);
            rock1.ChangePosition(5, 10);
            rock2.ChangePosition(13, 5);

            controllables = new List<ITile> { player };
            pushables = new List<ITile> { rock1, rock2 };

            playerFacing = new Point(1, 0);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyData.ToString();
            switch (key)
            {
                case "Left": playerFacing.X = -1; break;
                case "Right": playerFacing.X = 1; break;
                case "Up": playerFacing.Y = -1; break;
                case "Down": playerFacing.Y = 1; break;
                case "Z": break;
                default: return;
            }



        }

        private void MovePlayers()
        {
            foreach (var player in controllables)
            {

            }

            controllables.ForEach(p => p.ExecuteAction(null));
        }

        private Label CreateLabel(string text="", Color? backColor=null)
        {
            Label lbl = new Label()
            {
                Size = new Size(Game.TileSize, Game.TileSize),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.White,
                Text = text,
                BackColor = backColor ?? pnlMain.BackColor,

            };

            pnlMain.Controls.Add(lbl);
            return lbl;
        }

        


        

        

    }
}
