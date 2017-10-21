using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8queen
{
	public partial class ChessBoard : UserControl
	{
		private int n = 8;
		private int[] curState = null;

		public ChessBoard(){
			InitializeComponent();
		}

		private void DrawChessBoard(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;
			Brush black = new SolidBrush(Color.Black);
			Brush white = new SolidBrush(Color.White);
			Brush red = new SolidBrush(Color.Red);
			RectangleF bg = new RectangleF(0, 0, Width, Height);
			g.FillRectangle(white, bg);
			float spaceSize = bg.Width / n;
			Font f = new Font(FontFamily.GenericMonospace, (float)0.8 * spaceSize);
			StringFormat center = new StringFormat();
			center.Alignment = StringAlignment.Center;
			center.LineAlignment = StringAlignment.Center;
			RectangleF r;
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < n; j++) {
					r = new RectangleF(i * spaceSize, j * spaceSize, spaceSize, spaceSize);
					if ((i + j) % 2 == 1) {
						g.FillRectangle(black, r);
					}
					if (curState != null && curState[i] == j) {
						g.DrawString("Q", f, red, r, center);
					}
				}
			}
			black.Dispose();
			white.Dispose();
			red.Dispose();
		}

		public void SetState(String positionString){
			char[] delim = { ',' };
			char[] trims = { ' ', '{' , '}'};
			positionString = positionString.Trim(trims);
			String[] posStrings = positionString.Split(delim);
			int[] positions = new int[posStrings.Length];
			try {
				for (int i = 1; i < posStrings.Length; i++) {
					positions[i] = Int32.Parse(posStrings[i].Trim());
				}
			} catch (Exception ex) {
				if (ex is ArgumentException || ex is OverflowException) {
					curState = null;
					Invalidate();
					return;
				}
				throw;
			}
			n = positions.Length;
			curState = positions;
			Invalidate();			
		}
	}
}
