using DevBlog_Backend.Repository.Entities;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Repository.Repository
{
    internal class TagRepository : ITagRepository
    {
        private List<Tag> _tagList = new();

        public bool CreateTag(Tag newTag)
        {
            if (!CheckIfTagNameExists(newTag.Name))
            {
                _tagList.Add(newTag);
                return true;
            }
            return false;
        }

        public bool DeleteTag(Guid id)
        {
            if (!CheckIfTagExists(id))
            {
                _tagList.Remove(_tagList.FirstOrDefault(t => t.Id.Equals(id)));
                return true;
            }
            return false;
        }

        private bool CheckIfTagNameExists(string name)
        {
            foreach (Tag tag in _tagList)
            {
                if (tag.Name == name)
                    return true;
            }
            return false;
        }

        private bool CheckIfTagExists(Guid id)
        {
            foreach (Tag tag in _tagList)
            {
                if (tag.Id == id) return true;
            }
            return false;
        }



    }
}
