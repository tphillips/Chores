//AutoPath : Chores.DAL/PersonDAL.cs
using System;
using System.Linq;
using System.Collections.Generic;
using Chores.Entities;

namespace Chores.DAL
{
	public partial class PersonDAL
	{
	
		// Insert your additonal DAL code here
		
		public Person Get(int personId)
		{
			Person ret = _Get(personId);
			// Add any mods here
			return ret;
		}
		
		public List<Person> List()
		{
			return _List();
		}

		public int Save(Person entity)
		{
			return _Save(entity);
		}
		
		private bool RecordExists(int id)
		{
			return _RecordExists(id);	
		}

		public int Create(Person entity)
		{
			return _Create(entity);
		}
		
		public int Update(Person entity)
		{
			return _Update(entity);
		}
		
		public void Delete(int id)
		{
			_Delete(id);
		}
	
	}
	
}
	