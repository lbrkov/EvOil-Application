namespace EvOil.Business.Services.Implementations;

public class EvaluationService
{
    private readonly IEvOilDatabaseContext _databaseContext;

    public EvaluationService(IEvOilDatabaseContext databaseContext)
    {
        this._databaseContext = databaseContext;
    }
}