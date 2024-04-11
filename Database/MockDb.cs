using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDb
{
    public List<Animal> animals { get; set; } = new List<Animal>();

    public MockDb()
    {
        animals.Add(new Animal());
        animals.Add(new Animal());
        animals.Add(new Animal());
        animals.Add(new Animal());
        animals.Add(new Animal());
    }
}