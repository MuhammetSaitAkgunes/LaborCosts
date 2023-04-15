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
    public class WorkingHourManager : IWorkingHourService
    {
        private IWorkingHourDal _workingHourDal;

        public WorkingHourManager(IWorkingHourDal workingHourDal)
        {
            _workingHourDal = workingHourDal;
        }

        public IResult Add(WorkingHour workHour)
        {
            _workingHourDal.Add(workHour);
            return new SuccessResult(WorkingHourMessages.WorkingHourAdded);
        }

        public IResult Delete(WorkingHour workHour)
        {
            _workingHourDal.Delete(workHour);
            return new SuccessResult(WorkingHourMessages.WorkingHourDeleted);
        }

        public IDataResult<WorkingHour> GetById(int id)
        {
            return new SuccessDataResult<WorkingHour>(_workingHourDal.Get(p => p.Id == id));
        }

        public IDataResult<WorkingHour> GetByPersonelId(int personelId)
        {
            return new SuccessDataResult<WorkingHour>(_workingHourDal.Get(p => p.PersonelId == personelId));
        }

        public IDataResult<WorkingHour> GetByProjectId(int projectId)
        {
           return new SuccessDataResult<WorkingHour>(_workingHourDal.Get(p => p.ProjectId == projectId));
        }

        public IDataResult<List<WorkingHour>> GetList()
        {
            return new SuccessDataResult<List<WorkingHour>>(_workingHourDal.GetList().ToList());
        }

        public IResult Update(WorkingHour workHour)
        {
            _workingHourDal.Update(workHour);
            return new SuccessResult(WorkingHourMessages.WorkingHourUpdated);
        }
    }
}
