using System;
using System.Collections.Generic;
using System.Linq;

namespace Asset_Tracking_Mini_project_saranya
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Asset Tracking");
            List<Asset> Details = new List<Asset>();
            int index = 0;
            string[] values = new string[10];
            while (true)
            {
                while (true)
                {
                    Console.Write("Enter Type: ");
                    string input = Console.ReadLine();
                    if (input.ToLower().Trim() == "exit")
                    {
                        break;
                    }
                   
                    Console.Write("Enter Brand: ");
                    string brand = Console.ReadLine();
                    Console.Write("Enter Model: ");
                    string model = Console.ReadLine();
                    Console.Write("Enter Country: ");
                    string country = Console.ReadLine();
                    Console.Write("Enter DateOfPurchase: ");

                    var userInput = Console.ReadLine();


                    DateTime dt = new DateTime();
                    DateTime.TryParse(userInput, out dt);

                    Console.Write("Enter Price: ");
                    double usd = double.Parse(Console.ReadLine());
                    Console.Write("Enter currency: ");
                    string currency = Console.ReadLine();



                    Asset detail = new Asset(input, brand, model, country, dt, usd, currency);
                    Details.Add(detail);
                    values[index] = input;
                    index++;

                }
                List<Asset> SortedItems = Details.OrderBy(detail => detail.Type).ThenBy(detail => detail.Dt).ToList();

               
                
                    
                    Console.WriteLine("TYPE".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Office".PadRight(15) + "DateOfPurchase".PadRight(20) + "Price(USD)".PadRight(15) + "Currency".PadRight(15) + "LocalPrice");

                    foreach (Asset detail in SortedItems)
                    {
                        Console.WriteLine(detail.Type.PadRight(15) + detail.Brand.PadRight(15) + detail.Model.PadRight(15) + detail.Country.PadRight(15) + detail.Dt.ToString("yyyy-MM-dd").PadRight(20) + detail.Usd.ToString().PadRight(15) + detail.Currency);
                    }



                
            }
        }
    }
        class Asset
        {
            public Asset(string type, string brand, string model, string country, DateTime dt, double usd, string currency)
            {
                Type = type;
                Brand = brand;
                Model = model;
                Country = country;
                Dt = dt;
                Usd = usd;
                Currency = currency;
            }

            public string Type { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Country { get; set; }
            public DateTime Dt { get; set; }

            public double Usd { get; set; }

            public string Currency { get; set; }

        }
        class CurrencyConvert : Asset
        {
        public CurrencyConvert(string type, string brand, string model, string country, DateTime dt, double usd, string currency) : base(type, brand, model, country, dt, usd, currency)
        {
        }

        public double ConvertCurrency { get; set; }
         }
    

}   

