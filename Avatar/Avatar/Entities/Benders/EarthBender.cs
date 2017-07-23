namespace Avatar
{
    public class EarthBender : Bender
    {
        private double groundSaturation;
        public EarthBender(string name, int power,double groundSaturation) : base(name, power)
        {
            this.GroundSaturation = groundSaturation;
        }

        public double GroundSaturation
        {
            get
            {
                return groundSaturation;
            }

            set
            {
                groundSaturation = value;
            }
        }

        public override double GetPower() => this.GroundSaturation * this.Power;

        public override string ToString()
        {
            return $"{base.ToString()}, Ground Saturation: {this.GroundSaturation:f2}";
        }
    }
}