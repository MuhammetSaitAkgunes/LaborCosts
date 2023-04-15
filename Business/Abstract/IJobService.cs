using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IJobService
    {
        IDataResult<List<Job>> GetList();
        IResult Add(Job job);
        IResult Delete(Job job);
        IResult Update(Job job);
    }
}
