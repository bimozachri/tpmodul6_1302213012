// See https://aka.ms/new-console-template for more information
internal class Program
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " +  id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " +  playCount);
        }

        public static void Main(string[] args)
        {
            SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract — Bimo Zachriansyah Wicaksono Hermawan");
            vid.IncreasePlayCount(2);
            vid.PrintVideoDetails();
        }
    }
}
