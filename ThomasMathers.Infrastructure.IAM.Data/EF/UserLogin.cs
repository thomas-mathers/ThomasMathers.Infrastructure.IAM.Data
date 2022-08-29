using Microsoft.AspNetCore.Identity;

namespace ThomasMathers.Infrastructure.IAM.Data.EF;

public class UserLogin : IdentityUserLogin<Guid>
{
    public DateTime Created { get; private set; } = DateTime.UtcNow;
}