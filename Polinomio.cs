namespace MathProject;

 public class Polinomio 
{
    private double[] terms;

    public double[] Terms {get => terms; private set => terms = value;}
    
    // Esta funcion permite evaluar el polinomio en un numero real
    public double Evaluate(double x) 
    {
        double result = 0;
        try 
        {
            for(int i = 0; i < Terms.Length; i++)
            {
                result += Terms[i] * Math.Pow(x,Terms.Length-1-i);
            }
            return result;
        }
        catch (OverflowException e) 
        {
            Console.WriteLine("{0}", e);
        }
        return result;
    }
    
    //Constructor de Clase
    public Polinomio(double[] terms)
    {
        this.Terms = (double[])terms.Clone();
    }
}

