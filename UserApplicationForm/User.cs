using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CsvHelper.Configuration;

namespace UserApplicationForm
{
	[Serializable()]
	[XmlRoot("UserList")]

	public class User : IComparable<User>
	{
		private string _firstname;
		private string _lastname;
		private string _street;
		private string _city;
		private string _state;
		private string _zip;
		private string _dob;
		private string _username;
		private string _password;
		private string _firstkey;
		private string _lastkey;

		public string FirstName { get { return _firstname; } set { _firstname = value; } }
		public string LastName { get { return _lastname; } set { _lastname = value; } }
		public string Street { get { return _street; } set { _street = value; } }
		public string City { get { return _city; } set { _city = value; } }
		public string State { get { return _state; } set { _state = value; } }
		public string Zip { get { return _zip; } set { _zip = value; } }
		public string DateofBirth { get { return _dob; } set { _dob = value; } }
		public string Username { get { return _username; } set { _username = value; } }
		public string Password { get { return _password; } set { _password = value; } }
		public string FirstKey { get { return _firstkey; } set { _firstkey = value; } }
		public string LastKey { get { return _lastkey; } set { _lastkey = value; } }

		public string ToString(bool justname = false)
		{
			if ( !justname ) { return "First Name: " + FirstName + "\n" + "Last Name: " + LastName + "\n" + "Address: " + Street + "\n" + "Date of Birth: " + DateofBirth + "\n" + "Username: " + Username + "\n" + "Password: " + Password; }
			else { return LastName + ", " + FirstName; }
		}
		public int CompareTo(User other) {
			return String.Compare(this.LastName, other.LastName);
		}

	}


	public sealed class UserCSVMap : CsvClassMap<User> {
		public UserCSVMap() {
			Map(m => m.FirstName);
			Map(m => m.LastName);
			Map(m => m.Street);
			Map(m => m.City);
			Map(m => m.State);
			Map(m => m.Zip);
			Map(m => m.DateofBirth);
			Map(m => m.Username);
			Map(m => m.Password);
			Map(m => m.FirstKey);
			Map(m => m.LastKey);
		}
	}

}
