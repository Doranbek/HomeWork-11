using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork11Class
{
    class Student
    {
        private string Name { get; set; }
        private string FirstName { get; set; }
        private string Group;
        private string Facultet;
        private int Cours { get; set; }
        private int Age { get; set; }

        public string group
        {
            get
            {
                return Group;
            }
            set
            {
                if (string.IsNullOrEmpty(Facultet))
                {
                    Console.WriteLine("Значение group пустое");
                }
                group = value;

            }

        }
        public string facultet
        {
            get
            {
                return Facultet;
            }
            set
            {
                if (string.IsNullOrEmpty(Facultet))
                {
                    Console.WriteLine("Значение Facultet пустое");
                }
                facultet = value;

            }
        }


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
            Group = group;
            Facultet = facultet;
        }

    }
}
