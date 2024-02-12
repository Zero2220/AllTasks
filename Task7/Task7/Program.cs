
using System.Net.WebSockets;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Age = 1,
                Fullname = "anar"
            };

            JsonSerializer.Serialize(person);
            
            using(FileStream fs = new ("C:\\Users\\Asus\\Desktop\\AllTasks\\Task7\\Task7\\data\\person.json",FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                var json = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
 