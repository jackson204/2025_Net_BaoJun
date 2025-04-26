using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        // 導覽屬性 - 一個 Blog 有多個 Post
        public virtual ICollection<Post> Posts { get; set; }
    }
}