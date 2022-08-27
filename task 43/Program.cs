Console.Write("Введите коэффиценты первой прямой: ");
float k1= Convert.ToInt32(Console.ReadLine());
float b1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффиценты второй прямой: ");
float k2= Convert.ToInt32(Console.ReadLine());
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