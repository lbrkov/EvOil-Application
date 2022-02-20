using System.Threading;
using System.Collections.Generic;
using EvOil.Domain.Models;
using System.Threading.Tasks;
using EvOil.Business.DataTransferObjects;
using EvOil.Business.Exceptions;
using Microsoft.EntityFrameworkCore;
using EvOil.Business.Services.Abstractions;

namespace EvOil.Business.Services.Implementations;

public class OilService : IOilService
{
    private readonly IEvOilDatabaseContext _databaseContext;

    public OilService(IEvOilDatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;

    }

    public async Task SetOil(OilDto oilDto, CancellationToken cancellationToken)
    {
        if (oilDto.CodeName == null)
        {
            throw new OilNotFound($"Oil with codename:{oilDto.CodeName} is not found");
        }
        var oil = new Oil(
            codeName: oilDto.CodeName,
            fullName: oilDto.FullName
        );
        _databaseContext.Oils.Add(oil);
        await _databaseContext.SaveChangesAsync(cancellationToken);
    }
    public async Task<ICollection<Oil>> GetOils(CancellationToken cancellationToken)
    {
        var oils = await _databaseContext.Oils.ToListAsync(cancellationToken);
        return oils;

    }

}
