using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string Description { get; set; }
    public int Id { get; } // don't add set method, bc this property will be set in the constructor automatically
    // don't EVER want to manually edit it bc it might lose uniqueness
    private static List<Place> _instances = new List<Place> {};

    public Place (string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId) // our new Find()
    {
      return _instances[searchId-1];
    }

  }
}