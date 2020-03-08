using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Nuevo.Entities.Abstract;

namespace Nuevo.Entities.Concrete
{
    public class Manager : IEntity
    {
        public Manager()
        {
            this.Personals = new List<Personal>();
        }
        [ForeignKey("User")]
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Surname { get; set; }

        public User User { get; set; }
        public List<Personal> Personals { get; set; }
    }
}
