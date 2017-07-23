using System.Text;

public abstract  class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearOfProduction { get; set; }
    public int Horsepower { get; set; }
    public int Acceleration { get; set; }
    public int Suspension { get; set; }
    public int Durability { get; set; }

    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.Horsepower += this.Horsepower + tuneIndex;
        this.Suspension = this.Suspension + tuneIndex / Constants.TUNING_SUSPENSION_MODIFIER;

    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Brand} {Model} {YearOfProduction}");
        sb.AppendLine($"{Horsepower} HP, 100 m/h in {Acceleration} s");
        sb.AppendLine($"{Suspension} Suspension force, {Durability} Durability");

        return sb.ToString();
    }
}

