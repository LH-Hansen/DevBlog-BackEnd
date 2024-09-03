using DevBlog_Backend.Repository.Entities;
using DevBlog_Backend.Repository.Interface;
using DevBlog_Backend.Service.Interface;

namespace DevBlog_Backend.Service.Service
{
    internal class CommentService : ICommentService
    {
        public readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        { _commentRepository = commentRepository; }

        public void CreateComment(User author, string content)
        {
            Comment newComment = new(author, content);

            _commentRepository.CreateComment(newComment);
        }

        public void DeleteComment(User author)
        {
            _commentRepository.DeleteComment(author.Id);
        }
    }
}