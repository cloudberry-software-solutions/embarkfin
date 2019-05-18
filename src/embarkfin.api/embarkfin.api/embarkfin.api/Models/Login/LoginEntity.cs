using System;
using System.ComponentModel.DataAnnotations.Schema;
using embarkfin.api.Models.Database;
namespace embarkfin.api.Models.Login
{
    [Table("Login")]
    public class LoginEntity :BaseEntity
    {
        [Column("User_Name")]
        public String User_Name { get; set; }

        [Column("Password")]
        public String Password { get; set; }

        public LoginEntity(String User_Name, String Password) 
        {
            this.User_Name = User_Name;
            this.Password = Password;
        }
    }
}
