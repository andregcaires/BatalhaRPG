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
    public partial class Batalha : Form
    {

        Dragao dragao;
        Protagonista protagonista;
        static Random rand = new Random();

        public Batalha(string nome, string sexo, string raca, string classe)
        {
            if(classe == "Mago")
            {
                protagonista = new Protagonista(nome, sexo, raca, 150, 400, 10);
            }
            else
            {
                protagonista = new Protagonista(nome, sexo, raca, 250, 160, 15);

            }

            dragao = new Dragao(400);
            

            InitializeComponent();
            vidaProtagonista.Maximum = protagonista.PontosDeVida;
            vidaProtagonista.Value = protagonista.PontosDeVida;

            magiaProtagonista.Maximum = protagonista.PontosDeMagia;
            magiaProtagonista.Value = protagonista.PontosDeMagia;

            vidaDragao.Maximum = dragao.PontosDeVida;
            vidaDragao.Value = dragao.PontosDeVida;

            lblNome.Text = protagonista.Nome;

            if (protagonista.Sexo == "Masculino")
            {
                lblTitulo.Text = "herói";
            }
            else
            {
                lblTitulo.Text = "heroína";
            }

        }

        private void Batalha_Load(object sender, EventArgs e)
        {
            
        }

        private void Batalha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            int dano = 0;
            int r = rand.Next(3);
            switch (r)
            {
                case 0:
                    {
                        dano = protagonista.ataqueEspada();
                        log.Items.Add(protagonista.Nome + " atacou com Espada! Causou " + dano + " de dano!");
                        break;
                    }
                case 1:
                    {
                        dano = protagonista.ataqueFlecha();
                        log.Items.Add(protagonista.Nome + " atacou com Flecha! Causou " + dano + " de dano!");
                        break;
                    }
                case 2:
                    {
                        dano = protagonista.ataqueCritico();
                        log.Items.Add(protagonista.Nome + " usou ataque Crítico! Causou "+dano+" de dano!");
                        break;
                    }
            }
            combate(dano, 0);
        }

        private void btnMagia_Click(object sender, EventArgs e)
        {
            int dano = 0;
            int r = rand.Next(3);
            switch (r)
            {
                case 0:
                    {
                        log.Items.Add(protagonista.Nome + " usa Magia de Fogo...");
                        dano = protagonista.magiaDeFogo();
                        if(dano != 0)
                        {
                            log.Items.Add("Sucesso! Causou " + dano + " de dano!");
                            magiaProtagonista.Value -= 10;
                        }
                        else
                        {
                            log.Items.Add("Pontos de Magia insuficientes!");
                        }
                        break;
                    }
                case 1:
                    {
                        log.Items.Add(protagonista.Nome + " usa Magia de Gelo...");
                        dano = protagonista.magiaDeGelo();
                        if (dano != 0)
                        {
                            log.Items.Add("Sucesso! Causou " + dano + " de dano!");
                            magiaProtagonista.Value -= 20;

                        }
                        else
                        {
                            log.Items.Add("Pontos de Magia insuficientes!");
                        }
                        break;
                    }
                case 2:
                    {
                        log.Items.Add(protagonista.Nome + " usa Magia Elétrica...");
                        dano = protagonista.magiaEletrica();
                        if (dano != 0)
                        {
                            log.Items.Add("Sucesso! Causou " + dano + " de dano!");
                            magiaProtagonista.Value -= 25;
                        }
                        else
                        {
                            log.Items.Add("Pontos de Magia insuficientes!");
                        }
                        break;
                    }
            }
            combate(dano, 0);
        }

        private void btnCura_Click(object sender, EventArgs e)
        {
            int cura = 0;
            
            if(vidaProtagonista.Maximum < (vidaProtagonista.Value + 40))
            {
                log.Items.Add("Pontos de vida no limite! Não é necessário curar!");
                log.Items.Add("\n");
                log.SelectedIndex = log.Items.Count - 1;
                return;
            }

            log.Items.Add(protagonista.Nome + " usa Cura...");
            cura = protagonista.cura();
            if (cura != 0)
            {
                log.Items.Add("Sucesso! Se curou em " + cura + " pontos de Vida" +
                    "!");
                if((magiaProtagonista.Value - 20) <= 0)
                {
                    magiaProtagonista.Value = 1;
                }
                else
                {
                    magiaProtagonista.Value -= 20;
                }
                vidaProtagonista.Value += cura;
            }
            else
            {
                log.Items.Add("Pontos de Magia insuficientes!");
            }
            log.Items.Add("\n");
            log.SelectedIndex = log.Items.Count - 1;
        }

        private void btnDefesa_Click(object sender, EventArgs e)
        {
            combate(0, protagonista.Defesa);
        }


        public int ataqueDragao()
        {
            int dano = 0;
            int r = rand.Next(3);
            switch (r)
            {
                case 0:
                    {
                        dano = dragao.mordida();
                        log.Items.Add("O dragão atacou com Mordida!");
                        break;
                    }
                case 1:
                    {
                        dano = dragao.bolaDeFogo();
                        log.Items.Add("O dragão atacou com Bola de Fogo!");
                        break;
                    }
                case 2:
                    {
                        dano = dragao.arranhao();
                        log.Items.Add("O dragão usou ataque Arranhão!");
                        break;
                    }
            }
            return dano;
        }


        public void combate(int dano, int defesa)
        {

            dragao.PontosDeVida -= dano;
            
            if(dragao.PontosDeVida <= 0)
            {
                vidaDragao.Value = 1;
                log.Items.Add("--- Acabou!");
                MessageBox.Show("Você venceu o dragão!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.None);
                FimDeJogo final = new FimDeJogo(protagonista.Nome, protagonista.Sexo, protagonista.Raca);
                final.Show();
                this.Hide();
                return;
            }
            vidaDragao.Value -= dano;


            int danoDragao = ataqueDragao();
            if (defesa != 0)
            {
                log.Items.Add(protagonista.Nome + " Defendeu!");
                danoDragao -= defesa;
            }
            protagonista.PontosDeVida -= danoDragao;
            //vidaProtagonista.Value -= danoDragao;
            log.Items.Add("O dragão causou " + danoDragao + " de dano!");


            if (protagonista.PontosDeVida <= 0)
            {
                log.Items.Add("--- Acabou!");
                vidaProtagonista.Value = 1;
                if (MessageBox.Show("Fim de jogo, tentar novamente?", "Fim de jogo", MessageBoxButtons.RetryCancel, MessageBoxIcon.None) == DialogResult.Retry)
                {
                    CriarPersonagem criar = new CriarPersonagem();
                    criar.Show();
                    this.Dispose();
                }
                else
                {
                    Application.Exit();
                }
                return;
            }
            vidaProtagonista.Value -= danoDragao;


            log.Items.Add("\n");
            log.SelectedIndex = log.Items.Count - 1;
        }
    }
}
