using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymExercise
{
    public class Person
    {
        public string name { set; private get; }
        private int age;

        public Person()
        { 
            
        }

       

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int GetAge
        {
            get { return age; }
            set { if (value > 0) { age = value; }
                else { Console.WriteLine("Hong bet");  }
            }
        }

        public string Getname
        {
            get => name;
            set => name = value;
        }

        public int GetAge2 => age!=10 ? age : 100;
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            Person person1 = new Person(); // Vo Dich 18    
            //Person person2 = person1;    // Chỉ vào chung person 1
            Person person2 = new Person("Tuan Anh", 20);

            person1.name = "Vo Dich";
            person1.Getname = "Rong Xanh";
            person1.GetAge = -11;
            person2.GetAge = 10;

            Console.WriteLine(person1.Getname + " " + person1.GetAge);
            Console.WriteLine(person2.Getname + " " + person2.GetAge + " " );
            Console.WriteLine(person2.Getname + " " + person2.GetAge2 + " ");
            Console.WriteLine(person2.Getname + " " + person2.GetAge + " ");

        }
    }



}
