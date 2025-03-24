using System;




namespace Example
{
    public class Fan
    {
        public const int SPEED_SLOW = 1;
        public const int SPEED_MEDIUM = 2;
        public const int SPEED_FAST = 3;

        private int speed = SPEED_SLOW;

        public int SpeedX   // property
        {
            get { return speed; }   // get method
            set { speed = value; }  // set method
        }
        public bool IsOn { get; private set; }
       

        //public bool on { get; set; };
        private double radius = 5;
        private string color = "blue";

        public Fan()
        {
            speed = 1;
            IsOn = false;
            radius = 5;
            color = "blue";
        }

        //public void setSpeed(int newSpeed)
        //{
        //    speed = newSpeed;
        //}

        //public void setOn(bool newOn)
        //{
        //    on = newOn;
        //}

        //public void setRadius(double newRadius)
        //{
        //    radius = newRadius;
        //}

        //public void setColor(string newColor)
        //{
        //    color = newColor;
        //}

        //public int getSpeed()
        //{
        //    return speed;
        //}
        //public bool getOn()
        //{
        //    return on;
        //}
        //public double getRadius()
        //{
        //    return radius;
        //}
        //public string getColor()
        //{
        //    return color;
        //}

        public Fan(int speed, bool on, double radius, string color)
        {
            this.color = color;
            this.IsOn = on;
            this.radius = radius;
            this.speed = speed;
        }

        


        public string toString()
        {
            if (IsOn)
            {
                return "Speed: " + speed + " Color: " + color + " Radius: " + radius + " Fan is on";
            }
            else
            {
                return "Color: " + color + " Radius: " + radius + " Fan is off";
            }
        }

    };

    public class Test
    {
        public static void Main(string[] args)
        {
            Fan fan1 = new Fan(3, true, 10, "yellow");
            Fan fan2 = new Fan(2, false, 5, "blue");
            Console.WriteLine(fan1.toString());
            Console.WriteLine(fan2.toString());
        }
    };

};

