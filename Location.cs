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

        public string Name { get; set; } //location name
        public string Description { get; set; } //text displayed when player comes to the lcoation

		public override string ToString()
		{
            return Name;
		}
	}
}
