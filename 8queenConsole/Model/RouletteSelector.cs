using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model
{
	class RouletteSelector : ISelector{
		private List<Arrangement> items;
		private int[] roulette;
		private int rSize;
		public RouletteSelector(List<Arrangement> data) {
			items = new List<Arrangement>(data);
			items.Sort(Arrangement.compareCosts);
			GenerateRoulette();
		}

		private void GenerateRoulette() {
			int worstScore = items.Last().Cost();
			rSize = 0;
			foreach(Arrangement a in items){
				rSize += worstScore / a.Cost();
			}
			roulette = new int[rSize];
			int i = 0;
			for (int j = 0; j < items.Count; j++) {
				int slots = worstScore / items[j].Cost();
				for (int k = 0; k < slots; k++) {
					roulette[i] = j;
					i++;
				}
			}
		}

		public List<Arrangement> GetCarryOver() {
			List<Arrangement> carry = new List<Arrangement>(1);
			carry.Add(items.First());
			return carry;
		}

		public Tuple<Arrangement, Arrangement> SelectPair() {
			Arrangement p1 = items[roulette[Program.rng.Next() % rSize]];
			Arrangement p2 = items[roulette[Program.rng.Next() % rSize]];
			return new Tuple<Arrangement, Arrangement>(p1, p2);
		}
	}
}
