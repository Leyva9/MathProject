namespace AnalisisProject;
internal class Program 
{
    private static void Main(string[] args)
    {
        Polinomio pol = new Polinomio(1,0,-1,-2);
        Bissections bissections = new Bissections(pol,0.0000780);
        Console.WriteLine(bissections.Root);

    }
}