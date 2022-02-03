namespace CSharpHomework
{
    public abstract class Figure
    {
        public Point XY1 { get; set; }
        public Point XY2 { get; set; }
        public Point XY3 { get; set; }

        abstract public double GetArea();
    }
}
