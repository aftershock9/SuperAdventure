using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Derived class
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        // inherting base class constructor
        public HealingPotion(int Id, string name, string namePlural, int amountToHeal) : base(Id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}