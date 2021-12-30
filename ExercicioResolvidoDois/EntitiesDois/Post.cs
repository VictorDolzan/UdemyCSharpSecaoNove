using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoNove.ExercicioResolvidoDois.EntitiesDois
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public Post()
        {

        }
        public Post(DateTime moment, string externalTitle, string externalContent, int externalLikes)
        {
            Moment = moment;
            Title = externalTitle;
            Content = externalContent;
            Likes = externalLikes;
        }
        public void AddComments(Comment externalComment)
        {
            Comments.Add(externalComment);
        }
        public void RemoveComments(Comment externalComment)
        {
            Comments.Remove(externalComment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("MM/dd/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }

    }
}