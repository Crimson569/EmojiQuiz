using System.ComponentModel;

namespace EmojiQuiz;

partial class AdminForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textAnswer = new System.Windows.Forms.TextBox();
        textEmoji = new System.Windows.Forms.TextBox();
        textCategory = new System.Windows.Forms.TextBox();
        buttonAdd = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textAnswer
        // 
        textAnswer.Location = new System.Drawing.Point(26, 41);
        textAnswer.Name = "textAnswer";
        textAnswer.Size = new System.Drawing.Size(100, 23);
        textAnswer.TabIndex = 0;
        // 
        // textEmoji
        // 
        textEmoji.Location = new System.Drawing.Point(26, 12);
        textEmoji.Name = "textEmoji";
        textEmoji.Size = new System.Drawing.Size(100, 23);
        textEmoji.TabIndex = 1;
        // 
        // textCategory
        // 
        textCategory.Location = new System.Drawing.Point(26, 70);
        textCategory.Name = "textCategory";
        textCategory.Size = new System.Drawing.Size(100, 23);
        textCategory.TabIndex = 2;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new System.Drawing.Point(713, 415);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(75, 23);
        buttonAdd.TabIndex = 3;
        buttonAdd.Text = "Добавить";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // AdminForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonAdd);
        Controls.Add(textCategory);
        Controls.Add(textEmoji);
        Controls.Add(textAnswer);
        Text = "AdminForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textAnswer;
    private System.Windows.Forms.TextBox textEmoji;
    private System.Windows.Forms.TextBox textCategory;
    private System.Windows.Forms.Button buttonAdd;

    #endregion
}