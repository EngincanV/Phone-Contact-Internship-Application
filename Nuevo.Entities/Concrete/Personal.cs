using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Nuevo.Entities.Abstract;

namespace Nuevo.Entities.Concrete
{
    public class Personal : IEntity
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Surname { get; set; }
        
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string PhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public int ManagerId { get; set; }

        public Manager Manager { get; set; }
        public Departmant Departmant { get; set; }
        public User User { get; set; }
    }
}
