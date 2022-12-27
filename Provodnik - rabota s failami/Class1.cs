using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provodnik___rabota_s_failami
{
    public class Fail
    {
        public Fail(string WAY)
        {
            way = WAY;
        }
        public string txt_fail;
        public string json_fail;
        public string xml_fail;
        public string way;
        public ConsoleKeyInfo key = Console.ReadKey();
        public void Txt()
        {
           if (File.Exists(way)) 
           {
                string[] txt_fail =File.ReadAllLines(way);
                Console.WriteLine(txt_fail); 
           }
           else
           {
                Console.WriteLine("Вы ввели неверный путь или этот файл не существует");
                Console.WriteLine("Желаете создать новый файл? Num1 - Да    Num2 - Нет");
                if (key.Key == ConsoleKey.NumPad1)
                {
                    File.Create(way);
                    Console.WriteLine("Вы создали новый файл");
                }
                else
                {
                    Console.WriteLine("Завершение программы");

                }
           }
        }
        public void Json()
        {
            Console.WriteLine(json_fail);

        }
        public void Xml()
        {
            Console.WriteLine(xml_fail);

        }
    }
    
}
