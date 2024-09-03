using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.Service.Interface
{
    internal interface IPostService
    {
        bool AddComment(Guid id, Comment comment);
        bool AddTag(Guid id, Tag tag);
        void CreatePost(string head, string body, User author, Category category);
        bool DeletePost(Guid id);
        List<Post> GetPostByCategory(Category category);
        List<Post> GetPostByTag(Tag tag);
        List<Post> GetPostList();
        bool UpdateBody(string newBody, Guid id);
        bool UpdateHead(string newHead, Guid id);
    }
}