using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde.Heranca2
{
    public class Veiculo
    {
        public string cor;
        public int quantidadedeRodas;
        public int quantidadedeAssentos;
        public bool TemMotor;

        public string ExibirDados()
        {
            if (TemMotor)
            {
                return "Tem motor" + cor + " " + quantidadedeAssentos + " " + quantidadedeRodas;
            }

            else
            {
                return cor + " " + quantidadedeAssentos + " " + quantidadedeRodas;
            }
        }
    }
}
