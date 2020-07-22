using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork11Class
{
    class Car
    {
        public string CarName { get;  private set; }
        public string Model { get; private set; }
        public string Color { get;  private set; } = "Не крашено";
        public double Capacity { get;  private set; }

        public Car(string carName, string model, string color, double capacity) 
        {
            this.CarName = carName;
            this.Model = model;
            this.Color = color;
            this.Capacity = capacity;
        }

        public Car(string carName, string model, double capacity)
        {
            this.CarName = carName;
            this.Model = model;
            this.Capacity = capacity;
        }

        public void Painting(string color)
        {
            this.Color = color;            
        }

        public void Setting( double capacity) 
        {            
            this.Capacity = capacity;        
        }

        public void DisplayInfo() 
        {
            Console.WriteLine($"Car:{CarName} Model:{Model} Color:{Color} Engine capacity:{Capacity}"); 
        }
    }
}
