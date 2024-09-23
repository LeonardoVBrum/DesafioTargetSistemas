using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3__questão
{
    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }

        public Faturamento()
        {

        }

        public Faturamento(int dia, double valor)
        {
            Dia = dia;
            Valor = valor;
        }
    }
}