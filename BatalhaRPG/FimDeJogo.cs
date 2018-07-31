using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhaRPG
{
    public partial class FimDeJogo : Form
    {
        public FimDeJogo(string nome, string sexo, string raca)
        {
            string msg = "";
            string msgRaca = "";

            switch (sexo)
            {
                case "Feminino":
                    {
                        msg = "A heroína ";
                        break;
                    }
                case "Masculino":
                    {
                        msg = "O herói ";
                        break;
                    }
            }


            switch (raca)
            {
                case "Humano":
                    {
                        msgRaca = "humanos";
                        break;
                    }
                case "Elfo":
                    {
                        msgRaca = "elfos";
                        break;
                    }
                case "Anão":
                    {
                        msgRaca = "anões";
                        break;
                    }
            }

            InitializeComponent();
            lbl1.Text = msg + " " +nome + " venceu...";
            lbl2.Text = "finalmente o dragão foi derrotado... ";
            lbl3.Text = "e o mundo dos " + msgRaca + " está em paz!";


        }

        private void FimDeJogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por jogar!", "Agradecimento", MessageBoxButtons.OK, MessageBoxIcon.None);
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por jogar!", "Agradecimento", MessageBoxButtons.OK, MessageBoxIcon.None);
            BatalhaRPG.Menu menu = new BatalhaRPG.Menu();
            this.Dispose();
            menu.Show();
        }
    }
}
