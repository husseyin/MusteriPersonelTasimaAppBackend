using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.OperationResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGuzergahService
    {
        IDataResult<List<Guzergah>> GetAll();
        IResult Add(Guzergah guzergah);
        IResult Delete(Guzergah guzergah);
        IResult DeleteAll(List<Guzergah> guzergahlar);
        IResult Update(Guzergah guzergah);
    }
}
