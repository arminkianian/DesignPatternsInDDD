using Factory.OnAggregate.AnotherType.Model.TopicAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.OnAggregate.AnotherType.Model.ForumAggregate
{
    public class Forum
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsClosed { get; set; }

        public Topic OpenTopic(string topicTitle, Guid ownerId)
        {
            if (this.IsClosed)
            {
                throw new Exception($"Forum {this.Title} closed!");
            }

            return new Topic(topicTitle, ownerId, this.Id);
        }
    }
}
