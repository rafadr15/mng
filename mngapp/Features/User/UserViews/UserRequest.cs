using System.ComponentModel.DataAnnotations;

namespace mngapp.Features.User.UserViews;

public class UserRequest
{
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [Required] public string Email { get; set; }
}