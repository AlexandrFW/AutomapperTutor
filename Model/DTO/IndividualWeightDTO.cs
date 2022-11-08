namespace AutomapperTutor.Model.DTO;

public class IndividualWeightDTO
{
    public DateTime CurrentDateTime { get; set; } = DateTime.Now;

    public string ProdCode { get; set; } = string.Empty;

    public string IPAddress { get; set; } = string.Empty;

    public double CurrentWeight { get; set; }
}