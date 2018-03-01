using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONE
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("MY First Message");
			Form2 f = new Form2();
			f.Show();
		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Button1 has been clicked.");
			MessageBox.Show("Heigh is="+button1.Height.ToString());
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
