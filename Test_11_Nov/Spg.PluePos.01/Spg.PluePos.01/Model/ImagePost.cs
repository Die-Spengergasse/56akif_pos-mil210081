using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public class ImagePost : Post
    {
        public string? Url { get; set; }

        public override string Html
        {
            get
            {
                if (Url == null)
                {
                    throw new ArgumentNullException("Content war NULL!");
                }
                return $"<h1>{Title}</h1><img src={Url} />";
            }
        }

        public ImagePost(string title) : base(title)
        {
        }

        public ImagePost(string title, DateTime created) : base(title, created)
        {
        }
    }
}
