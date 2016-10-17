using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using CsvHelper;

namespace UserApplicationForm
{
	class FileHandler
	{

		public static void ResetCurrentFile() {
			Program.mainform.CurrentFileLabel.Text = "No file open";
			Program.CurrentFileName = string.Empty;
			Program.CurrentFilePath = string.Empty;
		}
		public static void SetCurrentFile(string s) {
			int lastpos = s.LastIndexOfAny(new char[2] { '/', '\\' }) + 1;
			string safename = s.Substring(lastpos);
			Program.mainform.CurrentFileLabel.Text = safename;
			Program.CurrentFileName = safename;
			Program.CurrentFilePath = s;

			Program.ChangeWasMade = false;
		}

		public static SaveFileDialog SaveFile() {
			SaveFileDialog savefile = new SaveFileDialog();
			savefile.Title = "Save users";
			savefile.Filter = "CSV (Comma delimited) (*.csv)|*.csv|Text File (*.txt)|*.txt|All Files (*.*)|*.*";
			savefile.AddExtension = true;
			savefile.DefaultExt = ".csv";
			savefile.FileName = "Users.csv";
			if (savefile.ShowDialog() == DialogResult.OK) {
				return savefile;
			}
			else
				return null;
		}

		public static bool SaveUsersToCSV(string filepath) {
			if (filepath == null || filepath.Equals(string.Empty))
				return false;

			using (StreamWriter file = new StreamWriter(filepath)) {
				CsvWriter csv = new CsvWriter(file);
				csv.WriteRecords(UserList.users);
			}
			SetCurrentFile(filepath);
			return true;
			/*
			string csvtext = "";
			foreach (User u in UserList.users) {
				string[] delimited = new string[] { u.FirstName, u.LastName, u.Street, u.City, u.State, u.Zip, u.DateofBirth, u.Username, u.Password, u.FirstKey, u.LastKey };
				for (int i = 0; i < delimited.Length; i++) {
					string s = delimited[i] == null ? string.Empty : delimited[i];
					s = s.Replace("\"", "\"\""); //replace " with ""

					if (s.IndexOf(',') > -1)
						s = "\"" + s + "\"";
					delimited[i] = s;
				}
				string newline = delimited[0] + "," + delimited[1] + "," + delimited[2] + "," + delimited[3] + "," + delimited[4] + "," + delimited[5] + "," + delimited[6] + "," + delimited[7] + "," + delimited[8] + "," + delimited[9] + "," + delimited[10] + "\n";
				csvtext += newline;
			}
			File.WriteAllText(filename, csvtext);
			*/
		}

		public static OpenFileDialog LoadFile(String title = "Load File", String filter = "CSV (Comma delimited) (*.csv)|*.csv|Text File (*.txt,*.rtf,*.doc)|*.txt;*.rtf;*.doc|All Files (*.*)|*.*") {
			OpenFileDialog loadfile = new OpenFileDialog();
			loadfile.Title = title;
			loadfile.Filter = filter;
			if (loadfile.ShowDialog() == DialogResult.OK) {
				return loadfile;
			}
			return null;
		}

		public static void LoadUsersFromCSV(string filepath) {
			if (filepath == null || filepath == string.Empty)
				return;
			try {
				using (StreamReader file = new StreamReader(filepath)) {
					//Stopwatch sw = new Stopwatch();
					//sw.Start();
					try {
						CsvReader csv = new CsvReader(file);
						var records = csv.GetRecords<User>().ToList();
						UserList.users.Clear();
						foreach (User u in records) {
							UserList.AddUser(u);
						}
					}
					catch (CsvHelperException) {
						MessageBox.Show("Invalid CSV file.", "Error");
						return;
					}
				}
			}
			catch (FileNotFoundException) {
				MessageBox.Show("Cannot find file. Please try another file.","Error");
				return;
			}
			catch (IOException){
				MessageBox.Show("Cannot open file.\nPlease make sure that the file is closed and try again.","Error");
				return;
			}

			Search.Update();
			SetCurrentFile(filepath);

		}


		/*
						string line;

						while ((line = file.ReadLine()) != null) {
							bool quotes = false;
							string newstring = string.Empty;
							char lastchar = ' ';
							List<string> parsedcsv = new List<string>();
							foreach (char c in line.ToCharArray()) {
								switch (c) {
									case '"':
										quotes = !quotes;
										if (lastchar != '"') {
											newstring += "\"";
											lastchar = ' ';
										}
										else
											lastchar = c;
										break;

									case ',':
										if (quotes) {
											newstring += ",";
											lastchar = c;
										}
										else {
											parsedcsv.Add(newstring);
											newstring = string.Empty;
											lastchar = ' ';
										}
										break;

									default:
										newstring += c;
										lastchar = c;
										break;
								}
							}
							parsedcsv.Add(newstring);//add last string

							User newuser = new User();
							newuser.FirstName = parsedcsv[0];
							newuser.LastName = parsedcsv[1];
							newuser.Street = parsedcsv[2];
							newuser.City = parsedcsv[3];
							newuser.State = parsedcsv[4];
							newuser.Zip = parsedcsv[5];
							newuser.DateofBirth = parsedcsv[6];
							newuser.Username = parsedcsv[7];
							newuser.Password = parsedcsv[8];
							newuser.FirstKey = parsedcsv[9];
							newuser.LastKey = parsedcsv[10];
							UserList.AddUser(newuser);

						}

						Program.mainform.UpdateSearch();
						*/

		public static void SaveUsers(List<User> userlist)
		{
			var serializer = new XmlSerializer(typeof(List<User>));
			string path = Environment.CurrentDirectory + "/Users.xml";
			if ( File.Exists(path) ) { File.Delete(path); }
			using ( var stream = File.OpenWrite(path) )
			{
				serializer.Serialize(stream, UserList.users);
			}
		}

		public static void LoadUsers(ListBox l)
		{
			var serializer = new XmlSerializer(typeof(List<User>));
			try
			{
				using ( var stream = File.OpenRead(Environment.CurrentDirectory + "/Users.xml") )
				{
					var other = (List<User>)(serializer.Deserialize(stream));
					UserList.users.Clear();
					UserList.users.AddRange(other);
					UserList.users.Sort();
					foreach ( User user in UserList.users )
					{
						l.Items.Add(user.ToString(true));
					}
					Search.CurrentResults = UserList.users;
				}
			}
			catch (FileNotFoundException)
			{
				return;
			}
		}
	}
}
