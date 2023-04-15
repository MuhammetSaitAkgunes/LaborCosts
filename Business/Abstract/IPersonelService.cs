using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        IDataResult<List<Personel>> GetList();
        IDataResult<Personel> GetById(int id);
        IResult Add(Personel personel);
        IResult Update(Personel personel);
        IResult Delete(Personel personel);
    }
}
