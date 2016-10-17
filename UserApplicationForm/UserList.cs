using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using SoundexAlgorithm;

namespace UserApplicationForm
{
	class UserList
	{ 
		public static List<User> users = new List<User>();

		public static void AddUser(User u) {
			if (u.FirstKey == null || u.FirstKey.Equals(string.Empty))
				u.FirstKey = NYSoundex.GetSoundex(u.FirstName);
			if (u.LastKey == null || u.LastKey.Equals(string.Empty))
				u.LastKey = NYSoundex.GetSoundex(u.LastName);
			users.Add(u);
		}
	}
}
