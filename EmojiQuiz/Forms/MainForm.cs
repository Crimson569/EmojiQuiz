namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        GameForm gameForm = new GameForm();
        gameForm.Show();
        this.Hide();
    }
}