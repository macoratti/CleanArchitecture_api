namespace CleanArchitecture.Application.UseCases.CreateUser;

public sealed record CreateUserResponse
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
}
