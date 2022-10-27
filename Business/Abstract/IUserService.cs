using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.OperationResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IResult DeleteAll(List<User> users);
        IResult Update(User user);
        IDataResult<string> ValidUser(string username, string password);
        IDataResult<User> GetByUsername(string username);
    }
}
