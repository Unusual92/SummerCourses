using _5_lesson.Models;

namespace _5_lesson.Interfaces;

public interface IPostsRepository
{
    public IEnumerable<Post> GetAll();
    public Post? GetById(Guid id);
    public Post Add(PostRequest request);
    public Post? Edit(PostRequest request, Guid id);
    public Post? Delete(Guid id);
}