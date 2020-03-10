﻿using System.Collections.Generic;
using Nuevo.Business.Abstract;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Concrete
{
    public class PersonalManager : IPersonalService
    {
        private readonly IPersonalDal _personalDal;

        public PersonalManager(IPersonalDal personalDal)
        {
            _personalDal = personalDal;
        }

        public IList<Personal> GetAll()
        {
            return _personalDal.GetAll();
        }
    }
}