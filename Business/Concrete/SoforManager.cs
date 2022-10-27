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
    public class SoforManager : ISoforService
    {
        ISoforDal _soforDal;

        public SoforManager(ISoforDal soforDal)
        {
            _soforDal = soforDal;
        }

        // REFACTORING !!

        public IResult Add(Sofor sofor)
        {
            try
            {
                _soforDal.Add(sofor);
                return new SuccessResult(Messages.SoforAdd);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.SoforAddError);
            }
        }

        public IResult Delete(Sofor sofor)
        {
            try
            {
                _soforDal.Delete(sofor);
                return new SuccessResult(Messages.SoforDelete);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.SoforDeleteError);
            }
        }

        public IResult DeleteAll(List<Sofor> soforler)
        {
            try
            {
                _soforDal.DeleteAll(soforler);
                return new SuccessResult(Messages.SoforDeleteAll);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.SoforDeleteAllError);
            }
        }

        public IDataResult<List<Sofor>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Sofor>>(_soforDal.GetAll(), Messages.SoforList);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Sofor>>(Messages.SoforListError);
            }
        }

        public IResult Update(Sofor sofor)
        {
            try
            {
                _soforDal.Update(sofor);
                return new SuccessResult(Messages.SoforUpdate);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.SoforUpdateError);
            }
        }
    }
}
