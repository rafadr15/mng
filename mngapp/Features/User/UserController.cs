using Microsoft.AspNetCore.Mvc;
using mngapp.Database;
using mngapp.Features.User.UserModels;
using mngapp.Features.User.UserViews;

namespace mngapp.Features.User;


[ApiController]
[Route("user")]
public class UserController : ControllerBase
{


    private readonly AppDbContext _dbContext;
    public UserController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<UserResponse>> Add(UserRequest request)
    {
        var user = new UserModel
        {
            Id = Guid.NewGuid().ToString(),
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        };
        var response = await _dbContext.User.AddAsync(user);
        await _dbContext.SaveChangesAsync();
        return Created("users", response.Entity);
    }
    
}