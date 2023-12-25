using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin
{
    public class World
    {
        
        public ObjectsToCreate[,] world;


        public List<ObjectsToCreate> Enemies { get; private set; }
        public List<ObjectsToCreate> Towers { get; private set; }

        public World(int size)
        {
            world = new ObjectsToCreate[size, size];
            Enemies = new List<ObjectsToCreate>();
            Towers = new List<ObjectsToCreate>();
        }

        public void AddEnemy(Position position, ObjectsToCreate enemy)
        {
            Enemies.Add(enemy);
            world[position.X, position.Y] = enemy;
        }

        public void AddTower(Position position, ObjectsToCreate tower)
        {
            Enemies.Add(tower);
            world[position.X, position.Y] = tower;
        }

        public void WorldUpdate()
        {
            foreach (var tower in Towers)
            {
                tower.CheckForNecessityAction();
            }
            foreach (var enemy in Enemies)
            {
                enemy.CheckForNecessityAction();
            }
        }
    }
}
