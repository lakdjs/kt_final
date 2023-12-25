using kt_Final_interfaces_Filchagin.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin
{
    public class ObjectsToCreate : IDeath, IAttack, IHavingPosition, IHavingRange
    {
        protected bool _alive;
        public string Name { get; protected set; }
        public float Damage { get; protected set; }

        public float Hp { get; protected set; }


        public Position Position { get; protected set; }

        public int Range { get; protected set; }

        protected World _world;
        public ObjectsToCreate(string name, float damage, int hp, int xPos, int yPos, int range)
        {
            _alive = true;
            Name = name;
            Damage = damage;
            Hp = hp;
            Position = new Position(xPos, yPos);
            Range = range;
        }
        public virtual void CheckForNecessityAction()
        {

        }
        public void Attack(IDeath enemy)
        {
            enemy.ReceiveDamage(Damage);
        }
        public void ReceiveDamage(float damage)
        {
            Hp -= damage;
            if (Hp <= 0)
            {
                Die();
            }
        }
        public virtual void Die()
        {
            _world.world[Position.X, Position.Y] = null;
            _alive = false;
        }
    }
}
