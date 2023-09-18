using Microsoft.VisualBasic.Logging;
using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace MathProject
{
    public partial class Form1 : Form
    {
        string[] potenciasNegativasDe10 = { "10⁻¹", "10⁻²", "10⁻³", "10⁻⁴", "10⁻⁵", "10⁻⁶", "10⁻⁷", "10⁻⁸", "10⁻⁹", "10⁻¹⁰", "10⁻¹¹", "10⁻¹²", "10⁻¹³", "10⁻¹⁴", "10⁻¹⁵" };

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(potenciasNegativasDe10);
        }

        private void txtPol_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCalculate_TextChanged(object sender, EventArgs e)
        {

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
            try
            {
                string input = txtPol.Text;
                string[] coeficientesStr = input.Split(' ');
                double[] coeficientes = new double[coeficientesStr.Length];

                if (coeficientes.Length > 3 && coeficientes.Length % 2 == 0 && Convert.ToDouble(coeficientesStr[0]) != 0)
                {
                    for (int i = 0; i < coeficientesStr.Length; i++)
                    {
                        if (!double.TryParse(coeficientesStr[i], out coeficientes[i]))
                        {
                            MessageBox.Show("Ingrese coeficientes v�lidos separados por espacios.");
                            break;
                        }
                        coeficientes[i] = Convert.ToDouble(coeficientesStr[i]);
                    }
                    // Ahora, el array de coeficientes contiene los n�meros ingresados en la TextBox.
                    Polinomio pol = new Polinomio(coeficientes);
                    if (comboBox1.SelectedItem != null)
                    {
                        string selected = comboBox1.SelectedItem.ToString();
                        int indice = Array.IndexOf(potenciasNegativasDe10, selected);
                        double tole = Math.Pow(10, -1 - indice);
                        Bissections bis = new Bissections(pol, tole);
                        DialogResult result = MessageBox.Show($"La raiz del polinomio es aproximadamente {bis.Root}", " ", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            Clipboard.SetText(bis.Root.ToString());
                        }
                    }
                    else
                    {
                        Bissections bis = new Bissections(pol);
                        DialogResult result = MessageBox.Show($"La raiz del polinomio es aproximadamente {bis.Root}", " ", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            Clipboard.SetText(bis.Root.ToString());
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese coeficientes v�lidos separados por espacios.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurri� un error: {ex.Message}");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtPol.Text;
                string[] coeficientesStr = input.Split(' ');
                double[] coeficientes = new double[coeficientesStr.Length];

                if (coeficientes.Length > 3 && coeficientes.Length % 2 == 0 && Convert.ToDouble(coeficientesStr[0]) != 0)
                {
                    for (int i = 0; i < coeficientesStr.Length; i++)
                    {
                        if (!double.TryParse(coeficientesStr[i], out coeficientes[i]))
                        {
                            MessageBox.Show("Ingrese coeficientes v�lidos separados por espacios.");
                            break;
                        }
                        coeficientes[i] = Convert.ToDouble(coeficientesStr[i]);
                    }
                    // Ahora, el array de coeficientes contiene los n�meros ingresados en la TextBox.
                    Polinomio pol = new Polinomio(coeficientes);
                    try
                    {
                        string numberToEvaluateStr = txtCalculate.Text;
                        double numberToEvaluate = 0;
                        double.TryParse(numberToEvaluateStr, out numberToEvaluate);
                        double result = pol.Evaluate(numberToEvaluate);
                        MessageBox.Show($"El resultado es: {result}");
                    }

                    catch (Exception exe)
                    {
                        MessageBox.Show($"Ocurrio un error: {exe.Message}");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese coeficientes v�lidos separados por espacios.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurri� un error: {ex.Message}");
            }
        }
    }
}