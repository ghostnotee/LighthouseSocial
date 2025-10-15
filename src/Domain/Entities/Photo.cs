using Domain.Common;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Photo : EntityBase
{
    public Guid UserId { get; private set; }
    public Guid LighthouseId { get; private set; }
    public string FileName { get; private set; }
    public DateTime UploadDate { get; private set; }
    public PhotoMetadata Metadata { get; private set; }
    public List<Comment> Comments { get; } = [];

    protected Photo() { }

    public Photo(Guid userId, Guid lighthouseId, string fileName, PhotoMetadata metadata)
    {
        UserId = userId;
        LighthouseId = lighthouseId;
        FileName = fileName;
        Metadata = metadata;
        UploadDate = DateTime.UtcNow;
    }
}
