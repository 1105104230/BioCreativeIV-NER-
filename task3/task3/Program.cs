using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\ken19980727\Desktop\ISLAB_30902\Biocreative\BioCreative_TrainTask3.0.tsv"))
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                using (StreamWriter sw = new StreamWriter(@"C:\Users\ken19980727\Desktop\ISLAB_30902\Biocreative\train1.txt", true, utf8))
                {
                    string line;
                    int c = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] a = line.Split('\t');
                        string[] text = a[3].Split(' ');
                        if (a[4] == "start")
                        {}
                        else if (a[4] != "-")
                        {
                            int text_length = 0;
                            Console.WriteLine("qweqwe");
                            string[] b = a[7].Split(' ');
                            if (b.Length > 1)
                            {
                                for (int i = 0; i < b.Length; i++)
                                {
                                    Console.WriteLine(b[i]);
                                }
                            }
                            else
                            {
                                foreach (var t in text)
                                {
                                    
                                    if (text_length.ToString() != a[4])
                                    {
                                        Console.Write(t);
                                        Console.Write('\t');
                                        Console.WriteLine('0');
                                    }
                                    text_length += t.Le

                                }
                                
                            }
                        }
                        else
                        {
                            foreach (var i in text)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.WriteLine("");
                        c += 1;
                        if (c > 1)
                        {
                            break;
                        }
                    }
                }

            }
            Console.Read();
        }
    }
}
