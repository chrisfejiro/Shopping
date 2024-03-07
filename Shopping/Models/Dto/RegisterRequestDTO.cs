namespace Shopping.Models.Dto
{
    public class RegisterRequestDTO
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }//role is not something you would want ot expose to the api,but for now lets just use it like that
    }
}
