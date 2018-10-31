using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int currentHitPoints { get; set; }
        public int maximumHitPoints { get; set; }

        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            this.currentHitPoints = currentHitPoints;
            this.maximumHitPoints = maximumHitPoints;
        }
    }
}
