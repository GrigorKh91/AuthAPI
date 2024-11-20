using Domain.EntityModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace Auth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //    GET /api/user/me                        - Fetch current user details
        //    PUT /api/user/update-profile            - Update user profile information
        //    DELETE /api/user/delete                 - Delete(or deactivate) the user account

        //Fetch User Details
        //Update Profile
        //Delete Account(Soft Delete)

    }
}
