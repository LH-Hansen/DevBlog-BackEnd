using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Repository.Repository
{
    internal class CommentRepository : ICommentRepository
    {
        private List<Comment> _commentList = new();

        public void CreateComment(Comment newComment)
        {
            _commentList.Add(newComment);
        }

        public bool DeleteComment(uint id)
        {
            if (CheckIfCommentExists(id))
            {
                _commentList.Remove(_commentList.FirstOrDefault(c => c.Id.Equals(id)));

                return true;
            }
            return false;
        }

        private bool CheckIfCommentExists(uint id)
        {
            foreach (Comment comment in _commentList)
            {
                if (comment.Id == id) return true;
            }
            return false;
        }
    }
}
