using _24HourAssignment.Data;
using _24HourAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourAssignment.Services
{
    public class ReplyService
    {
        //CRUD
        private readonly Guid _userId;

        public ReplyService(Guid userId)
        {
            _userId = userId;
        }

        public bool ReplyCreate(ReplyCreate model)
        {
            var reply = new Reply
            {
                AuthorId = _userId,
                ReplyText = model.ReplyText,
                CommentId = (model.CommentId != null) ? model.CommentId : null
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Reply.Add(reply);

                return ctx.SaveChanges() > 0;


            }
        }

        public IEnumerable<ReplyListItem> GetReplies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .Reply
                    .Where(e => e.AuthorId == _userId)
                    .Select(e => new ReplyListItem
                    {
                        ReplyId = e.ReplyId,
                        ReplyText = e.ReplyText,
                    });

                return query.ToArray();
            }
        }

        public bool UpdateReply(ReplyEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Reply
                    .Single(e => e.ReplyId == model.ReplyId && e.AuthorId == _userId);

                entity.ReplyText = model.ReplyText;
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteReply(int replyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Reply
                    .Single(e => e.ReplyId == replyId && e.AuthorId == _userId);
                ctx.Reply.Remove(entity);
                return ctx.SaveChanges() ==1;

            }

        }

    }
}
