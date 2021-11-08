using System;
using System.Collections.Generic;
using System.Linq;
using AbstractFactoryDemo.Factory;
using AbstractFactoryDemo.Services;

namespace AbstractFactoryDemo.Car
{
    public abstract class Car : ICar
    {
        public int NumberOfWheels { get; protected init; }
        public VehicleTypeEnum VehicleType { get; protected init; }
        public string Color { get; private set; }
        public int NumberOfDoors { get; protected init; }
        public CarMotorEnum Motor { get; protected init; }
        
        public string Model => GetType().Name;

        protected Car(string color = null,
                      int numberOfDoors = 2,
                      CarMotorEnum motor = CarMotorEnum.Comum)
        {
            NumberOfWheels = 4;
            VehicleType = VehicleTypeEnum.Carro;
            NumberOfDoors = numberOfDoors;
            Motor = motor;
            
            try
            {
                Paint(color ?? AvailableColors().First());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Paint(AvailableColors().First());
            }            
            
        }


        public string Description() =>
            $"Carro: {Model} - Cor: {Color} - {NumberOfDoors} Portas - Motor {Motor}";


        public abstract IEnumerable<string> AvailableColors();

        
        public void Paint(string color)
        {
            if (!AvailableColors().Contains(color))
            {
                throw new ArgumentException($"Cor indisponível para {Model}");
            }
            
            Color = color;
        }

        
        public void ExecuteBodyShopService(BodyShopServiceEnum service, string part) =>
            Console.WriteLine($"Serviço de {service} realizado no {part} do carro");
    }
}