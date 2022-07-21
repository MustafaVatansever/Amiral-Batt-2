using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Amiral_Battı_2
{
   public static class Oyuncu
    {
       public static string name;
       public static bool Host = false;

       public static Socket s;
       public static Stream stm;
       public static IPAddress ipad = IPAddress.Parse("127.0.0.1");
       public static TcpListener dinle = new TcpListener(ipad, 7011);

       public static TcpClient tcpclnt = new TcpClient();
      
        public static bool HostBaglanti()
        {
            dinle.Start();
            s = dinle.AcceptSocket();
            dinle.Stop();
            Host = true;
            return true;
        }
        public static bool ClientBaglanti()
        {
            Host = false;
            try
            {
                tcpclnt.Connect("127.0.0.1", 7011);
                stm = tcpclnt.GetStream();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public static string HostingButongetir()
        { 
            dinle.Start();
            byte[] byt = new byte[100];
            int k = s.Receive(byt);
            string gelenbutonname = "";
              for(int i = 0;i < k; i++)
            {
                gelenbutonname += Convert.ToChar(byt[i]);
            }
            dinle.Stop();
            return gelenbutonname;
        }
        public static void HostingButonGotur(string gidenbutonname)
        {
            ASCIIEncoding asen = new ASCIIEncoding();
            s.Send(asen.GetBytes(gidenbutonname));
           // s.Close();
           // dinle.Stop();
        }
        public static void ClientButonGotur(string gidenbutonname)
        {
         //   tcpclnt.Connect("127.0.0.1", 8001);
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] gönder = asen.GetBytes(gidenbutonname);

            
            stm.Write(gönder,0,gönder.Length);
        }

        public static string ClientButonGetir()
        {
            byte[] getir = new byte[100];
            if (stm == null)
            {
                Console.WriteLine("stm nul");
            }
            int k = stm.Read(getir, 0, getir.Length);
            string gelenbutonname = "";
            for (int i = 0; i < k; i++)
            {
                gelenbutonname += Convert.ToChar(getir[i]);
            }
           
            return gelenbutonname;
        }

    }
    
}
