using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDowntimeService
    {
        IDataResult<List<Downtime>> GetList();
        IResult Add(Downtime downtime);
        IResult Delete(Downtime downtime);
        IResult Update(Downtime downtime);
    }
}
