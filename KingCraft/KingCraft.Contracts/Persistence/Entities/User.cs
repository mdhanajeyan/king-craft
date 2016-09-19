using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingCraft.Contracts.Persistence.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public int UserRoleId { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string EmailAddress { get; set; }

        [Phone]
        public string TelephoneNumber { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required, ForeignKey("UserRoleId")]
        public virtual UserRole UserRole { get; set; }
    }
}