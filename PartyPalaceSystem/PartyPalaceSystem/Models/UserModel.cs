namespace PartyPalaceSystem.Models
{
    public class UserModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string Address { get; set; }
        public DateOnly DOB { get; set; }
        public string Gender { get; set; }
        public bool UserRole { get; set; }
        public string Password { get; set; }
    }
}
