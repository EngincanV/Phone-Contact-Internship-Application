using System.Collections.Generic;
using Nuevo.Business.Abstract;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Concrete
{
    public class DepartmantManager : IDepartmantService
    {
        private readonly IDepartmantDal _departmantDal;

        public DepartmantManager(IDepartmantDal departmantDal)
        {
            _departmantDal = departmantDal;
        }

        public Departmant GetById(int id)
        {
            return _departmantDal.GetById(id);
        }

        public IList<Departmant> GetAll()
        {
            return _departmantDal.GetAll();
        }

        public void Add(Departmant departmant)
        {
            _departmantDal.Add(departmant);
        }

        public void Delete(int id)
        {
            _departmantDal.Delete(id);
        }

        public void Update(Departmant departmant)
        {
            _departmantDal.Update(departmant);
        }
    }
}
