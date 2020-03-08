using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Nuevo.Entities.Abstract;

namespace Nuevo.Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Username { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }
        public int RoleId { get; set; }

        public Role Role { get; set; }
        public Manager Manager { get; set; }
    }
}
