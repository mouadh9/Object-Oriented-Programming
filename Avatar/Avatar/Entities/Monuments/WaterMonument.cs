using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Entities.Monuments
{
    public class WaterMonument : Monument
    {
        private int waterAffinity;
        public WaterMonument(string name, int waterAffinity) : base(name)
        {
            this.WaterAffinity = waterAffinity;
        }

        public int WaterAffinity
        {
            get
            {
                return waterAffinity;
            }

            set
            {
                waterAffinity = value;
            }
        }

        public override int GetAffinity()
        {
            return this.waterAffinity;
            
        }
    }
}
