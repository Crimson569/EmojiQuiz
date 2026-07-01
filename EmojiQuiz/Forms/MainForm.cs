namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void buttonPlay_Click(object sender, EventArgs e)
    {
        GameForm gameForm = new GameForm();
        gameForm.Show();
        this.Hide();
    }

    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        AdminForm adminForm = new AdminForm();
        adminForm.Show();
        this.Hide();
    }
}