using AutoMapper;
using SQLite;
using WeightControlApp.Core.Classes;
using WeightControlApp.Core.Interfaces;
using WeightControlApp.Database.Tables;

namespace WeightControlApp.Database.Core
{
    public class DatabaseHandler : ISourceHandler
    {

        private readonly SQLiteConnection _db;
        private readonly IMapper _mapper;

        public DatabaseHandler(IMapper mapper)
        {
            _db = new SQLiteConnection(@"C:\Yana\Projects\WeightControlApp\WeightControlApp\Database\Core\weight.db");
            _mapper = mapper;
        }

        public void CreateSourceFromScratch()
        {
            _db.CreateTable<WeightMeasurement>();
        }

        public List<WeightEntry> GetAllEntries()
        {
            var entries = _db.Query<WeightMeasurement>("SELECT * FROM WeightMeasurements");

            return entries.Select(_mapper.Map<WeightMeasurement, WeightEntry>).ToList();
        }
    }
}
