using System;
using System.Collections;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;


namespace MixingPot
{
	// The dialogue box that allows the user to select a file to upload for the class roster
	public partial class Form2 : Form
	{
		// Saves the main window form in order to close it once the user has properly uploaded a file
		private Form1 f1;

		public Form2(Form1 f1)
		{
			InitializeComponent();
			this.f1 = f1;
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
		{

		}

		// Will open a file dialogue to allow user to select a file. Closes the form and goes onto group constraints next.
		private void button1_Click(object sender, EventArgs e)
		{
			// Make an open file dialogue that only accepts .csv files
			OpenFileDialog ofd = new OpenFileDialog
			{
				Filter = "CSV File|*.csv",
				Title = "Upload a Student Roster"
			};

			// If the user enters a proper file, the form will change to the group constraints input form
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				// Stores the student names to pass to the next window
				ArrayList student_names = new ArrayList();

				// Read from the file using VB.NET parser
				using (TextFieldParser parser = new TextFieldParser(ofd.FileName))
				{
					// Set parser constraints
					parser.SetDelimiters(new string[] { "," });
					parser.HasFieldsEnclosedInQuotes = false;

					// Read line by line and get each token as a string
					while (!parser.EndOfData)
					{
						string[] fields = parser.ReadFields();
						// A line has been parsed into strings (each students' name), now add each to an ArrayList
						for(int i = 0; i < fields.Length; i++)
						{
							student_names.Add(fields[i]);
						}
					}
				}

				// Hide the current window and begin to close the main window, open the next window
				Hide();
				// Hide the main window in order to transition to the new window
				f1.Hide();
				// Open the next window (selecting group constraints)
				Form4 f4 = new Form4(student_names);
				f4.ShowDialog();
				// Close the file selection window and the main window
				Close();
				f1.Close();
			}
		}
	}
}
