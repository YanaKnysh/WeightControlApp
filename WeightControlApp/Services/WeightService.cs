using WeightControlApp.Core.Enums;
using WeightControlApp.Core.Interfaces;

namespace WeightControlApp.Services
{
    public class WeightService : IWeightService
    {
        private ISourceHandler _sourceHandler;

        public WeightService(ISourceHandler sourceHandler)
        {
            _sourceHandler = sourceHandler;
        }

        public void getAllEntries()
        {
            throw new NotImplementedException();
        }

        public void AddEntry(double weight, WeightUnit weightUnit, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public void editEntry(int id, double newWeight, WeightUnit newWeightUnit, DateTime newDateTime)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntry(int id)
        {
            throw new NotImplementedException();
        }
    }
}
