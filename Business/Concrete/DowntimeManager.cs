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
    public class DowntimeManager : IDowntimeService
    {
        private IDowntimeDal _downtimeDal;

        public DowntimeManager(IDowntimeDal downtimeDal) 
        {
            _downtimeDal = downtimeDal;
        }

        public IResult Add(Downtime downtime)
        {
            _downtimeDal.Add(downtime);
            return new SuccessResult(DowntimeMessages.DowntimeAdded);
        }

        public IResult Delete(Downtime downtime)
        {
            _downtimeDal.Delete(downtime);
            return new SuccessResult(DowntimeMessages.DowntimeDeleted);
        }

        public IDataResult<List<Downtime>> GetList()
        {
            return new SuccessDataResult<List<Downtime>>(_downtimeDal.GetList().ToList());
        }

        public IResult Update(Downtime downtime)
        {
            _downtimeDal.Update(downtime);
            return new SuccessResult(DowntimeMessages.DowntimeUpdated);
        }
    }
}
