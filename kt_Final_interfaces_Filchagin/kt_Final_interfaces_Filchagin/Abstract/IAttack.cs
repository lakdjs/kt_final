using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin.Abstract
{
    internal interface IAttack
    {
        public int Damage { get; }
        public void Attack(IDeath enemy); 
    }
}
