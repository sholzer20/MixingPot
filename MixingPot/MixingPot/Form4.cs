﻿using System;
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
		// Stores the names of each student as an index in the ArrayList
		private ArrayList student_names;    

		// Keeps track of all the UserControl1 objects that store location information from user
		private ArrayList Locations = new ArrayList();

		// Used to append a new UserControl1 object to the end of the arraylist
		private int counter = 2;

		// If this window was generated from the manual entry, need to accept list of students
		public Form4(ArrayList names)
		{
			InitializeComponent();

			// Keep track of the student names
			student_names = names;

			// Store the first Locations control in the arraylist
			Locations.Add(userControl11);
		}

		private void userControl11_Load(object sender, EventArgs e)
		{

		}

		// Start the window in fullscreen
		private void Form4_Load(object sender, EventArgs e)
		{
			//WindowState = FormWindowState.Maximized;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Move the button down to make space for the new UserControl1 object
			button3.Location = new System.Drawing.Point(1196, 308 + 127 * (counter-1));
			// Create a new UserControl1 object on click
			UserControl1 newlocation = new UserControl1();
			// Append the count to the end of the name
			newlocation.Name = "userControl1" + counter;
			// Expand the form to show the new textbox
			//Height = Height + 50;
			// Make the location dynamic so that it adds to the end of the list of UserControl1, then increment counter
			newlocation.Anchor = AnchorStyles.None;
			newlocation.Location = new System.Drawing.Point(97, 175 + 127 * (counter-1));
			counter++;
			Controls.Add(newlocation);
			// Push the textbox into the arraylist "textboxes" for the Save_Entries function
			Locations.Add(newlocation);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Hide the current window and begin to close the main window, open the next window
			Hide();
			// Open the next window (Outputting Groups) and send the entered names and Location information
			Form5 f5 = new Form5(student_names, Locations);
			f5.ShowDialog();
			// Close the Form4 window
			Close();
		}

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
