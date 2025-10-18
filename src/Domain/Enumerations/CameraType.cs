using Domain.Common;

namespace Domain.Enumerations;

public sealed class CameraType(int id, string name) : EnumerationBase(id, name)
{
    public static readonly CameraType SLR = new(1, "SLR");
    public static readonly CameraType DSLR = new(2, "DSLR");
    public static readonly CameraType Mirrorless = new(3, "Mirrorless");
    public static readonly CameraType Phone = new(4, "Phone");
    public static readonly CameraType PointAndShoot = new(5, "Point and Shoot");

    public static IEnumerable<CameraType> List() => [SLR, DSLR, Mirrorless, Phone, PointAndShoot];

    public static CameraType FromId(int id) =>
        List().FirstOrDefault(c => c.Id == id) ?? throw new ArgumentNullException(nameof(id));

    public static CameraType FromName(string name) =>
        List().FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
        throw new ArgumentNullException($"Invalid name:{name}");
}
