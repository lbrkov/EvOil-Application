using EvOil.Domain.Enumerations;

namespace EvOil.Domain.Models;
public class Evaluation
{
    public Evaluation() { }
    public Evaluation(int oilId, int inflamed, int sour, int burned, int spicy, int frosted, int fruity, int bitter)
    {
        OilId = oilId;
        Inflamed = inflamed;
        Sour = sour;
        Burned = burned;
        Spicy = spicy;
        Frosted = frosted;
        Fruity = fruity;
        Bitter = bitter;
    }
    public int Id { get; set; }
    public int OilId { get; private set; }
    public int UserId { get; private set; }
    public User? Users { get; private set; }
    public Oil? Oils { get; private set; }
    public EvaluationSession? EvaluationSession { get; private set; }
    public float Inflamed { get; private set; }
    public float Moldy { get; private set; }
    public float Sour { get; private set; }
    public float Frosted { get; private set; }
    public float Burned { get; private set; }
    public float Fruity { get; private set; }
    public float Spicy { get; private set; }
    public float Bitter { get; private set; }
}