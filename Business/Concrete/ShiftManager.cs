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
    public class ShiftManager : IShiftService
    {
        private IShiftDal _shiftDal;

        public ShiftManager(IShiftDal shiftDal)
        {
            _shiftDal = shiftDal;
        }

        public IResult Add(Shift shift)
        {
            _shiftDal.Add(shift);
            return new SuccessResult(ShiftMessages.ShiftAdded);
        }

        public IResult Delete(Shift shift)
        {
            _shiftDal.Delete(shift);
            return new SuccessResult(ShiftMessages.ShiftDeleted);
        }

        public IDataResult<List<Shift>> GetList()
        {
            return new SuccessDataResult<List<Shift>>(_shiftDal.GetList().ToList());
        }

        public IResult Update(Shift shift)
        {
            _shiftDal.Update(shift);
            return new SuccessResult(ShiftMessages.ShiftUpdated);
        }
    }
}
