namespace MathProject;

static class Bolzano // Clase que utiliza en diferentes formas las hipotesis para el primer Teorema de Bolzano
{
    //Este metodo devuelve un tupla que representa un intervalo cerrado  en el que hay al menos una raiz
    static public (int, int) FindInterval(Polinomio polinomio)
    {
        
        for (int i = 0; ; i++)
        {
            if(polinomio.Evaluate(-Math.Pow(2, i)) * polinomio.Evaluate(Math.Pow(2, i)) < 0)
            {
                (int, int) interval = (-(int)Math.Pow(2, i), (int)Math.Pow(2, i));
                return interval;
            }
        }
    }
    //Permite checar la condicion de bolzano en un intervalo para la existencia de raices
    static public bool Check((double,double) intervalo,Polinomio polinomio)
    {
        if(polinomio.Evaluate(intervalo.Item1)*polinomio.Evaluate(intervalo.Item2)<0)
        {
            return true;
        }
        return false;
    }
}
public class Bissections
{
    //Instance Variables
    private (int, int) initialinterval;
    private double tolerance;
    private int numberofiterations;
    private Polinomio polinomio;
    private double root;
    //Properties
    public (int, int) InitialInterval { get => initialinterval; }
    public double Tolerance { get => tolerance; set => tolerance = value; }
    public int NumberOfIterations { get => numberofiterations; }
    public Polinomio Polinomio { get => polinomio; }
    public double Root { get => root; }
    
    //Constructors
    public Bissections (Polinomio polinomio, double tolerance = 0.00000000001)
    {
        this.initialinterval = Bolzano.FindInterval(polinomio);
        this.tolerance = tolerance;
        this.polinomio = polinomio;
        this.root = FindRoot(this.InitialInterval,this.Tolerance); 
        this.numberofiterations = (int)((this.initialinterval.Item2 - this.initialinterval.Item1) / tolerance);
    }

    //Methods
    private double FindRoot((double, double) interval, double tolerance)
    {
        double start = interval.Item1;
        double end = interval.Item2;
        //  Console.WriteLine("Intervalo Inicial"+"["+a+";"+b+"]"+"numero de iteraciones que faltan:"+n);
        double medium = (start + end) / 2;
        int x = 0;
        while(Math.Abs(this.polinomio.Evaluate(medium))>=tolerance && x < 100)
        {
            if (Bolzano.Check((start,medium),this.polinomio))
            {
                end = medium;
                medium = (start+end)/2;
            }
            else
            {
                start = medium;
                medium = (start + end) / 2;
            }
            x++;
        }
        return medium; 
    }
}