using Newtonsoft.Json;
using Provodnik___rabota_s_failami;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
 
namespace Provodnik___rabota_s_failami 
{   
    public class osnova_vvoda
    {

        static void Main(string[] args)
        {
            Menu();
            
            
        
        }
        public static void Menu() 
        {
            Console.WriteLine("Введите путь до файла");
            string way = Console.ReadLine();
            Fail a = new Fail(way);
        }
    }
} 