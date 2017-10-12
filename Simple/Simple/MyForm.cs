using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple
{
    public class MyForm : Form
    {
        private TextBox MessageTextBox = new TextBox();
        private Button button = new Button();
        private Label label = new Label();

        string textMessage = "I will show here what you type";
        public MyForm()
        {
            this.Text = "My Form";

            MessageTextBox.Left = 25;
            MessageTextBox.Top = 25;
            MessageTextBox.Width = 200;
            Controls.Add(MessageTextBox);

            label.Left = 25;
            label.Top = 75;
            label.Width = 200;
            label.Text = textMessage;
            Controls.Add(label);

            button.Left = 50;
            button.Top = 125;
            button.Width = 100;
            button.Text = "Show Information";
            Controls.Add(button);
            button.Click += ClickButton;
        }

        private void ClickButton(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MessageTextBox.Text))
            {
                label.Text = MessageTextBox.Text;
            }
            else
            {
                label.Text = textMessage;
            }
        }
    }
}
