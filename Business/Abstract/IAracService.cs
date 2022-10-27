using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.OperationResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAracService
    {
        IDataResult<List<Arac>> GetAll();
        IResult Add(Arac arac);
        IResult Delete(Arac arac);
        IResult DeleteAll(List<Arac> araclar);
        IResult Update(Arac arac);
    }
}
