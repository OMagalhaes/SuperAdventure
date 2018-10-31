﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int gold { get; set; }
        public int experiencePoints { get; set; }
        public int level { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            this.gold = gold;
            this.experiencePoints = experiencePoints;
            this.level = level;
        }
    }
}
