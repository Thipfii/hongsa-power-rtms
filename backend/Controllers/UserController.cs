using Microsoft.AspNetCore.Mvc;
using Hongsa.Rtms.Api.Models;

namespace Hongsa.Rtms.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public string GetUsers()
    {
        return "Hello from UserController";
    }

    [HttpPost]
    public string PostUsers()
    {
        return "Post User";
    }

    [HttpPut]
    public string UpdateUsers()
    {
        return "Update User API!";
    }

    [HttpDelete]
    public string DeleteUsers()
    {
        return "Delete User";
    }
}