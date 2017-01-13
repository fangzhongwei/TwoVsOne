using SimpleSQL;

public class ResourceRaw {
    [PrimaryKey]
    public int Id { get; set; }
    public string Code { get; set; }
    public string Lan { get; set; }
    public string Desc { get; set; }
}
