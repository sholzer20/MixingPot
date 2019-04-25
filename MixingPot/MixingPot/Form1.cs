using System;
using System.Windows.Forms;

namespace MixingPot
{
	// The main page of the application which allows the user to upload or enter a class roster or continue a project
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Start the main page in fullscreen
		private void Form1_Load(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized;
		}

		// Upload a Class Roster button. Opens the appropriate form to allow file selection
		private void button1_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2(this);
			f2.ShowDialog();
		}

		// Enter a Roster Manually button. Will open an appropriate form to allow the user to enter student information
		private void button2_Click(object sender, EventArgs e)
		{
			Form3 f3 = new Form3(this);
			f3.ShowDialog();
		}

		// Will interact with the database to import an existing project to the application
		private void button3_Click(object sender, EventArgs e)
		{

		}

		// Non-interactive
		private void label1_Click(object sender, EventArgs e)
		{
		}
		// Non-interactive
		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
