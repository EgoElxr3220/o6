using System;
using System.Collections.Generic;
using System.Text;

namespace CarSpace
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public Car(string model)
        {
            Model = model;
            Speed = 0;
            
        }

        public void Accelerate()
        {
            Speed += 10;
            
        }

        public void Brake()
        {
            Speed -= 10;
            if (Speed < 0)
            {
                Speed = 0;
            }
            
        }
    }
}
