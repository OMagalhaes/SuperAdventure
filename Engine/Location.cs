using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public Item itemRequiredToEnter { get; set; }
        public Quest questAvailableHere { get; set; }
        public Monster monsterLivingHere { get; set; }
        public Location locationToNorth { get; set; }
        public Location locationToEast { get; set; }
        public Location locationToSouth { get; set; }
        public Location locationToWest { get; set; }

        public Location(int id, string name, string description, Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.itemRequiredToEnter = itemRequiredToEnter;
            this.questAvailableHere = questAvailableHere;
            this.monsterLivingHere = monsterLivingHere;
        }

    }
}
