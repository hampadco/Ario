using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]/[Action]")]
public class UserController:ControllerBase
{
    private readonly Context db;
    public UserController(Context _db)
    {
        db=_db;
    }

    [HttpPost]
    public IActionResult AddUsers(Usre usre)
    {

        db.Usres.Add(usre);
        db.SaveChanges();
        return Ok("success");

    }


    [HttpGet]

    public List<Usre> GetUsers()
    {
        return db.Usres.OrderByDescending(x=>x.Id).ToList();
    }


    
}