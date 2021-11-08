using AbstractFactoryDemo.Factory;
using AbstractFactoryDemo.Services;

namespace AbstractFactoryDemo.Car
{
    public interface ICar : IVehicle, IBodyShopService
    {
        int NumberOfDoors { get; }
        
        CarMotorEnum Motor { get; }
        
        string Model { get; }
    }
}