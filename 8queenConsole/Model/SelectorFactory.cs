using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model
{
	public class SelectorFactory{

		public enum Type { ROULETTE, DEMO, STEADY, NONE }
		private Type currentType = Type.ROULETTE;

		public String GetTypeName() {
			switch (currentType) {
				case Type.ROULETTE: return "Roulette Selector";
				case Type.DEMO: return "Demo Selector";
				case Type.STEADY: return "Steady State Selector";
				default: return "None (Default: Roulette)";
			}
		}

		internal ISelector GetSelector(List<Arrangement> data) {
			ISelector sel = null;
			switch (currentType) {
				case Type.DEMO:
					sel = (ISelector)(new DemoSelector(data));
					break;
				case Type.STEADY:
					sel = (ISelector)(new SteadySelector(data));
					break;
				case Type.ROULETTE:
				case Type.NONE:  // Default type is Roullette
					sel = (ISelector)(new RouletteSelector(data));
					break;
			}
			return sel;
		}

		internal void ChangeSettings(Type type) {
			currentType = type;
		}
	}
}
