using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaRPG
{
    class Protagonista : IMago, IGuerreiro
    {
        public string Nome { get; set; }

        public string Sexo { get; set; }

        public int PontosDeVida { get; set; }

        public int PontosDeMagia { get; set; }

        public int Defesa { get; set; }

        public string Raca { get; set; }

        public Protagonista(string nome, string sexo, string raca, int pontosDeVida, int pontosDeMagia, int defesa)
        {
            Nome = nome;
            Sexo = sexo;
            PontosDeVida = pontosDeVida;
            PontosDeMagia = pontosDeMagia;
            Defesa = defesa;
            Raca = raca;
        }

        public int ataqueCritico()
        {
            return 35;
        }

        public int ataqueEspada()
        {
            return 25;
        }

        public int ataqueFlecha()
        {
            return 20;
        }

        public int magiaDeFogo()
        {
            if(this.PontosDeMagia >= 10)
            {
                this.PontosDeMagia -= 10;
                return 15;
            }
            return 0;
        }

        public int magiaDeGelo()
        {
            if(this.PontosDeMagia >= 20)
            {
                this.PontosDeMagia -= 20;
                return 35;
            }
            return 0;
        }

        public int magiaEletrica()
        {
            if(this.PontosDeMagia >= 25)
            {
                this.PontosDeMagia -= 25;
                return 30;
            }
            return 0;
        }

        public int cura()
        {
            if(this.PontosDeMagia >= 20)
            {
                this.PontosDeMagia -= 20;
                this.PontosDeVida += 40;
                return 40;
            }
            return 0;
        }
    }
}
