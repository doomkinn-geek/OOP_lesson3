using System;
using System.IO;
using System.Text;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя файла, который нужно обработать: ");
            string fileName = Console.ReadLine();
            string outputFile = "emails.txt";
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Указанного файла не существует");
                return;
            }
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string s = String.Empty;
                    using (StreamWriter sw = new StreamWriter(File.Create(outputFile)))
                    {
                        while ((s = sr.ReadLine()) != null)
                        {
                            string[] strs = s.Split('&');
                        
                            for (int i = 0; i < strs.Length; i++)
                            {
                                SearchMail(ref strs[i]);
                                if (strs[i].Trim() != "")
                                {
                                    sw.WriteLine(strs[i]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка обработки: {e.Message}");
            }
        }

        public static void SearchMail(ref string s)
        {
            if(s.Contains('@'))
            {
                s = s.Trim();
                if (s.Contains(' '))
                {
                    s = s.Substring(0, s.IndexOf(' '));
                }
            }
            else
            {
                s = "";
            }
        }
    }
}
