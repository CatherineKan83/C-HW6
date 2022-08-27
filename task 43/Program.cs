Console.WriteLine("Введите коэффиценты первой прямой: ");
Console.Write("k1: ");
float k1= Convert.ToInt32(Console.ReadLine());
Console.Write("b1: ");
float b1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффиценты второй прямой: ");
Console.Write("k2: ");
float k2= Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
float b2= Convert.ToInt32(Console.ReadLine());
float x = -((b1-b2)/(k1-k2));
float y = k1*x + b1;
if(k1!=k2)
{
    Console.WriteLine($"Точка пересечения прямых - [{x}, {y}] .");
}
else
{
    Console.WriteLine("Прямые с данными параметрами параллельны.");
}