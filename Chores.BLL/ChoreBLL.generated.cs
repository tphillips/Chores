//AutoPath : Chores.BLL/ChoreBLL.generated.cs
/* THIS CODE WAS GENERATED BY A TOOL (Codification) */
/* DO NOT EDIT BY HAND - Instead edit the other partial class called ChoreBLL */
using System;
using System.Linq;
using System.Collections.Generic;
using Chores.Entities;
using Chores.DAL;

namespace Chores.BLL
{
	public partial class ChoreBLL
	{
		
		internal Chore _Get(int id)
		{
			return new Chores.DAL.ChoreDAL().Get(id);
		}
		
		internal List<Chore> _List()
		{
			return new Chores.DAL.ChoreDAL().List();
		}

		internal int _Create(Chore e)
		{
			return new Chores.DAL.ChoreDAL().Create(e);
		}

		internal int _Save(Chore e)
		{
			return new Chores.DAL.ChoreDAL().Save(e);
		}

		internal int _Update(Chore e)
		{
			return new Chores.DAL.ChoreDAL().Update(e);
		}

		internal void _Delete(int id)
		{
			new Chores.DAL.ChoreDAL().Delete(id);
		}

	}

}
	