using EmojiQuiz.Repositories;

namespace EmojiQuiz;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        Db.EnsureCreated();
        Db.SeedFromFile("movies_ru_emoji.tsv");
        
        Application.Run(new MainForm());
    }
}