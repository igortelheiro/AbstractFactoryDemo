using System;
using AbstractFactoryDemo.Car;
using AbstractFactoryDemo.Factory;
using AbstractFactoryDemo.Services;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var brasilia = VehicleFactory.BuildCar(CarModelEnum.Brasilia, motor: CarMotorEnum.V8);

            Console.WriteLine("Novo carro construído por AbstractFactory:");
            Console.WriteLine(brasilia.Description());
            
            Console.WriteLine($"Consultando cores disponíveis para {brasilia.Model}: " + string.Join(", ", brasilia.AvailableColors()));
            brasilia.Paint("Amarelo");
            Console.WriteLine($"{brasilia.Model} pintado de {brasilia.Color}");
            
            brasilia.ExecuteBodyShopService(BodyShopServiceEnum.Polimento, "Capô");
        }
    }
}