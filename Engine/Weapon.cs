using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int minimumDamage { get; set; }
        public int maximumDamage { get; set; }

        public Weapon (int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base (id, name, namePlural)
        {
            this.minimumDamage = minimumDamage;
            this.maximumDamage = maximumDamage;
        }
    }
}
