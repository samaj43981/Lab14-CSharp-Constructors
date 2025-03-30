var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;

    // เปลี่ยน access modifier เป็น protected หรือ public
    protected Shape()
    {
        System.Console.WriteLine("This is some shape with unknown side");
    }

    public Shape(int NumOfSide)
    {
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    // ส่งค่าพารามิเตอร์ให้ base()
    public Circle() : base(0) // วงกลมไม่มีด้าน
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4)
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3)
    {
        System.Console.WriteLine("This is a triangle");
    }
}