using LukeText_For_Desktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukeText_For_Desktop
{
	partial class AboutBox1 : Form
	{
		public AboutBox1()
		{
			InitializeComponent();
			/* DO NOT USE THIS
			this.Text = String.Format("About {0}", AssemblyTitle);
			this.labelProductName.Text = AssemblyProduct;
			this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
			this.labelCopyright.Text = AssemblyCopyright;
			this.labelCompanyName.Text = AssemblyCompany;
			this.textBoxDescription.Text = AssemblyDescription;
			*/
			string file = Application.StartupPath + "LICENSE.rtf";
			richTextBox1.LoadFile(file, RichTextBoxStreamType.RichText);
		}

		#region Assembly Attribute Accessors

		public string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}
				}
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable SYSLIB0012
				return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
#pragma warning restore CS8603 // Possible null reference return.
#pragma warning restore SYSLIB0012
			}
		}

		public string AssemblyVersion
		{
			get
			{
#pragma warning disable CS8602 // Dereference of a possibly null reference.
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
			}
		}

		public string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion

		private void labelProductName_Click(object sender, EventArgs e)
		{

		}

		private void AboutBox1_Load(object sender, EventArgs e)
		{

		}

		private void labelVersion_Click(object sender, EventArgs e)
		{

		}

		private void labelCompanyName_Click(object sender, EventArgs e)
		{

		}

		private void textBoxDescription_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxDescription_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
