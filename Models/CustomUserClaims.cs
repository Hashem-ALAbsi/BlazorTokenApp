namespace BlazorTokenApp.Models
{
	//public record CustomUserClaims(string Name = null!, string Email = null!);
	public class CustomUserClaims
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
