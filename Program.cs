void PointIntersectionTwoLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"({x}; {y})");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = GetInput("Введите значение b1: ");
double k1 = GetInput("Введите значение k1: ");
double b2 = GetInput("Введите значение b2: ");
double k2 = GetInput("Введите значение k2: ");
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
PointIntersectionTwoLines(b1, k1, b2, k2);