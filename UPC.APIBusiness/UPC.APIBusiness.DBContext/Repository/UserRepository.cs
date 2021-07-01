using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UPC.APIBusiness.API.Constantes;

namespace DBContext
{
    public class UserRepository : BaseRepository, IUserRepository
    {

        public EntityUser Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
            {
                var mensaje = string.Format("{0}|{1}", ConstantesError.ERROR_VALOR_NULO_CODIGO, string.Format("{0}", "Login no puede ser nulo o vacío."));
                throw new Exception(mensaje);
            }

            if (string.IsNullOrEmpty(password))
            {
                var mensaje = string.Format("{0}|{1}", ConstantesError.ERROR_VALOR_NULO_CODIGO, string.Format("{0}", "Clave no puede ser nulo o vacío."));
                throw new Exception(mensaje);
            }

            var returnEntity = new EntityUser();
            using (var db = GetSqlConnection())
            {
                const string sql = @"g3_usuario_login_pa";

                var p = new DynamicParameters();
                p.Add(name: "@p_email", value: email, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add(name: "@p_password", value: password, dbType: DbType.String, direction: ParameterDirection.Input);

                returnEntity = db.Query<EntityUser>(sql: sql, param: p, commandType: CommandType.StoredProcedure).FirstOrDefault();

                if (returnEntity == null)
                {
                    var mensaje = string.Format("{0}|{1}", ConstantesError.ERROR_CONTRASENA_INCORRECTO_CODIGO, string.Format("{0}", "Clave incorrecta."));
                    throw new Exception(mensaje);
                }

                returnEntity.Profile = ObtenerProfilePorId(returnEntity.IdProfile);
            }


            return returnEntity;
        }

        public EntityUser ObtenerPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public EntityUser ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public EntityProfile ObtenerProfilePorId(int idprofile = 0)
        {
            if (idprofile == 0)
            {
                var mensaje = string.Format("{0}|{1}", ConstantesError.ERROR_VALOR_NULO_CODIGO, string.Format("{0}", "idprofile no puede ser nulo o vacío."));
                throw new Exception(mensaje);
            }

            var returnEntity = new EntityProfile();
            using (var db = GetSqlConnection())
            {
                const string sql = @"g3_profile_obtenerporid_pa";

                var p = new DynamicParameters();
                p.Add(name: "@p_id", value: idprofile, dbType: DbType.Int32, direction: ParameterDirection.Input);

                returnEntity = db.Query<EntityProfile>(sql: sql, param: p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return returnEntity;
        }

        public List<EntitySidebar> ObtenerSidebar(int idprofile = 0)
        {
            if (idprofile == 0)
            {
                var mensaje = string.Format("{0}|{1}", ConstantesError.ERROR_VALOR_NULO_CODIGO, string.Format("{0}", "idprofile no puede ser nulo o vacío."));
                throw new Exception(mensaje);
            }

            var returnEntity = new List<EntitySidebar>();
            using (var db = GetSqlConnection())
            {
                const string sql = @"g3_sidebar_obtenerporprofile_pa";

                var p = new DynamicParameters();
                p.Add(name: "@p_idprofile", value: idprofile, dbType: DbType.Int32, direction: ParameterDirection.Input);

                returnEntity = db.Query<EntitySidebar>(sql: sql, param: p, commandType: CommandType.StoredProcedure).ToList();
            }

            return returnEntity;
        }

        public EntityUserProfile ObtenerUserProfile(int iduser = 0)
        {
            if (iduser == 0)
            {
                var mensaje = string.Format("{0}|{1}", ConstantesError.ERROR_VALOR_NULO_CODIGO, string.Format("{0}", "iduser no puede ser nulo o vacío."));
                throw new Exception(mensaje);
            }

            var returnEntity = new EntityUserProfile();
            using (var db = GetSqlConnection())
            {
                const string sql = @"g3_userprofile_obtenerporiduser_pa";

                var p = new DynamicParameters();
                p.Add(name: "@p_iduser", value: iduser, dbType: DbType.Int32, direction: ParameterDirection.Input);

                returnEntity = db.Query<EntityUserProfile>(sql: sql, param: p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return returnEntity;
        }
    }
}
