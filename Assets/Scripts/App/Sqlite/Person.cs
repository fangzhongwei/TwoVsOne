using SQLite4Unity3d;

public class Person  {

    public int Id { get; set; }
	public string Identity { get; set; }
	public string NickName { get; set; }
	public string Token { get; set; }

	public override string ToString ()
	{
		return string.Format ("[Person: Id={0}, Identity={1},  NickName={2}, Token={3}]", Id, Identity, NickName, Token);
	}
}
