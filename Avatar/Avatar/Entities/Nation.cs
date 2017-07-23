using System.Collections.Generic;
using System.Linq;
using Avatar.Entities.Monuments;

namespace Avatar.Entities
{
    public class Nation
    {
        private List<Bender> benders;
        private List<Monument> monuments;

        public Nation()
        {
            this.Benders = new List<Bender>();
            this.Monuments = new List<Monument>();
        }

        public List<Bender> Benders
        {
            get
            {
                return benders;
            }

            set
            {
                benders = value;
            }
        }

        public List<Monument> Monuments
        {
            get
            {
                return monuments;
            }

            set
            {
                monuments = value;
            }
        }

        public double GetTotalPower()
        {
            int moumentsIncreasePercentage = this.monuments.Sum(m => m.GetAffinity());
            double totalBendersPower =  this.Benders.Sum(b => b.GetPower());
            double totalPowerIncrese = totalBendersPower / moumentsIncreasePercentage * 100;

            return totalBendersPower + totalPowerIncrese;
        }

        public void AddBender(Bender currentBender)
        {
            this.Benders.Add(currentBender);
        }

        public void AddMonument(Monument curreMonument)
        {
            throw new System.NotImplementedException();
        }
    }
}