using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Repository.Interface
{
    internal interface ICommentRepository
    {
        void CreateComment(User author, string content);
        bool DeleteComment(uint id);
    }
}