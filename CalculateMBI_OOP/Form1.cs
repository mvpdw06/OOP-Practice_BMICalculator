using System;
using System.Windows.Forms;

namespace CalculateMBI_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Human human = new Human()
            {
                Gender = radioButton1.Checked ? Gender.Male : Gender.FeMale,
                Height = Convert.ToDouble(this.textBox1.Text),
                Weight = Convert.ToDouble(this.textBox2.Text)
            };

            var humanBMI = BMI.GetHumanBMI(human);
            var comment = ResultFactory.GetComment(human.Gender, humanBMI);

            MessageBox.Show("BMI：" + humanBMI + "，結果為：" + comment);
        }
    }
}
