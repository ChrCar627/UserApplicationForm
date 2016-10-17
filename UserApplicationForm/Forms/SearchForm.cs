using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserApplicationForm
{
	public partial class SearchForm : Form
	{

		public SearchForm()
		{
			InitializeComponent();
		}
		
		private void buttonview_Click(object sender, EventArgs e)
		{
			if (resultsbox.SelectedIndex >= 0 && resultsbox.SelectedIndex < Search.CurrentResults.Count) {
				User user = Search.CurrentResults[resultsbox.SelectedIndex];
				using (UserInfoForm newform = new UserInfoForm(user,this)) {
					newform.SetInfo(user.FirstName, user.LastName, user.Street, user.City, user.State, user.Zip, user.DateofBirth, user.Username, user.Password);
					newform.WindowType = UserInfoForm.Types.View;
					newform.ShowDialog();
				}
			}
		}

		private void buttonremove_Click(object sender, EventArgs e) {
			if ( resultsbox.SelectedIndex >= 0 && resultsbox.SelectedIndex < Search.CurrentResults.Count ) {
				int pos = resultsbox.SelectedIndex;
				User selected = Search.CurrentResults[resultsbox.SelectedIndex];
				int selectedindex = UserList.users.IndexOf(selected);
				UserList.users.RemoveAt(selectedindex);
				resultsbox.DataSource = null;
				Search.Update();
				resultsbox.SelectedIndex = pos==resultsbox.Items.Count?pos-1:pos;
				Program.ChangeWasMade = true;
			}
		}

		private void searchbutton_Click(object sender, EventArgs e) {
			Search.Update();
		}

		private void searchfirstname_TextChanged(object sender, EventArgs e) {
			Search.Update();
		}

		private void searchlastname_TextChanged(object sender, EventArgs e) {
			Search.Update();

		}
		
		private void resultsbox_MouseDoubleClick(object sender, MouseEventArgs e) {
			buttonview_Click(sender, e);
		}

		private void buttonadd_Click(object sender, EventArgs e) {
			using (UserInfoForm newform = new UserInfoForm(this)) {
				newform.WindowType = UserInfoForm.Types.Add;
				newform.ShowDialog();
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
			SaveFileDialog filedialog = FileHandler.SaveFile();
			if (filedialog != null) {
				FileHandler.SaveUsersToCSV(filedialog.FileName);
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog filedialog = FileHandler.LoadFile();
			if (filedialog != null) {
				FileHandler.LoadUsersFromCSV(filedialog.FileName);
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			if(Program.CurrentFilePath != null) {
				if(FileHandler.SaveUsersToCSV(Program.CurrentFilePath) == true)
					MessageBox.Show("File Saved.","Success");
			}
			else {
				saveAsToolStripMenuItem_Click(sender, e);
			}
		}

		private void buttonload_Click(object sender, EventArgs e) {
			openToolStripMenuItem_Click(sender, e);
		}

		private void buttonsave_Click(object sender, EventArgs e) {
			saveToolStripMenuItem_Click(sender, e);
		}

		private void resultsbox_Format(object sender, ListControlConvertEventArgs e) {
			string fullname = ((User)e.ListItem).LastName + ", " + ((User)e.ListItem).FirstName;
			e.Value = fullname;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void SearchForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (Program.ChangeWasMade) {
				if (Program.CurrentFileName != null) {
					DialogResult dialogresult = MessageBox.Show("Do you want to save changes to " + Program.CurrentFileName + "?", this.Text, MessageBoxButtons.YesNoCancel);
					if (dialogresult == DialogResult.Yes) {
						FileHandler.SaveUsersToCSV(Program.CurrentFilePath);
						e.Cancel = false;
					}
					else if (dialogresult == DialogResult.Cancel)
						e.Cancel = true;
					return;
				}
			}
			e.Cancel = false;
		}

		private void resultsbox_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Delete) {
				buttonremove_Click(sender, e);
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
			if (Program.ChangeWasMade) {
				if (Program.CurrentFileName != null) {
					DialogResult dialogresult = MessageBox.Show("Do you want to save changes to " + Program.CurrentFileName + "?", this.Text, MessageBoxButtons.YesNoCancel);
					if (dialogresult == DialogResult.Yes) {
						FileHandler.SaveUsersToCSV(Program.CurrentFilePath);
					}
					else if (dialogresult == DialogResult.Cancel)
						return;
				}
			}
			UserList.users.Clear();
			Program.ChangeWasMade = false;
			FileHandler.ResetCurrentFile();
			Search.Update();
		}
	}
}
