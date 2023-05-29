namespace ConsultaDeCep
{
    internal class CepQueryResponse
    {
        public string Id { get; set; }
        public string CreatedAt { get; set; } 

        public void PrintToConsole()
        {
            Console.WriteLine("Resposta do Servidor");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Criado em: {CreatedAt}\n");
        }
    }
}