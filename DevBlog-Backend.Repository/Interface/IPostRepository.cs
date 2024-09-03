using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.Repository.Interface
{
    internal interface IPostRepository
    {
        bool AddComment(Guid id, Comment comment);
        bool AddTag(Guid id, Tag tag);
        bool CheckIfPostExists(Guid id);
        void CreatePost(Post newPost);
        bool DeletePost(Guid id);
        List<Post> GetPostList();
        List<Post> GetPostListByCategory(Category category);
        List<Post> GetPostListByTag(Tag tag);
        bool UpdateBody(string newBody, Guid id);
        bool UpdateHead(string newHead, Guid id);
    }
}