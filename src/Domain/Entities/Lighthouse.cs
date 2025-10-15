using Domain.ValueObjects;

namespace Domain.Entities;

public class Lighthouse
{
    public string Name { get; private set; }
    public string Country { get; private set; }
    public Coordinates Coordinates { get; private set; }
    public List<Photo> Photos { get; } = [];

    protected Lighthouse() { }

    public Lighthouse(string name, string country, Coordinates coordinates)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Country = country ?? throw new ArgumentNullException(nameof(country));
        Coordinates = coordinates;
    }
}
