namespace Avatar.Entities.Monuments
{
    public class EarthMonument : Monument
    {
        private int earthAffinity;
        public EarthMonument(string name, int earthAffinity) : base(name)
        {
            this.EarthAffinity = earthAffinity;
        }

        public int EarthAffinity
        {
            get
            {
                return earthAffinity;
            }

            set
            {
                earthAffinity = value;
            }
        }

        public override int GetAffinity() => this.earthAffinity;
    }
}