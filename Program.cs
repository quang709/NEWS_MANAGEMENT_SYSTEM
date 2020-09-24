using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections;

namespace NEWS_MANAGEMENT_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;

            Console.WriteLine("1.chen tin tuc");
            Console.WriteLine("2.xem tin danh sach");
            Console.WriteLine("3.ty le trung binh");
            Console.WriteLine("thoat");
            do
            {
                Console.WriteLine("select:");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.addNews();
                        break;
                    case 2:
                        program.ViewNews();
                        break;
                    case 3:
                        program.EverateRate();
                        break;
                    case 4:

                        return;

                }

            }
            while (choice != 4);
        }
        int count = 0;
        Hashtable Listnews = new Hashtable();
        public void addNews()
        {
            News news = new News();
            news.ID = ++count;
            Console.Write("Title: ");
            news.Title = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Publish date: ");
                    news.PublishDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Publish date is not formatted !");
                }
            }
           
            Listnews.Add(count,news);
            
        }

        public void ViewNews()
        {
            if (Listnews.Count > 0)
            {
                foreach (News item in Listnews.Values)
                {
                    item.Display();
                }
            }

            else
            {
                Console.WriteLine("News not found!");
            }
        }


        public void EverateRate()
        {
            if (Listnews.Count > 0)
            {
                foreach (News news in Listnews.Values)
                {
                    news.Calculate();
                    news.Display();
                }
            }
            else
            {
                Console.WriteLine("News not found!");
            }
        }
    }
}
