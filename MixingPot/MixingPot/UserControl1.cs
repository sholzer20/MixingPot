using System;
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

		// Returns the location from the usercontrol to form5
		public String GetLocation()
		{
			if (comboBox1.Items.Count != 0)
			{
				return comboBox1.Text;
			}
			else
			{
				return "";
			}
		}

		// Returns the string of group sizes from the usercontrol to the 
		public String GetGroups()
		{
				return textBox1.Text;
		}

		// Returns true if the user selected all male groups for a particular entry
		public bool GetMale()
		{
			// The first check box indicates all male group(s)
			return checkedListBox1.GetItemChecked(0);
		}

		// Returns true if the user selected all female groups for a particular entry
		public bool GetFemale()
		{
			// The second check box indicates all female group(s)
			return checkedListBox1.GetItemChecked(1);
		}
	}
}
