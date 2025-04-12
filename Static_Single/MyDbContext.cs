internal class MyDbContext
{
    static MyDbContext()
    {
        Instance = new MyDbContext();
    }

    private MyDbContext()
    {
    }

    public static MyDbContext Instance { get; } = null;

    public string UserName { get; set; }
}
