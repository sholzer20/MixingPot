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
	public partial class Form4 : Form
	{
		private ArrayList student_names;	// Stores the names of each student as an index in the ArrayList

		// If this window was generated from the manual entry, need to accept list of students
		public Form4(ArrayList names)
		{
			InitializeComponent();
			student_names = names;
		}

		// Start the window in fullscreen
		private void Form4_Load(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized;
		}

	}
}
