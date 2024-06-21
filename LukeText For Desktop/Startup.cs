using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
		public static void UpdateChecker()
		{
			string remoteUri = "http://api.lukeit.net/api/";
			string remoteFile = "luketext.json", updateJsonFile = null;
			string locationEnv = "%localappdata%/LukeIT/LukeText/Update.json";
			string location = Environment.ExpandEnvironmentVariables(locationEnv);
			WebClient updateChecker = new WebClient();
			updateJsonFile = remoteUri + remoteFile;
			updateChecker.DownloadFile(updateJsonFile, location);
			string json = File.ReadAllText(location);
			JToken token = JArray.Parse(json);
			string version = (string)token.SelectToken("version");
			string update = (string)token.SelectToken("update");
			if (version == "2.2.1" && update == "true")
			{
				DialogResult result = MessageBox.Show("A New LukeText Update is Available! Do you want to download it?", "LukeText", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (result == DialogResult.Yes)
				{
					System.Diagnostics.Process.Start("https://www.lukeit.net/LukeText");
				}
			}
		}
	}
}
