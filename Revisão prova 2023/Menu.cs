using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisão_prova_2023
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            divisoes dv = new divisoes();
            dv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string escolha = "";
            string sexo = "";
            if (radioButton1.Checked)
            {
                sexo = radioButton1.Text; // esta pegando as informações no button 1 
            }
            else if (radioButton2.Checked)
            {
                sexo = radioButton2.Text;

            }
            MessageBox.Show(sexo); // aqui impirmi as informações
            MessageBox.Show(escolha);
        }
    }
}
