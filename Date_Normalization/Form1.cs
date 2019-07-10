using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace Date_Normalization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string line = null;
                System.IO.TextReader readFile = new StreamReader("D:\\NLP.txt");
                line = readFile.ReadToEnd();
              
                rt2.Text += line;
                readFile.Close();
                readFile = null;

                string str = rt2.Text;

       
                 //MatchCollection mc = Regex.Matches(str, @"\d{4}[- /.]([1-9]|0[1-9]|1[012])[- /.]([1-9]|0[1-9]|[12][0-9]|3[01])");
               //YY MM DD
                //MatchCollection mc = Regex.Matches(str, @"\d{4}(?:[- / .]\d{1,2}){2}");
                MatchCollection mc = Regex.Matches(str, @"\d{4}[- /.]([1-9]|0[1-9]|1[012])[- /.]([1-9]|0[1-9]|[12][0-9]|3[01])");

                foreach (Match m in mc)
                {
                
                    rt.Text += m + "\n";
                }
                MatchCollection mc2 = Regex.Matches(str, @"\d{4}[- /.](JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC| jan|feb|mar|apr|may|jun|jul|aug|sep|oct|nov|dec)[- /.]([1-9]|0[1-9]|[12][0-9]|3[01])");
                foreach (Match m in mc2)
                {
                 
                    rt.Text += m + "\n";
                }
                //YY DD MM
                MatchCollection mc3 = Regex.Matches(str, @"\d{4}[- /.](0[1-9]|[12][0-9]|3[01])[- /.]([1-9]|0[1-9]|1[2])");

                foreach (Match m in mc3)
                {
                    
                    rt3.Text += m + "\n";
                }
                MatchCollection mc4 = Regex.Matches(str, @"\d{4}[- /.](0[1-9]|[12][0-9]|3[01])[- /.](JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC| jan|feb|mar|apr|may|jun|jul|aug|sep|oct|nov|dec)");

                foreach (Match m in mc4)
                {
                
                    rt3.Text += m + "\n";
                }
                //DD MM YY
                MatchCollection mc5 = Regex.Matches(str, @"\d{1,2}(?:[- / .])(JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC| jan|feb|mar|apr|may|jun|jul|aug|sep|oct|nov|dec)(?:[- / .])\d{1,4}");
                foreach (Match m in mc5)
                {
                   
                    rt6.Text += m + "\n";
                }
                //DD YY MM
                MatchCollection mc6 = Regex.Matches(str, @"\d{1,2}(?:[- / .])\d{1,4}(?:[- / .])(JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC| jan|feb|mar|apr|may|jun|jul|aug|sep|oct|nov|dec)");
                foreach (Match m in mc6)
                {
                   
                    rt7.Text += m + "\n";
                }
                //MatchCollection mc = Regex.Matches(str, @"\([1-9]|[]|[])");
                //{([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])[- / .]([1-9]|0[1-9]|1[0-2])[- / .](1[9][0-9][0-9]|2[0][0-9][0-9])}
//                MatchCollection mc = Regex.Matches(str, @"\d((([0-9][0-9][0-9][1-9])|([1-9][0-9][0-9][0-9])|([0-9][1-9][0-9][0-9])|([0-9][0-9][1-9][0-9]))[- / .]((0[13578])|(1[02]))[- / .]((0[1-9])|([12][0-9])|(3[01])))|((([0-9][0-9][0-9][1-9])|([1-9][0-9][0-9][0-9])|([0-9][1-9][0-9][0-9])|([0-9][0-9][1-9][0-9]))[- / .]((0[469])|11)[- / .]((0[1-9])|([12][0-9])|(30)))|(((000[48])|([0-9]0-9)|([0-9][1-9][02468][048])|([1-9][0-9][02468][048]))-02-((0[1-9])|([12][0-9])))|((([0-9][0-9][0-9][1-9])|([1-9][0-9][0-9][0-9])|([0-9][1-9][0-9][0-9])|([0-9][0-9][1-9][0-9]))-02-((0[1-9])|([1][0-9])|([2][0-8]))|{4}(?:/\d{1,2}){2})
//
//");
                
 
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void a_TextChanged(object sender, EventArgs e)
        {

        }

        private void rt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
    }
}
