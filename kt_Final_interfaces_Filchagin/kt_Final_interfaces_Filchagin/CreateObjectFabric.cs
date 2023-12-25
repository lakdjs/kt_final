using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin
{
    public static class CreateObjectFabric
    {
        public static Enemy CreateEnemy(World world, Position position, string name, float damage, int hp, int range, int persentToHeal)
        {
            return new Enemy(name,damage,hp,position.X,position.Y,range,persentToHeal);
        }

        public static Tower CreateTower(World world, Position position, string name, float damage, int hp, int range)
        {
            return new Tower(name, damage, hp, position.X, position.Y,range);
        }
    }
}
