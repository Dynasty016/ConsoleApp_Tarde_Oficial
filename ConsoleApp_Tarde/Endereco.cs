using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    internal class Endereco
    {
        private int Id;
        private string Rua;
        private string Bairro;
        private string Cidade;
        private int Numero;
        public string CEP;


        public Endereco(int id, string rua, string bairro, string cidade, int numero, string cep) 
        {
            Id = id;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Numero = numero;
            CEP = cep;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public string getRua()
        {
            return Rua;
        }

        public void setRua(string rua)
        {
            Rua = rua;
        }

        public string getBairro()
        {
            return Bairro;
        }

        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public string getCidade()
        {
            return Cidade;
        }

        public void setCidade(string cidade) 
        {
            Cidade = cidade;
        }

        public int getNumero()
        {
            return Numero;
        }

        public string getCEP()
        {
            return CEP;
        }

        public void setCEP(string cep)
        {
            CEP = cep;
        }
    }
}
