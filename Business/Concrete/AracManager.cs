using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.OperationResults;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AracManager : IAracService
    {
        IAracDal _aracDal;

        public AracManager(IAracDal aracDal)
        {
            _aracDal = aracDal;
        }

        // REFACTORING !!

        public IResult Add(Arac arac)
        {
            try
            {
                _aracDal.Add(arac);
                return new SuccessResult(Messages.AracAdd);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.AracAddError);
            }
        }

        public IResult Delete(Arac arac)
        {
            try
            {
                _aracDal.Delete(arac);

                return new SuccessResult(Messages.AracDelete);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.AracDeleteError);
            }
        }

        public IResult DeleteAll(List<Arac> araclar)
        {
            try
            {
                _aracDal.DeleteAll(araclar);

                return new SuccessResult(Messages.AracDeleteAll);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.AracDeleteAllError);
            }
        }

        public IDataResult<List<Arac>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Arac>>(_aracDal.GetAll(), Messages.AracList);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Arac>>(Messages.AracListError);
            }
        }

        public IResult Update(Arac arac)
        {
            try
            {
                _aracDal.Update(arac);
                return new SuccessResult(Messages.AracUpdate);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.AracUpdateError);
            }
        }
    }
}
