using WeightControlApp.Core.Enums;

namespace WeightControlApp.Core.Classes
{
    public class WeightEntry
    {
        public WeightEntry(int id, double measure, WeightUnit unit, DateTime weightDate) 
        {
            Id = id;
            Measure = measure;
            Unit = unit;
            Date = weightDate;
        }

        public WeightEntry()
        {
        }

        public int Id { get; set; }
        public double Measure { get; set; }
        public WeightUnit Unit { get; set; }
        public DateTime Date { get; set; }
    }
}
