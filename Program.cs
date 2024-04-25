using System.Runtime.InteropServices;

namespace Konzole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string o = File.ReadAllText("alice.txt");
            string[] s = o.Split(new char[] { ' ', ',', '.', '\n' });
            foreach (var s2 in s)
            {
                if (s2.Trim() != "")
                {
                    if (!dic.ContainsKey(s2))
                    {
                        dic.Add(s2, 1);
                    }
                    else { dic[s2]++; }
                }
            }
            foreach (var septic in dic.OrderBy( x => x.Value).Reverse())
            {
                Console.WriteLine(septic.Value + " : " + septic.Key);
            }
        }
            /*
            for(int i = 0; i < 3; i++)
            {
                Console.Write("o");
                for(int j = 0; j < 2; j++)
                {
                    Console.Write("o");
                }
                Console.WriteLine();
            }
            int x;
            int y;
            ConsoleKeyInfo key = Console.ReadKey(true);
            
            Console.ReadKey();

            string o = @"C:\Users\svobon\Downloads\shrek3.txt";

            dynamic spvoice = Activator.CreateInstance(Type.GetTypeFromProgID("sapi.spvoice"));

            Func<string,Task> anim = x =>
            {
                return Task.Run(
                    () =>
                    {
                        foreach (var c in x)
                        {
                            Console.Write(c);
                            if (c != ' ' && c != '\n')
                                Thread.Sleep(5);
                        }
                    });
            };

            foreach (var s in File.ReadAllLines(o))
            {
                spvoice.Rate = 3;
                var t = anim(s + Environment.NewLine);
                var str = s.Trim();
                if (str.Length != 0)
                {
                    spvoice.Speak(str);
                    
                }
                t.Wait();
            }
            */
            /*string o = @"C:\Users\svobon\Downloads\shrek3.txt";
            Console.WriteLine(File.ReadAllText(o));
            if (File.ReadAllText == "\n") {  }*/
            /*
            string heslo = "$!";
            string pop = "tajne slovo";
            bool running = true;
            ConsoleKeyInfo key = Console.ReadKey(true);
            while (running)
            {
                Console.WriteLine("Zadej heslo: ");
                string zadano = Console.ReadLine();
                if (zadano != heslo)
                {
                    Console.WriteLine("Spante");
                }
                else { Console.WriteLine(pop); running = false; }
                
            }

        }
            */
    }
}