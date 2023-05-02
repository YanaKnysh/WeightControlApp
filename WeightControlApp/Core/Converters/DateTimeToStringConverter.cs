using AutoMapper;

namespace WeightControlApp.Core.Converters
{
    public class DateTimeToStringConverter : ITypeConverter<DateTime, string>
    {
        public string Convert(DateTime source, string destination, ResolutionContext context)
        {
            return source.ToString();
        }
    }
}
