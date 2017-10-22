using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using _8queen.Model;

namespace _8queen
{
	class Program
	{
		public static Random rng;
		
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			rng = new Random();
			Logger log = new Logger();
			Solver sol = new Solver(log);
			UI ui = new UI(sol);
			sol.Init(ui);

			Application.Run(ui);
			
			log.Close();
		}
	}
}