﻿using Mindbox_test;
//предполагается что значения корректные (не проводятся проверки на >0 и существование треугольника)
IFigure figure = new Triangle(25, 40, 25);

IFigure circle = new Circle(1);

Console.WriteLine(figure.CalculateArea());

Console.WriteLine(circle.CalculateArea());


