//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class HistoricoOperacoes
    {
        
        private List<string> historicoOperacoes = new List<string>();

        public void RegistrarOperacoes(string operacao)
        {
            historicoOperacoes.Add(operacao);
        }

        public void ExibirHistorico()
        {
            Console.WriteLine("Histórico das operações realizadas:");
            foreach (string operacao in historicoOperacoes)
            {
                Console.WriteLine(operacao);
            }
        }
    }
}