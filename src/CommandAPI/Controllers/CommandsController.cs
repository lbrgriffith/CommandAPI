using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class CommandsController : ControllerBase 
{
    private readonly CommandContext _context; 
    public CommandsController(CommandContext context) => _context = context; 
    //GET:      api/commands 
    [HttpGet] 
    public ActionResult<IEnumerable<Command>> GetCommandItems() 
    { 
        return _context.CommandItems;
    }
}