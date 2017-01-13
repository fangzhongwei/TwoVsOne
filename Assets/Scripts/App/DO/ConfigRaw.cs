using SimpleSQL;

public class ConfigRaw
{
    [PrimaryKey]
    public int Id { get; set; }
    public int ResourceVersion { get; set; }
    public string Lan { get; set; }
}
