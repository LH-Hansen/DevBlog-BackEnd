using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Interface;
using DevBlog_Backend.Service.Interface;

namespace DevBlog_Backend.Service.Service
{
    internal class CommentService : ICommentService
    {
        public readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        { _commentRepository = commentRepository; }

        private uint _commentsCreated = 0;

        public void CreateComment(User author, string content)
        {
            Comment newComment = new(_commentsCreated, author, content);

            _commentRepository.CreateComment(newComment);
            _commentsCreated++;
        }

        public void DeleteComment(User author)
        {
            _commentRepository.DeleteComment(author.Id);
        }
    }
}
