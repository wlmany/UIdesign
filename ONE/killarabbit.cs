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
	public partial class killarabbit : Form
	{
		public killarabbit()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

	
        private void button1_MouseDown(object sender, MouseEventArgs e)
		{
			sadrabbit s = new sadrabbit();
			s.Show();
		}
	}
}
