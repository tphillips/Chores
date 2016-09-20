//AutoPath : Chores.BLL/ChoreBLL.cs
using System;
using System.Linq;
using System.Collections.Generic;
using Chores.Entities;

namespace Chores.BLL
{
	public partial class ChoreBLL
	{

		/// <summary>
		/// Gets a Chore entity.
		/// </summary>
		public Chore Get(int id)
		{
			Chore ret = _Get(id);
			if (ret == null) { return null; }
			PersonBLL pbll = new PersonBLL();
			if (ret.LastDonePersonID != null)
			{
				ret.LastDonePersonName = pbll.Get((int)ret.LastDonePersonID).Name;
			}
			if (ret.LastDoneDate != null)
			{
				ret.NextDueDate = ((DateTime)ret.LastDoneDate).AddDays(ret.Frequency);
				ret.Due = ((DateTime)ret.LastDoneDate) <= DateTime.Now.AddDays(ret.Frequency * -1);
			}
			if (ret.LastDonePersonID != null)
			{
				ret.LastDonePersonName = pbll.Get((int)ret.LastDonePersonID).Name;
			}
			ret.NextDuePersonName = pbll.Get(pbll.GetNextPersonID((int)ret.LastDonePersonID)).Name;
			return ret;
		}

		/// <summary>
		/// Lists all DUE Chores.
		/// </summary>
		public List<Chore> ListDue()
		{
			List<Chore> all = _List();
			List<Chore> due = (from Chore c in all 
				where c.LastDoneDate == null || 
					c.LastDoneDate <= DateTime.Now.AddDays(c.Frequency * -1) 
				select c).ToList();
			ProcessList(due);
			// Insert your code here
			return due;
		}

		/// <summary>
		/// Lists all Chores.
		/// </summary>
		public List<Chore> List()
		{
			List<Chore> l = _List();
			ProcessList(l);
			// Insert your code here
			return l;
		}

		private void ProcessList(List<Chore> l)
		{
			for (int x = 0; x < l.Count; x++)
			{
				l[x] = Get(l[x].ID);
			}
		}

		/// <summary>
		/// Creates a new Chore.
		/// </summary>
		public int Create(Chore e)
		{
			// Insert your code here
			return _Create(e);
		}

		/// <summary>
		/// Saves a Chore. 
		/// If it already exists it will be updated, if not it will be created.
		/// </summary>
		public int Save(Chore e)
		{
			// Insert your code here
			return _Save(e);
		}

		/// <summary>
		/// Saves an existing Chore.
		/// </summary>
		public int Update(Chore e)
		{
			// Insert your code here
			return _Update(e);
		}

		/// <summary>
		/// Deletes a Chore.
		/// </summary>
		public void Delete(int id)
		{
			// Insert your code here
			_Delete(id);
		}

	}

}
	