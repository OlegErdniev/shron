using System;

namespace Chetire
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Vvedite chislo iks");
            int x = Int32.Parse(Console.ReadLine());
            double a = x * 2;
            double b = -3 * x;
            if (x<-2 || x > 2){
                Console.WriteLine($"{a}");
            }
            else if (-2<=x && x<=2)
            {
                Console.WriteLine($"{b}");
            }
            else
            {
                Console.WriteLine("Jija");

            }*/
            /*Console.WriteLine("Vvedite chislo iks");
            int x = Int32.Parse(Console.ReadLine());
            double a = 2*Math.Sin(x);
            double b = -6+x;
            if (x > 0)
            {
                Console.WriteLine($"{a}");
            }
            else if (x <= 0)
            {
                Console.WriteLine($"{b}");
            }
            else
            {
                Console.WriteLine("Jija");
            }

                Console.ReadKey();*/
            /* Console.WriteLine("Vvedite chislo odin, dva ili tri(tsiframi)");
             int x = Int32.Parse(Console.ReadLine());
             switch (x)
             {
                 case 1:
                     Console.WriteLine("portsiya stoit 25RUBLEY");
                     break;

                 case 2:
                     Console.WriteLine("portsiya stoit 50RUBLEY");
                     break;

                 case 3:
                     Console.WriteLine("portsiya stoit 75RUBLEY");
                     break;
             }*/
            /*Console.WriteLine("Vvedite nomer dnya nedeli(tsiframi)");
            int x = Int32.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Ponedelnik");
                    break;

                case 2:
                    Console.WriteLine("Vtornik");
                    break;

                case 3:
                    Console.WriteLine("Sreda");
                    break;
                case 4:
                    Console.WriteLine("Shitverg");
                    break;
                case 5:
                    Console.WriteLine("Pyatnitsa");
                    break;
                case 6:
                    Console.WriteLine("Subbota");
                    break;
                case 7:
                    Console.WriteLine("Voskresenie");
                    break;
            }
            Console.ReadKey();*/



            /*UROK 3*/

            /*Console.WriteLine("Vvedite chislo");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }*/
            /*Console.WriteLine("Nomer1");
            for (int i = -3; i <=24; i+=3)
            {
                Console.WriteLine($"{i} ");
            }*/
            /*Console.WriteLine("Nomer2");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"{i} ");
            }
            for (int i = 100; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }

           Console.ReadKey()*/
            /*Console.WriteLine("Nomer3");
            Console.WriteLine();
            int p = 0;
            int o = 0;
            for (int i = 1; i <= 10; i++)
            {
               
                int a = Int32.Parse(Console.ReadLine());
                if (a >= 0)
                {
                    p += 1;
                }
                else
                {
                    o += 1;
                }
            }
            Console.WriteLine($"Kolichestvo polozhitelnich = {p}");
            Console.WriteLine($"Kolichestvo otritsatelnich = {o}");*/
            /*Console.WriteLine("Nomer4etire");
            Console.WriteLine();
            int o = 0;
            for (int i = 1; i <= 10; i++)
            {

                int a = Int32.Parse(Console.ReadLine());
                o += a;
            }
            Console.WriteLine($"summa ravna {o}");*/
            /*Console.WriteLine("Nomer5");
            int sum = 0;
            int a = 1;
            for (int i = 2; a <= 20;)
            {
                sum += a;
                a += i;
            }
            Console.WriteLine(sum);
                Console.ReadKey();*/
            /*Console.WriteLine("Nomer6");
            double product = 1.0;
            for (int i = 1; i <= 10; i++)
            {
                double a = double.Parse(Console.ReadLine());
                product *= a;
            }
            Console.WriteLine(product);*/
            /*Console.WriteLine("LABARATORNAYA");
            int o;
            int inn;
            for (o = 2; o <= 100; o++)
            {
                for (inn = 2; inn <= (o / 2); inn++)
                {
                    if ((o % inn) == 0) break;
                }
                if (inn > (o / inn))
                {
                    Console.WriteLine($"{o} prostoe chislo");
                }
            }*/
            /*Console.WriteLine("Nomer7");
            double z = 0.0;
            for (int x = 2; x <= 8; x++)
            {
                for (int y = 2; y <= 5; y++)
                {
                    z = Math.Pow(x, y);
                    Console.WriteLine(z);
                }
            }*/
            /*Console.WriteLine("Nomer8");
            double z = 0.0;
            for (int x = 30; x <= 33; x++)
            {
                for (int y = 1; y <= 5; y++)
                {
                    z = x-y;
                    Console.WriteLine(z);
                }
            }*/



            /* UROK 4*/


            /*Console.WriteLine("Laboaratornaya1");
            Console.WriteLine("Vvedite chislo");
            int N = Int32.Parse(Console.ReadLine());
            int counter = 0;
            while (counter <= N) { 
                counter++;
                Console.WriteLine($"Schetschik raven {counter}");
                    }*/
            /*Console.WriteLine("Laba2");
            int counter = 1;
            do
            {
                Console.WriteLine($"Schetschik raven {counter}");
                counter++;
            } while (counter <= 5);*/
            /*Console.WriteLine("Nomer1");
            int counter1 = 3;
            int counter2 = 3;
            while (counter1 <= 21)
            {
                Console.WriteLine($"Schetschik raven {counter1}");
                   counter1 += 2;
            }
            do
            {
                Console.WriteLine($"Schetschik raven {counter2}");
                    counter2 += 2;
            } while (counter2 <= 21);*/
            /* Console.WriteLine("Nomer2");
             int counter1 = 15;
             int counter2 = 15;
             while (counter1 >= 0)
             {
                 Console.WriteLine($"Schetschik raven {counter1}");
                 counter1 -= 3;
             }
             do
             {
                 Console.WriteLine($"Schetschik raven {counter2}");
                 counter2 -= 3;
             } while (counter2 >= 0);*/
            /*Console.WriteLine("Nomer3");
            int counter = 10;
            double product = 1;
        
            while (counter <=20)
            {
                product *= counter;
                counter += 2;
            }
            Console.WriteLine($"{product}");*/
            /*Console.WriteLine("Nomer4");
            int counter = 0;
            double sum = 0;                                                                                                                          
            while (counter < 5)
            {
                double a = double.Parse(Console.ReadLine());
                sum += a;
                counter++;
            }
            Console.WriteLine(sum);*/
            /*Console.WriteLine("Laba3");
            int jija;
            int jijamin = int.MaxValue;

            do
            {
                jija = Int32.Parse(Console.ReadLine());
                if(jija < jijamin && jija != 0)
                {
                    jijamin = jija;
                }
            } while (jija != 0);
            Console.WriteLine($"Minimal - {jijamin}");*/
            /*Console.WriteLine("Nomer5");
            int jija;
            int jaja = 0;
            int jijamax = 0;

            do
            {
                jija = Int32.Parse(Console.ReadLine());
                if (jija > jijamax && jija != 0)
                {
                    jijamax = jija;
                    jaja++;
                }
            } while (jija != 0);
            Console.WriteLine($"Maximal - {jijamax} and ego number {jaja}")*/
            /*Console.WriteLine("DopNomer1");
    
            for (int i = 1; i <= 3; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double gachimuchi = x - 3;
                double y = 4 * Math.Pow(gachimuchi, 6) - 7 * Math.Pow(gachimuchi, 3) + 2;
                Console.WriteLine($"Zna4enie {i} funktsii ravno {y}");
            }
            

            }*/
            
        }
    }
}
