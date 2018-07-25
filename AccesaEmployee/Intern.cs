using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AccesaEmployee
{
    [DataContract]
    public class Intern:Employee
	{
        [DataMember] private string _universityName;
        [DataMember] private int _yearOfStudy;
        [DataMember] private EmployeePosition _targetPosition;

		public string UniversityName => _universityName;
		public int YearOfStudy => _yearOfStudy;
		public EmployeePosition TargetPosition => _targetPosition;
		public Intern(string name, float capacity) 
			: base(name, EmployeePosition.Intern, capacity)
		{
		}
	}
}
