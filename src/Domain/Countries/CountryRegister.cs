namespace Domain.Countries;

public class CountryRegister(IEnumerable<Country> countries) : ICountryRegister
{
    private readonly Dictionary<int, Country> _countries = countries.ToDictionary(c => c.Id);

    public Country GetById(int id) =>
        _countries.TryGetValue(id, out Country? country) ? country
            : throw new KeyNotFoundException($"Country with ID {id} not found.");

    public IReadOnlyList<Country> GetAll() => _countries.Values.ToList();
}
