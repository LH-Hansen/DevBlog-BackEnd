using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Entities;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Repository.Repository
{
    internal class PostRepository : IPostRepository
    {
        private List<Post> _postList = new();

        public void CreatePost(Post newPost)
        {
            _postList.Add(newPost);
        }

        public bool AddTag(Guid id, Tag tag)
        {
            if (CheckIfPostExists(id))
            {
                _postList.FirstOrDefault(p => p.Id.Equals(id)).Tags.Add(tag);
                return true;
            }
            return false;
        }

        public bool AddComment(Guid id, Comment comment)
        {
            if (CheckIfPostExists(id))
            {
                _postList.FirstOrDefault(p => p.Id.Equals(id)).Comments.Add(comment);
                return true;
            }
            return false;
        }

        public List<Post> GetPostList() { return _postList; }

        public List<Post> GetPostListByTag(Tag tag)
        {
            return _postList.Where(p => p.Tags.Equals(tag)).ToList();
        }

        public List<Post> GetPostListByCategory(Category category)
        {
            return _postList.Where(p => p.Category.Equals(category)).ToList();
        }

        public bool UpdateHead(string newHead, Guid id)
        {
            if (CheckIfPostExists(id))
            {
                _postList.FirstOrDefault(p => p.Id.Equals(id)).Head = newHead;
                return true;
            }
            return false;
        }

        public bool UpdateBody(string newBody, Guid id)
        {
            if (CheckIfPostExists(id))
            {
                _postList.FirstOrDefault(p => p.Id.Equals(id)).Body = newBody;
                return true;
            }
            return false;
        }

        public bool DeletePost(Guid id)
        {
            if (CheckIfPostExists(id))
            {
                _postList.Remove(_postList.FirstOrDefault(p => p.Id.Equals(id)));
                return true;
            }
            return false;
        }

        public bool CheckIfPostExists(Guid id)
        {
            foreach (Post post in _postList)
            {
                if (post.Id == id) return true;
            }
            return false;

        }

    }
}
