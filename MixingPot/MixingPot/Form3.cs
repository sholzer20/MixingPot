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

		private ArrayList student_names = new ArrayList();

		public Form3(Form1 f1)
		{
			InitializeComponent();
			this.f1 = f1;
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

		// Stores the strings from the textboxes in the list variable to pass to the next form
		private void Save_Entries()
		{
			if (textBox1.Text != "")
			{
				student_names.Add(textBox1.Text);
			}

			if (textBox2.Text != "")
			{
				student_names.Add(textBox2.Text);
			}

			if (textBox3.Text != "")
			{
				student_names.Add(textBox3.Text);
			}

			if (textBox4.Text != "")
			{
				student_names.Add(textBox4.Text);
			}

			if (textBox5.Text != "")
			{
				student_names.Add(textBox5.Text);
			}

			if (textBox6.Text != "")
			{
				student_names.Add(textBox6.Text);
			}

			if (textBox7.Text != "")
			{
				student_names.Add(textBox7.Text);
			}

			if (textBox8.Text != "")
			{
				student_names.Add(textBox8.Text);
			}

			if (textBox9.Text != "")
			{
				student_names.Add(textBox9.Text);
			}
		}
        private void button1_Click(object sender, EventArgs e)
        {
			// Make sure user entry is saved
			Save_Entries();
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
    }
}
