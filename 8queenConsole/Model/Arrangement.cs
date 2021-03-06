﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model
{
	class Arrangement
	{
		private int[] rowPositions;
		public int Size { get; private set; }
		private int _cost = -1;
		
		public Arrangement(int size) {
			this.Size = size;
			rowPositions = new int[Size];
			for (int i = 0; i < Size; i++) {
				rowPositions[i] = i;
			}
			for (int i = 0; i < Size - 1; i++) {
				int k = i + (Program.rng.Next() % (Size - i - 1)); //  Pick an element from i to size - 1
				int temp = rowPositions[k];
				rowPositions[k] = rowPositions[i];
				rowPositions[i] = temp;
			}
		}

		public Arrangement(Arrangement p1, Arrangement p2, bool[] mask) {
			this.Size = p1.Size;
			if (p2.Size != Size || mask.Length != Size) {
				Console.WriteLine("Size Error");
				Environment.Exit(1);
			}
			rowPositions = new int[Size];
			List<int> duplicateRows = new List<int>();
			bool[] used = new bool[Size];
			for (int i = 0; i < Size; i++) {
				used[i] = false;
			}
			for (int i = 0; i < Size; i++) {
				int col = (mask[i]) ? p1.rowPositions[i] : p2.rowPositions[i];
				if (used[col]) {
					duplicateRows.Add(i);
				} else {
					used[col] = true;
					rowPositions[i] = col;
				}
			}
			for (int i = 0; i < Size; i++) {
				if (!used[i]) {
					int k = Program.rng.Next() % duplicateRows.Count;
					rowPositions[duplicateRows[k]] = i;
					duplicateRows.RemoveAt(k); 
				}
			}


		}

		private int positiveModulusSize(int n) {
			int t = n % Size;
			return (t < 0) ? (t + Size) : (t);
		}

		//  Basic opperations on chromosomes 
		public void Shift(int offset) {
			int[] temp = new int[Size];
			for (int i = 0 ; i < Size; i++) {
				int oIdx = positiveModulusSize(i + offset);
				temp[i] = rowPositions[oIdx];
			 }
			rowPositions = temp;
			_cost = -1;
		}

		public void RowSwap(int r1, int r2) {
			r1 = positiveModulusSize(r1);
			r2 = positiveModulusSize(r2);
			int temp = rowPositions[r1];
			rowPositions[r1] = rowPositions[r2];
			rowPositions[r2] = temp;
			_cost = -1;
		}

		public void Reverse(int r1, int r2) {
			r1 = positiveModulusSize(r1);
			r2 = positiveModulusSize(r2);			
			if (r1 > r2) {
				int temp = r2;
				r2 = r1;
				r1 = temp;
			}

			int dist = (r2 - r1) / 2;

			for (int i = 0; i <= dist; i++) {
				int temp = rowPositions[r1 + i];
				rowPositions[r1 + i] = rowPositions[r2 - i];
				rowPositions[r2 - i] = temp;
			}
			_cost = -1;
		}


		public int Cost()
		{
			if (_cost < 0)
			{
				int totalCost = 0;
				for (int r = 0; r < Size; r++)
				{
					int c = rowPositions[r];
					// Check Verticaly
					for (int i = 0; i < Size; i++)
					{
						if (i != r && rowPositions[i] == c)
							totalCost++;
					}

					// Check Diagonals
					for (int scanRow = 0; scanRow < Size; scanRow++)
					{
						int d = Math.Abs(scanRow - r);
						if (d != 0)
						{
							if (rowPositions[scanRow] == c - d) totalCost++;
							if (rowPositions[scanRow] == c + d) totalCost++;
						}
					}
				}
				_cost = totalCost/2;
			}
			return _cost;
		}

		public static int compareCosts(Arrangement a1, Arrangement a2) {
			if (a1 == null){
				if (a2 == null){
					return 0;
				} else {
					return -1;
				}
			} else {
				if (a2 == null) {
					return 1;
				}
				return a1.Cost() - a2.Cost();
			}
		}

		override public string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.Append("{ ");
			sb.Append(rowPositions[0]);
			for (int i = 1; i < rowPositions.Length; i++) {
				sb.Append(" , ");
				sb.Append(rowPositions[i]);
			}
			sb.Append("}");
			return sb.ToString();
		}
	}
}
