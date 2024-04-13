using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace LukeText_For_Desktop
{
	public partial class Form1 : Form
	{
		public Form1(string filename)
		{
			InitializeComponent();
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
			if (filename != null)
			{
				try
				{
					richTextBox1.LoadFile(filename);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Loading File. Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
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
			richTextBox1.EnableAutoDragDrop = true;
		}

		public Form1()
		{
			InitializeComponent();
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
			richTextBox1.EnableAutoDragDrop = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Title = "Open Any File...";
			openFile.Filter = "Text Document (*.txt)|*.txt|LukeText Document (*.ltd)|*.ltd|LukeText Text Document (*.ltdt)|*.ltdt|All Files (*.*)|*.*";
			openFile.DefaultExt = "*.ltd";
			openFile.FilterIndex = 2;
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.Clear();
				string filename = openFile.FileName;
				RichTextBoxStreamType streamType;
				if (openFile.FilterIndex == 2)
					streamType = RichTextBoxStreamType.RichText;
				else
					streamType = RichTextBoxStreamType.PlainText;

				richTextBox1.LoadFile(filename, streamType);
			}

		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			string filename = "";
			saveFile.Title = "Save file as...";
			saveFile.Filter = "Text Document (*.txt)|*.txt|LukeText Document (*.ltd)|*.ltd|LukeText Text Document(*.ltdt)|*.ltdt|All Files (*.*)|*.*";
			saveFile.DefaultExt = "*.ltd";
			saveFile.FilterIndex = 2;

			DialogResult retval = saveFile.ShowDialog();
			if (retval == DialogResult.OK)
				filename = saveFile.FileName;
			else
				return;

			RichTextBoxStreamType streamType;
			if (saveFile.FilterIndex == 2)
				streamType = RichTextBoxStreamType.RichText;
			else
				streamType = RichTextBoxStreamType.PlainText;

			richTextBox1.SaveFile(filename, streamType);
		}

		private void cutToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pasteToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			newToolStripButton.PerformClick();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openToolStripButton.PerformClick();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveToolStripButton.PerformClick();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Undo();
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Redo();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

		private void normalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Calibri", 11);
		}

		private void boldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Calibri", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Garamond", 11);
		}

		private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Garamond", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Times New Roman", 11);
		}

		private void boldToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Arial", 11);
		}

		private void boldToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Arial", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cambria", 11);
		}

		private void boldToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cambria", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Verdana", 11);
		}

		private void boldToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Verdana", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Rockwell", 11);
		}

		private void boldToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Rockwell", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Franklin Gothic", 11);
		}

		private void boldToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Franklin Gothic", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Code PL", 11);
		}

		private void boldToolStripMenuItem11_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Code PL", 11, FontStyle.Bold);
		}

		private void boldToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Code", 11);
		}

		private void boldToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Code", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem11_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Mono PL", 11);
		}

		private void boldToolStripMenuItem12_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Mono PL", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Mono", 11);
		}

		private void boldToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Mono PL", 11, FontStyle.Bold);
		}

		private void blackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Black;
		}

		private void silverToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Silver;
		}

		private void grayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Gray;
		}

		private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.White;
		}

		private void darkRedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Maroon;
		}

		private void redToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Red;
		}

		private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Orange;
		}

		private void oliveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Olive;
		}

		private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Yellow;
		}

		private void lightGreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Lime;
		}

		private void greenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Green;
		}

		private void navyBlueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Navy;
		}

		private void blueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Blue;
		}

		private void tealToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Teal;
		}

		private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Aqua;
		}

		private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Purple;
		}

		private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Fuchsia;
		}

		private void goldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Gold;
		}

		private void moreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fdlg = new FontDialog();
			fdlg.ShowDialog();
			richTextBox1.Font = fdlg.Font;
		}

		private void moreToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ColorDialog cdlg = new ColorDialog();
			cdlg.ShowDialog();
			richTextBox1.ForeColor = cdlg.Color;

		}

		private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton3.PerformClick();
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					Clipboard.SetImage(Image.FromFile(ofd.FileName));
					richTextBox1.Paste();
				}
			}
		}

		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionBackColor = Color.Yellow;
		}

		private void redToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionBackColor = Color.Red;
		}

		private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionBackColor = Color.Green;
		}

		private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionBackColor = Color.Blue;
		}

		private void moreToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ColorDialog cdlg = new ColorDialog();
			cdlg.ShowDialog();
			richTextBox1.SelectionBackColor = cdlg.Color;
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			Font SelectedText_Font = richTextBox1.SelectionFont;
			if (SelectedText_Font != null)
				richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Underline);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			Font SelectedText_Font = richTextBox1.SelectionFont;
			if (SelectedText_Font != null)
				richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
		}

		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			Font SelectedText_Font = richTextBox1.SelectionFont;
			if (SelectedText_Font != null)
				richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
		}

		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			Font SelectedText_Font = richTextBox1.SelectionFont;
			if (SelectedText_Font != null)
				richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Strikeout);
		}

		private void aboutLukeTextToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton5.PerformClick();
		}

		private void italicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton6.PerformClick();
		}

		private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton4.PerformClick();
		}

		private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton7.PerformClick();
		}

		private void toolStripComboBox1_Click(object sender, EventArgs e)
		{

		}

		private void leftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Select();
			richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void centerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Select();
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void rightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Select();
			richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fdlg = new FontDialog();
			fdlg.ShowDialog();
			richTextBox1.Font = fdlg.Font;
		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog cdlg = new ColorDialog();
			cdlg.ShowDialog();
			richTextBox1.ForeColor = cdlg.Color;
		}

		private void highlightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog cdlg = new ColorDialog();
			cdlg.ShowDialog();
			richTextBox1.SelectionBackColor = cdlg.Color;
		}

		private void leftAlignToolStripMenuItem_Click(object sender, EventArgs e)
		{
			leftToolStripMenuItem.PerformClick();
		}

		private void centerAlignToolStripMenuItem_Click(object sender, EventArgs e)
		{
			centerToolStripMenuItem.PerformClick();
		}

		private void rightAlignToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rightToolStripMenuItem.PerformClick();
		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AboutBox1 aboutBox1 = new AboutBox1();
			aboutBox1.Show();
		}

		private void aboutLukeTextToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			AboutBox1 aboutBox1 = new AboutBox1();
			aboutBox1.Show();
		}

		private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
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
