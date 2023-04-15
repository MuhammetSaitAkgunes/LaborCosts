using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProjectService
    {
        IDataResult<List<Project>> GetList();
        IDataResult<Project> GetById(int id);
        IResult Add(Project project);
        IResult Update(Project project);
        IResult Delete(Project project);
    }
}
