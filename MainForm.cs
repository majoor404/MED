using System;
using System.Windows.Forms;

namespace MED
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                // esc gezien, zet focus op invoer balk en zet ">"
                textBoxCommando.Focus();
                textBoxCommando.Text = " > : ";
                textBoxCommando.SelectionStart = textBoxCommando.Text.Length;
            }
        }

        private void TextBoxCommando_MouseClick(object sender, MouseEventArgs e)
        {
            Tekst.Focus();
        }

        private void TextBoxCommando_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                
                case (char)27:      // esc (terug naar tekst)
                    textBoxCommando.Text = " ";
                    Tekst.Focus();
                    break;
                case (char)13:
                    Parse_commando(textBoxCommando.Text);
                    break;
                //case (char)32:      // spatie , commando regel 
                //    textBoxCommando.Text = " > : ";
                //    textBoxCommando.SelectionStart = textBoxCommando.Text.Length;
                //    break;
                default:
                    break;
            }
        }

        private void Parse_commando(string commando_regel)
        {
            string commando = commando_regel.Substring(5, 1);

            commando = commando.ToLower();

            switch (commando)
            {
                case "l":
                    LoadWindow lf = new LoadWindow();
                    lf.ShowDialog();
                    //LoadFile(commando_regel.Substring(7));
                    break;
                case "q":           // q is close
                    Close();
                    break;
                case "c":           // c is clear
                    Tekst.Clear();
                    textBoxCommando.Text = "";
                    break;
                case "h":           // h is help
                    Tekst.Clear();
                    Tekst.AppendText("Q = Quit");
                    Tekst.AppendText(Environment.NewLine);
                    Tekst.AppendText("C = Clear");
                    Tekst.AppendText(Environment.NewLine);
                    Tekst.AppendText("L = Load textfile.txt");
                    Tekst.AppendText(Environment.NewLine);
                    textBoxCommando.Text = "";
                    break;
                default:
                    break;
            }


        }

        private void LoadFile(string file)
        {

        }

        private void MainForm_Shown(object sender, System.EventArgs e)
        {
            Tekst.Focus();
        }

        private void TextBoxCommando_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
