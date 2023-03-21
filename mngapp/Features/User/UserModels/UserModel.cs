using System.ComponentModel.DataAnnotations;
using mngapp.Base;

namespace mngapp.Features.User.UserModels;

public class UserModel : Model
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    //roles
}