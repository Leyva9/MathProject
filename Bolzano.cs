namespace AnalisisProject;

static class Bolzano
{
    static public (int, int) FindInterval(Polinomio polinomio)
    {
        
        for (int i = 0; ; i++)
        {
            if(polinomio.EvaluatePol(-Math.Pow(2, i)) * polinomio.EvaluatePol(Math.Pow(2, i)) < 0)
            {
                (int, int) interval = (-(int)Math.Pow(2, i), (int)Math.Pow(2, i));
                return interval;
            }
        }
    }
}