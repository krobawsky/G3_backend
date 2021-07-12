using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DBContext
{
    public class ComproRepository : BaseRepository, IComproRepository
    {
        public List<EntityCompro> getComproByDate(string date)
        {
            var returnEntity = new List<EntityCompro>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    var p = new DynamicParameters();
                    p.Add(name: "@fActual", value: date, dbType: DbType.String, direction: ParameterDirection.Input);

                    const string sql = @"g3_Comprobante_BuscarTodo";
                    returnEntity = db.Query<EntityCompro>(sql: sql, param: p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnEntity;
        }

        public List<EntityCompro> getComproByRuc(string ruc)
        {
            var returnEntity = new List<EntityCompro>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    var p = new DynamicParameters();
                    p.Add(name: "@ruc", value: ruc, dbType: DbType.String, direction: ParameterDirection.Input);

                    const string sql = @"g3_Comprobante_BuscarRuc";
                    returnEntity = db.Query<EntityCompro>(sql: sql, param: p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnEntity;
        }
    }
}
