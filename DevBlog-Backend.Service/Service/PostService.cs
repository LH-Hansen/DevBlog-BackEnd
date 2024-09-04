using DevBlog_Backend.Repository.Entities;
using DevBlog_Backend.Repository.Interface;
using DevBlog_Backend.Service.Interface;

namespace DevBlog_Backend.Service.Service
{
    internal class PostService : IPostService
    {
        public readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        { _postRepository = postRepository; }

        public void CreatePost(string head, string body, User author, Category category)
        {
            Post newPost = new(head, body, author, category);

            _postRepository.CreatePost(newPost);
        }

        public bool AddTag(Guid id, Tag tag) => _postRepository.AddTag(id, tag);

        public bool AddComment(Guid id, Comment comment) => (_postRepository.AddComment(id, comment));

        public List<Post> GetPostList() => _postRepository.GetPostList();

        public List<Post> GetPostByTag(Tag tag) => _postRepository.GetPostListByTag(tag);

        public List<Post> GetPostByCategory(Category category) => _postRepository.GetPostListByCategory(category);

        public bool UpdateHead(string newHead, Guid id) => _postRepository.UpdateHead(newHead, id);

        public bool UpdateBody(string newBody, Guid id) => _postRepository.UpdateBody(newBody, id);

        public bool DeletePost(Guid id) => _postRepository.DeletePost(id);
    }
}
