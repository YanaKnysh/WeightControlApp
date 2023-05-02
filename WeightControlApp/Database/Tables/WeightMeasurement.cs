using SQLite;
using WeightControlApp.Core.Enums;

namespace WeightControlApp.Database.Tables
{
    [Table("WeightMeasurements")]
    public class WeightMeasurement
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Indexed]
        [Column("measure")]
        public double Measure { get; set; }

        [Column("date")]
        public string Date { get; set; }

        [Column("unit")]
        public WeightUnit Unit { get; set; }
    }
}
