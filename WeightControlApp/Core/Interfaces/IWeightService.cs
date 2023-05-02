using WeightControlApp.Core.Enums;

namespace WeightControlApp.Core.Interfaces
{
    public interface IWeightService
    {
        void getAllEntries();
        void AddEntry(double weight, WeightUnit weightUnit, DateTime dateTime);
        void editEntry(int id, double newWeight, WeightUnit newWeightUnit, DateTime newDateTime);
        void RemoveEntry(int id);
    }
}
