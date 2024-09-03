using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.Service.Interface
{
    public interface ICommentService
    {
        void CreateComment(User author, string content);
        void DeleteComment(User author);
    }
}