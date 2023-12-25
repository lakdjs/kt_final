using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin
{
    public class WorldUI
    {
        public WorldUI(World world) 
        {
            _world = world;
            _cells = new GameCellUI[_world.world.GetLength(0),_world.world.GetLength(1)];
        }
        private World _world;
        private GameCellUI[,] _cells;

        public void Draw()
        {
            //
        }
    }
}
