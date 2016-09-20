//AutoPath : Chores.BLL/PersonBLL.cs
using System;
using System.Linq;
using System.Collections.Generic;
using Chores.Entities;

namespace Chores.BLL
{
	public partial class PersonBLL
	{

		/// <summary>
		/// Gets a Person entity.
		/// </summary>
		public Person Get(int id)
		{
			Person ret = _Get(id);
			// Insert your code here
			return ret;
		}

		public int GetNextPersonID(int? id)
		{
			if (id == null) { return 1; }
			int count = List().Count();
			if ((int)id < count) { return (int)id + 1; }
			return 1;
		}

		/// <summary>
		/// Lists all Persons.
		/// </summary>
		public List<Person> List()
		{
			// Insert your code here
			return _List();
		}

		/// <summary>
		/// Creates a new Person.
		/// </summary>
		public int Create(Person e)
		{
			// Insert your code here
			return _Create(e);
		}

		/// <summary>
		/// Saves a Person. 
		/// If it already exists it will be updated, if not it will be created.
		/// </summary>
		public int Save(Person e)
		{
			// Insert your code here
			return _Save(e);
		}

		/// <summary>
		/// Saves an existing Person.
		/// </summary>
		public int Update(Person e)
		{
			// Insert your code here
			return _Update(e);
		}

		/// <summary>
		/// Deletes a Person.
		/// </summary>
		public void Delete(int id)
		{
			// Insert your code here
			_Delete(id);
		}

	}

}
	