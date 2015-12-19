using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonDataFile = "JsonInput.txt";
            var jsonString = File.ReadAllText(jsonDataFile);
            var greenhouseEvent = JsonConvert.DeserializeObject<GreenhouseEvent>(jsonString);
            Console.WriteLine($"Action: {greenhouseEvent.Action}");
            Console.WriteLine($"Event: {greenhouseEvent.Payload.Event}");
            Console.ReadKey();
        }
    }
}
