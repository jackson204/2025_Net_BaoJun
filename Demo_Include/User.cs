namespace Demo_Include;

public class User
{
    public int Id { get; set; }
    public string Account { get; set; }
    public virtual Member Member { get; set; }
}
