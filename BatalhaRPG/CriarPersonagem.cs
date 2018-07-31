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
    public partial class CriarPersonagem : Form
    {
        public CriarPersonagem()
        {
            InitializeComponent();
        }

        private void CriarPersonagem_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void CriarPersonagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe um nome",
                    "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbRaca.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma raça",
                    "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cmbSexo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um sexo",
                    "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var radio = radioClasse.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if(radio == null)
            {
                MessageBox.Show("Selecione uma Classe",
                    "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Batalha batalha = new Batalha(txtNome.Text, cmbSexo.Text, cmbRaca.Text, radio.Text);

            batalha.Show();
            this.Hide();

        }
    }
}
