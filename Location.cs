using System;
namespace _350_final_project
{
    public class Location
    {
        public Location(int id, string locationName, string locationDescription) 
        {
            ID = id;
            Name = locationName;
            Description = locationDescription;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

		public override string ToString()
		{
            return Name;
		}
	}
}
