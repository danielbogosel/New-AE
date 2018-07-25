﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AccesaEmployee
{
    [DataContract]
    public class Project
	{
        [DataMember] private readonly string _name;
        [DataMember] private readonly string _description;
        [DataMember] private DateTime _deadLine;
        [DataMember] private readonly Dictionary<Employee, float> _team = new Dictionary<Employee, float>();

		public string Name => _name;
		public string Description => _description;
		public DateTime DeadLine => _deadLine;
		public IReadOnlyDictionary<Employee, float> Team => _team;

		public Project(string name, string description, DateTime deadLine)
		{
			_name = name;
			_description = description;
			_deadLine = deadLine;
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"Project {_name} that is valid until {_deadLine.ToShortDateString()} is about {_description} and has the following team members:");
			var sb =new StringBuilder();
			foreach (var teamMember in _team)
			{
				sb.AppendLine($"{teamMember.Key.Name} with {teamMember.Value} hours");
			}

			Console.WriteLine(sb);
		}

		public void AddTeamMember(Employee employee, float capacity)
		{
			if (!_team.ContainsKey(employee))
				_team.Add(employee, capacity);
		}

		public void DeleteTeamMember(Employee employee)
		{
			if (_team.ContainsKey(employee))
				_team.Remove(employee);
		}
	}
}
