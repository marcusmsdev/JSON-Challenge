using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.DOB = new DateTime(1981, 4, 17);
            person.FavoriteIceCreamFlavors = new List<string>
            {
                "Strawberry", "Chocolate",
            };

            string json = JsonConvert.SerializeObject(person);


            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
