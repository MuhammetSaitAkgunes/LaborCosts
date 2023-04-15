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
    public class ProjectManager : IProjectService
    {
        private IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IResult Add(Project project)
        {
            _projectDal.Add(project);
            return new SuccessResult(ProjectMessages.ProjectAdded);
        }

        public IResult Delete(Project project)
        {
            _projectDal.Delete(project);
            return new SuccessResult(ProjectMessages.ProjectDeleted);
        }

        public IDataResult<Project> GetById(int id)
        {
            return new SuccessDataResult<Project>(_projectDal.Get(p =>  p.Id == id));
        }

        public IDataResult<List<Project>> GetList()
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetList().ToList());
        }

        public IResult Update(Project project)
        {
            _projectDal.Update(project);
            return new SuccessResult(ProjectMessages.ProjectUpdated);
        }
    }
}
