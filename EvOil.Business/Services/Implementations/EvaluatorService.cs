using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvOil.Business.Services.Implementations;

public class EvaluatorService
{
    private readonly IEvOilDatabaseContext _databaseContext;

    public EvaluatorService(IEvOilDatabaseContext databaseContext)
    {
        this._databaseContext = databaseContext;
    }
}
