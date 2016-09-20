//AutoPath : Chores.DAL/ChoreDAL.cs
using System;
using System.Linq;
using System.Collections.Generic;
using Chores.Entities;

namespace Chores.DAL
{
	public partial class ChoreDAL
	{
	
		// Insert your additonal DAL code here
		
		public Chore Get(int choreId)
		{
			Chore ret = _Get(choreId);
			// Add any mods here
			return ret;
		}
		
		public List<Chore> List()
		{
			return _List();
		}

		public int Save(Chore entity)
		{
			return _Save(entity);
		}
		
		private bool RecordExists(int id)
		{
			return _RecordExists(id);	
		}

		public int Create(Chore entity)
		{
			return _Create(entity);
		}
		
		public int Update(Chore entity)
		{
			return _Update(entity);
		}
		
		public void Delete(int id)
		{
			_Delete(id);
		}
	
	}
	
}
	