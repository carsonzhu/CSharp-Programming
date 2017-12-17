using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 这是使用托管C++对C函数和C++类建立的包装，本质上是一个托管类的对象
        /// </summary>
        clrClass ClrClass = new clrClass();
        /// <summary>

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            //通过托管C++调用C函数int Add(int a,int b)实现的加法
            textBox3.Text = ClrClass.menberFuncAdd(a, b).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            //通过托管C++调用C++的CClassNative类函数实现的减法
            textBox3.Text = ClrClass.menderFuncSub(a, b).ToString();
        }
    }
}
