using DevBlog_Backend.Repository.Entities;
using DevBlog_Backend.Repository.Interface;
using DevBlog_Backend.Service.Interface;

namespace DevBlog_Backend.Service.Service
{
    internal class TagService : ITagService
    {
        public readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        { _tagRepository = tagRepository; }

        public bool CreateTag(string name)
        {
            Tag newTag = new(name);

            return _tagRepository.CreateTag(newTag);
        }

        public bool DeleteTag(Guid id)
        {
            return _tagRepository.DeleteTag(id);
        }
    }
}
