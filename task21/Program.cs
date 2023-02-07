Console.Clear();

Console.WriteLine("введите Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите У1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double px = Math.Pow(x2 - x1, 2);
double py = Math.Pow(y2 - y1, 2);
double pz = Math.Pow(z2 - z1, 2);

double l = Math.Sqrt(px + py + pz);

Console.WriteLine($"расстояние между точками {l:f2} ");
