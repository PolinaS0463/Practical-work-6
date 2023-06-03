Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double X_coord = (-b2 + b1)/(-k1 + k2);
double Y_coord = k2 * X_coord + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами: X => {X_coord}, Y => {Y_coord}");
