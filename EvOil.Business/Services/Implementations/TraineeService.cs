using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvOil.Business.Services.Implementations;

public class TraineeService
{
    private readonly IEvOilDatabaseContext _databaseContext;

    public TraineeService(IEvOilDatabaseContext databaseContext)
    {
        this._databaseContext = databaseContext;
    }
}
