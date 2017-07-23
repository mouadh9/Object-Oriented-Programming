using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.modifyStatus();
        this.addOns = new List<string>();
    }

    private void modifyStatus()
    {
        this.Horsepower = this.Horsepower +
                          this.Horsepower * Constants.PERFORMANCE_CAR_HORSEPOWER_PERCENTAGE_MODIFIER / Constants.MAXIMUM_PERCENTAGE;

        this.Suspension = this.Suspension -
                          this.Suspension * Constants.PERFORMANCE_CAR_SUSPENSION_PERCENTAGE_MODIFIER / Constants.MAXIMUM_PERCENTAGE;
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        this.addOns.Add(addOn);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        if (this.addOns.Count > 0)
        {
            sb.AppendLine("Add-ons: " + string.Join(", ", addOns));
        }
        else
        {
            sb.AppendLine("Add-ons: None");
        }
        return sb.ToString().Trim();
    }
}
