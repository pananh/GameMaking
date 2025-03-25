using System;

namespace CompareTest
{

    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        private int speed;
        private bool onOff;
        private double radius;
        private string color;

        public Fan()
        {
            speed = SLOW;
            onOff = false;
            radius = 5;
            color = "blue";
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 1)
                {
                    onOff = false;
                    value = 0;
                }
                else
                {
                    if (value > 3)
                    { value = 3; }
                }
                speed = value;
            }
        }

        public bool OnOff
        {
            get { return onOff; }
            set { onOff = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string ToString()
        {
            if (onOff)
            {
                return "Speed " + speed + " Color " + color + " Radius " + radius + " Fan is on";
            }
            else
            {
                return "Color " + color + " Radius " + radius + " Fan is off";
            }
        }

        public string FanState
        {
            get
            {
                if (onOff) { return "Fan is on"; }
                else { return "Fan is off"; }
            }
            set
            {
                if (value == "on") { onOff = true; }
                else { onOff = false; }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            Fan fan2 = new Fan();
            Fan fan3 = new Fan();

            fan1.Speed = Fan.FAST;
            fan1.OnOff = true;
            fan1.Radius = 10;
            fan1.Color = "yellow";

            fan2.Speed = Fan.MEDIUM;
            fan2.OnOff = false;
            fan2.Radius = 5;
            fan2.Color = "blue";

            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());

            // Test riêng
            fan3.Speed = Fan.SLOW;
            fan3.OnOff = true;
            fan3.Speed = -1;
            fan3.Color = "red";
            Console.WriteLine(fan3.Speed + " " + fan3.Color + " " + fan3.FanState);

        }

    }
}
