using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvOil.Domain.Models;
using EvOil.Business.DataTransferObjects;

namespace EvOil.Business.Services.Implementations;

public class OrganizerService
{
    private readonly IEvOilDatabaseContext _databaseContext;

    public OrganizerService(IEvOilDatabaseContext databaseContext)
    {
        this._databaseContext = databaseContext;
    }

}
