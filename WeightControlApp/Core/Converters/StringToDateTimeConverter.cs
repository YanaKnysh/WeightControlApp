using AutoMapper;

namespace WeightControlApp.Core.Converters
{
    public class StringToDateTimeConverter : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            DateTime dateTimeResult;

            if (source == null)
            {
                return default;
            }

            if (DateTime.TryParse(source, out dateTimeResult))
            {
                return dateTimeResult;
            }

            return default;
        }
    }
}
