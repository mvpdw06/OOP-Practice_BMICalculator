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
            Human human = new Human();
            human.Height = Convert.ToDouble(this.textBox1.Text);
            human.Weight = Convert.ToDouble(this.textBox2.Text);

            var BMI = human.BMI;
            MessageBox.Show("BMI：" + BMI + "，結果為：" + human.Comment);
        }
    }
}
