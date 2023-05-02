using WeightControlApp.Core.Classes;

namespace WeightControlApp.Core.Interfaces
{
    public interface ISourceHandler
    {
        void CreateSourceFromScratch();
        List<WeightEntry> GetAllEntries();
    }
}
