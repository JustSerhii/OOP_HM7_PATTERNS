using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface ICar
    {
        void Ride();
        void MakeNoise();

    }
    class Mustang : ICar
    {
        public void Ride()
        {
            Console.WriteLine("Is riding");
        }
        public void MakeNoise()
        {
            Console.WriteLine("Real car noises");
        }
    }

    interface IToyCar
    {
        void BeingControlled();
    }
    class MustangToyCar : IToyCar
    {
        public void BeingControlled()
        {
            Console.WriteLine("The toy car is getting controlled by somebody");
        }
    }

    class CarAdapter : IToyCar
    {
        private ICar car;

        public CarAdapter (ICar car)
        {
            this.car = car;
        }
        public void BeingControlled()
        {
            car.MakeNoise();
        }
    }

}
