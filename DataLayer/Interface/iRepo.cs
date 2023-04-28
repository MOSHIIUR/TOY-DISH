using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface iRepo<TYPE, ID, RETURN>
    {
        List<TYPE> Get();
        TYPE Get(ID id);
        RETURN Insert(TYPE emp);
        RETURN Update(TYPE emp);
        bool Delete(ID id);

        //The model class the replaced by the `Type`
        //the identefier is replaced by the `ID`
        //return type is replcaed by the `Return`
        //delete just keep as bool, you can change it as well
        
    }
} 
