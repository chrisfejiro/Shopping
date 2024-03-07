namespace Shopping.Models.Dto
{
    public class LoginResponseDTO
    {
        public string Email { get; set; }
        public string Token { get; set; }//to respond with a jwt token we need a secret key ,the key is in my appSettings.json
    }
}
