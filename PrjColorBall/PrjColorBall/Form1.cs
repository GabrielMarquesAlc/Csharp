using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjColorBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var nomedocomponente = "";
            var Corzinha = new Color[6];
            var ContagemdasBolas = new int[6];
            var OrdenacaoBolas = new int[20];
            var randomico = new Random();

            /// Cria um array com os valores referentes 
            /// as cores
            Corzinha[0] = Color.Red;
            Corzinha[1] = Color.Green;
            Corzinha[2] = Color.Purple;
            Corzinha[3] = Color.Blue;
            Corzinha[4] = Color.Yellow;
            Corzinha[5] = Color.Pink;
            /// 
            for (int i = 0; i < 6; i++)
            {
                nomedocomponente = "Quadrado00" + Convert.ToString(i + 1); ;
                (Controls[nomedocomponente] as Panel).BackColor = Corzinha[i];
            }

            for (int i = 0; i < 20; i++)
            {
                if ((i + 1) < 10)
                {
                    nomedocomponente = "Bola0" + Convert.ToString(i + 1);
                }
                else
                {
                    nomedocomponente = "Bola" + Convert.ToString(i + 1);
                };

                OrdenacaoBolas[i] = randomico.Next(0,5);
                (Controls[nomedocomponente] as Panel).BackColor = Corzinha[OrdenacaoBolas[i]];
                ContagemdasBolas[OrdenacaoBolas[i]]++;
            }

            label1.Text = Convert.ToString(ContagemdasBolas[0]);
            label2.Text = Convert.ToString(ContagemdasBolas[1]);
            label3.Text = Convert.ToString(ContagemdasBolas[2]);
            label4.Text = Convert.ToString(ContagemdasBolas[3]);
            label5.Text = Convert.ToString(ContagemdasBolas[4]);
            label6.Text = Convert.ToString(ContagemdasBolas[5]);




        }
    }
}
