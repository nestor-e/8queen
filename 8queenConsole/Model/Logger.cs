using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _8queen.Model
{
	class Logger{
		private readonly string filePath;
		private StreamWriter fileOut = null;
		private bool logToConsole = true;
		private bool logToFile = false;

		public Logger() {
			filePath = String.Format("../../Logs/log{0:mm-dd-hh-mm}.txt", DateTime.Now);
		}
		
		public void Close() {
			if (fileOut != null) {
				fileOut.Flush();
				fileOut.Close();
			}		
		}

		private void openLogFile() {
			if (fileOut == null) {
				fileOut = new StreamWriter(new FileStream(filePath, FileMode.Append));
			}
		}

		private void logLine(string toWrite) {
			if (logToConsole) {
				Console.Out.WriteLine(toWrite);
			}
			if (logToFile) {
				openLogFile();
				fileOut.WriteLine(toWrite);
			}
		}


		public void LogRunStart(int popSize, SelectorFactory sf, GeneOperator go) {
			int size = Program.BoardSize;
			string type = sf.GetTypeName();
			object[] mValues = { go.PerGeneMoveChance, go.PerGeneSwapChance, go.MaxMutationDistance, go.CrossCount };
			string s1 = String.Format("Starting puzzle of size {0} using {1} and {2} individuals per generation", size, type, popSize);
			string s2 = String.Format("{3} Crossovers, Mutation Chances : move - {0:P1} , swap - {1:P1} ; {2} max distance", mValues);
			logLine(s1);
			logLine(s2);
		}

		public void LogRunEnd() { }

		public void LogGeneration(Population p, int genNum){
			object[] values = { genNum, p.GetBest().Cost(), p.GetAvg(), p.GetWorst().Cost() };
			String output = String.Format("\tGen #{0}: Best - {1} , Avg - {2:F2} , Worst - {3}", values);
			logLine(output);
		}
	}
}
