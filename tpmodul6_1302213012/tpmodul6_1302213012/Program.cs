// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

internal class Program
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null, "Judul video tidak boleh null");
            Contract.Requires(title.Length <= 100, "Judul video memiliki panjang maksimal 100 karakter");

            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Contract.Requires(playCount >= 0 && playCount <= 10000000, "Input penambahan play count " +
                "maksimal 10.000.000 per panggilan method");
            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Error: " + e.Message);    
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " +  id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " +  playCount);
        }

        public static void Main(string[] args)
        {
            try
            {
                SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract — Bimo Zachriansyah Wicaksono Hermawan");
                vid.IncreasePlayCount(2);
                vid.IncreasePlayCount(10000000);

                for (int i = 0; i < 1000000000; i++)
                {
                    vid.IncreasePlayCount(1);
                }
                vid.PrintVideoDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
