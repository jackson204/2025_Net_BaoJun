namespace Demo_Include;

public class Member
{
    public int Id { get; set; }
    public int DiscountSettingId { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
