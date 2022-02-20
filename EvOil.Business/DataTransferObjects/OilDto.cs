namespace EvOil.Business.DataTransferObjects;

public class OilDto
{
    public OilDto(string fullName)
    {
        FullName = fullName;
    }
    public string FullName { get; set; }
    public string CodeName { get; set; }

}
