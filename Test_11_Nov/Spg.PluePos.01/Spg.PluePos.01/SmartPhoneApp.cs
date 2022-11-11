using Spg.PluePos._01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01
{
    public class SmartPhoneApp : List<Post>
    {
        public List<Post> posts { get; set; } = new List<Post>();

        public string SmartPhoneId { get; set; } = string.Empty;

        public SmartPhoneApp(string smartPhoneId)
        {
            SmartPhoneId = smartPhoneId;
        }

        public new void Add(Post p)
        {
            if (p != null)
            {
                this.posts.Add(p);
                p.SmartPhone = this;
            }
        }

        public string ProcessPosts()
        {
            string a = string.Empty;

            foreach (Post post in this)
            {
                if (a != null)
                {
                    a.Concat(post.Html).Concat("\n");
                }
            }
            Console.WriteLine(a);
            return a;
        }

        public int CalcRating()
        {
            int a = 0;
            foreach (Post post in this)
            {
                a += post.Rating;
            }
            Console.WriteLine(a);   
            return a;
        }

        /*
        public string this[string title]
        {
            get
            { return Post.[title].Html ?? null; }

            Dictionary<string, Post> _posts = new Dictionary<string, Post>();
            public Post SmartPhoneAppIterator(string title)
            {
                foreach (Post p in _posts)
                {
                    if (_posts[title].Html == "TextPost 6")
                    {
                        return p;
                    }
                }
                return null;
        }
    }*/
    }
}
