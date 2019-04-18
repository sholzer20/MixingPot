using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixingPot
{
	public partial class Form5 : Form
	{
		// Stores the names of each student as an index in the ArrayList
		private ArrayList student_names;

		// Keeps track of all the UserControl1 objects that store location information from user
		private ArrayList Locations = new ArrayList();

		// This array tracks students in each group
		String[,] groups = new string[10, 10];

		public Form5(ArrayList names, ArrayList locations)
		{
			InitializeComponent();

			// Assign the ArrayLists to manage students and the user's group contraints
			student_names = names;
			Locations = locations;
		}

		private void Display_Groups()
		{
			foreach (UserControl1 l in Locations)
			{
				
			}
		}
	}
}
