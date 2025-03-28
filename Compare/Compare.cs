using System;

namespace CompareTest
{
    
    public class Shape
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing:");
        }

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            // Code to draw a circle
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }

    public class Triangle : Shape
    {
        public override void Draw() {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw() {
            Console.WriteLine("Drawing a rectagle");
            base.Draw();
        }
    }

    class Animal { }
    class Dog : Animal { }
    


    class Program
    {

        static void PrintTypes(Animal a)
        {
            Console.WriteLine("--------" );
            Console.WriteLine(a.GetType() == typeof(Animal));
            Console.WriteLine(a is Animal);
            Console.WriteLine(a.GetType() == typeof (Dog));
            Console.WriteLine(a is Dog);
        }
        static void Main(string[] args)
        {
            //var shape = new List<Shape>() { new Rectangle(), new Triangle(), new Circle() };

            //foreach (var item in shape)
            //{
            //    item.Draw();
            //}

            //shape[1].Draw();
        
            Dog dog = new Dog();
            PrintTypes(dog);

            Animal animal = new Animal();
            PrintTypes(animal);

            Animal ani2 = dog;
            PrintTypes(ani2);

            //Dog dog2 = animal as Dog;         khong dao duoc
            //Dog dog2 = (Dog)animal;       
            //PrintTypes((Dog)dog2);

        }
    }
}
   
