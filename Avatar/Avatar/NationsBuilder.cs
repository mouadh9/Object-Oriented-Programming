using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avatar.Entities;
using Avatar.Entities.Monuments;

namespace Avatar
{
    public class NationsBuilder
    {
        private Dictionary<string, Nation> nations;

        public NationsBuilder()
        {
            this.nations = new Dictionary<string, Nation>()
            {
                {"Air", new Nation() },
                {"Fire", new Nation() },
                {"Earth", new Nation() },
                {"Water", new Nation() }
            };
        }
        public void AssignBender(List<string> benderArgs)
        {
            var benderType = benderArgs[0];
            Bender currentBender = this.GetBender(benderArgs);
            this.nations[benderType].AddBender(currentBender);
        }

        private Bender GetBender(List<string> benderArgs)
        {
            var benderType = benderArgs[0];
            var benderName = benderArgs[1];
            var benderPower = int.Parse(benderArgs[2]);
            var benderAuxParams = double.Parse(benderArgs[3]);

            switch (benderType)
            {
                case "Air":
                    return new AirBender(benderName,benderPower,benderAuxParams);
                case "Water":
                    return new WaterBender(benderName,benderPower,benderAuxParams);
                case "Fire":
                    return new FireBender(benderName,benderPower,benderAuxParams);
                case "Earth":
                    return new EarthBender(benderName,benderPower,benderAuxParams);
                default:
                    throw new ArgumentException();

            }
        }

        public void AssignMonuments(List<string> monumentsArgs)
        {
            var monumentType = monumentsArgs[0];
            Monument curreMonument = this.GetMonument(monumentsArgs);
            this.nations[monumentType].AddMonument(curreMonument);
        }

        private Monument GetMonument(List<string> monumentsArgs)
        {
            var monumentType = monumentsArgs[0];
            var monumentName = monumentsArgs[1];
            var monumentAuxParams = int.Parse(monumentsArgs[2]);

            switch (monumentType)
            {
                case "Air":
                    return new AirMonument(monumentName,monumentAuxParams);
                case "Fire":
                    return new FireMonument(monumentName,monumentAuxParams);
                case "Earth":
                    return new EarthMonument(monumentName,monumentAuxParams);
                case "Water":
                    return new WaterMonument(monumentName,monumentAuxParams);
                default:
                    throw new ArgumentException();
            }
        }

        public string GetStatus(string s)
        {
            throw new NotImplementedException();
        }

        public void IssueWar(string s)
        {
            throw new NotImplementedException();
        }

        public string GetWarsRecord()
        {
            throw new NotImplementedException();
        }
    }
}
