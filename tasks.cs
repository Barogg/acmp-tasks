using System; //970 task
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            string s = Console.ReadLine();
            string[] s1 = s.Split(' ');
            a = int.Parse(s1[0]);
            b = int.Parse(s1[1]);
            c = int.Parse(s1[2]);
            if (a + b == c || a + c == b || b + c == a)
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }
  
        }
    }
}

using System; //948
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int k, n,temp;
            string text = Console.ReadLine();
            string[] text1 = text.Split(' ');
            k = int.Parse(text1[0]);
            n = int.Parse(text1[1]);
            temp = n - 1;
            temp = temp % k + 1;
            Console.WriteLine((n+k-1) / k + " " + temp);
        }
    }
}


using System; //907
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int w, h, r, d;
            List<int> s1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            w = s1[0];
            h = s1[1];
            r = s1[2];
            d = r * 2;
            //a = int.Parse(Console.ReadLine());
            if (d <= w && d <= h)
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
            
        }
    }
}


using System; //35

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int d, m, n;
            string s;
            //List<int> s1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                s = Console.ReadLine();
                string[] s1 = s.Split(' ');
                n = int.Parse(s1[0]);
                m = int.Parse(s1[1]);
                d = 19 * m + (n + 239) * (n + 366) / 2;
                Console.WriteLine(d);
            }
        }
    }
}

using System; //43
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {   
            string str = Console.ReadLine();

            int res = 0, c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                    res += 1;
                else
                {
                    if (c < res)
                        c = res;
                    res = 0;
                }
            }
            if (c < res)
                c = res;

            Console.WriteLine(c);
        }
    }
}

using System; //52

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var s = Console.ReadLine();
            int a, b;
            a = s[0] + s[1] + s[2];
            b = s[3] + s[4] + s[5];
            if (a == b)
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }
                
        }
    }
}

using System; //504
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int k, i;
            string text = Console.ReadLine();
            string temp;
            string[] text1 = {"G", "C", "V" };
            k = int.Parse(text);
            for (i=0; i<k; i++)
            {
                temp = text1[2];
                text1[2] = text1[1];
                text1[1] = temp; //утро

                temp = text1[1];
                text1[1] = text1[0];
                text1[0] = temp; //вечер
            }
            foreach(string s in text1)
            {
                Console.Write(s);
            }
            
        }
    }
}

using System; //529
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string text,text2;
            int x1,x2,y1,y2;
            double dl = 0;
            text = Console.ReadLine();
            string[] text1 = text.Split(' ');
            x1 = int.Parse(text1[0]);
            y1 = int.Parse(text1[1]);
            x2 = int.Parse(text1[2]);
            y2 = int.Parse(text1[3]);
            dl = Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)));
            text2 = Convert.ToString(dl);
            text2 = text2.Replace(",", ".");
            Console.WriteLine(text2); 
        }
    }
}

using System; //13
using System.IO;
 
namespace TestCLang
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            string a, b;
            int cow=0,byk=0;
            a = tokens[0];
            b = tokens[1];
            for (int i = 0; i < 4; i++) {
                if (int.Parse(Convert.ToString(a)[i].ToString()) == int.Parse(Convert.ToString(b)[i].ToString()))
                {
                    byk += 1;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j=0;j<4;j++)
                {
                    if (int.Parse(Convert.ToString(a)[i].ToString()) == int.Parse(Convert.ToString(b)[j].ToString()) && i != j)
                    {
                        cow += 1;
                    }
                }
            }
            Console.WriteLine(byk + " " + cow);
        }
     }
}


using System; //5

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int a, chet=0, nechet = 0, i;
            string s = Console.ReadLine();
            a = Convert.ToInt32(s);
            string[] ans = new string[a];
            string s1 = Console.ReadLine();
            string[] splitString1 = s1.Split(' ');

            for (i=0; i<a; i++)
            {            
                ans[i] = splitString1[i];
                if (int.Parse(ans[i]) % 2 == 0) //четность
                {
                    nechet++;
                } else
                {
                    chet++;
                }
            }
            for (i = 0; i < a; i++)
            {
                if (int.Parse(ans[i]) % 2 != 0)
                {
                    Console.Write(ans[i] + ' '); //нечетность
                }
            }
            Console.WriteLine();
            for (i = 0; i < a; i++)
            {
                if (int.Parse(ans[i]) % 2 == 0) //четность
                {
                    Console.Write(ans[i] + ' ');
                }
            }
            Console.WriteLine();
            if (chet > nechet)
            {
                Console.WriteLine("NO"); 
            } else
            {
                Console.WriteLine("YES");
            }
            Console.ReadLine();
        }
    }
}


