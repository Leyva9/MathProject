namespace AnalisisProject;
internal class Program 
{
    private static void Main(string[] args)
    {
        Polinomio pol = new Polinomio(1, 5, 8, 3);
        System.Console.WriteLine("a: {0} b: {1}", Bolzano.FindInterval(pol).Item1, Bolzano.FindInterval(pol).Item2);
        System.Console.WriteLine(Bolzano.Check((-1,1/2),pol)); //Probando la nueva funcion
        
    }
}