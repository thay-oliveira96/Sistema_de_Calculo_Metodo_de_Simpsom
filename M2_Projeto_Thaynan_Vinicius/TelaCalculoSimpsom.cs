using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M2_Projeto_Thaynan_Vinicius
{
    public partial class TelaCalculoSimpsom : Form
    {
        public TelaCalculoSimpsom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Variaveis
                double n = 0, a = 2, b = 3, h = 0.05;

                //Variavel Resultado
                double result = 0;

                //Variaveis de Somas
                double somE = 0, somI = 0, somP = 0;

                //Variaveis de I
                int i0 = 0, i1 = 1, i2 = 2, i3 = 3, i4 = 4, i5 = 5, i6 = 6, i7 = 7, i8 = 8, i9 = 9, i10 = 10,
                    i11 = 11, i12 = 12, i13 = 13, i14 = 14, i15 = 15, i16 = 16, i17 = 17, i18 = 18, i19 = 19, i20 = 20;
                
                //Variaveis de X
                double x0 = 2, x1 = 2.05, x2 = 2.10, x3 = 2.15, x4 = 2.20, x5 = 2.25, x6 = 2.30, x7 = 2.35,
                    x8 = 2.40, x9 = 2.45, x10 = 2.50, x11 = 2.55, x12 = 2.60, x13 = 2.65, x14 = 2.70,
                    x15 = 2.75, x16 = 2.80, x17 = 2.85, x18 = 2.90, x19 = 2.95, x20 = 3;

                //Variaveis da Funcao de f(x)
                double f0 = 5 * Math.Pow(x0, 3) + 3, f1 = 5 * Math.Pow(x1, 3) + 3, f2 = 5 * Math.Pow(x2, 3) + 3,
                  f3 = 5 * Math.Pow(x3, 3) + 3, f4 = 5 * Math.Pow(x4, 3) + 3, f5 = 5 * Math.Pow(x5, 3) + 3,
                  f6 = 5 * Math.Pow(x6, 3) + 3, f7 = 5 * Math.Pow(x7, 3) + 3, f8 = 5 * Math.Pow(x8, 3) + 3,
                  f9 = 5 * Math.Pow(x9, 3) + 3, f10 = 5 * Math.Pow(x10, 3) + 3, f11 = 5 * Math.Pow(x11, 3) + 3,
                  f12 = 5 * Math.Pow(x12, 3) + 3, f13 = 5 * Math.Pow(x13, 3) + 3, f14 = 5 * Math.Pow(x14, 3) + 3,
                  f15 = 5 * Math.Pow(x15, 3) + 3, f16 = 5 * Math.Pow(x16, 3) + 3, f17 = 5 * Math.Pow(x17, 3) + 3,
                  f18 = 5 * Math.Pow(x18, 3) + 3, f19 = 5 * Math.Pow(x19, 3) + 3, f20 = 5 * Math.Pow(x20, 3) + 3;

                //variavel E recebendo valores dos extremos de f(x)
                double e1 = f0, e2 = f20;

                /*Testando somente os impares, como temos 20 itens precisamos de metade no caso 10, ou seja 
                 precisa selecionar 10 variaveis para isso, como o objetivo da aplicação é fazer o teste com
                20 itens.
                 */
                //variaveis impares
                double imp1 = 0, imp2 = 0, imp3 = 0, imp4 = 0, imp5 = 0, imp6 = 0, imp7 = 0, imp8 = 0, 
                    imp9 = 0, imp10 = 0;
                //variaveis pares
                double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, p7 = 0, p8 = 0, p9 = 0;

                //separando valores impares
                imp1 = f1;
                imp2 = f3;
                imp3 = f5;
                imp4 = f7;
                imp5 = f9;
                imp6 = f11;
                imp7 = f13;
                imp8 = f15;
                imp9 = f17;
                imp10 = f19;

                //separando valores pares
                p1 = f2;
                p2 = f4;
                p3 = f6;
                p4 = f8;
                p5 = f10;
                p6 = f12;
                p7 = f14;
                p8 = f16;
                p9 = f18;

                //soma de E
                somE = e1 + e2;

                //soma de Impares
                somI = imp1 + imp2 + imp3 + imp4 + imp5 + imp6 + imp7 + imp8 + imp9 + imp10;

                //soma de Pares
                somP = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9;

                //Resultado
                result = h / 3 * (somE+4*somI+2*somP);

                //Recuperando dados
                n = double.Parse(txtN.Text = "20");

                dataGridView1.Rows.Add(i0, x0, Math.Round(f0, 4), e1, " ", " ");
                dataGridView1.Rows.Add(i1, x1, Math.Round(f1, 4), " ",Math.Round(imp1, 4), " ");
                dataGridView1.Rows.Add(i2, x2, Math.Round(f2, 4), " ", " ", Math.Round(p1, 4));
                dataGridView1.Rows.Add(i3, x3, Math.Round(f3, 4), " ", Math.Round(imp2, 4), " ");
                dataGridView1.Rows.Add(i4, x4, Math.Round(f4, 4), " ", " ", Math.Round(p2, 4));
                dataGridView1.Rows.Add(i5, x5, Math.Round(f5, 4), " ", Math.Round(imp3, 4), " ");
                dataGridView1.Rows.Add(i6, x6, Math.Round(f6, 4), " ", " ", Math.Round(p3, 4));
                dataGridView1.Rows.Add(i7, x7, Math.Round(f7, 4), " ", Math.Round(imp4, 4), " ");
                dataGridView1.Rows.Add(i8, x8, Math.Round(f8, 4), " ", " ", Math.Round(p4, 4));
                dataGridView1.Rows.Add(i9, x9, Math.Round(f9, 4), " ", Math.Round(imp5, 4), " ");
                dataGridView1.Rows.Add(i10, x10, Math.Round(f10, 4), " ", " ", Math.Round(p5, 4));
                dataGridView1.Rows.Add(i11, x11, Math.Round(f11, 4), " ", Math.Round(imp6, 4), " ");
                dataGridView1.Rows.Add(i12, x12, Math.Round(f12, 4), " ", " ", Math.Round(p6, 4));
                dataGridView1.Rows.Add(i13, x13, Math.Round(f13, 4), " ", Math.Round(imp7, 4), " ");
                dataGridView1.Rows.Add(i14, x14, Math.Round(f14, 4), " ", " ", Math.Round(p7, 4));
                dataGridView1.Rows.Add(i15, x15, Math.Round(f15, 4), " ", Math.Round(imp8, 4), " ");
                dataGridView1.Rows.Add(i16, x16, Math.Round(f16, 4), " ", " ", Math.Round(p8, 4));
                dataGridView1.Rows.Add(i17, x17, Math.Round(f17, 4), " ", Math.Round(imp9, 4), " ");
                dataGridView1.Rows.Add(i18, x18, Math.Round(f18, 4), " ", " ", Math.Round(p9, 4));
                dataGridView1.Rows.Add(i19, x19, Math.Round(f19, 4), " ", Math.Round(imp10, 4), " ");
                dataGridView1.Rows.Add(i20, x20, Math.Round(f20, 4), e2, " ", " ");

                //Retorno de somas
                lblResultE.Text = Convert.ToString(somE.ToString("F4"));
                lblResultImpar.Text = Convert.ToString(somI.ToString("F4"));
                lblResultPar.Text = Convert.ToString(somP.ToString("F4"));

                //Mensagem de retorno
                lblResultado.Text = Convert.ToString(result.ToString("F4"));

            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se todos valores foram preenchidos", "Teste de calculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
