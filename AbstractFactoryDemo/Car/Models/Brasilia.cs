using System.Collections.Generic;

namespace AbstractFactoryDemo.Car.Models
{
    public class Brasilia : Car
    {
        public Brasilia(string color,
                        int numberOfDoors = 2,
                        CarMotorEnum motor = CarMotorEnum.Comum)
            : base(color, numberOfDoors, motor) { }

        
        public override IEnumerable<string> AvailableColors() =>
            new[] { "Preto", "Amarelo" };
    }
}