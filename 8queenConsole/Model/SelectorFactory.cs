using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model
{
	public class SelectorFactory{

		public enum Type { ROULETTE, DEMO, NONE }
		private Type currentType = Type.ROULETTE;

		public String GetTypeName() {
			switch (currentType) {
				case Type.ROULETTE: return "Roulette Selector";
				case Type.DEMO: return "Demo Selector";
				default: return "None";
			}
		}

		internal ISelector GetSelector(List<Arrangement> data) {
			ISelector sel = null;
			switch (currentType) {
				case Type.ROULETTE:
					sel = (ISelector) (new RouletteSelector(data));
					break;
				case Type.DEMO:
					sel = (ISelector)(new DemoSelector(data));
					break;
			}
			return sel;
		}
	}
}
