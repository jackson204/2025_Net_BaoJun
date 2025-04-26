namespace ConsoleApplication2
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        // 外鍵屬性
        public int BlogId { get; set; }
        // 導覽屬性 - 一個 Post 屬於一個 Blog
        public virtual Blog Blog { get; set; }
    }
}
