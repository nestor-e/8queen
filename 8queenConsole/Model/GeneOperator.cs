﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model
{
	class GeneOperator{	
		public double ChromaShiftChance { get; private set; } = 0.05;
		public double PerGeneSwapChance { get; private set; } = 0.05;
		public double PerGeneRevChance { get; private set; } = 0.05;
		public int MaxMutationDistance { get; private set; } = 4;
		public int CrossCount { get; private set; } = 1;

		private int getMutationDistance() {
			int d = (MaxMutationDistance > 1)?( (Program.rng.Next() % (MaxMutationDistance - 1)) + 1) : (1);
			return d;
		}

		private bool[] generateMask(int size) {
			bool[] res = new bool[size];
			
			List<int> crossPoints = new List<int>(CrossCount);
			for (int i = 0; i < CrossCount; i++) {
				int nextInt = Program.rng.Next() % size;
				do{
					nextInt = Program.rng.Next() % size;
				} while (crossPoints.Contains(nextInt));
				crossPoints.Add(nextInt);
			}
			crossPoints.Add(size + 1);
			crossPoints.Sort();
			bool cur = true;
			int nextPoint = crossPoints.First();
			crossPoints.RemoveAt(0);
			for (int i = 0; i < size; i++) {
				if (i == nextPoint) {
					nextPoint = crossPoints.First();
					crossPoints.RemoveAt(0);
					cur = !cur;	
				}
				res[i] = cur;
			}
			return res;
		}
		
		public Tuple<Arrangement, Arrangement> DoCrossover(Arrangement p1, Arrangement p2) {
			int size = p1.Size;
			if (p2.Size != size) {
				Console.WriteLine("Size mismatch");
				Environment.Exit(1);
			}
			bool[] mask = generateMask(size);
			Arrangement c1 = new Arrangement(p1, p2, mask);
			Arrangement c2 = new Arrangement(p2, p1, mask);
			return new Tuple<Arrangement, Arrangement>(c1, c2);
		}
		
		public void DoMutation(Arrangement a) {
			for (int i = 0; i < a.Size; i++) {
				double rollSwap = Program.rng.NextDouble();
				double rollRev = Program.rng.NextDouble();
				if (rollSwap < PerGeneSwapChance)
				{
					if (Program.rng.NextDouble() > 0.5) {
						a.RowSwap(i, i + getMutationDistance());
					} else {
						a.RowSwap(i, i - getMutationDistance());
					}
				}
				if (rollRev < PerGeneSwapChance) {
					if (Program.rng.NextDouble() > 0.5) {
						a.Reverse(i, i + getMutationDistance());
					} else {
						a.Reverse(i, i - getMutationDistance());
					}
				}
			}
			double rollShift = Program.rng.NextDouble();
			if (rollShift < ChromaShiftChance) {
				if (Program.rng.NextDouble() > 0.5) {
					a.Shift(getMutationDistance());
				} else {
					a.Shift(-getMutationDistance());
				}
			}
		}

		public void ChangeSettings(Tuple<int, int, double, double, double> settings) {  // cross, distance, mvChance, swpChance
			CrossCount = Math.Max(1, settings.Item1);
			MaxMutationDistance = Math.Max(1, settings.Item2);
			ChromaShiftChance = Math.Min(1.0, Math.Max(0.0 , settings.Item3));
			PerGeneSwapChance = Math.Min(1.0, Math.Max(0.0, settings.Item4));
			PerGeneRevChance = Math.Min(1.0, Math.Max(0.0, settings.Item5));
		}
	}
}
