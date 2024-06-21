using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukeText_For_Desktop
{
	public class StartupClass
	{
		public static void PrivacyPolicy()
		{
			const string userRoot = "HKEY_CURRENT_USER";
			const string key1 = "Software";
			const string key2 = "LukeIT";
			const string key3 = "LukeText";
			const string subkey = "PrivacyPolicy";
			const string fullKey = userRoot + "\\" + key1 + "\\" + key2 + "\\" + key3;
			string keyValue = (string)Registry.GetValue(fullKey, subkey, "NotAsked");
			if (keyValue == "NotAsked")
			{
				MessageBox.Show("By using LukeText, You agree to the LukeIT Privacy Policy. Do you agree to the LukeIT Privacy Policy? To view the privacy policy, go to https://www.lukeit.net/PrivacyPolicy", "LukeText", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				Registry.SetValue(fullKey, subkey, "Agreed", RegistryValueKind.String);
			}
		}
	}
}
