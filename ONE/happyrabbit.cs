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
	public partial class happyrabbit : Form
	{
		public happyrabbit()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void button1_MouseEnter(object sender, EventArgs e)
		{

			Random a = new Random();
			Random b = new Random();


			int x;
			x = a.Next(0, this.Width - 201);

			int y = a.Next(0, this.Height - 131);
			this.button1.Location = new System.Drawing.Point(x, y);
		}
	}
}
