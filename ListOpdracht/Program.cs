namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bird = new List<string>() {"uil", "kraai", "hond","papegaai"};
            List<string> bird2 = new List<string>() { "meeuw", "duil" };
            bird.AddRange(bird2);
            bird.Remove("hond");
            foreach (string s in bird)
            {
                Console.WriteLine(s);
            }
            


        }
    }
}