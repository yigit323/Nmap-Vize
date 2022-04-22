using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NmapO
{
    class Program
    {
        static void Main(string[] args)
        { 

            string Nmapscan, MACAddress;

            
            Console.WriteLine("╔══════════════════*+*══════════════════╗");
            Console.WriteLine("║         Ip Adresini Giriniz:          ║ ");
            Console.WriteLine("╚═══════════════════════════════════════╝");
            Nmapscan = Convert.ToString(Console.ReadLine());

            MACAddress = Convert.ToString(Console.ReadLine());

            //Alt tarafta CMD'yi çalıştırıp,Nmap sayesinde bilgisayarda çalışan aktif IP adreslerin hangi portları çalıştırdığını gösteren çıktısı text olan uygulama yazılmıştır.
            //Örnek IP olarak 192.168.1.1 bunu girebilirsiniz
            string strCmdText;
            strCmdText = "/C nmap -sn 192.168.1.1/25  | findstr /v Host > odevmap.txt";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //Çıktı:\NmapO\NmapO\bin\Debug\odevmap.txt


        }

    }
    }
