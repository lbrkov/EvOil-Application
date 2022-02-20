namespace EvOil.Business.Services.Implementations;

public class EvaluationSessionService
{
    private readonly IEvOilDatabaseContext _databaseContext;

    public EvaluationSessionService(IEvOilDatabaseContext databaseContext)
    {
        this._databaseContext = databaseContext;
    }

}
