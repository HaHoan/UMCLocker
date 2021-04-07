using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMCLocker.Entities
{
    public interface IModelEntities
    {
        ResultInfo Insert();
        ResultInfo Update();
        ResultInfo Delete();
        IEnumerable GetAllData();
    }
}
