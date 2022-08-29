using Microsoft.AspNetCore.Identity;

namespace ThomasMathers.Infrastructure.IAM.Data.EF;

public class User : IdentityUser<Guid>
{
    public DateTime Created { get; private set; } = DateTime.UtcNow;
    public List<SocialMediaProfile> Profiles { get; set; } = new List<SocialMediaProfile>();
}