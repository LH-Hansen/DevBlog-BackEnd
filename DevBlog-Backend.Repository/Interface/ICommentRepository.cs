using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Repository.Interface
{
    public interface ICommentRepository
    {
        void CreateComment(Comment newComment);
        bool DeleteComment(Guid id);
    }
}