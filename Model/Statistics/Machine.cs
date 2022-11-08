namespace AutomapperTutor.Model.Statistics;

public class Machine
{
    public int IdLines { get; set; }
    public string LinesName { get; set; } = string.Empty;
    public int IdScale { get; set; }
    public int IdLinesFwn { get; set; }
    public string SerialNum { get; set; } = string.Empty;
    public string IPAddress { get; set; } = string.Empty;
}
