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

		public UI(){
			InitializeComponent();
		}

		internal void InitSolver(Solver s) {
			//s.InitLabels();
			//s.InitBoard();
		}

		private void PushSettings() { }
				
		public Tuple<int, int> GetPopSettings() {
			int popSize = (int) popSizeSelector.Value;
			int boardSize = (int) boardSizeSelector.Value;
			return new Tuple<int, int>(popSize, boardSize);
		}

		public Tuple<int, int, double, double> GetMutationSettings() {
			int cross = (int) crossoverSelector.Value;
			int distance = (int) mDistanceSelector.Value;
			double mvChance = (double)mChanceMoveSelector.Value;
			double swpChance = (double)mChanceSwapSelector.Value;
			return new Tuple<int, int, double, double>(cross, distance, mvChance, swpChance);
		}

		public SelectorFactory.Type GetSelectionType() {
			if (selectRoullete.Checked){
				return SelectorFactory.Type.ROULETTE;
			} else if (selectDemo.Checked) {
				return SelectorFactory.Type.DEMO;
			} else {
				return SelectorFactory.Type.NONE;
			}
		}

		
		private void DisableFixedWhileRunningComponents() { 
			
		}
		private void EnableFixedWhileRunningComponents() { }

		private void speedSelector_ValueChanged(object sender, EventArgs e) {
			if (solver != null) {
				int selected = speedSelector.Value;
				solver.SleepTimeUpdate( sleepTimes[selected] );
			}
		}

		private void buttonStart_Click(object sender, EventArgs e) {
			PushSettings();
			DisableFixedWhileRunningComponents();
			solver.Solve();
		}

		public void RunComplete() {
			EnableFixedWhileRunningComponents();
		}
	}
}
