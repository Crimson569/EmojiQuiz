namespace EmojiQuiz.Models;

public class Question
{
    public int Id { get; set; }
    public string Emoji { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
}