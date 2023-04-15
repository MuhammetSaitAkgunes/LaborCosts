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
    public class JobManager : IJobService
    {
        private IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }
        public IResult Add(Job job)
        {
            _jobDal.Add(job);
            return new SuccessResult(JobMessages.JobAdded);

        }

        public IResult Delete(Job job)
        {
            _jobDal.Delete(job);
            return new SuccessResult(JobMessages.JobDeleted);
        }

        public IDataResult<List<Job>> GetList()
        {
            return new SuccessDataResult<List<Job>>(_jobDal.GetList().ToList());
        }

        public IResult Update(Job job)
        {
            _jobDal.Update(job);
            return new SuccessResult(JobMessages.JobUpdated);
        }
    }
}
