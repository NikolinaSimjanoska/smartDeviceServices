using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonServiceReference.Service1Client service1Client = new TelefonServiceReference.Service1Client();

            WatchServiceReference.Service2Client service2Client = new WatchServiceReference.Service2Client();

            int i = 0;

            while (i != 5)
            {
                Console.WriteLine("\n1 - Izpis podatkov o napravah. ");
                Console.WriteLine("2 - Izpis podatkov o senzorjih.");
                Console.WriteLine("3 - Izpis vrednoste znotraj senzorjev.");
                Console.WriteLine("4 - Demonstracija uporabljene senzore.");
                Console.WriteLine("5 - Izhod.");
                Console.Write("Vnos izbire: ");
                String izbira = Console.ReadLine();
                i = Convert.ToInt32(izbira);

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Izpis podatkov o napravah: ");
                        Console.Write("Naziv naprave: {0}", service1Client.GetData().Naziv);
                        Console.Write(", ID naprave: {0}", service1Client.GetData().ID);
                        Console.Write(", Proizvajalec: {0}", service1Client.GetData().Proizvajalec);
                        if (service1Client.GetData().Stanje == true)
                            Console.WriteLine(", Stanje: vklopljen");
                        else
                            Console.WriteLine(", Stanje: izklopljen");
                        Console.Write("Če želiš vklopiti/izklopiti napravo vtipkaj true/false:");
                        String read = Console.ReadLine();
                        bool result = Convert.ToBoolean(read);
                        if (service1Client.SetState(result).Stanje == true)
                            Console.WriteLine("Spremenjeno stanje je vklopljeno");
                        else
                            Console.WriteLine("Spremenjeno stanje je izklopljeno");
                        Console.Write("Naziv naprave: {0}", service2Client.GetData().Naziv);
                        Console.Write(", ID naprave: {0}", service2Client.GetData().ID);
                        Console.Write(", Proizvajalec: {0}", service2Client.GetData().Proizvajalec);
                        if (service2Client.GetData().Stanje == true)
                            Console.WriteLine(", Stanje: vklopljen");
                        else
                            Console.WriteLine(", Stanje: izklopljen");
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Izpis podatke o senzorji: ");
                        Console.Write("Senzor 1: {0}", service1Client.GetData().Pedometer.Naziv);
                        Console.Write(", Proizvajalec: {0}", service1Client.GetData().Pedometer.Proizvajalec);
                        if (service1Client.GetData().Pedometer.Stanje == true)
                            Console.WriteLine(", Stanje: vklopljen");
                        else
                            Console.WriteLine(", Stanje: izklopljen");
                        Console.Write("Senzor 2: {0}", service1Client.GetData().Proximity.Naziv);
                        Console.Write(", Proizvajalec: {0}", service1Client.GetData().Proximity.Proizvajalec);
                        if (service1Client.GetData().Proximity.Stanje == true)
                            Console.WriteLine(", Stanje: vklopljen");
                        else
                            Console.WriteLine(", Stanje: izklopljen");
                        Console.Write("Senzor 3: {0}", service1Client.GetData().Light.Naziv);
                        Console.Write(", Proizvajalec: {0}", service1Client.GetData().Light.Proizvajalec);
                        if (service1Client.GetData().Light.Stanje == true)
                            Console.WriteLine(", Stanje: vklopljen");
                        else
                            Console.WriteLine(", Stanje: izklopljen");
                        Console.Write("Senzor 4: {0}", service2Client.GetData().HeartMonitor.Naziv);
                        Console.Write(", Proizvajalec: {0}", service2Client.GetData().HeartMonitor.Proizvajalec);
                        if (service2Client.GetData().HeartMonitor.Stanje == true)
                            Console.WriteLine(", Stanje: vklopljen");
                        else
                            Console.WriteLine(", Stanje: izklopljen");
                        Console.Write("Senzor 5: {0}", service2Client.GetData().SkinTemp.Naziv);
                        Console.Write(", Proizvajalec: {0}", service2Client.GetData().SkinTemp.Proizvajalec);
                        if (service2Client.GetData().SkinTemp.Stanje == true)
                            Console.WriteLine(", Stanje: vklopljen");
                        else
                            Console.WriteLine(", Stanje: izklopljen");
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Izpis vrednoste iz senzorja: ");
                        Console.Write("Izpis število korakov: {0}", service1Client.GetData().Pedometer.Steps);
                        Console.WriteLine(", Izpis kilometrov: {0}", service1Client.GetData().Pedometer.Km);
                        Console.WriteLine("Izpis kilometrov oddaljenosti od obraza: {0}", service1Client.GetData().Proximity.Km);
                        Console.WriteLine("Izpis vrednosti svetlobe: {0} %", service1Client.GetData().Light.Light);
                        Console.WriteLine("Izpis srčnega otripa: {0}", service2Client.GetData().HeartMonitor.Beats);
                        Console.WriteLine("Izpis temperature: {0}C", service2Client.GetData().SkinTemp.Temp);
                        break;
                    case 4:

                        Console.WriteLine();
                        Console.WriteLine("Demonstracija uporabljene senzore: ");
                        Console.WriteLine("Povecaj stevilo korakov. Stevilo korakov je: {0}", service1Client.RaiseSteps().Pedometer.Steps);
                        Console.WriteLine("Nov dan. Resetiraj stevilo korakov. Stevilo korakov je: {0}", service1Client.RestartSteps().Pedometer.Steps);
                        Console.Write("Preverba če je telefon preveč blizu. Oddaljenost od obraza je: {0}.", service1Client.GetData().Proximity.Km);
                        if (service1Client.TurnOffScreen().Proximity.TurnOff == true)
                            Console.WriteLine("Zaslon je vklopljen. Oddaljenost od obraza je primerna.");
                        else
                            Console.WriteLine("Zaslon se izklopi.");

                        Console.Write("Trenutna svetloba je: {0}%. ", service1Client.GetData().Light.Light);
                        Console.WriteLine("Prilagoditev svetlobe -> Svetloba je: {0} %", service1Client.AdjustBrightness().Light.Light);
                        if (service2Client.RaiseBeats().HeartMonitor.Beats > 100)
                            Console.WriteLine("Število utripov je preveliko. Take a break.");
                        else if (service2Client.RaiseBeats().HeartMonitor.Beats < 60)
                            Console.WriteLine("Get up and move!");

                        if (service2Client.Termometer().SkinTemp.Temp > 37)
                            Console.WriteLine("Vaša temperatura je prevelika. Poklicite svojega zdravnika.");
                        else
                            Console.WriteLine("Vasa temperatura je primerna.");
                        break;
                    case 5:
                        Console.WriteLine("\nAdijo!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("\nNapačna izbira! Poskusite znova");
                        break;
                }
            }
        }
    }
}
