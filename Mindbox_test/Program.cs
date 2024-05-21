using Mindbox_test;

Console.WriteLine("Введите тип фигуры");
var type = Console.ReadLine();
IFigure figure = null;
switch (type.ToLower())
{
    //предполагается что значения корректные (не проводятся проверки на >0 и существование треугольника)
    case "triangle": figure = new Triangle(4, 5, 3); break;
    case "circle": figure = new Circle(1); break;
}
if (figure != null)
{
    Console.WriteLine(figure.CalculateArea());
}
else
{
    Console.WriteLine("Неверный тип фигуры");
}


