using MediatR;

namespace CleanArchitecture.Application.UseCases.CreateUser
{
    public sealed record CreateUserRequest(string Email, string Name) :
                                      IRequest<CreateUserResponse>;

}
