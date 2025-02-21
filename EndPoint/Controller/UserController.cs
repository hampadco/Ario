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
   [HttpPost]
public IActionResult AddUsers(User user)
{
    if (db.Users.Any(u => u.UserName == user.UserName))
    {
        return BadRequest("نام کاربری قبلاً استفاده شده است.");
    }

    if (db.Users.Any(u => u.PhoneNumber == user.PhoneNumber))
    {
        return BadRequest("شماره تلفن قبلاً ثبت شده است.");
    }

    db.Users.Add(user);
    db.SaveChanges();
    return Ok("کاربر با موفقیت ثبت شد.");
}


    [HttpGet]

    public List<User> GetUsers()
    {
        return db.Users.OrderByDescending(x=>x.Id).ToList();
    }

    [HttpPost]
public IActionResult CheckLogin([FromBody] LoginRequest loginRequest)
{
    // بررسی اینکه نام کاربری و رمز عبور وجود داشته باشند
    var user = db.Users.FirstOrDefault(u => u.UserName == loginRequest.Username && u.Password == loginRequest.Password);

    if (user != null)
    {
        // اگر کاربر پیدا شد، ورود موفقیت‌آمیز است
        return Ok("ورود موفقیت‌آمیز بود");
    }
    else
    {
        // اگر کاربر پیدا نشد، ورود ناموفق است
        return Unauthorized("نام کاربری یا رمز عبور اشتباه است");
    }
}



    
}