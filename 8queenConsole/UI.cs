using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _8queen.Model;

namespace _8queen
{
	public partial class UI : Form {
		private readonly int[] sleepTimes = { 5000,2500, 1500 ,1000, 800, 500, 300, 200, 100, 0 };
		private Solver solver;

		internal UI(Solver s){
			InitializeComponent();
			solver = s;
			ValidateMutationRanges();
			textCostAvg.Text = "";
			textCostMin.Text = "";
			textCostMax.Text = "";
			textGenNum.Text  = "";
			textGenBest.Text = "";
		}
				
		public Tuple<int, int> GetPopSettings() {
			int popSize = (int) popSizeSelector.Value;
			int boardSize = (int) boardSizeSelector.Value;
			return new Tuple<int, int>(popSize, boardSize);
		}

		public Tuple<int, int, double, double, double> GetMutationSettings() {
			int cross = (int) crossoverSelector.Value;
			int distance = (int) mDistanceSelector.Value;
			double mvChance = (double)mChanceShiftSelector.Value;
			double swpChance = (double)mChanceSwapSelector.Value;
			double revChance = (double)mChanceRevSelector.Value;
			return new Tuple<int, int, double, double, double>(cross, distance, mvChance, swpChance, revChance);
		}

		internal Tuple<bool, bool> GetLogSettings() {
			bool useConsole = logEnabledConsole.Checked;
			bool useFile = logEnabledFile.Checked;
			return new Tuple<bool, bool>(useConsole, useFile); 
		}

		public SelectorFactory.Type GetSelectionType() {
			if (selectRoullete.Checked) {
				return SelectorFactory.Type.ROULETTE;
			} else if (selectDemo.Checked) {
				return SelectorFactory.Type.DEMO;
			} else if (selectSteady.Checked) {
				return SelectorFactory.Type.STEADY;
			} else {
				return SelectorFactory.Type.NONE;
			}
		}
		
		public void UpdateOutputs(int gen, string bestSol, int bestScore, double avgScore, int worstScore) {
			chessBoard.SetState(bestSol);
			textGenNum.Text = String.Format("{0}", gen);
			textGenBest.Text = bestSol;
			textCostMin.Text = String.Format("{0}", bestScore);
			textCostAvg.Text = String.Format("{0:F2}", avgScore);
			textCostMax.Text = String.Format("{0}", worstScore);
		}		


		private void DisableFixedWhileRunningComponents() {
			buttonStart.Enabled = false;
			groupBoxPop.Enabled = false;
			buttonCancel.Enabled = true;
		}
		
		private void EnableFixedWhileRunningComponents() {
			buttonStart.Enabled = true;
			groupBoxPop.Enabled = true;
			buttonCancel.Enabled = false;

		}

		private void speedSelector_ValueChanged(object sender, EventArgs e) {
			if (solver != null) {
				int selected = speedSelector.Value;
				solver.SleepTimeUpdate( sleepTimes[selected] );
			}
		}



		private void ValidateMutationRanges() {
			int newSize = (int)boardSizeSelector.Value;

			crossoverSelector.Value = Math.Min(crossoverSelector.Value, newSize - 1);
			crossoverSelector.Maximum = newSize - 1;

			mDistanceSelector.Value = Math.Min(mDistanceSelector.Value, newSize);
			mDistanceSelector.Maximum = newSize;
		}


		public void RunComplete() {
			EnableFixedWhileRunningComponents();
		}

		private void SettingsChanged(object sender, EventArgs e) {
			solver.PullSettings();
		}

		private void GenomeSizeChanged(object sender, EventArgs e) {
			ValidateMutationRanges();
		}

		private void buttonCancel_Click(object sender, EventArgs e) {
			solver.RequestCancel();
		}

		private void buttonStart_Click(object sender, EventArgs e) {
			DisableFixedWhileRunningComponents();
			speedSelector_ValueChanged(sender, e);
			solver.StartSolve(GetPopSettings());
		}
	}
}
