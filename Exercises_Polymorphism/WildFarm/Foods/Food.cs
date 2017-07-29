namespace WildFarm.Foods
{
    public abstract class Food
    {
        public int Quantity { get; set; }

        protected Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}