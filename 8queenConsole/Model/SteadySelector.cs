using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model {
	class SteadySelector : ISelector{
		private List<Arrangement> items;
		private int pairCounter;


		public SteadySelector(List<Arrangement> data) {
			items = new List<Arrangement>(data);
			items.Sort(Arrangement.compareCosts);
			pairCounter = 0;
		}


		public List<Arrangement> GetCarryOver() {
			int cutOff = items.First().Cost() + items.Last().Cost();
			cutOff /= 2;
			List<Arrangement> survivors = new List<Arrangement>();
			int i = 0;
			while (items[i].Cost() <= cutOff) {
				survivors.Add(items[i]);
				i++;
			}
			return survivors;
		}

		public Tuple<Arrangement, Arrangement> SelectPair() {
			Arrangement p1 = items[(2 * pairCounter) % items.Count];
			Arrangement p2 = items[(2 * pairCounter + 1) % items.Count];
			pairCounter++;
			return new Tuple<Arrangement, Arrangement>(p1, p2);
		}

	}
}
