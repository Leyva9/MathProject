namespace AnalisisProject;

class Polinomio
{
    private double a; //x3
    private double b; //x2
    private double c; //x
    private double d; //TI

    public double A {get => a; private set => a = value;}
    public double B {get => b; private set => b = value;}
    public double C {get => c; private set => c = value;}
    public double D {get => d; private set => d = value;}

    public double EvaluatePol(double x)
    {
        return (this.A*Math.Pow(x,3) + this.B*Math.Pow(x,2) + this.C*x + this.D);
    }
    public double EvaluatePol(int x)
    {
        return (this.A*Math.Pow(x,3) + this.B*Math.Pow(x,2) + this.C*x + this.D);
    }

    public Polinomio(double a, double b, double c, double d)
    {
        this.A = a;
        this.B = b;
        this.C = c;
        this.D = d; 
    }
}

