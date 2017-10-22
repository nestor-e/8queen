using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model
{
	class Population
	{
		readonly int popSize;
		private readonly int boardSize;
		private List<Arrangement> pool;

		private Population(int n, int s) {
			popSize = n;
			boardSize = s;
			pool = new List<Arrangement>(n);
		}

		public static Population GenerateRandom(int popSize, int boardSize) {
			Population p = new Population(popSize, boardSize);
			for (int i = 0; i < popSize; i++) {
				p.pool.Add(new Arrangement(boardSize));
			}
			p.pool.Sort(Arrangement.compareCosts);
			return p;
		}

		public Population Reproduce(SelectorFactory sf, GeneOperator geneOp) {
			ISelector sel = sf.GetSelector(pool);
			Population newPop = new Population(popSize, boardSize);
			List<Arrangement> survirors = sel.GetCarryOver();
			newPop.pool.AddRange(survirors);
			while (newPop.pool.Count < popSize) {
				Tuple<Arrangement, Arrangement> parents = sel.SelectPair();
				Tuple<Arrangement, Arrangement> children = geneOp.DoCrossover(parents.Item1, parents.Item2);
				geneOp.DoMutation(children.Item1);
				newPop.pool.Add(children.Item1);
				if( newPop.pool.Count < popSize){
					geneOp.DoMutation(children.Item2);
					newPop.pool.Add(children.Item2);
					newPop.pool.Sort(Arrangement.compareCosts);
				}
			}

			return newPop;
		}


		public Arrangement GetBest() { return pool.First(); }
		public Arrangement GetWorst() { return pool.Last(); }
		public double GetAvg() {
			int total = 0;
			foreach (Arrangement a in pool) {
				total += a.Cost();
			}
			return ((double)total) / popSize;
		}
	}
}
