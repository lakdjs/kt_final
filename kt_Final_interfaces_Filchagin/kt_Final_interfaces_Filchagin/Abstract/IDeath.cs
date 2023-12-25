using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin.Abstract
{
    public interface IDeath
    {
        public float Hp { get; }
        public void ReceiveDamage(float damage);
    }
}
