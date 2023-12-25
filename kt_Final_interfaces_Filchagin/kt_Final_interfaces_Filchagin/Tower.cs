using kt_Final_interfaces_Filchagin.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin
{
    public class Tower : ObjectsToCreate
    {
        public Tower(string name, float damage, int hp, int xPos, int yPos, int range) : base(name, damage, hp, xPos, yPos, range)
        {
            Name = name;
            Damage = damage;
            Hp = hp;
            Position = new Position(xPos, yPos);
            Range = range;
        }

    }
}
