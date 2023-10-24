using Microsoft.VisualBasic.Logging;
using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace MathProject
{
    public partial class Form1 : Form
    {
        string[] potenciasNegativasDe10 = { "10⁻¹", "10⁻²", "10⁻³", "10⁻⁴", "10⁻⁵", "10⁻⁶", "10⁻⁷", "10⁻⁸", "10⁻⁹", "10⁻¹⁰", "10⁻¹¹", "10⁻¹²", "10⁻¹³", "10⁻¹⁴", "10⁻¹⁵" };
        Polinomio pol = null;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(potenciasNegativasDe10);
        }

        public double[] ParseMyPol(string[] pol)
        {
            double[] polParsed = new double[pol.Length];
            for (int i = 0; i < pol.Length; i++)
            {
                if (!double.TryParse(pol[i], out polParsed[i]))
                {
                    MessageBox.Show("Ingrese coeficientes v�lidos separados por espacios.");
                    break;
                }
                else
                {
                    polParsed[i] = Convert.ToDouble(pol[i]);
                }
            }
            return polParsed;
        }

        public double SelectTolerance()
        {
            string selected = comboBox1.SelectedItem.ToString();
            int indice = Array.IndexOf(potenciasNegativasDe10, selected);
            double tole = Math.Pow(10, -1 - indice);
            return tole;
        }

        public void ExecuteBisections(Polinomio pol, double tole)
        {
            Bissections bis = new Bissections(pol, tole);
            DialogResult result = MessageBox.Show($"La raiz del polinomio es aproximadamente {bis.Root}", " ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Clipboard.SetText(bis.Root.ToString());
            }
        }

        public void MostraryCopiarRaiz(Bissections bis)
        {
            DialogResult result = MessageBox.Show($"La raiz del polinomio es aproximadamente {bis.Root}", " ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Clipboard.SetText(bis.Root.ToString());
            }
        }

        private void txtPol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("No se permiten caracteres no numericos en el polinomio.");
            }
        }
        private void txtCalculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("No se permiten caracteres no numericos para evaluar el polinomio.");
            }
        }

        private void btnFindRoot_Click(object sender, EventArgs e)
        {            
            string input = txtPol.Text;
            string[] coeficientesStr = input.Split(' ');
            double[] coeficientes = new double[coeficientesStr.Length];

            
            if (coeficientes.Length > 3 && coeficientes.Length % 2 == 0 && Convert.ToDouble(coeficientesStr[0]) != 0)
            {                
                pol = new Polinomio(ParseMyPol(coeficientesStr));                  
                
                if (comboBox1.SelectedItem != null)
                {
                    Bissections bis = new Bissections(pol, SelectTolerance());
                    MostraryCopiarRaiz(bis);
                }
                else
                {
                    Bissections bis = new (pol);
                    MostraryCopiarRaiz(bis);
                }
            }               
            else
            {   
                if(string.IsNullOrWhiteSpace(input))
                {   
                    // Se procede a crear un polinomio de grado 3 con coeficientes aleatorios entre 15000 y -15000
                    pol = new Polinomio();
                    MessageBox.Show($"Se genera un polinomio random de grado 3 con los coeficientes {pol.Terms[0]} {pol.Terms[1]} {pol.Terms[2]} {pol.Terms[3]}");

                    if (comboBox1.SelectedItem != null)
                    {
                        Bissections bis = new Bissections(pol, SelectTolerance());
                        MostraryCopiarRaiz(bis);
                    }
                    else
                    {
                        Bissections bis = new(pol);
                        MostraryCopiarRaiz(bis);
                    }                    
                }
                else
                {
                    MessageBox.Show("Escriba un numero par de coeficientes...");
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {        
            string input = txtPol.Text;
            string[] coeficientesStr = input.Split(' ');
            double[] coeficientes = new double[coeficientesStr.Length];
           
            if (coeficientes.Length > 3 && coeficientes.Length % 2 == 0 && Convert.ToDouble(coeficientesStr[0]) != 0)
            {    
                // Ahora, el array de coeficientes contiene los n�meros ingresados en la TextBox.
                Polinomio pol = new (ParseMyPol(coeficientesStr));                                   
                double result = pol.Evaluate(txtCalculate.Text);
                MessageBox.Show($"El resultado es: {result}");                               
            }
            else
            {
                double result = pol.Evaluate(txtCalculate.Text);
                MessageBox.Show($"El resultado es: {result}");
            }
        }
    }
}