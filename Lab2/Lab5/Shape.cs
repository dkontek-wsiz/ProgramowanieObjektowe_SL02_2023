namespace Lab2.Lab5
{
    public abstract class Shape
    {
        public abstract double CalulateArea();

        public double GetArea()
        {
            return 0;
        }
    }


    public class Square : Shape
    {
        public double X { get; set; }

        public override double CalulateArea()
        {
            return X * X;
        }
    }
}
