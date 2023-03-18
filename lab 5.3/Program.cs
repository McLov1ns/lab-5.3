namespace lab_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check();
        }
        public class Vector
        {
            private double x;
            private double y;
            public double Length { get { return Math.Sqrt(x * x + y * y); } }

            public Vector(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double X { get { return x; } set { x = value; } }
            public double Y { get { return y; } set { y = value; } }

            public override string ToString()
            {
                return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
            }
        }
        public static void Check()
        {
            Vector vector = new Vector(3, 4);
            Console.WriteLine(vector.ToString());

            vector.X = 0;
            vector.Y = -1;
            Console.WriteLine(vector.ToString());

            vector = new Vector(9, 40);
            Console.WriteLine(vector.ToString());

            Console.WriteLine(new Vector(0, 0).ToString());
        }


    }
}