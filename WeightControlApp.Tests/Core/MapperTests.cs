using AutoMapper;
using WeightControlApp.Core.Classes;
using WeightControlApp.Core.Enums;
using WeightControlApp.Core.Mapper;
using WeightControlApp.Database.Tables;

namespace WeightControlApp.Tests.Core
{
    public class MapperTests
    {
        private readonly MapperConfiguration _mapperConfiguration;
        private readonly IMapper _mapper;

        public MapperTests()
        {
            _mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = _mapperConfiguration.CreateMapper();
        }

        [Fact]
        public void MappingProfile_ConfigurationIsValid()
        {
            // Assert
            _mapperConfiguration.AssertConfigurationIsValid();
        }

        [Fact]
        public void MappingProfile_MapWeightEntryToWeightMeasurement()
        {
            // Arrange
            var source = new WeightEntry(1, 54.2, WeightUnit.Kg, new DateTime(2023, 5, 3, 10, 27, 0));

            // Act
            var destination = _mapper.Map<WeightMeasurement>(source);

            // Assert
            Assert.Equal(source.Id, destination.Id);
            Assert.Equal(source.Unit, destination.Unit);
            Assert.Equal(source.Measure, destination.Measure);
            Assert.Equal(source.Date.ToString(), destination.Date);
        }

        [Fact]
        public void MappingProfile_MapWeightMeasurementToWeightEntry()
        {
            // Arrange
            var source = new WeightMeasurement()
            {
                Id = 1,
                Unit = WeightUnit.Pounds,
                Measure = 80.9,
                Date = "5/3/2023 10:27:00 AM"
            };

            // Act
            var destination = _mapper.Map<WeightEntry>(source);

            //Assert
            Assert.Equal(source.Id, destination.Id);
            Assert.Equal(source.Unit, destination.Unit);
            Assert.Equal(source.Measure, destination.Measure);
            Assert.Equal(source.Date, destination.Date.ToString());
        }
    }
}