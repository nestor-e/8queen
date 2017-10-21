using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model
{
	class Solver
	{


		private SelectorFactory sel;
		private GeneOperator gene;
		private int sleepTime;

		//  Output Objects
		private Logger output;
		private ChessBoard board;
		private Label genNumLabel;
		private Label genBestLabel;
		private Label costBestLabel;
		private Label costAvgLabel;
		private Label costWorstLabel;

		

		public Solver() {
			output = new Logger();
		}

		public void PullSettings() { }

		public void SleepTimeUpdate(int milliseconds) {
			if (milliseconds <= 0) {
				sleepTime = 0;
			} else {
				sleepTime = milliseconds;
			}
			
		}

		public void Solve(int popSize, int boardSize) {
			Population p = Population.GenerateRandom(popSize);
			int i = 1;
			output.LogRunStart(popSize);
			while (p.GetBest().Cost() > 0)
			{
				output.LogGeneration(p, i);
				p = p.Reproduce(sel, gene);
				i++;
				//Thread.Sleep(100);
			}
			output.LogGeneration(p, i);
			output.LogRunEnd();
			output.Close();
		}
	}
}
