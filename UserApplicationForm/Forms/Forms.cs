using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms {
	class Forms {


		public static void DisableControls(Control.ControlCollection controls) {
			foreach (Control c in controls) {
				if (c.Controls.Count >= 1)
					DisableControls(c.Controls);
				else {
					Label l = c as Label;
					Button b = c as Button;
					if (l == null && b == null)
						c.Enabled = false;
				}
			}
		}

		public static void EnableControls(Control.ControlCollection controls) {
			foreach (Control c in controls) {
				if (c.Controls.Count >= 1)
					EnableControls(c.Controls);
				else {
					Label l = c as Label;
					if (l == null)
						c.Enabled = true;
				}
			}
		}

	}
}
