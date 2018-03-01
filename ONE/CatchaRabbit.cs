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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random a = new Random();
			Random b = new Random();

			
			int x;
			x = a.Next(0,this.Width-201);
			
			int y = a.Next(0,this.Height-131);
			this.button1.Location = new System.Drawing.Point(x, y);
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
