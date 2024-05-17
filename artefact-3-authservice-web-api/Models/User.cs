using Postgrest.Models;
using Postgrest.Attributes;

namespace AuthService.Models;

[Table("users")]
public class User : BaseModel
{
    [PrimaryKey("id", false)]
    public string Id { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("password")]
    public string Password { get; set; }

    [Column("created_at")]
    public DateTimeOffset CreatedAt { get; set; }
}
