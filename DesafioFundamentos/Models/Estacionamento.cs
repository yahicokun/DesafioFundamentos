using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        //Atributos 
        private decimal precoinicial = 0;
        private decimal precohora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoinicial, decimal precohora)
        {
            this.precoinicial = precoinicial;
            this.precohora = precohora;
        }

        public void AdicionarVeiculo()
        {
            string veiculo;
            Console.WriteLine("Digite a Placa do Veiculo: ");
            veiculo = Console.ReadLine() ?? string.Empty;
            veiculos.Add(veiculo);
            Console.WriteLine($"O veículo {veiculo} foi adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a Placa do Veiculo: ");
            string placa = Console.ReadLine() ?? string.Empty;

            if (veiculos.Any(x => x.Equals(placa, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal preco = precoinicial + (horas * precohora);
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {preco}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                return;
            }
  
        }

        public void ListarVeiculos() {

            if (veiculos != null && veiculos.Count > 0)
            {
                for (int i = 0 ; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"Os Veiculos estacionados são: {veiculos[i]}");
                }
            }
            else
            {
                  Console.WriteLine("Não há veículos estacionados.");

            }

        }
    }
}
