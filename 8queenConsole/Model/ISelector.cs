using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queen.Model
{
	interface ISelector{
		List<Arrangement> GetCarryOver();
		Tuple<Arrangement, Arrangement> SelectPair();
	}
}
