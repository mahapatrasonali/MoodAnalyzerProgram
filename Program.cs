namespace MoodAnalyzerProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("How is your mood Happy or Sad");
            string message = Console.ReadLine();
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            Console.WriteLine(moodAnalyzer.AnalyseMood(message));
        }
    }
}
