namespace Avatar.Entities.Monuments
{
    public class AirMonument : Monument
    {
        private int airAffinity;
        public AirMonument(string name, int airAffinity) : base(name)
        {
            this.AirAffinity = airAffinity;
        }

        public int AirAffinity
        {
            get
            {
                return airAffinity;
            }

            set
            {
                airAffinity = value;
            }
        }

        public override int GetAffinity()
        {
            return this.airAffinity;
        }
    }
}