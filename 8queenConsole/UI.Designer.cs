namespace _8queen
{
	partial class UI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label staticTextMDistance;
			System.Windows.Forms.Label staticTextMChanceSwap;
			System.Windows.Forms.Label staticTextMChanceMove;
			System.Windows.Forms.Label staticTextCrossover;
			System.Windows.Forms.Label staticTextBoardSize;
			System.Windows.Forms.Label staticTextPopSize;
			System.Windows.Forms.Label staticTextCostMin;
			System.Windows.Forms.Label staticTextCostAvg;
			System.Windows.Forms.Label staticTextCostMax;
			System.Windows.Forms.Label staticTextGen;
			System.Windows.Forms.Label staticTextBest;
			System.Windows.Forms.Label staticTextSpeed;
			this.logEnabledConsole = new System.Windows.Forms.CheckBox();
			this.logEnabledFile = new System.Windows.Forms.CheckBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.mDistanceSelector = new System.Windows.Forms.NumericUpDown();
			this.mChanceMoveSelector = new System.Windows.Forms.NumericUpDown();
			this.mChanceSwapSelector = new System.Windows.Forms.NumericUpDown();
			this.selectRoullete = new System.Windows.Forms.RadioButton();
			this.selectDemo = new System.Windows.Forms.RadioButton();
			this.crossoverSelector = new System.Windows.Forms.NumericUpDown();
			this.groupBoxMutation = new System.Windows.Forms.GroupBox();
			this.groupBoxSelection = new System.Windows.Forms.GroupBox();
			this.LoggingBox = new System.Windows.Forms.GroupBox();
			this.groupBoxPop = new System.Windows.Forms.GroupBox();
			this.popSizeSelector = new System.Windows.Forms.NumericUpDown();
			this.boardSizeSelector = new System.Windows.Forms.NumericUpDown();
			this.textCostMax = new System.Windows.Forms.Label();
			this.textCostAvg = new System.Windows.Forms.Label();
			this.textCostMin = new System.Windows.Forms.Label();
			this.groupBoxCosts = new System.Windows.Forms.GroupBox();
			this.textGenNum = new System.Windows.Forms.Label();
			this.textGenBest = new System.Windows.Forms.Label();
			this.speedSelector = new System.Windows.Forms.TrackBar();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.selectSteady = new System.Windows.Forms.RadioButton();
			this.chessBoard = new _8queen.ChessBoard();
			staticTextMDistance = new System.Windows.Forms.Label();
			staticTextMChanceSwap = new System.Windows.Forms.Label();
			staticTextMChanceMove = new System.Windows.Forms.Label();
			staticTextCrossover = new System.Windows.Forms.Label();
			staticTextBoardSize = new System.Windows.Forms.Label();
			staticTextPopSize = new System.Windows.Forms.Label();
			staticTextCostMin = new System.Windows.Forms.Label();
			staticTextCostAvg = new System.Windows.Forms.Label();
			staticTextCostMax = new System.Windows.Forms.Label();
			staticTextGen = new System.Windows.Forms.Label();
			staticTextBest = new System.Windows.Forms.Label();
			staticTextSpeed = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.mDistanceSelector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mChanceMoveSelector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mChanceSwapSelector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.crossoverSelector)).BeginInit();
			this.groupBoxMutation.SuspendLayout();
			this.groupBoxSelection.SuspendLayout();
			this.LoggingBox.SuspendLayout();
			this.groupBoxPop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.popSizeSelector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.boardSizeSelector)).BeginInit();
			this.groupBoxCosts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.speedSelector)).BeginInit();
			this.SuspendLayout();
			// 
			// staticTextMDistance
			// 
			staticTextMDistance.AutoSize = true;
			staticTextMDistance.Location = new System.Drawing.Point(20, 58);
			staticTextMDistance.Name = "staticTextMDistance";
			staticTextMDistance.Size = new System.Drawing.Size(93, 13);
			staticTextMDistance.TabIndex = 2;
			staticTextMDistance.Text = "Mutation Distance";
			// 
			// staticTextMChanceSwap
			// 
			staticTextMChanceSwap.AutoSize = true;
			staticTextMChanceSwap.Location = new System.Drawing.Point(20, 118);
			staticTextMChanceSwap.Name = "staticTextMChanceSwap";
			staticTextMChanceSwap.Size = new System.Drawing.Size(91, 13);
			staticTextMChanceSwap.TabIndex = 6;
			staticTextMChanceSwap.Text = "Swap Chance (%)";
			// 
			// staticTextMChanceMove
			// 
			staticTextMChanceMove.AutoSize = true;
			staticTextMChanceMove.Location = new System.Drawing.Point(20, 90);
			staticTextMChanceMove.Name = "staticTextMChanceMove";
			staticTextMChanceMove.Size = new System.Drawing.Size(91, 13);
			staticTextMChanceMove.TabIndex = 4;
			staticTextMChanceMove.Text = "Move Chance (%)";
			// 
			// staticTextCrossover
			// 
			staticTextCrossover.AutoSize = true;
			staticTextCrossover.Location = new System.Drawing.Point(18, 30);
			staticTextCrossover.Name = "staticTextCrossover";
			staticTextCrossover.Size = new System.Drawing.Size(59, 13);
			staticTextCrossover.TabIndex = 0;
			staticTextCrossover.Text = "Crossovers";
			// 
			// staticTextBoardSize
			// 
			staticTextBoardSize.AutoSize = true;
			staticTextBoardSize.Location = new System.Drawing.Point(18, 32);
			staticTextBoardSize.Name = "staticTextBoardSize";
			staticTextBoardSize.Size = new System.Drawing.Size(58, 13);
			staticTextBoardSize.TabIndex = 0;
			staticTextBoardSize.Text = "Board Size";
			// 
			// staticTextPopSize
			// 
			staticTextPopSize.AutoSize = true;
			staticTextPopSize.Location = new System.Drawing.Point(18, 63);
			staticTextPopSize.Name = "staticTextPopSize";
			staticTextPopSize.Size = new System.Drawing.Size(80, 13);
			staticTextPopSize.TabIndex = 2;
			staticTextPopSize.Text = "Population Size";
			// 
			// staticTextCostMin
			// 
			staticTextCostMin.AutoSize = true;
			staticTextCostMin.Location = new System.Drawing.Point(11, 24);
			staticTextCostMin.Name = "staticTextCostMin";
			staticTextCostMin.Size = new System.Drawing.Size(28, 13);
			staticTextCostMin.TabIndex = 0;
			staticTextCostMin.Text = "Best";
			// 
			// staticTextCostAvg
			// 
			staticTextCostAvg.AutoSize = true;
			staticTextCostAvg.Location = new System.Drawing.Point(11, 48);
			staticTextCostAvg.Name = "staticTextCostAvg";
			staticTextCostAvg.Size = new System.Drawing.Size(26, 13);
			staticTextCostAvg.TabIndex = 2;
			staticTextCostAvg.Text = "Avg";
			// 
			// staticTextCostMax
			// 
			staticTextCostMax.AutoSize = true;
			staticTextCostMax.Location = new System.Drawing.Point(11, 78);
			staticTextCostMax.Name = "staticTextCostMax";
			staticTextCostMax.Size = new System.Drawing.Size(35, 13);
			staticTextCostMax.TabIndex = 4;
			staticTextCostMax.Text = "Worst";
			// 
			// staticTextGen
			// 
			staticTextGen.AutoSize = true;
			staticTextGen.Location = new System.Drawing.Point(13, 13);
			staticTextGen.Name = "staticTextGen";
			staticTextGen.Size = new System.Drawing.Size(30, 13);
			staticTextGen.TabIndex = 0;
			staticTextGen.Text = "Gen:";
			// 
			// staticTextBest
			// 
			staticTextBest.AutoSize = true;
			staticTextBest.Location = new System.Drawing.Point(104, 13);
			staticTextBest.Name = "staticTextBest";
			staticTextBest.Size = new System.Drawing.Size(72, 13);
			staticTextBest.TabIndex = 2;
			staticTextBest.Text = "Best Solution:";
			// 
			// staticTextSpeed
			// 
			staticTextSpeed.AutoSize = true;
			staticTextSpeed.Location = new System.Drawing.Point(521, 156);
			staticTextSpeed.Name = "staticTextSpeed";
			staticTextSpeed.Size = new System.Drawing.Size(92, 13);
			staticTextSpeed.TabIndex = 7;
			staticTextSpeed.Text = "Simulation Speed:";
			// 
			// logEnabledConsole
			// 
			this.logEnabledConsole.AutoSize = true;
			this.logEnabledConsole.Checked = true;
			this.logEnabledConsole.CheckState = System.Windows.Forms.CheckState.Checked;
			this.logEnabledConsole.Location = new System.Drawing.Point(21, 20);
			this.logEnabledConsole.Name = "logEnabledConsole";
			this.logEnabledConsole.Size = new System.Drawing.Size(64, 17);
			this.logEnabledConsole.TabIndex = 0;
			this.logEnabledConsole.Text = "Console";
			this.logEnabledConsole.UseVisualStyleBackColor = true;
			this.logEnabledConsole.CheckedChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// logEnabledFile
			// 
			this.logEnabledFile.AutoSize = true;
			this.logEnabledFile.Location = new System.Drawing.Point(108, 21);
			this.logEnabledFile.Name = "logEnabledFile";
			this.logEnabledFile.Size = new System.Drawing.Size(42, 17);
			this.logEnabledFile.TabIndex = 1;
			this.logEnabledFile.Text = "File";
			this.logEnabledFile.UseVisualStyleBackColor = true;
			this.logEnabledFile.CheckedChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(12, 522);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(146, 23);
			this.buttonStart.TabIndex = 5;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// mDistanceSelector
			// 
			this.mDistanceSelector.Location = new System.Drawing.Point(149, 58);
			this.mDistanceSelector.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.mDistanceSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.mDistanceSelector.Name = "mDistanceSelector";
			this.mDistanceSelector.Size = new System.Drawing.Size(120, 20);
			this.mDistanceSelector.TabIndex = 3;
			this.mDistanceSelector.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.mDistanceSelector.ValueChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// mChanceMoveSelector
			// 
			this.mChanceMoveSelector.DecimalPlaces = 2;
			this.mChanceMoveSelector.Location = new System.Drawing.Point(149, 90);
			this.mChanceMoveSelector.Name = "mChanceMoveSelector";
			this.mChanceMoveSelector.Size = new System.Drawing.Size(120, 20);
			this.mChanceMoveSelector.TabIndex = 5;
			this.mChanceMoveSelector.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.mChanceMoveSelector.ValueChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// mChanceSwapSelector
			// 
			this.mChanceSwapSelector.DecimalPlaces = 2;
			this.mChanceSwapSelector.Location = new System.Drawing.Point(149, 118);
			this.mChanceSwapSelector.Name = "mChanceSwapSelector";
			this.mChanceSwapSelector.Size = new System.Drawing.Size(120, 20);
			this.mChanceSwapSelector.TabIndex = 7;
			this.mChanceSwapSelector.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.mChanceSwapSelector.ValueChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// selectRoullete
			// 
			this.selectRoullete.AutoSize = true;
			this.selectRoullete.Checked = true;
			this.selectRoullete.Location = new System.Drawing.Point(31, 19);
			this.selectRoullete.Name = "selectRoullete";
			this.selectRoullete.Size = new System.Drawing.Size(64, 17);
			this.selectRoullete.TabIndex = 0;
			this.selectRoullete.TabStop = true;
			this.selectRoullete.Text = "Roullete";
			this.selectRoullete.UseVisualStyleBackColor = true;
			this.selectRoullete.CheckedChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// selectDemo
			// 
			this.selectDemo.AutoSize = true;
			this.selectDemo.Location = new System.Drawing.Point(32, 42);
			this.selectDemo.Name = "selectDemo";
			this.selectDemo.Size = new System.Drawing.Size(53, 17);
			this.selectDemo.TabIndex = 1;
			this.selectDemo.Text = "Demo";
			this.selectDemo.UseVisualStyleBackColor = true;
			this.selectDemo.CheckedChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// crossoverSelector
			// 
			this.crossoverSelector.Location = new System.Drawing.Point(147, 30);
			this.crossoverSelector.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.crossoverSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.crossoverSelector.Name = "crossoverSelector";
			this.crossoverSelector.Size = new System.Drawing.Size(120, 20);
			this.crossoverSelector.TabIndex = 1;
			this.crossoverSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.crossoverSelector.ValueChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// groupBoxMutation
			// 
			this.groupBoxMutation.Controls.Add(this.mChanceMoveSelector);
			this.groupBoxMutation.Controls.Add(staticTextCrossover);
			this.groupBoxMutation.Controls.Add(this.mDistanceSelector);
			this.groupBoxMutation.Controls.Add(this.crossoverSelector);
			this.groupBoxMutation.Controls.Add(staticTextMDistance);
			this.groupBoxMutation.Controls.Add(this.mChanceSwapSelector);
			this.groupBoxMutation.Controls.Add(staticTextMChanceSwap);
			this.groupBoxMutation.Controls.Add(staticTextMChanceMove);
			this.groupBoxMutation.Location = new System.Drawing.Point(699, 121);
			this.groupBoxMutation.Name = "groupBoxMutation";
			this.groupBoxMutation.Size = new System.Drawing.Size(284, 164);
			this.groupBoxMutation.TabIndex = 10;
			this.groupBoxMutation.TabStop = false;
			this.groupBoxMutation.Text = "Mutation Settings";
			// 
			// groupBoxSelection
			// 
			this.groupBoxSelection.Controls.Add(this.selectSteady);
			this.groupBoxSelection.Controls.Add(this.selectRoullete);
			this.groupBoxSelection.Controls.Add(this.selectDemo);
			this.groupBoxSelection.Location = new System.Drawing.Point(699, 291);
			this.groupBoxSelection.Name = "groupBoxSelection";
			this.groupBoxSelection.Size = new System.Drawing.Size(183, 100);
			this.groupBoxSelection.TabIndex = 11;
			this.groupBoxSelection.TabStop = false;
			this.groupBoxSelection.Text = "Selection Method";
			// 
			// LoggingBox
			// 
			this.LoggingBox.Controls.Add(this.logEnabledConsole);
			this.LoggingBox.Controls.Add(this.logEnabledFile);
			this.LoggingBox.Location = new System.Drawing.Point(699, 397);
			this.LoggingBox.Name = "LoggingBox";
			this.LoggingBox.Size = new System.Drawing.Size(200, 58);
			this.LoggingBox.TabIndex = 12;
			this.LoggingBox.TabStop = false;
			this.LoggingBox.Text = "Logging";
			// 
			// groupBoxPop
			// 
			this.groupBoxPop.Controls.Add(staticTextPopSize);
			this.groupBoxPop.Controls.Add(staticTextBoardSize);
			this.groupBoxPop.Controls.Add(this.popSizeSelector);
			this.groupBoxPop.Controls.Add(this.boardSizeSelector);
			this.groupBoxPop.Location = new System.Drawing.Point(699, 12);
			this.groupBoxPop.Name = "groupBoxPop";
			this.groupBoxPop.Size = new System.Drawing.Size(284, 103);
			this.groupBoxPop.TabIndex = 9;
			this.groupBoxPop.TabStop = false;
			this.groupBoxPop.Text = "Population Settings";
			// 
			// popSizeSelector
			// 
			this.popSizeSelector.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.popSizeSelector.Location = new System.Drawing.Point(147, 61);
			this.popSizeSelector.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.popSizeSelector.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.popSizeSelector.Name = "popSizeSelector";
			this.popSizeSelector.Size = new System.Drawing.Size(120, 20);
			this.popSizeSelector.TabIndex = 3;
			this.popSizeSelector.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// boardSizeSelector
			// 
			this.boardSizeSelector.Location = new System.Drawing.Point(147, 32);
			this.boardSizeSelector.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.boardSizeSelector.Name = "boardSizeSelector";
			this.boardSizeSelector.Size = new System.Drawing.Size(120, 20);
			this.boardSizeSelector.TabIndex = 1;
			this.boardSizeSelector.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.boardSizeSelector.ValueChanged += new System.EventHandler(this.GenomeSizeChanged);
			// 
			// textCostMax
			// 
			this.textCostMax.AutoSize = true;
			this.textCostMax.Location = new System.Drawing.Point(63, 78);
			this.textCostMax.Name = "textCostMax";
			this.textCostMax.Size = new System.Drawing.Size(41, 13);
			this.textCostMax.TabIndex = 5;
			this.textCostMax.Text = "label10";
			// 
			// textCostAvg
			// 
			this.textCostAvg.AutoSize = true;
			this.textCostAvg.Location = new System.Drawing.Point(63, 48);
			this.textCostAvg.Name = "textCostAvg";
			this.textCostAvg.Size = new System.Drawing.Size(41, 13);
			this.textCostAvg.TabIndex = 3;
			this.textCostAvg.Text = "label11";
			// 
			// textCostMin
			// 
			this.textCostMin.AutoSize = true;
			this.textCostMin.Location = new System.Drawing.Point(63, 24);
			this.textCostMin.Name = "textCostMin";
			this.textCostMin.Size = new System.Drawing.Size(41, 13);
			this.textCostMin.TabIndex = 1;
			this.textCostMin.Text = "label12";
			// 
			// groupBoxCosts
			// 
			this.groupBoxCosts.Controls.Add(this.textCostMax);
			this.groupBoxCosts.Controls.Add(this.textCostAvg);
			this.groupBoxCosts.Controls.Add(this.textCostMin);
			this.groupBoxCosts.Controls.Add(staticTextCostMax);
			this.groupBoxCosts.Controls.Add(staticTextCostAvg);
			this.groupBoxCosts.Controls.Add(staticTextCostMin);
			this.groupBoxCosts.Location = new System.Drawing.Point(524, 12);
			this.groupBoxCosts.Name = "groupBoxCosts";
			this.groupBoxCosts.Size = new System.Drawing.Size(129, 117);
			this.groupBoxCosts.TabIndex = 6;
			this.groupBoxCosts.TabStop = false;
			this.groupBoxCosts.Text = "Costs";
			// 
			// textGenNum
			// 
			this.textGenNum.AutoSize = true;
			this.textGenNum.Location = new System.Drawing.Point(48, 13);
			this.textGenNum.Name = "textGenNum";
			this.textGenNum.Size = new System.Drawing.Size(34, 13);
			this.textGenNum.TabIndex = 1;
			this.textGenNum.Text = "Temp";
			// 
			// textGenBest
			// 
			this.textGenBest.AutoSize = true;
			this.textGenBest.Location = new System.Drawing.Point(194, 13);
			this.textGenBest.Name = "textGenBest";
			this.textGenBest.Size = new System.Drawing.Size(41, 13);
			this.textGenBest.TabIndex = 3;
			this.textGenBest.Text = "label16";
			// 
			// speedSelector
			// 
			this.speedSelector.LargeChange = 1;
			this.speedSelector.Location = new System.Drawing.Point(524, 179);
			this.speedSelector.Maximum = 9;
			this.speedSelector.Name = "speedSelector";
			this.speedSelector.Size = new System.Drawing.Size(129, 45);
			this.speedSelector.TabIndex = 8;
			this.speedSelector.Value = 7;
			this.speedSelector.ValueChanged += new System.EventHandler(this.speedSelector_ValueChanged);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Location = new System.Drawing.Point(164, 522);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(146, 23);
			this.buttonCancel.TabIndex = 13;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// selectSteady
			// 
			this.selectSteady.AutoSize = true;
			this.selectSteady.Location = new System.Drawing.Point(32, 65);
			this.selectSteady.Name = "selectSteady";
			this.selectSteady.Size = new System.Drawing.Size(58, 17);
			this.selectSteady.TabIndex = 2;
			this.selectSteady.Text = "Steady";
			this.selectSteady.UseVisualStyleBackColor = true;
			this.selectSteady.CheckedChanged += new System.EventHandler(this.SettingsChanged);
			// 
			// chessBoard
			// 
			this.chessBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.chessBoard.Location = new System.Drawing.Point(12, 36);
			this.chessBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chessBoard.Name = "chessBoard";
			this.chessBoard.Size = new System.Drawing.Size(480, 480);
			this.chessBoard.TabIndex = 4;
			// 
			// UI
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(998, 550);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(staticTextSpeed);
			this.Controls.Add(this.speedSelector);
			this.Controls.Add(this.textGenBest);
			this.Controls.Add(staticTextBest);
			this.Controls.Add(this.textGenNum);
			this.Controls.Add(staticTextGen);
			this.Controls.Add(this.chessBoard);
			this.Controls.Add(this.groupBoxCosts);
			this.Controls.Add(this.groupBoxPop);
			this.Controls.Add(this.LoggingBox);
			this.Controls.Add(this.groupBoxSelection);
			this.Controls.Add(this.groupBoxMutation);
			this.Controls.Add(this.buttonStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "UI";
			this.Text = "N-Queens GA Solver";
			((System.ComponentModel.ISupportInitialize)(this.mDistanceSelector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mChanceMoveSelector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mChanceSwapSelector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.crossoverSelector)).EndInit();
			this.groupBoxMutation.ResumeLayout(false);
			this.groupBoxMutation.PerformLayout();
			this.groupBoxSelection.ResumeLayout(false);
			this.groupBoxSelection.PerformLayout();
			this.LoggingBox.ResumeLayout(false);
			this.LoggingBox.PerformLayout();
			this.groupBoxPop.ResumeLayout(false);
			this.groupBoxPop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.popSizeSelector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.boardSizeSelector)).EndInit();
			this.groupBoxCosts.ResumeLayout(false);
			this.groupBoxCosts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.speedSelector)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox logEnabledConsole;
		private System.Windows.Forms.CheckBox logEnabledFile;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.NumericUpDown mDistanceSelector;
		private System.Windows.Forms.NumericUpDown mChanceMoveSelector;
		private System.Windows.Forms.NumericUpDown mChanceSwapSelector;
		private System.Windows.Forms.RadioButton selectRoullete;
		private System.Windows.Forms.RadioButton selectDemo;
		private System.Windows.Forms.NumericUpDown crossoverSelector;
		private System.Windows.Forms.GroupBox groupBoxMutation;
		private System.Windows.Forms.GroupBox groupBoxSelection;
		private System.Windows.Forms.GroupBox LoggingBox;
		private System.Windows.Forms.GroupBox groupBoxPop;
		private System.Windows.Forms.NumericUpDown popSizeSelector;
		private System.Windows.Forms.NumericUpDown boardSizeSelector;
		private System.Windows.Forms.Label textCostMax;
		private System.Windows.Forms.Label textCostAvg;
		private System.Windows.Forms.Label textCostMin;
		private System.Windows.Forms.GroupBox groupBoxCosts;
		private ChessBoard chessBoard;
		private System.Windows.Forms.Label textGenNum;
		private System.Windows.Forms.Label textGenBest;
		private System.Windows.Forms.TrackBar speedSelector;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.RadioButton selectSteady;
	}
}