using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Repository.Repository
{
    internal class CommentRepository : ICommentRepository
    {
        private readonly List<Comment> _commentList = new();

        public void CreateComment(Comment newComment)
        {
            _commentList.Add(newComment);
        }

        public bool DeleteComment(Guid id)
        {
            if (CheckIfCommentExists(id))
            {
                _commentList.Remove(_commentList.FirstOrDefault(c => c.Id.Equals(id)));
                return true;
            }
            return false;
        }

        private bool CheckIfCommentExists(Guid id)
        {
            foreach (Comment comment in _commentList)
            {
                if (comment.Id == id) return true;
            }
            return false;
        }

        //todo; make remove comment list and make exchange it with post.
    }
}
