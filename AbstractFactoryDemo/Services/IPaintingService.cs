using System.Collections.Generic;

namespace AbstractFactoryDemo.Services
{
    public interface IPaintingService
    {
        IEnumerable<string> AvailableColors();

        void Paint(string color);
    }
}