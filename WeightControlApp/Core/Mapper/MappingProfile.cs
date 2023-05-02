using AutoMapper;
using System.Globalization;
using WeightControlApp.Core.Classes;
using WeightControlApp.Core.Converters;
using WeightControlApp.Database.Tables;

namespace WeightControlApp.Core.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WeightEntry, WeightMeasurement>();
            CreateMap<WeightMeasurement, WeightEntry>();
            CreateMap<string, DateTime>().ConvertUsing<StringToDateTimeConverter>();
            CreateMap<DateTime, string>().ConvertUsing<DateTimeToStringConverter>();
        }
    }
}
