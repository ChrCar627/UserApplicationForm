using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundexAlgorithm;

namespace UserApplicationForm
{
	class Search
	{
		public static List<User> results = new List<User>();
		public static List<User> CurrentResults = new List<User>();


		public static void Update() {
			results = Search.SearchUsers(Program.mainform.SearchFirstName.Text, Program.mainform.SearchLastName.Text);
			results.Sort();
			Program.mainform.ResultsBox.DataSource = null;
			Program.mainform.ResultsBox.DataSource = Search.results;
		}

		public static List<User> SearchUsers(string firstname, string lastname) {
			List<User> firstresult = SearchFirstName(firstname);
			List<User> lastresult = SearchLastName(lastname);
			List<User> resultlist;
			if ( firstresult == null && lastresult == null ) {
				CurrentResults = UserList.users;
				return UserList.users;
			}
			else if ( firstresult == null && lastresult != null )
				resultlist = lastresult;
			else if ( lastresult == null && firstresult != null )
				resultlist = firstresult;
			else {
				IEnumerable<User> resultquery = (from user1 in firstresult
												 from user2 in lastresult
												 where user1.FirstKey == user2.FirstKey
												 where user1.LastKey == user2.LastKey
 												select user1).Distinct();
				resultlist = resultquery.ToList();
			}
			CurrentResults = resultlist;
			return resultlist;
		}

		public static List<User> SearchLastName(string lastname) {
			if ( string.IsNullOrWhiteSpace(lastname) )
				return null;
			else {
				string searchterm = Soundex.GetSoundex(lastname);
				return UserList.users.FindAll(s => s.LastKey.Equals(searchterm));
			}
		}
		public static List<User> SearchFirstName(string firstname) {
			if ( string.IsNullOrWhiteSpace(firstname) )
				return null;
			else {
				string searchterm = Soundex.GetSoundex(firstname);
				return UserList.users.FindAll(s => s.FirstKey.Equals(searchterm));
			}
		}
	}
}
