using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork11Class
{
    class Student
    {
        private string Name { get; set; }
        private string FirstName { get; set; }
        private string Group { get; set; }
        private string Facultet { get; set; }
        private int Cours { get; set; }
        private int Age{ get; set; }
        
        public Student(string name, string firstName, string group, string facultet, int cours, int age)
        {
            Name = name;
            FirstName = firstName;
            Group = group;
            Facultet = facultet;
            Cours = cours;
            Age = age;
        }

        public void Info()
        {
            
            Console.WriteLine($"\nИмя студента:{Name}\nФамилия Студента:{FirstName}\n" +
                $"Группа:{Group}\nФакультет:{Facultet}\nКурс:{Cours}\nВозраст:{Age}");
        }

        public void Transfer(string group, string facultet)
        {
            if (group != "")
            {
                Group = group;
            }
            else Error("group");

            if (facultet != "")
            {
                Facultet = facultet;
            }
            else Error("facultet");

        }
        private void Error(string input)
        {            
            Console.WriteLine($"\nЗначение {input} пустое");
        }
        
    }
}
