using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingCraft.Contracts.Persistence.Entities
{
    [Table("UserRole")]
    public sealed class UserRole
    {
        public UserRole()
        {
            Users = new HashSet<User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserRoleId { get; set; }

        [Required, MaxLength(50)]
        public string Role { get; set; }

        public ICollection<User> Users { get; set; }
    }
}