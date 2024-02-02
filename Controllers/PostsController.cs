using BlogOS.API.Data;
using BlogOS.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    private readonly BlogOSContext _context;

    public PostsController(BlogOSContext context)
    {
        _context = context;
    }

    [HttpPost]
    [Authorize]
    public IActionResult CreatePost()
    {
        // TODO: Implement post creation
        throw new NotImplementedException();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PostDto>>> GetAllPosts(
        int page = 1,
        int pageSize = 10
    )
    {
        // Calculate the number of items to skip
        var skip = (page - 1) * pageSize;

        // Query the database for posts, skipping the posts that come before the current page
        // and taking the number of posts specified by the pageSize
        // Lastly, project the results into a PostDto and materialize the query
        var posts = await _context.Posts
            .OrderByDescending(p => p.CreatedAt)
            .Skip(skip)
            .Take(pageSize)
            .Select(
                p =>
                    new PostDto
                    {
                        Id = p.PostID,
                        Title = p.Title,
                        Content = p.Content
                    }
            )
            .ToListAsync();

        return Ok(posts);
    }

    [HttpGet("{id}")]
    public IActionResult GetSinglePost(int id)
    {
        // TODO: Implement retrieval of a single post by its ID
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    [Authorize]
    public IActionResult UpdatePost(int id)
    {
        // TODO: Implement post update
        // Check if the current user is authorized to update the post
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    [Authorize]
    public IActionResult DeletePost(int id)
    {
        // TODO: Implement post deletion
        // Check if the current user is authorized to delete the post
        throw new NotImplementedException();
    }
}
