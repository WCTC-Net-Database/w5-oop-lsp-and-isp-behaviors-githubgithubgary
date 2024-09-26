using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Character : IEntity, ISwimmable
{
    public string Name { get; set; }

    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}");
    }
    public void Move()
    {
        Console.WriteLine($"{Name} moves forward.");
    }
    public void Swim()
    {
        Console.WriteLine($"{Name} swims the from crawl.");
    }
}
