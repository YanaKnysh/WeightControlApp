using WeightControlApp.Core.Enums;

namespace WeightControlApp.Core.Classes
{
    public class WeightEntry
    {
        public WeightEntry(int weight, WeightUnit weightUnit, DateTime weightDateTime) 
        {
            Weight = weight;
            WeightUnit = weightUnit;
            WeightDateTime = weightDateTime;
        }

        public WeightEntry()
        {
        }

        public int Weight { get; set; }
        public WeightUnit WeightUnit { get; set; }
        public DateTime WeightDateTime { get; set; }
    }
}
