using System.ComponentModel.DataAnnotations;

public class Usre
{

     [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public bool Statue { get; set; }
    
}