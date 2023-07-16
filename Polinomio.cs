namespace AnalisisProject;

class Polinomio //Clase con los polinomios de la forma ax^3 + bx^2 +cx +d
{
    private double a; //x3
    private double b; //x2
    private double c; //x
    private double d; //TI

    public double A {get => a; private set => a = value;}
    public double B {get => b; private set => b = value;}
    public double C {get => c; private set => c = value;}
    public double D {get => d; private set => d = value;}
// Esta sobrecarga permite evaluar el polinomio en un numero real
    public double Evaluate(double x) 
    {
        try {
            return (this.A*Math.Pow(x,3) + this.B*Math.Pow(x,2) + this.C*x + this.D);
        }
        catch (OverflowException e) 
        {
            System.Console.WriteLine("Valores fuera de lo permitido");
        }
        return (this.A*Math.Pow(x,3) + this.B*Math.Pow(x,2) + this.C*x + this.D);
    }
    public double Evaluate(int x)
    {
        return (this.A*Math.Pow(x,3) + this.B*Math.Pow(x,2) + this.C*x + this.D);
    }
//Constructor de Clase
    public Polinomio(double a, double b, double c, double d)
    {
        this.A = a;
        this.B = b;
        this.C = c;
        this.D = d; 
    }
}

