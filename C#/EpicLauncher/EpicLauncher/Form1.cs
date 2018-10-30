using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicLauncher
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AccountList.Items.Add(new ListViewItem("ABC"));
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_ControlAdded(object sender, ControlEventArgs e)
		{

		}

		private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{

		}
	}
}
