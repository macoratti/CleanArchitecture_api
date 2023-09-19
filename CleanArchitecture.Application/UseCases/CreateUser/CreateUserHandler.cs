using AutoMapper;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.UseCases.CreateUser;

public class CreateUserHandler :
       IRequestHandler<CreateUserRequest, CreateUserResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public CreateUserHandler(IUnitOfWork unitOfWork,
        IUserRepository userRepository,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<CreateUserResponse> Handle(CreateUserRequest request,
        CancellationToken cancellationToken)
    {

        var user = _mapper.Map<User>(request);

        _userRepository.Create(user);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateUserResponse>(user);
    }
}
