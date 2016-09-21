//AutoPath : Chores.Entities/Chore.cs
using System;
using System.Linq;
using System.Collections.Generic;

namespace Chores.Entities
{
	public partial class Chore
	{
	
		// Add your new Entity code here
		public string LastDonePersonName { get; set; }

		public string NextDuePersonName { get; set; }

		public DateTime NextDueDate { get; set; }

		public string NextDueDateString 
		{ 
			get
			{
				return NextDueDate != null && NextDueDate > DateTime.MinValue ? ((DateTime)NextDueDate).ToString("dd MMM yy") : "-";
			}
			set
			{
				if (value != "-") { NextDueDate = DateTime.Parse(value); }
			}
		}

		public bool Due {get;set;}


	}
}
	