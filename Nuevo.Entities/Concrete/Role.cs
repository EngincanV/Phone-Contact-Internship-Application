using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Nuevo.Entities.Abstract;

namespace Nuevo.Entities.Concrete
{
    public class Role : IEntity
    {
        public Role()
        {
            this.Users = new List<User>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
