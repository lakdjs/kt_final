using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin
{
    public class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
       
        public void ChangePosition(Position position)
        {
            X = position.X;
            Y = position.Y;
        }
        public Position CheckDistance(Position position1, Position position2)
        {
            Position distance = new Position(0,0);
            distance.X = position2.X - position1.X;
            distance.Y = position2.Y - position1.Y;
            return distance;
        }
    }
}
