using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class CommandsController : ControllerBase 
{
    [HttpGet] 
    public ActionResult<IEnumerable<string>> Get() 
    { 
        return new string[] 
        { "this", "is", "hard", "coded" }; 
    } 
}