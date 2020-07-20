using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork11Class
{
    class Cars
    {
        private string CarName { get;  set; }
        private string Model { get;  set; }
        private string Color { get;  set; } = "Не крашено";
        private double Capacity { get;  set; }

        public Cars(string carName, string model, string color, double capacity) 
        {
            this.CarName = carName;
            this.Model = model;
            this.Color = color;
            this.Capacity = capacity;

        }
        public Cars(string carName, string model, double capacity)
        {
            this.CarName = carName;
            this.Model = model;
            this.Capacity = capacity;

        }
        public void Painting(string color)
        {
            this.Color = color;            
        }
        public void Setting(string color, double capacity) 
        {
            Color = color;
            Capacity = capacity;        
        }
        public void DisplayInfo() 
        {
            Console.WriteLine($"Car:{CarName} Model:{Model} Color:{Color} Engine capacity:{Capacity}"); 
        }


    }
}
