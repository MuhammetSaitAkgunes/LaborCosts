using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWorkingHourService
    {
        IDataResult<List<WorkingHour>> GetList();
        IDataResult<WorkingHour> GetByPersonelId(int personelId);
        IDataResult<WorkingHour> GetByProjectId(int projectId);
        IDataResult<WorkingHour> GetById(int id);
        IResult Add(WorkingHour workHour);
        IResult Update(WorkingHour workHour);
        IResult Delete(WorkingHour workHour);
    }
}
