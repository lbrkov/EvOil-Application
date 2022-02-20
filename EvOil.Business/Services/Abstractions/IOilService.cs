using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EvOil.Business.DataTransferObjects;
using EvOil.Domain.Models;

namespace EvOil.Business.Services.Abstractions;

public interface IOilService
{
    public Task SetOil(OilDto oilDto, CancellationToken cancellationToken);
    public Task<ICollection<Oil>> GetOils(CancellationToken cancellationToken);

}
