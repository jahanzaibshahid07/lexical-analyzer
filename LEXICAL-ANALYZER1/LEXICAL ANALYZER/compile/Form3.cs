using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
namespace compile
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string _for = @"^for{1}\(((int\s)|(float\s)|(char\s))?\w+=(\d|\w)+;\w+(=|<=|>=|<|>)(\d|\w)+;\w+(\+\+|--)?\)$";
            string _while = @"^while{1}\(\w+(=|<=|>=|>|<|!=|==)(\d|\w)+\)$";
            string _print = @"^(cout\<\<){1}((\w*\s*\d*)*);$";
            string _input = @"^(\w)+=(cin\>\>){1}\((\w*\s*\d*)*\);$";
            string _dowhile = @"^do{1}\{(cout\<\<){1}\([0-9a-zA-Z]*\);\}$";
            string _if = @"^if{1}\s?\(\w+(=|<=|>=|>|<|!=|==)(\d|\w)+\)\{(cout\<\<){1}((\w*\s*\d*)*));}$";
            string _elif = @"^else{1}\s{1}if{1}\(\w+(=|<=|>=|>|<|!=|==)(\d|\w)+\)\{(cout\<\<){1}((\w*\s*\d*)*));}$";
            string _else = @"^else\s{1}(cin\>\>){1}((\w*\s*\d*)*);$";
            string _main = @"^void\s{1}(main)*\s\(\)$";
            string _sw = @"^switch\(\w+\){$";
            string _case = @"^case\s(\d)+:+$";
            string _break = @"^break{1};$";
            string _continue = @"^continue{1};$";
            string _decl = @"^(int\s|float\s|char\s){1}(\w+,*)+;$";
            string _dasign = @"^(int\s|float\s|char\s)\w+=(\d|\w)+;$";
            string _asig = @"^(\w+)=(\d|\w)+;$";
            string _deflt = @"^}\s*default:\s*(cout\<\<){1}((\w*\s*\d*)*));$";
            string _header = @"(^\s*\#\s*include\s*<([^<>]+)>)";
            
            string line = richTextBox1.Text;
            string[] w = line.Split('\n');
            foreach (string user in w)
            {
                if (Regex.IsMatch(user, _for))
                {
                    correcttext.Text += user + "\n";
                }
                else if (Regex.IsMatch(user, _header))
                {
                    correcttext.Text += user + "\n";
                }
                else if (Regex.IsMatch(user, _while))
                {
                    correcttext.Text += user + "\n";
                }
                else if (Regex.IsMatch(user, _print))
                {
                    correcttext.Text += user + "\n";
                }
                else if (Regex.IsMatch(user, _input))
                {
                    correcttext.Text += user + "\n";
                }
                else if (Regex.IsMatch(user, _dowhile))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("do while Matched\n{0}", user);
                }
               else if (Regex.IsMatch(user, _if))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("if Matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _elif))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("else if Matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _else))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("else matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _main))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("main matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _sw))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("switched matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _case))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("case matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _break))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("break matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _continue))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("continue matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _decl))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("declaration matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _dasign))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("declare assignment Matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _asig))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("Assignment matched\n{0}", user);
                }
                else if (Regex.IsMatch(user, _deflt))
                {
                    correcttext.Text += user + "\n";
                    //Console.WriteLine("Default matched\n{0}", user);
                }
                else
                {
                    errortext.Text += user + "\n";
                    //Console.WriteLine("wrong\n{0}", user);
                }
            }
        }
        
        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            errortext.Text = "";
            correcttext.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 c = new Form4();
            c.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
