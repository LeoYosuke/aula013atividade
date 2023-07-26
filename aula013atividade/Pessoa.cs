using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula013atividade
{
    internal class Pessoa
    {
        public string name;
        public int idade;
        public string rua;
        public string cidade;

        public Pessoa(string name, int idade, string rua, string cidade)
        {
            this.idade = idade;
            this.rua = rua;
            this.cidade = cidade;
            this.name = name;
            
        }

        public void mostra()
        {
            MessageBox.Show($"Seu nome é {name}, e sua idade é {idade}, mora na rua {rua}, na cidade de {cidade}!");
        }
    }
}
