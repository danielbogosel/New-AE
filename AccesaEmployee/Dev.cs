using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AccesaEmployee
{
    [DataContract]
    public class Dev:Employee
	{
        [DataMember] private readonly List<string> _technologyStack = new List<string>();

        [DataMember] public List<string> TechnologyStack => _technologyStack;

        public Dev(string name, float capacity) 
			: base(name, EmployeePosition.DEV, capacity)
		{
		}

		public override void DisplayInfo()
		{
			base.DisplayInfo();
			var sb = new StringBuilder();
			_technologyStack.ForEach(x => sb.Append(x + ", "));
			Console.WriteLine("Technology stack: \r\n {0}", sb);
		}
	}
}
