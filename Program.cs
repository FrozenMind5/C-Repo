using System;

namespace Project2
{
    class Allign
    {
        public string st;
        public string[] splitword(string st)
        {
            string[] s2 = st.Split(' ');
            return s2;
        }
        public void print_allign(string []str)
        {
            string ss = "";
            int cur = 0;
            int len = str.Length;
            for(int i=0;i<=len-1;i++)
            {
                int tmp_sz = str[i].Length;
                if (cur + tmp_sz == 16)
                {
                    ss = ss + str[i];
                    Console.WriteLine(ss);
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
                else if(cur+tmp_sz>16)
                {
                    Console.WriteLine(ss);
                    ss = "";
                    cur = 0;
                    i--;
                }
            }
            Console.WriteLine(ss);
        }
    }
    class ExtendAllign
    {
        static void Main(string []args)
        {
            Allign a = new Allign();
            a.st = "I am ready to rock u know it very well and that is we are looking for";
            String[] s3=a.splitword(a.st);
            a.print_allign(s3);
            Console.ReadKey();
            
        }
    }
}
