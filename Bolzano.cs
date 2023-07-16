namespace AnalisisProject;

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
    static public bool Check((float,float) intervalo,Polinomio polinomio)
    {
        if(polinomio.Evaluate(intervalo.Item1)*polinomio.Evaluate(intervalo.Item2)<0)
        {
            return true;
        }
        return false;
    }
}