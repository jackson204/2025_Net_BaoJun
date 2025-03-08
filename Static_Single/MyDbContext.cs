class MyDbContext
{
    public static MyDbContext Instance => _myDbContext;

    private static MyDbContext _myDbContext = null;

    private MyDbContext()
    {
    }

    static MyDbContext()
    {
        _myDbContext = new MyDbContext();
    }

    public string UserName { get; set; }
}
