
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
double InputData(string msg)
{
    Console.Write(msg);
    double a = double.Parse(Console.ReadLine());
    return a;
}

bool IsInputValid(double k1, double k2)
{
    if (k1 == k2) return false;
    return true;
}

double[] CrossLine(double k1, double k2, double b1, double b2)
{
    double[] coordinates = new double[2];
    coordinates[0] = (b2 - b1) / (k1 - k2);
    coordinates[1] = k1 * coordinates[0] + b1;
    return coordinates;
}

double k1 = InputData("введите k1=");
double b1 = InputData("введите b1=");
double k2 = InputData("введите k2=");
double b2 = InputData("введите b2=");
bool IsValid = IsInputValid(k1, k2);
if (IsValid)
{
    double[] Coord = CrossLine(k1, k2, b1, b2);
    double x = Coord[0];
    double y = Coord[1];
    Console.WriteLine("Отрезки пересекаются в точке с координатами x=" + x + " y=" + y);
}
else Console.WriteLine("Отрезки не пересекаются");



