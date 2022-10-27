using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.OperationResults;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        // REFACTORING !!

        public IResult Add(User user)
        {
            try
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.UserAdd);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.UserAddError);
            }
        }

        public IResult Delete(User user)
        {
            try
            {
                _userDal.Delete(user);
                return new SuccessResult(Messages.UserDelete);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.UserDeleteError);
            }
        }

        public IResult DeleteAll(List<User> users)
        {
            try
            {
                _userDal.DeleteAll(users);
                return new SuccessResult(Messages.UserDeleteAll);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.UserDeleteAllError);
            }
        }

        public IDataResult<List<User>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserList);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<User>>(Messages.UserListError);
            }
        }

        public IDataResult<User> GetByUsername(string username)
        {
            try
            {
                return new SuccessDataResult<User>(_userDal.Get(u => u.KullaniciAdi == username), Messages.UserGet);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<User>(Messages.UserGetError);
            }
        }

        public IResult Update(User user)
        {
            try
            {
                _userDal.Update(user);
                return new SuccessResult(Messages.UserUpdate);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.UserUpdateError);
            }
        }

        public IDataResult<string> ValidUser(string username, string password)
        {
            if (_userDal.GetAll(u => u.KullaniciAdi == username && u.Sifre == password).Any())
            {
                return new SuccessDataResult<string>( TokenManager.GenerateToken(username), Messages.UserValid);
            }

            return new ErrorDataResult<string>(Messages.UserValidError);
        }
    }
}
