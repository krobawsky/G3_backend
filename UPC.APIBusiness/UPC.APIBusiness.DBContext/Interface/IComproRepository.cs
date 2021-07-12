using DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBContext
{
    public interface IComproRepository
    {
        List<EntityCompro> getComproByRuc(string ruc);


        List<EntityCompro> getComproByDate(string date);
    }
}
