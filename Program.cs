// Программа принимает на вход координаты двух точек и выдает расстояние между ними в 3D пространстве
Console.WriteLine("Input x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z2 ");
int z2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("distance between A&B is " +Math.Round(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)), 2));