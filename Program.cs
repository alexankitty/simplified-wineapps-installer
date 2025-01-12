using System;
using Eto.Forms;
using Eto.Drawing;

namespace simplified_wineapps_installer
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			new Application(Eto.Platform.Detect).Run(new MainForm());
		}
	}
}
