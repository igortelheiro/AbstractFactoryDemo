using AbstractFactoryDemo.Services;

namespace AbstractFactoryDemo.Factory
{
    public interface IVehicle : IPaintingService
    {
        VehicleTypeEnum VehicleType { get; }
        
        int NumberOfWheels { get; }
        
        string Color { get; }

        string Description();
    }
}