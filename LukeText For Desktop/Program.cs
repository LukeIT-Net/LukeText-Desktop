using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukeText_For_Desktop
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (args.Length > 0 )
			{
				Application.Run(new Form1(args[0]));
			}
			else
			{
				Application.Run(new Form1());
			}
		}
	}
}
