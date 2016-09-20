//AutoPath : Chores.DAL/ChoresDB.generated.cs
using System;
using System.Collections.Generic;
using Chores.Entities;
using Newtonsoft.Json;
using System.IO;

namespace Chores.DAL
{
	public class ChoresDB
	{
	
		private static ChoresDB instance = null;

		public static ChoresDB Instance()
		{
			if (instance == null)
			{
				instance = new ChoresDB();
				instance.Load();
			}
			return instance;
		}
		
		private ChoresDB()
		{
		}
		
		public List<Chore> Chores{ get; set; }
		public List<Person> Persons{ get; set; }

		public void Save()
		{
			Console.WriteLine("Saving . . .");
			File.WriteAllText("person.json", JsonConvert.SerializeObject(Persons));
			File.WriteAllText("chore.json", JsonConvert.SerializeObject(Chores));
		}

		public List<T> LoadTable<T>()
		{
			if (File.Exists(typeof(T).Name.ToLower() + ".json")) 
			{
				return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(typeof(T).Name.ToLower() + ".json")); 
			}
			return new List<T>();
		}

		public void Load()
		{
			Console.WriteLine("Loading . . .");
			Chores = LoadTable<Chore>();
			Persons = LoadTable<Person>();
		}
	
	}
	
}
	