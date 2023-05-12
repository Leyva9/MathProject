namespace AnalisisProject;
internal class Program
{
    private static void Main(string[] args)
    {
        Polinomio pol = new Polinomio(1, -999999999, 999999, 10000241);
        System.Console.WriteLine("a: {0} b: {1}", Bolzano.FindInterval(pol).Item1, Bolzano.FindInterval(pol).Item2);
        
    }
}