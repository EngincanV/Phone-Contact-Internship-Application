using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Nuevo.Entities.Abstract;

namespace Nuevo.Entities.Concrete
{
    public class Departmant : IEntity
    {
        public Departmant()
        {
            this.Personals = new List<Personal>();
        }
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        public List<Personal> Personals { get; set; }
    }
}
