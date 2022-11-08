namespace AutomapperTutor.Model.Statistics;

public class Statistics
{
    public string EquipmentSN { get; set; } = string.Empty;

    public string ProductName { get; set; } = string.Empty;

    public string ProdCode { get; set; } = string.Empty;

    public double AverageTrans { get; set; }

    public double PercentTu1TotalTrans { get; set; }

    public int TransAccepted { get; set; }

    public int TransTO2 { get; set; }

    public int TransTO1 { get; set; }

    public int TransTooHeavy { get; set; }

    public int TransTooLight { get; set; }

    public double CurrentWeight { get; set; }

    public int PermanentTooLight { get; set; }

    public int PermanentAccepted { get; set; }

    public int PermanentTooHeavy { get; set; }

    public int PermanentTotal { get; set; }
}
