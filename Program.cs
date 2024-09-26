using Kalkulytor;

start:


CL clas = new CL();

string symb;

Console.WriteLine("введите первое число");
double x = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("введите действие");
symb = Convert.ToString(Console.ReadLine());

Console.WriteLine("введите второе число");
double y = Convert.ToDouble(Console.ReadLine());



switch (symb)
{
    case "-":
        clas.minus(x, y);
        goto start;
    case "+":
        clas.plus(x, y);
        goto start;
    case "/":
        clas.division(x, y);
        goto start;
    case "*":
        clas.multiplication(x, y);
        goto start;

    case "степень":
        clas.degree(x, y);
        goto start;
    case "квадрат":
        clas.square(x, y);
        goto start;
    case "округление":
        clas.rounding(x, y);
        goto start;
    case "arksin":
        clas.arksin(x, y);
        goto start;
    case "sin":
        clas.sin(x, y);
        goto start;
    case "cos":
        clas.cos(x, y);
        goto start;

    case "периметр":
        clas.squarePerimeter(x, y);
        goto start;
    case "площадь":
        clas.squreArea(x, y);
        goto start;
    case "радиус":
        clas.circleRadius(x, y);
        goto start;
    case "диаметр":
        clas.circleDiameter(x, y);
        goto start;
}