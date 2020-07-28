namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime Admittance { get; set; }
    public string Breed { get; set; }
    public int TypeId { get; set; }
    public virtual Type Type { get; set; }
  }
}