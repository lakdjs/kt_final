using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_Final_interfaces_Filchagin.Abstract
{
    public interface IHeal
    {
        public float Hp { get; }
        public int PersentToHeal { get; }
        public void Heal(int persentToHeal);
    }
}
