using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IResult Add(Personel personel)
        {
            _personelDal.Add(personel);
            return new SuccessResult(PersonelMessages.PersonelAdded);
        }

        public IResult Delete(Personel personel)
        {
            _personelDal.Delete(personel);
            return new SuccessResult(PersonelMessages.PersonelDeleted);
        }

        public IDataResult<Personel> GetById(int id)
        {
            return new SuccessDataResult<Personel>(_personelDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Personel>> GetList()
        {
            return new SuccessDataResult<List<Personel>>(_personelDal.GetList().ToList());
        }

        public IResult Update(Personel personel)
        {
            _personelDal.Update(personel);
            return new SuccessResult(PersonelMessages.PersonelUpdated);
        }
    }
}
