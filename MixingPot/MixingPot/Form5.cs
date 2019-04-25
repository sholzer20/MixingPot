using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MixingPot
{
	public partial class Form5 : Form
	{
		// Stores the names of each student as an index in the ArrayList
		private List<String> student_names = new List<String>();

		// Keeps track of all the UserControl1 objects that store location information from user
		private List<UserControl1> Locations = new List<UserControl1>();

		// This array tracks students in each group
		private List<Group> group_objects = new List<Group>();

		public Form5(List<String> names, List<UserControl1> locations)
		{
			InitializeComponent();

			// Assign the ArrayLists to manage students and the user's group contraints
			student_names = names;
			Locations = locations;

			CreateGroups();
		}

		private void CreateGroups()
		{
			foreach (UserControl1 l in Locations)
			{
				// Parse how many groups the user entered for one location and constraint values
				String group_entry = l.GetGroups();
				String[] groups = group_entry.Split(',');

				// Make a group object for each of those groups
				foreach (var size in groups)
				{
					// Convert the group entry to an int
					Int32.TryParse(size, out int x);

					// Make the group object and add it to the list
					if (x != 0)
					{
						group_objects.Add(new Group(l.GetLocation(), x, l.GetMale(), l.GetFemale()));
					}
				}
			}
		}
	}

	// A class to keep track of each group within the user entry
	public partial class Group
	{
		// True if the group should be all male
		private bool male;

		// True if the group should be all female
		private bool female;

		// How many students should be in this group
		private int group_size;

		// What location is this group for? Should have all students at a location in multiple groups
		private String location;

		public Group(String location, int group_size, bool male, bool female)
		{
			// Initialize the group object
			this.male = male;
			this.female = female;
			this.group_size = group_size;
			this.location = location;
		}
	}
}
