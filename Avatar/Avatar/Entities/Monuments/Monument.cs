using System.Collections.Specialized;

namespace Avatar.Entities.Monuments
{
    public abstract class Monument
    {
        private string name;

        protected Monument(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public abstract int GetAffinity();
    }
}