using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EvOil.Business.DataTransferObjects;
using EvOil.Domain.Models;

namespace EvOil.Business.Services.Abstractions;

public interface IUsersService
{
    public Task SetUser(UserDto userDto, CancellationToken cancellationToken);
    public Task<User> GetUserById(int id, CancellationToken cancellationToken);
    public Task<ICollection<User>> GetUsers(CancellationToken cancellationToken);
    public Task RemoveUser(string username, CancellationToken cancellationToken);

}
