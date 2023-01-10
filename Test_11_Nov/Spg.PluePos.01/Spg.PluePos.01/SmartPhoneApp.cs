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
        // public List<Post> posts { get; set; } = new List<Post>();

        public string SmartPhoneId { get; set; } = string.Empty;

        public SmartPhoneApp(string smartPhoneId)
        {
            SmartPhoneId = smartPhoneId;
        }

        public new void Add(Post p)
        {
            if (p != null)
            {
                base.Add(p);
                p.SmartPhone = this;
            }
        }

        public string ProcessPosts()
        {
            StringBuilder a = new StringBuilder();

            foreach (Post post in this) // die Klass
            {
                a.Append(post.ToString());
            }
            Console.WriteLine(a);
            return a.ToString();
        }

        /*
        public string ProcessPosts1()
        {
            string a = string.Empty;
            StringBuilder sb =new StringBuilder();

            foreach (Post post in this)
            {
                sb.AppendLine(post.Html);
            }
            Console.WriteLine(a);
            return a;
        }*/

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

        public Post this[string title]
        {
            get { return this.FirstOrDefault(p => p.Title.Equals(title)); }
        }
    }
}
