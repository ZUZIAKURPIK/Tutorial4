using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public List<Visit> Visits { get; set; } = new List<Visit>();

    public MockDb()
    {
        var animal1 = new Animal{Id = 1, Name = "Rex", Category = "Dog", Weight = 30, FurColor = "Black"}; 
        var animal2 = new Animal{Id = 2, Name = "Mia", Category = "Cat", Weight = 10, FurColor = "White"}; 
        
        Animals.Add(animal1);
        Animals.Add(animal2);
        
        Visits.Add(new Visit{VisitDate = DateTime.Now, AnimalId = animal1.Id, Description = "Regular checkup", Price = 50});
        Visits.Add(new Visit{VisitDate = DateTime.Today.AddDays(-1), AnimalId = animal2.Id, Description = "Vaccination", Price = 70});
    }
}