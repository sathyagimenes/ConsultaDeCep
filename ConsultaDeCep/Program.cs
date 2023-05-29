namespace ConsultaDeCep
{
	internal class Pogram
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Insira o CEP a ser consultado:");
				var cep = Console.ReadLine();
				if(string.IsNullOrEmpty(cep)) {
					cep = "13083859";
				}
				var cepInfo = ApiHelper.GetCepInfoAsync(cep).Result;
				cepInfo.PrintToConsole();

				var cepQuery = new CepQuery(cepInfo);

				var cepQueryResponse = ApiHelper.AddConsultedCepAsync(cepQuery).Result;
				cepQueryResponse.PrintToConsole();
			}
		} 
	}
}