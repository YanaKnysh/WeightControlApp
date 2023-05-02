using AutoMapper;
using WeightControlApp.Core.Interfaces;
using WeightControlApp.Core.Mapper;
using WeightControlApp.Database.Core;
using WeightControlApp.Services;

namespace WeightControlApp.Registry
{
    public static class SeriveRegistry
    {
        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<ISourceHandler, DatabaseHandler>();
            mauiAppBuilder.Services.AddTransient<IWeightService, WeightService>();
            mauiAppBuilder.Services.AddSingleton(CreateMapper());


            return mauiAppBuilder;
        }

        public static IMapper CreateMapper() 
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            return mapper;
        }
    }
}
