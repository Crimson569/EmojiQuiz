using EmojiQuiz.Models;
using Microsoft.EntityFrameworkCore;

namespace EmojiQuiz;

public class QuizContext : DbContext
{
    public DbSet<Question> Questions => Set<Question>();
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=quiz.db");
    }
}