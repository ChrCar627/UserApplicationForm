using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundexAlgorithm;

namespace UserApplicationForm
{
	static class Program {
		public static SearchForm mainform;
		public static string CurrentFilePath;
		public static string CurrentFileName;
		public static bool ChangeWasMade = false;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		[STAThread]
		static void Main()
		{

			Soundex.UseNYSoundexForAll = true;

			AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			mainform = new SearchForm();
			//FileHandling.LoadUsers(form1.ResultsBox);
			FileHandler.LoadUsersFromCSV("Users.csv");
			Application.Run(mainform);

			/*while ( true ) {
				Console.WriteLine("Enter a name (or noting to exit): ");
				string name = Console.ReadLine();
				if ( string.IsNullOrEmpty(name) ) { return; }
				Console.WriteLine("Name: " + name + "\nSoundex: " + Soundex.GetSoundex(name));

			}
			*/
		}


		static void OnProcessExit(object sender, EventArgs e)
		{
			FileHandler.SaveUsers(UserList.users);
		}
	}
}
