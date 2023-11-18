namespace NetflixCloneAPI.DTO
{
    public class BaseUserDTO
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class ReturnUserDTO
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string AccessToken { get; set; } = string.Empty;
    }
}


//    public class UserDto
//    {
//        public string Username { get; set; } = string.Empty;
//        public string Password { get; set; } = string.Empty;
//    }

//    public class ReturnUserDto
//    {
//        public string Uid { get; set; } = string.Empty;
//        public string Username { get; set; } = string.Empty;
//        public string Email { get; set; } = string.Empty;
//        public string Role { get; set; } = string.Empty;
//        public string AccessToken { get; set; } = string.Empty;
//    }

//    public class UpdateUserDto
//    {
//        public string Username { get; set; } = string.Empty;
//        public string PhoneNumber { get; set; } = string.Empty;
//        //public string Address { get; set; } = string.Empty;
//        //public string PostalCode { get; set; } = string.Empty;
//        //public string City { get; set; } = string.Empty;
//    }

//    public class UserInfoDto
//    {
//        public string Uid { get; set; } = string.Empty;
//        public string Username { get; set; } = string.Empty;
//        public string Email { get; set; } = string.Empty;
//        public string PhoneNumber { get; set; } = string.Empty;
//        public string Role { get; set; } = string.Empty;
//    }

//    public class GoogleRetObj
//    {
//        public string sub { get; set; } = string.Empty;
//        public string name { get; set; } = string.Empty;
//        public string given_name { get; set; } = string.Empty;
//        public string email { get; set; } = string.Empty;
//        public bool verified_email { get; set; }
//        public string picture { get; set; } = string.Empty;
//        public string Locale { get; set; } = string.Empty;
//    }
//}
