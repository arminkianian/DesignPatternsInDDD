using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.OnAggregate.AnotherType.Model.TopicAggregate
{
    public class Topic
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid OwnerId { get; set; }
        public Guid ForumId { get; set; }

        //Internal Constructor
        internal Topic(string title, Guid ownerId, Guid forumId) 
        {
            Title = title;
            OwnerId = ownerId;
            ForumId = forumId;
        }
    }
}
