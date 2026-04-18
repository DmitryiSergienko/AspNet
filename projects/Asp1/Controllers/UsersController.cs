using Asp1.Dto;
using Asp1.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Asp1.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class UsersController(IUserService userService) : Controller
{
    [HttpGet("index")]
    public async Task<IActionResult> Index()
    {
        var users = await userService.GetUsersAsync();
        if (users != null) return Ok(users);
        return NotFound();
    }

    [HttpGet("details/{id:int}")]
    public async Task<IActionResult> Details(int id)
    {
        var user = await userService.GetUserAsync(id);
        if (user != null) return Ok(user);
        return NotFound();
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create(UserCreateDto userCreateDto)
    {
        var user = await userService.PostUserAsync(userCreateDto);
        if (ModelState.IsValid) return Ok(user);
        return BadRequest();
    }

    [HttpPut("edit")]
    public async Task<IActionResult> Edit(UserUpdateDto userUpdateDto)
    {
        var user = await userService.PutUserAsync(userUpdateDto);
        if (ModelState.IsValid) return Ok(user);
        return BadRequest();
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete(UserUpdateDto userUpdateDto)
    {
        if (!ModelState.IsValid) return BadRequest();
        await userService.DeleteUserAsync(userUpdateDto);
        return Ok();
    }

    [HttpPost("activate/{id:int}")]
    public async Task<IActionResult> Activate(int id)
    {
        var users = await userService.GetUsersAsync();
        var ids = users.Select(u => u.Id).ToList();
        if (ids.Contains(id))
        {
            await userService.PostActivateAsync(id);
            return Ok();
        }
        return BadRequest();
    }
}