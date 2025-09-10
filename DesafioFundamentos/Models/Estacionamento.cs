namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // R:       Realizado a validação da placa com o método criado na classe ValidationHelper, 
            //          também adicionei uma verificação para não cadastrar placas repetidas.

            string placa = ValidationHelper.LerPlacaComValidacao("\nDigite a placa do veículo para estacionar: ");
                // Verificação se a placa já está cadastrada

                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("\nEste veículo já está estacionado!\n");
                    return;
                }
            veiculos.Add(placa);
            Console.WriteLine("\nVeículo cadastrado com sucesso!\n");
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // R:       Realizado a validação da placa com o método criado na classe ValidationHelper.

            string placa = ValidationHelper.LerPlacaComValidacao("\nDigite a placa do veículo para remover: ");

            // Verifica se o veículo existe

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // R:   Realizado a validação de horas com o método criado na classe ValidationHelper, realização do calculo do  
                //      valor a ser pago.

                int horas = 0;
                decimal valorTotal = 0;

                int horas = ValidationHelper.LerInteiroComValidacao("\nDigite a quantidade de horas que o veículo permaneceu estacionado: ");

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // R:   Remove a placa digitada da lista de veículos

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // R:   Laço de repetição para exibir os veículos
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
