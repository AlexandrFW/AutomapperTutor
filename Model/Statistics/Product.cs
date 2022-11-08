namespace AutomapperTutor.Model.Statistics;

public class Product
{
    public string ProdCode { get; set; } = string.Empty;

    public string ProductName { get; set; } = string.Empty;

    public int Performance { get; set; } = 30;

    public int Length { get; set; } = 20;

    public double CorrFactor { get; set; } = 0.000;

    public double Nominal { get; set; }

    public double TU { get; set; }

    public double TO { get; set; }

    public double Tara { get; set; }
}
