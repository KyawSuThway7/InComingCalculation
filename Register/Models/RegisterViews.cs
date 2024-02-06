namespace Register.Models
{
    public class RegisterView
    {
        public string Name {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool Gender { get; set; }    
        public DateOnly Date {  get; set; }
        public string City {  get; set; }
        public string Adress {  get; set; }
    }
}
