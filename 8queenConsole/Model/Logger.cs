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
		private bool midRun = false;
		private bool targetToConsole = true;
		private bool targetToFile = false;

		public Logger() {
			filePath = String.Format("log{0:MM-dd-HH-mm}.txt", DateTime.Now);
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

		internal void ChangeSettings(Tuple<bool,bool> settings) {
			targetToConsole = settings.Item1;
			targetToFile = settings.Item2;
		}

		public void LogRunStart(int popSize, int boardSize, SelectorFactory sf, GeneOperator go) {
			if (!midRun) {
				logToConsole = targetToConsole;
				logToFile = targetToFile;
				midRun = true;
				string type = sf.GetTypeName();
				object[] mValues = { go.PerGeneMoveChance, go.PerGeneSwapChance, go.MaxMutationDistance, go.CrossCount };
				string s1 = String.Format("Starting puzzle of size {0} using {1} and {2} individuals per generation", boardSize, type, popSize);
				string s2 = String.Format("{3} Crossovers, Mutation Chances : move - {0:P1} , swap - {1:P1} ; {2} max distance", mValues);
				logLine(s1);
				logLine(s2);
			}
		}

		public void LogRunEnd() {
			logLine("Run concluded \n\n");
			logLine("");
			logLine("");
			midRun = false;
		}

		public void LogGeneration(Population p, int genNum){
			if (midRun) {
				object[] values = { genNum, p.GetBest().Cost(), p.GetAvg(), p.GetWorst().Cost() };
				String output = String.Format("\tGen #{0}: Best - {1} , Avg - {2:F2} , Worst - {3}", values);
				logLine(output);
			}
		}
	}
}
