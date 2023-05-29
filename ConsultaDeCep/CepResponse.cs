using Newtonsoft.Json;

namespace ConsultaDeCep
{
    internal class CepResponse
    {
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Localidade { get; set; }

        [JsonProperty("Uf")]
        public string Estado { get; set; }

        public long Ibge { get; set; }

        public long Gia { get; set; }

        public long Ddd { get; set; }

        public long Siafi { get; set; }

        public void PrintToConsole()
        {
            Console.WriteLine($"\n-------------------");
            Console.WriteLine($"CEP: {Cep}");
            Console.WriteLine($"Logradouro: {Logradouro}");
            Console.WriteLine($"Complemento: {Complemento}");
            Console.WriteLine($"Bairro: {Bairro}");
            Console.WriteLine($"Localidade: {Localidade}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"-------------------\n");
        }
    }
}