using System;
using AbstractFactoryDemo.Car;
using AbstractFactoryDemo.Car.Models;

namespace AbstractFactoryDemo.Factory
{
    public static class VehicleFactory
    {
        public static ICar BuildCar(CarModelEnum model,
                                    string color = null,
                                    int numberOfDoors = 2,
                                    CarMotorEnum motor = CarMotorEnum.Comum) =>
            model switch
            {
                CarModelEnum.Brasilia => new Brasilia(color, numberOfDoors, motor),
                CarModelEnum.Fusca => new Fusca(color, numberOfDoors, motor),
                _ => throw new ArgumentOutOfRangeException(nameof(model), model, "Modelo de carro indisponível")
            };
    }
}