using System.Net.Http.Json;

public class UserService
{
    private readonly HttpClient _http;
    public UserService( HttpClient http)
    {
        _http=http;
    }

    public async Task AddUser(Usre usre)
    {
        await _http.PostAsJsonAsync("http://localhost:5298/User/AddUsers",usre);
      
    }

}