using System;
using System.Collections.Generic;
namespace Project2
{
    class Allign
    {
        public string st;
        public List<string> splitword(string st)
        {
            List<string> s2=new List<string>();
            int len = st.Length;
            string tmp = "";
            int t = 0;
            for (int i = 0; i <= len - 1; i++)
            {
                if (st[i] == ' ')
                {
                    s2.Add(tmp);
                    tmp = "";
                    t++;
                }
                else
                {
                    tmp = tmp + st[i];
                }
            }
            s2.Add(tmp);
            return s2;
        }
        public void print_allign(List<string>str)
        {
            string ss = "";
            int cur = 0;
            int len = str.Count;
            for (int i = 0; i <= len - 1; i++)
            {
                int tmp_sz = str[i].Length;
                if (cur + tmp_sz == 16)
                {
                    ss = ss + str[i];
                    Console.WriteLine(String.Format("{0,16}", ss));
                    ss = "";
                    cur = 0;
                }
                else if (cur + tmp_sz < 16)
                {
                    cur = cur + tmp_sz;
                    ss = ss + str[i];
                    ss = ss + " ";
                    cur++;
                }
                else if (cur + tmp_sz > 16)
                {
                    Console.WriteLine(String.Format("{0,16}", ss));
                    ss = "";
                    cur = 0;
                    i--;
                }
            }
            Console.WriteLine(String.Format("{0,16}", ss));
        }
    }
    class ExtendAllign
    {
        static void Main(string[] args)
        {
            Allign a = new Allign();
            a.st = "I am ready to rock u know it very well and that is we are looking for";
             List<string>ss = a.splitword(a.st);
            a.print_allign(ss);
            int sz = ss.Count;
            for(int i=0;i<=sz-1;i++)
            {
                Console.WriteLine(ss[i]);
            }
            Console.ReadKey();

        }
    }
}