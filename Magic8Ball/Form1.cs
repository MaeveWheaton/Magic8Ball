using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        //random generator
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answerNumber = randGen.Next(1, 7);

            switch (answerNumber)
            {
                case 1:
                    answerOutput.Text = "Yes - definitely";
                    break;
                case 2:
                    answerOutput.Text = "Most likely";
                    break;
                case 3:
                    answerOutput.Text = "It's a possibility";
                    break;
                case 4:
                    answerOutput.Text = "Ask again later";
                    break;
                case 5:
                    answerOutput.Text = "Outlook not so good";
                    break;
                case 6:
                    answerOutput.Text = "Don't count on it";
                    break;
            }
        }
    }
}
