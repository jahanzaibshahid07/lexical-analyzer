using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;    
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compile
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int rowb=0, rowl = 0, rowd = 0, rowi=0, rowo=0 ;
            int i = 0, k = 0, l = 0, x = 0,bbb=0,brac=0,cbrac=0;
            char[] whitespace = new char[] { ' ', '\t','\n',' ' };
            string code3=null;
            code3=textBox1.Text;
            string lexed = code3.Replace(";", " ; ").Replace("{", "{ ").Replace("}", "}").Replace("(", " ( ").Replace(")", ") ").Replace("=", " = ").Replace("+", " + ").Replace(">", " > ").
               Replace("-", " - ").Replace("*", " * ").Replace("/", " / ").Replace("<=", " <= ").Replace(">=", " >= ").Replace("==", " == ").Replace("!=", " != ").
               Replace("<", " < ").Replace("&&", " && ").Replace("||", " || ").Replace(","," , ");
            string[] word = lexed.Split(whitespace);
            this.dataGridView1.Rows.Add(100);
            foreach (string words in word)
            {
                if (words == "int" || words == "float" || words == "double" || words == "char" || words == "string")
                {
                    dataGridView1.Rows[rowd].Cells[1].Value = words;
                    richTextBox2.Text += "  datatype"+k;
                    richTextBox1.Text += "\r\n" + words + "\t\t datatype" + k + " \t\t null";
                    k++;
                    rowd++;
                }
                else if(words=="void")
                {
                    dataGridView1.Rows[rowd].Cells[1].Value = words;
                    richTextBox2.Text += "  "+"constant";
                    richTextBox1.Text += "\r\n"+words+"\t Constant"+"\t NULL";
                    rowd++;
                }
                else if (words == "main")
                {
                    dataGridView1.Rows[rowd].Cells[1].Value = words;
                    richTextBox2.Text += "  "+"constant"+x;
                    richTextBox1.Text += "\r\n" + words + "\t" + x + "\t null";
                    x++;
                    rowd++;
                }
                else if (words == "<=" || words == ">=" || words == "==" || words == "!=" || words == ">" || words == "<" || words == "!=" || words == "&&" || words == "||" || words == "=")
                {
                    dataGridView1.Rows[rowo].Cells[3].Value = words;
                    richTextBox2.Text += "  relop"+i;
                    richTextBox1.Text += "\r\n" + words + "\t relop"+i+" \t null";
                    i++;
                    rowo++;
                }
                else if (words == "{" || words == "}" || words == "(" || words == ")" || words == "[" || words == "]")
                {
                    if (words == "{" || words == "(" || words == "[")
                    {
                        richTextBox2.Text += "  " + "opbracket"+brac;
                        brac++;
                    }
                    else if(words=="}"||words=="]"||words==")")
                    {
                        richTextBox2.Text += "  "+"clbracket"+cbrac;
                        cbrac++;
                    }
                    dataGridView1.Rows[rowb].Cells[4].Value = words;
                    richTextBox1.Text += "\r\n" + words + "\t bracket"+brac+" \t paranthesis";
                    rowb++;
                }

                else if (words == ";")
                {
                    dataGridView1.Rows[rowo].Cells[3].Value = words;
                    richTextBox2.Text +="  "+"terminator";
                    richTextBox1.Text += "\r\n" + "; \t terminator \t ;";
                    rowo++;
                }
                else if (words == "," || words == "^" || words == ".")
                {
                    dataGridView1.Rows[rowo].Cells[3].Value = words;
                    richTextBox2.Text += "  " + "operator";
                    richTextBox1.Text += "\r\n" + words + "\t gap operator \t , . ^";
                    rowo++;
                }
                else if (words == " " || words == "\n" || words == "\t" || words == "  " || words == "   " || words == "\r\n" || words == "\n\r")
                {
                    richTextBox2.Text += "  " + "whitespace" + l;
                    richTextBox1.Text += "\r\n" + "whitespace \t" + "whitespace" + l + "\t NULL";
                    l++;
                }
                
                else if (words == "+" || words == "-" || words == "*" || words == "/")
                {
                    dataGridView1.Rows[rowo].Cells[3].Value = words;
                    richTextBox2.Text += "  " + "arthematicoperator";
                    richTextBox1.Text += "\r\n" + words + "\t operator \t +,-,*,/";
                    rowo++;
                }
                else if (words == "for" || words == "while" || words == "do")
                {
                    dataGridView1.Rows[rowd].Cells[1].Value = words;
                    richTextBox2.Text += "  loop";
                    richTextBox1.Text += "\r\n" + words + "\t loop \t for,while,do";
                    rowd++;
                }
                else if (words == "if" || words == "else" || words == "switch")
                {
                    dataGridView1.Rows[rowd].Cells[1].Value = words;
                    richTextBox2.Text += "  " + "conditions";
                    richTextBox1.Text += "\r\n" + words + "\t condition \t if,else,switch";
                    rowd++;
                }
                else if (words == "#include")
                {
                    dataGridView1.Rows[rowl].Cells[0].Value = words;
                    richTextBox2.Text += "  " + "#include";
                    richTextBox1.Text +="\r\n" + words + "\t keyword \t Preprocessor";
                    rowl++;
                }
                else if(words=="conio.h"||words=="stdio.h"||words=="iostream.h")
                {
                    dataGridView1.Rows[rowl].Cells[1].Value = words;
                    richTextBox2.Text += "  " + "library";
                    richTextBox1.Text += "\r\n" + words + "\t library" + " \t header files";
                    rowl++;
                }
                else if(words=="cin"||words=="cout"||words=="clrscr"||words=="getch"||words=="return")
                {
                    dataGridView1.Rows[rowd].Cells[1].Value = words;
                    richTextBox2.Text += "  " + "functions";
                    richTextBox1.Text +="\r\n" + words + "\t keywords "+bbb+"\t functions";
                    bbb++;
                    rowd++;
                }
                else
                {
                    dataGridView1.Rows[rowi].Cells[2].Value =words;
                    richTextBox2.Text += "  " + words;
                    richTextBox1.Text += "\r\n" + words + "\t identifier "+ words + "\t L(L+d)*";
                    rowi++;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("************Group Members***************\n\r\tBurhannudin 2015-CS-101\n\r\tHussain 2015-CS-078\n\r\tUmair 2015-CS-077\n\r\tMuzamil 2015-CS-105\n\r\tAfshan 2015-CS-087\n\r\t");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit(); 
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            dataGridView1.Rows.Clear();
        }
        public string syn = "";
        public void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            syn = richTextBox2.Text;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 d = new Form4();
            d.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // syn=richTextBox2.Text;
            Form3 f3 = new Form3();
            f3.richTextBox1.Text = textBox1.Text;
            f3.Show();
            this.Hide();
            //this.Hide();
        
        }

      
    }
}

