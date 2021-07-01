using DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBContext
{
    public interface IUserRepository
    {
        EntityUser ObtenerPorId(int id);

        EntityUser Login(string email, string password);

        EntityUser ObtenerPorEmail(string email);

        EntityProfile ObtenerProfilePorId(int idprofile);

        List<EntitySidebar> ObtenerSidebar(int idprofile);

        EntityUserProfile ObtenerUserProfile(int iduser);

    }
}
