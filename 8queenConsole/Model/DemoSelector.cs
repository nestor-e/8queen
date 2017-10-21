using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model
{
	class DemoSelector : ISelector{
		private List<Arrangement> items;
		private int pairCounter;		


		public DemoSelector(List<Arrangement> data) {
			items = new List<Arrangement>(data);
			items.Sort(Arrangement.compareCosts);
			pairCounter = 0;
		}


		public List<Arrangement> GetCarryOver() {
			return items.GetRange(0, (items.Count) / 2);
		}

		public Tuple<Arrangement, Arrangement> SelectPair() {
			Arrangement p1 = items[2*pairCounter];
			Arrangement p2 = items[2*pairCounter + 1];
			pairCounter++;
			if (pairCounter >= items.Count / 4) {
				pairCounter = 0;
			}
			return new Tuple<Arrangement, Arrangement>(p1, p2);
		}
	}
}
