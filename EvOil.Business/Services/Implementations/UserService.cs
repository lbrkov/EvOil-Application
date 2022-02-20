using EvOil.Business.DataTransferObjects;
using EvOil.Business.Exceptions;
using EvOil.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EvOil.Business.Services.Abstractions;

namespace EvOil.Business.Services.Implementations;

public class UserService : IUsersService
{

    private readonly IEvOilDatabaseContext _databaseContext;

    public UserService(IEvOilDatabaseContext databaseContext)
    {
        this._databaseContext = databaseContext;
    }
    public async Task SetUser(UserDto userdto, CancellationToken cancellationToken)
    {
        if (userdto.Username == null)
        {
            throw new UserNotFoundException("Competitor with the same username already exist");
        }
        var user = new User(
            name: userdto.Name,
            password: default,
            username: userdto.Username
        );
        _databaseContext.Users.Add(user);
        await _databaseContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<User> GetUserById(int id, CancellationToken cancellationToken)
    {
        var user = await _databaseContext
            .Users
            .AsNoTracking()
            .FirstOrDefaultAsync(user => user.Id == id, cancellationToken);

        return user is null ? throw new UserNotFoundException($"User with {id} was not found!") : user;

    }
    public async Task<ICollection<User>> GetUsers(CancellationToken cancellationToken)
    {
        var users = await _databaseContext.Users.ToListAsync(cancellationToken);
        return users;
    }
    public async Task RemoveUser(string username, CancellationToken cancellationToken)
    {
        var user = await _databaseContext.Users.FirstOrDefaultAsync(u => u.Username == username, cancellationToken);
        _databaseContext.Users.Remove(user);
        await _databaseContext.SaveChangesAsync(cancellationToken);
    }

}
