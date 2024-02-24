using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baba_is_you
{
    internal interface ITile
    {
        int Column { get; set; }
        int Row { get; set; }
        int X { get; set; }
        int Y { get; set; }

        Point Facing { get; set; }

        void ChangePosition(int x, int y);
        void ExecuteAction(ITile other);
    }
}
