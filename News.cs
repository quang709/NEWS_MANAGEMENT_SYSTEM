using System;
using System.Collections.Generic;
using System.Text;

namespace NEWS_MANAGEMENT_SYSTEM
{
     public class News :INews
    {
    
    public int ID { get; set; }
        public string Title { get; set; }

        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AverageRate { get; set; }
        public void Display()
        {
            Console.WriteLine($"{Title} {PublishDate} {Author} {Content} {AverageRate}");
        }

       
        int[] RateList = new int[3];
        public void Calculate()
        {
            AverageRate = (RateList[0] + RateList[1] + RateList[2]) / 3;
        }

    }
}
