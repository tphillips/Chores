//AutoPath : Chores.DAL/PersonDAL.generated.cs
/* THIS CODE WAS GENERATED BY A TOOL (Codification) */
/* DO NOT EDIT BY HAND - Instead edit the other partial class called PersonDAL */
using System;
using System.Linq;
using System.Collections.Generic;
using Chores.Entities;

namespace Chores.DAL
{
	public partial class PersonDAL
	{
	
		ChoresDB db = ChoresDB.Instance();
	
		public Person _Get(int id)
		{
			return (from e in db.Persons where e.ID == id select e).FirstOrDefault();
		}

		public List<Person> _List()
		{
			return db.Persons;
		}

		public int _Save(Person entity)
		{
			if (RecordExists(entity.ID))
			{
				return Update(entity);
			}
			else
			{
				return Create(entity);
			}
		}
		
		private bool _RecordExists(int id)
		{
			return _Get(id) != null;
		}

		public int _Create(Person entity)
		{
			entity.ID = db.Persons.Count + 1;
			db.Persons.Add(entity);
			db.Save();
			return entity.ID;
		}
		
		public int _Update(Person entity)
		{
			Person e = _Get(entity.ID);
			e.PersonID = entity.PersonID;
			e.Name = entity.Name;
			
			db.Save();
			return e.ID;
		}
		
		public void _Delete(int id)
		{
			Person e = _Get(id);
			if (e != null)
			{
				db.Persons.Remove(e);
				db.Save();
			}
		}
		
	}
	
}
	