using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.OperationResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoforService
    {
        IDataResult<List<Sofor>> GetAll();
        IResult Add(Sofor sofor);
        IResult Delete(Sofor sofor);
        IResult DeleteAll(List<Sofor> soforler);
        IResult Update(Sofor sofor);
    }
}
