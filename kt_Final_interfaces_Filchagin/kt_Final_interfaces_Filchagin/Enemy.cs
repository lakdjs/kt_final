using kt_Final_interfaces_Filchagin.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin
{
    public class Enemy : ObjectsToCreate , IHeal
    {
        private Queue<Position> _wayPoints;

        public Enemy(string name, float damage, int hp, int xPos, int yPos, int range, int persentToHeal) : base(name, damage, hp, xPos, yPos, range)
        {
            Name = name;
            Damage = damage;
            Hp = hp;
            PersentToHeal = persentToHeal;
            Position = new Position(xPos, yPos);
            Range = range;
        }

        public int PersentToHeal { get; private set; }

        public override void CheckForNecessityAction()
        {
            if(!_alive)
            {
                return;
            }
            MoveWay();
        }
        public void AddPoint(Position newPos)
        {
            _wayPoints.Enqueue(newPos);
        }

       public void Heal(int persentToHeal)
        {
            if(_alive)
            {
                Hp *= 1 + (persentToHeal / 100);
            }
        }
        public void MoveWay()
        {
            if(_wayPoints.Count != 0)
            {
                Move(_wayPoints.Dequeue());
            }
        }
        private void Move(Position newPos)
        {
            Position oldPos = Position;
            Position.ChangePosition(newPos);
            _world.world[oldPos.X, oldPos.Y] = null;
            _world.AddEnemy(Position, this);
        }
    }
}
