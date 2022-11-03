void Step()
{
    int step, a, b;
    Console.WriteLine("1-e");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("2-e");
    b = int.Parse(Console.ReadLine());
    step = (int)Math.Pow(a,b);
    Console.WriteLine(step);
}