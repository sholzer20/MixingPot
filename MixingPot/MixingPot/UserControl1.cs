using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixingPot
{
	public partial class UserControl1 : UserControl
	{
		public UserControl1()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		// Returns the location number as an int from the usercontrol to form5
		public int GetLocation()
		{
			if (comboBox1.Items.Count != 0)
			{
				String t = comboBox1.Text;
				switch (t)
				{
					case "1":
						return 1;
					case "2":
						return 2;
					case "3":
						return 3;
					case "4":
						return 4;
					case "5":
						return 5;
					case "6":
						return 6;
					case "7":
						return 7;
					case "8":
						return 8;
					case "9":
						return 9;
					case "10":
						return 10;
					default:
						return 0;
				}
			}
			else
			{
				return 0;
			}
		}

		// Returns the string of group sizes from the usercontrol to the 
		public String GetGroups()
		{
				return textBox1.Text;
		}

		// Returns the grouping options from the checked list box
		public String GetConstraints()
		{
			if (checkedListBox1.Items.Count != 0)
			{
			}
			return "";
		}
	}
}
