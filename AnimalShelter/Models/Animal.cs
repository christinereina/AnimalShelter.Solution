using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
  }
}