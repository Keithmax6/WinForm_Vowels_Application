using System.Text.RegularExpressions;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxCapitalizedString.Enabled = false;
            textBoxVowels.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInputed = textBoxUserInput.Text;
            string lowerCase = userInputed.ToLower();
            string s = lowerCase;
            s = Regex.Replace(s, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
            textBoxCapitalizedString.Text = s;
            int i, len, vowel_count;
            vowel_count = 0;
            len = s.Length;
            for (i = 0; i < len; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    vowel_count++;
                }
            }
            textBoxVowels.Text = vowel_count.ToString();
        }

    }
}