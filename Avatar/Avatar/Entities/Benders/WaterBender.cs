namespace Avatar
{
    public class WaterBender : Bender
    {
        private double waterClarity;


        public WaterBender(string name, int power,double waterClarity) : base(name, power)
        {
            this.WaterClarity = waterClarity;
        }

        public double WaterClarity
        {
            get
            {
                return waterClarity;
            }

            set
            {
                waterClarity = value;
            }
        }

        public override double GetPower() => this.WaterClarity * this.Power;

        public override string ToString()
        {
            return $"{base.ToString()}, Water Clarity:{this.WaterClarity:f2}";
        }
    }
}