using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33___Criptografia_de_dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCriptografar_Click(object sender, EventArgs e)
        {
            CriptoMD5 md5 = new CriptoMD5();    
            textBoxSaida.Text = md5.RetornaMD5(textBoxEntrada.Text);  
                                     //Metodo que retorna dado criptografado
        }

        private void buttonComparar_Click(object sender, EventArgs e)
        {
            string senhaBanco = textBoxSaida.Text;
            string senha = textBoxEntrada.Text;

            CriptoMD5 md5 = new CriptoMD5();   
            bool res = md5.CompararMD5(senha, senhaBanco);  //Comparação das senhas

            if (res)    //Verifica o resultado da comparação
            {
                labelResultado.Text = "Senhas iguais";

            }
            else
            {
                labelResultado.Text = "Senhas diferentes";
            }

        }

        private void buttonLimp_Click(object sender, EventArgs e)
        {
            textBoxEntrada.Text = "";
            textBoxSaida.Text = "";
        }
    }
}
