using System;

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
            MessageBox.Show($"{e}");
        }
        return result;
    }

    public double Evaluate(string x)
    {
        string numberToEvaluateStr = x;
        double numberToEvaluate = 0;
        double.TryParse(numberToEvaluateStr, out numberToEvaluate);
        return Evaluate(numberToEvaluate);
    }

    private double GenerarCoeficienteAleatorio(Random random)
    {
        // Genera un coeficiente entre -15000 y 15000
        return random.NextDouble() * 30000 - 15000; // Rango de -15000 a 15000
    }

    private double[] GenerarCoeficientesPolinomioGrado3(Random random)
    {
        double[] coeficientes = new double[4];
        coeficientes[0] = GenerarCoeficienteAleatorio(random); // Coeficiente para x^3
        coeficientes[1] = GenerarCoeficienteAleatorio(random); // Coeficiente para x^2
        coeficientes[2] = GenerarCoeficienteAleatorio(random); // Coeficiente para x
        coeficientes[3] = GenerarCoeficienteAleatorio(random); // Término independiente
        return coeficientes;
    }
    //Constructor de Clase
    public Polinomio(double[] terms)
    {
        this.Terms = (double[])terms.Clone();
    }

    public Polinomio()
    {
        Random random = new Random();
        this.Terms = (double[])GenerarCoeficientesPolinomioGrado3(random).Clone();
    }
}

