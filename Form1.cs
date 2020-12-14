using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeVertaler
{
    public partial class Form1 : Form
    {
        private static Dictionary<char, string> VertalerNL;

        public Form1()
        {
            InitializeComponent();
            //Dictionary data
            VertalerNL = new Dictionary<char, string>()
            { {'a', ".-"}, {'b', "-..."}, {'c', "-.-."}, {'d', "-.."}, {'e', "."}, {'f', "..-."}, {'g', "--."},
            {'h', "...."}, {'i', ".."}, {'j', ".---"}, {'k', "-.-"}, {'l', ".-.."}, {'m', "--"}, {'n', "-."},
            {'o', "---"}, {'p', ".--."}, {'q', "--.-"}, {'r', ".-."}, {'s', "..."}, {'t', "-"}, {'u', "..-"},
            {'v', "...-"}, {'w', ".--"}, {'x', "-..-"}, {'y', "-.--"}, {'z', "--.."}, {'0', "-----"},
            {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."},
            {'7', "--..."}, {'8', "---.."}, {'9', "----."} };

        }

        private void buttonVertalen_Click(object sender, EventArgs e)
        {
            //Nederlands naar morse code
            if (textBoxNL.Text != null)
            {
                //textbox informatie pakken, kleine letters van maken en verwerken naar array
                string TextNLString = textBoxNL.Text.ToLower();
                char[] TextNL = TextNLString.ToArray();

                //individuele characters bekijken en vertalen
                StringBuilder BobdebouwerNL = new StringBuilder();
                foreach (char Character in TextNL)
                {
                    if (VertalerNL.ContainsKey(Character))
                    {
                        BobdebouwerNL.Append(VertalerNL[Character] + " ");
                    }
                    else if (Character == ' ')
                    {
                        BobdebouwerNL.Append("/ ");
                    }
                    else
                    {
                        BobdebouwerNL.Append(" ");
                    }
                }
                textBoxMC.Text += BobdebouwerNL.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMC.Text = "";
            textBoxNL.Text = "";
        }
    }
}
