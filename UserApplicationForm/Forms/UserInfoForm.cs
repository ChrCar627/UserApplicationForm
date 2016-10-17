using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundexAlgorithm;

namespace UserApplicationForm {
	public partial class UserInfoForm : Form {
		
		public enum Types {Add,Edit,View}
		private User _UserSelected { get; set; }
		private SearchForm Search;

		public Types WindowType { set { ChangeWindowType(value); } }

		public UserInfoForm(User u,SearchForm s) {
			Search = s;
			_UserSelected = u;
			InitializeComponent();
		}
		public UserInfoForm(SearchForm s) {
			Search = s;
			InitializeComponent();
		}

		public void SetInfo(string firstname, string lastname, string street, string city, string state, string zip, string dob, string username, string password) {
			textboxfirst.Text = firstname;
			textboxlast.Text = lastname;
			textboxstreetname.Text = street;
			textboxcity.Text = city;
			textboxstate.Text = state;
			textboxzip.Text = zip;
			dobpicker.Text = dob;
			textboxusername.Text = username;
			textboxpassword.Text = password;
		}

		public void DisableControls() { Forms.DisableControls(this.Controls); }

		public void EnableControls() { Forms.EnableControls(this.Controls); }

		private void buttonsubmit_Click(object sender, EventArgs e) {
			switch (buttonsubmit.Text) {
				case "Close":
					Close();
					break;
				case "Cancel":
					textboxfirst.Text = _UserSelected.FirstName;
					textboxlast.Text = _UserSelected.LastName;
					textboxstreetname.Text = _UserSelected.Street;
					textboxcity.Text = _UserSelected.City;
					textboxstate.Text = _UserSelected.State;
					textboxzip.Text = _UserSelected.Zip;
					dobpicker.Text = _UserSelected.DateofBirth;
					textboxusername.Text = _UserSelected.Username;
					textboxpassword.Text = _UserSelected.Password;
					ChangeWindowType(Types.View);
					break;
				case "Submit":
					User newuser = new User();
					newuser.FirstName = textboxfirst.Text;
					newuser.LastName = textboxlast.Text;
					newuser.Street = textboxstreetname.Text;
					newuser.City = textboxcity.Text;
					newuser.State = textboxstate.Text;
					newuser.Zip = textboxzip.Text;
					newuser.DateofBirth = DateTime.Parse(dobpicker.Text).ToString("M/dd/yyyy");
					newuser.Username = textboxusername.Text;
					newuser.Password = textboxpassword.Text;
					newuser.FirstKey = Soundex.GetSoundex(newuser.FirstName);
					newuser.LastKey = Soundex.GetSoundex(newuser.LastName);
					//resultsbox.Items.Add(newuser.ToString(true));
					UserList.users.Add(newuser);
					UserList.users.Sort();

					//searchfirstname_TextChanged(sender, e);
					_UserSelected = newuser;
					ChangeWindowType(Types.View);
					Program.ChangeWasMade = true;
					break;
			}
		}

		private void ChangeWindowType(Types type) {
			switch (type) {
				case Types.Add:
					buttonedit.Visible = false;
					break;
				case Types.Edit:
					buttonedit.Text = "Save Changes";
					buttonsubmit.Text = "Cancel";
					EnableControls();
					break;
				case Types.View:
					DisableControls();
					buttonedit.Visible = true;
					buttonsubmit.Text = "Close";
					buttonedit.Text = "Edit";
					this.Text = textboxfirst.Text + " " + textboxlast.Text;
					break;
			}
		}

		private void buttonedit_Click(object sender, EventArgs e) {
			switch (buttonedit.Text) {
				case "Edit":
					ChangeWindowType(Types.Edit);
					break;
				case "Save Changes":
					_UserSelected.FirstName = textboxfirst.Text;
					_UserSelected.LastName = textboxlast.Text;
					_UserSelected.Street = textboxstreetname.Text;
					_UserSelected.City = textboxcity.Text;
					_UserSelected.State = textboxstate.Text;
					_UserSelected.Zip = textboxzip.Text;
					_UserSelected.DateofBirth = DateTime.Parse(dobpicker.Text).ToString("M/dd/yyyy");
					_UserSelected.Username = textboxusername.Text;
					_UserSelected.Password = textboxpassword.Text;
					_UserSelected.FirstKey = Soundex.GetSoundex(_UserSelected.FirstName);
					_UserSelected.LastKey = Soundex.GetSoundex(_UserSelected.LastName);
					ChangeWindowType(Types.View);
					Program.ChangeWasMade = true;
					break;
			}
		}
		
		private void UserInfoForm_FormClosing(object sender, FormClosingEventArgs e) {
			Search.Update();
		}

		private void UserInfoForm_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Escape) {
				if (buttonsubmit.Text == "Cancel")
					buttonsubmit_Click(sender,e);
				else
					this.Close();
			}
		}
	}
}
