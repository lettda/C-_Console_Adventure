using System;
namespace _350_final_project
{
    public class Location
    {
        public Location(string locationName, string locationDescription) 
        {
            Name = locationName;
            Description = locationDescription;
        }

        public string Name { get; set; }
        public string Description { get; set; }

		public override string ToString()
		{
            return Name;
		}
	}
}
