using System;

namespace Dates
{
    public class DateModifier 
    {
        public double Calculator(string date1, string date2)
        {
            DateTime dateOne = DateTime.Parse(date1);
            DateTime dateTwo = DateTime.Parse(date2);
            double result = 0;
            if (dateOne > dateTwo)
            {
                result = (dateOne - dateTwo).TotalDays;
            }
            else
            {
                result = (dateTwo - dateOne).TotalDays;
            }

            return result;
        }
    }
}