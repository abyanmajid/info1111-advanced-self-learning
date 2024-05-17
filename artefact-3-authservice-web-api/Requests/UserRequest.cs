namespace AuthService.Requests;

public class CreateUserRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
}

public class UserResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}
