using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClassLibrary1;
using Dto;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Injeção de dependencia
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ITrade, Trade>()
                .BuildServiceProvider();

            var service = serviceProvider.GetService<ITrade>();

            var listTrades = new List<TradeDto>();

            var initialDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var numberOfTrades = Console.ReadLine();

            for (int i = 1; i <= int.Parse(numberOfTrades); i++)
            {
                var data = Console.ReadLine().Split(" ");

                // Condição incluída para tratamento da 2ª questão 
                if (data.Count() > 3)
                    listTrades.Add(new TradeDto(Double.Parse(data[0]), data[1], DateTime.ParseExact(data[2], "MM/dd/yyyy", CultureInfo.InvariantCulture), bool.Parse(data[3])));
                else
                    listTrades.Add(new TradeDto(Double.Parse(data[0]), data[1], DateTime.ParseExact(data[2], "MM/dd/yyyy", CultureInfo.InvariantCulture)));
            }

            // mock inputData 1ª questão
            //var initialDate = DateTime.ParseExact("12/11/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            //listTrades.Add(new TradeDto(Double.Parse("2000000"), "Private", DateTime.ParseExact("12/29/2025", "MM/dd/yyyy", CultureInfo.InvariantCulture)));
            //listTrades.Add(new TradeDto(Double.Parse("400000"), "Public", DateTime.ParseExact("07/01/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture)));
            //listTrades.Add(new TradeDto(Double.Parse("5000000"), "Public", DateTime.ParseExact("01/02/2024", "MM/dd/yyyy", CultureInfo.InvariantCulture)));
            //listTrades.Add(new TradeDto(Double.Parse("3000000"), "Public", DateTime.ParseExact("10/26/2023", "MM/dd/yyyy", CultureInfo.InvariantCulture)));

            // mock inputData 2ª questão
            //var initialDate = DateTime.ParseExact("12/11/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            //listTrades.Add(new TradeDto(Double.Parse("2000000"), "Private", DateTime.ParseExact("12/29/2025", "MM/dd/yyyy", CultureInfo.InvariantCulture)));
            //listTrades.Add(new TradeDto(Double.Parse("400000"), "Public", DateTime.ParseExact("07/01/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture), true));
            //listTrades.Add(new TradeDto(Double.Parse("5000000"), "Public", DateTime.ParseExact("01/02/2024", "MM/dd/yyyy", CultureInfo.InvariantCulture)));
            //listTrades.Add(new TradeDto(Double.Parse("3000000"), "Public", DateTime.ParseExact("10/26/2023", "MM/dd/yyyy", CultureInfo.InvariantCulture), false));

            for (int i = 0; i < listTrades.Count; i++)
                Console.WriteLine(service.VerifyCategory(initialDate, listTrades[i]));

            Console.ReadKey();

        }
    }
}
