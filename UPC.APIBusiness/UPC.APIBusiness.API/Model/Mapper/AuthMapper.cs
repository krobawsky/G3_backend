using AutoMapper;
using DBEntity;
using System;
using static UPC.APIBusiness.API.Model.Compro;

namespace UPC.APIBusiness.API.Model
{
    public class AuthMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region auth

            #region request 
            CreateMap<LoginRequest, EntityUser>();
            CreateMap<EntityUser, LoginRequest>();
            #endregion

            CreateMap<UsuarioResponseData, EntityUser>();
            CreateMap<EntityUser, UsuarioResponseData>();

            CreateMap<ProfileResponseData, EntityProfile>();
            CreateMap<EntityProfile, ProfileResponseData>();

            CreateMap<UserProfileResponseData, EntityUserProfile>();
            CreateMap<EntityUserProfile, UserProfileResponseData>();

            CreateMap<SidebarResponseData, EntitySidebar>();
            CreateMap<EntitySidebar, SidebarResponseData>();

            #endregion


            #region compro
            CreateMap<ComproResponseData, EntityCompro>();
            CreateMap<EntityCompro, ComproResponseData>();

            #endregion
        }
    }
}
