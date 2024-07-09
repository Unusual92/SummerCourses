using System.Text.Json;
using _5_lesson.Interfaces;
using _5_lesson.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace _5_lesson.Services;

public class PostsRepository : IPostsRepository
{
    private static readonly List<Post> _data =
    [
        new Post()
        {
            Id = Guid.NewGuid(),
            Body = "12345",
            Title = "123",
            UserId = 1
        }
    ];

    public IEnumerable<Post> GetAll()
    {
        return _data;
    }

    public Post? GetById(Guid id)
    {
        return _data.SingleOrDefault(p => p.Id == id);
    }
    
    public Post Add(PostRequest request)
    {
        var post = new Post()
        {
            Id = Guid.NewGuid(),
            Body = request.Body,
            Title = request.Title,
            UserId = request.UserId
        };
        _data.Add(post);
        return post;
    }

    public Post? Edit(PostRequest request, Guid id)
    {
        Post post = new()
        {
            Id = id,
            Title = request.Title,
            Body = request.Body,
            UserId = request.UserId
        };
        var index = _data.FindIndex(p => p.Id == id);
        if (index == -1)
        {
            return null;
        }
        _data.RemoveAt(index);
        _data.Add(post);
        return post;
    }

    public Post? Delete(Guid id)
    {
        var post = _data.SingleOrDefault(p => p.Id == id);
        if (post is null)
        {
            return null;
        }
        _data.Remove(post);
        return post;
    }
}                                                                                                               