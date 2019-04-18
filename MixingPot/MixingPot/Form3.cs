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
	// The dialogue box that allows the user to enter a roster manually
	public partial class Form3 : Form
	{
		// Saves the main window form in order to close it once the user has properly uploaded a file
		private Form1 f1;

		// Stores the textboxes to be read into the student_names arraylist at end
		private ArrayList textboxes = new ArrayList();

		// Counter for the dynamic textboxes
		private int counter = 1;

		// Stores the text from the textboxes
		private ArrayList student_names = new ArrayList();

		public Form3(Form1 f1)
		{
			InitializeComponent();
			this.f1 = f1;
			store_textboxes();
			// Set the form to the top middle of the user's screen and maximum height at the screen height
			Rectangle screen = Screen.PrimaryScreen.WorkingArea;
			Location = new Point((screen.Width / 2) - 408, 30);
			MaximumSize = new Size(816, (screen.Height - 30));
			// Don't let the user tab to the instruction box
			richTextBox1.TabStop = false;
			// Start user cursor in the first text box
			ActiveControl = textBox1;
		}

		// Stores the 9 hardcoded textboxes in an arraylist to be accessed when the user clicks the finish button
		private void store_textboxes()
		{
			textboxes.Add(textBox1);
			textboxes.Add(textBox2);
			textboxes.Add(textBox3);
			textboxes.Add(textBox4);
			textboxes.Add(textBox5);
			textboxes.Add(textBox6);
			textboxes.Add(textBox7);
			textboxes.Add(textBox8);
			textboxes.Add(textBox9);
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

		// Clears all the text from each textbox on screen
        private void button2_Click(object sender, EventArgs e)
        {
			foreach (TextBox t in textboxes)
			{
				t.Clear();
			}
		}

		// Stores the names from the textboxes in the list variable to pass to the next form if they are not blank
		private void save_entries()
		{
			foreach (TextBox t in textboxes)
			{
				if (t.Text != "") { student_names.Add(t.Text); }
			}
		}
        private void button1_Click(object sender, EventArgs e)
        {
			// Make sure user entry is saved
			save_entries();
			// Hide the current window and begin to close the main window, open the next window
			Hide();
			// Hide the main window in order to transition to the new window
			f1.Hide();
			// Open the next window (selecting group constraints) and send the entered names
			Form4 f4 = new Form4(student_names);
			f4.ShowDialog();
			// Close the file selection window and the main window
			Close();
			f1.Close();

        }

		private void button3_Click(object sender, EventArgs e)
		{
			// Create a new textbox on click
			TextBox newtxt = new TextBox();
			// Append the count to the end of the name
			newtxt.Name = "newbutton" + counter;
			// Expand the form to show the new textbox
			Height = Height + 50;
			// Make the location dynamic so that it adds to the end of the list of textboxes, then increment counter
			newtxt.Location = new System.Drawing.Point(312, 424 + 50 * counter++);
			newtxt.Size = new System.Drawing.Size(241, 20);
			Controls.Add(newtxt);
			// Push the textbox into the arraylist "textboxes" for the Save_Entries function
			textboxes.Add(newtxt);
		}
	}
}
