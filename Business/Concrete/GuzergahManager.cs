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
    public class GuzergahManager : IGuzergahService
    {
        IGuzergahDal _guzergahDal;

        public GuzergahManager(IGuzergahDal guzergahDal)
        {
            _guzergahDal = guzergahDal;
        }

        // REFACTORING !!

        public IResult Add(Guzergah guzergah)
        {
            try
            {
                _guzergahDal.Add(guzergah);
                return new SuccessResult(Messages.GuzergahAdd);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.GuzergahAddError);
            }
        }

        public IResult Delete(Guzergah guzergah)
        {
            try
            {
                _guzergahDal.Delete(guzergah);
                return new SuccessResult(Messages.GuzergahDelete);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.GuzergahDeleteError);
            }
        }

        public IResult DeleteAll(List<Guzergah> guzergahlar)
        {
            try
            {
                _guzergahDal.DeleteAll(guzergahlar);
                return new SuccessResult(Messages.GuzergahDeleteAll);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.GuzergahDeleteAllError);
            }
        }

        public IDataResult<List<Guzergah>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Guzergah>>(_guzergahDal.GetAll(), Messages.GuzergahList);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Guzergah>>(Messages.GuzergahListError);
            }
        }

        public IResult Update(Guzergah guzergah)
        {
            try
            {
                _guzergahDal.Update(guzergah);
                return new SuccessResult(Messages.GuzergahUpdate);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.GuzergahUpdateError);
            }
        }
    }
}
