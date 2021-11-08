using System.Collections.Generic;

namespace AbstractFactoryDemo.Car.Models
{
    public class Fusca : Car
    {
        public Fusca(string color,
                     int numberOfDoors = 2,
                     CarMotorEnum motor = CarMotorEnum.Comum)
            : base(color, numberOfDoors, motor) { }

        
        public override IEnumerable<string> AvailableColors() =>
            new[] { "Branco", "Azul" };
    }
}