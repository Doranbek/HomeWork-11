using System;

namespace HomeWork11Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача № 1
            Student student1 = new Student("Карл", "Маркс", "SH20", "Химия", 3, 25);
            student1.Info();
            
            student1.Transfer("", "Физика");
            student1.Info();
            
            student1.Transfer("SE20", "Экономика");
            student1.Info();
            
            //Задача № 2
            Cars car1 = new Cars("Audi", "A6", 2.3);
            Cars car2 = new Cars("Honda", "Accord", "Black", 2.4);
            car1.DisplayInfo();
            car2.DisplayInfo();
            
            car1.Painting("Red");
            car1.DisplayInfo();
            
            car1.Setting("White", 2.8);
            car1.DisplayInfo();

        }
    }
}
