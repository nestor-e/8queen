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
		public static int BoardSize { get; private set; } =  8;
		
		[STAThread]
		static void Main(string[] args)
		{
			rng = new Random();
			Logger output = new Logger();
			Solver sol = new Solver();
			Population p = Population.GenerateRandom(200);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new _8queen.UI());
			int i = 1;
			output.LogRunStart(200);
			while (p.GetBest().Cost() > 0) {
				output.LogGeneration(p, i);
				p = p.Reproduce();
				i++;
				//Thread.Sleep(100);
			}
			output.LogGeneration(p, i);
			output.LogRunEnd();
			output.Close();
			Console.In.ReadLine();
		}
	}
}