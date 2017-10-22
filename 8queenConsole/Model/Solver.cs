using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;

namespace _8queen.Model
{
	class Solver
	{

		private bool initialized = false;
		private readonly SelectorFactory sel;
		private readonly GeneOperator gene;
		private int sleepTime;

		//  Output Objects
		private Logger logOutput;
		private UI ui;

		private BackgroundWorker Runner;

		public Solver(Logger l) {
			sel = new SelectorFactory();
			gene = new GeneOperator();
			logOutput = l;
		}

		public void Init(UI ui) {
			if (ui != null) {
				this.ui = ui;
				initialized = true;
				PullSettings();
				InitRunner();
			}
		}

		private void InitRunner() {
			Runner = new BackgroundWorker();
			Runner.DoWork += new DoWorkEventHandler(Solve);
			Runner.ProgressChanged += new ProgressChangedEventHandler(WorkUpdated);
			Runner.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WorkFinished);
			Runner.WorkerReportsProgress = true;
			Runner.WorkerSupportsCancellation = true;
		}

		public void RequestCancel() {
			if (Runner.IsBusy) {
				Runner.CancelAsync();
			}
		}

		private void WorkFinished(object sender, RunWorkerCompletedEventArgs e) {
			logOutput.LogRunEnd();
			ui.RunComplete();
		}

		private void WorkUpdated(object sender, ProgressChangedEventArgs e) {
			Tuple<int, string, int, double, int> genStats = (Tuple<int, string, int, double, int>)e.UserState;
			ui.UpdateOutputs(genStats.Item1, genStats.Item2, genStats.Item3, genStats.Item4, genStats.Item5);
		}

		public void PullSettings() {
			if (initialized) {
				sel.ChangeSettings(ui.GetSelectionType());
				gene.ChangeSettings(ui.GetMutationSettings());
				logOutput.ChangeSettings(ui.GetLogSettings());
			}
		}

		public void SleepTimeUpdate(int milliseconds) {
			if (milliseconds <= 0) {
				sleepTime = 0;
			} else {
				sleepTime = milliseconds;
			}
			
		}
		private static Tuple<int, string, int, double, int> gatherOutputs(Population p, int gen) {
			Arrangement best = p.GetBest();
			int bestScore = best.Cost();
			string toDraw = best.ToString();
			double avgScore = p.GetAvg();
			int worstScore = p.GetWorst().Cost();
			return new Tuple<int, string, int, double, int>(gen, toDraw, bestScore, avgScore, worstScore);
		}

		private void Solve(object sender, DoWorkEventArgs e) {
			Tuple<int, int> settings = (Tuple<int, int>)e.Argument;
			Population p = Population.GenerateRandom(settings.Item1, settings.Item2);
			int genNum = 1;
			logOutput.LogRunStart(settings.Item1, settings.Item2, sel, gene);
			while (p.GetBest().Cost() > 0) {
				if (Runner.CancellationPending) {
					e.Cancel = true;
					break;
				} else {
					logOutput.LogGeneration(p, genNum);
					Runner.ReportProgress(1, gatherOutputs(p, genNum));
					p = p.Reproduce(sel, gene);
					genNum++;
					Thread.Sleep(sleepTime);
				}
			}
			logOutput.LogGeneration(p, genNum);
			Runner.ReportProgress(1, gatherOutputs(p, genNum));
		}	

		public void StartSolve(Tuple<int, int> settings) {
			if (!Runner.IsBusy) {
				Runner.RunWorkerAsync(settings);
			}
		}
	}
}
