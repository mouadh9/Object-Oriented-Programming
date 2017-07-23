namespace Avatar
{
    public class FireBender : Bender
    {
        private double heatAggression;
        public FireBender(string name, int power, double heatAggression) : base(name, power)
        {
            this.HeatAggression = heatAggression;
        }

        public double HeatAggression
        {
            get
            {
                return heatAggression;
            }

            set
            {
                heatAggression = value;
            }
        }

        public override double GetPower() => this.HeatAggression * this.Power;

        public override string ToString()
        {
            return $"{base.ToString()}, Heat Aggression: {this.HeatAggression:f2}";
        }
    }
}