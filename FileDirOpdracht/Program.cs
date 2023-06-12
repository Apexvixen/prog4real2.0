namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\ytshi\\OneDrive\\Documenten\\ma\\bewijzenmap\\periode.4\\prog\\prog4real2.0";
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files= dir.GetFiles();
            foreach (FileInfo file in files) 
            {
                Console.WriteLine(file.Name);

            }
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo iectory in dirs) 
            { 
                Console.WriteLine(iectory.Name);
            }
        }
    }
}