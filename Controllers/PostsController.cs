using _5_lesson.Interfaces;
using _5_lesson.Models;
using _5_lesson.Services;
using Microsoft.AspNetCore.Mvc;

namespace _5_lesson.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    private readonly IPostsRepository _postsRepository = new PostsRepository();

    [HttpGet]
    public IActionResult Get()
    {
        var posts = _postsRepository.GetAll();
        if (!posts.Any())
            return NotFound();                  
        return Ok(posts);
    }
                            
    [HttpPost]
    public IActionResult Create([FromBody] PostRequest request)
    {
        var newPost = _postsRepository.Add(request);
        
        return Ok(newPost);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var post = _postsRepository.GetById(id);

        if (post is null)
        {
            return NotFound();
        }

        return Ok(post);
    }


    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        var post = _postsRepository.Delete(id);
        if (post is null)
        {
            return NotFound();
        }

        return Ok();
    }
}