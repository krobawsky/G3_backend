﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UPC.APIBusiness.API.Constantes
{
    public static class Constantes
    {
        public static string Aplicacion = "API Inka";
    }

    public static class ConstantesSuccess
    {
        public const string RESPONSE_OK_CODIGO = "2000";
        public const string RESPONSE_OK_MENSAJE = "CORRECTO";
    }

    public static class ConstantesError
    {
        public const string ERROR_NO_CONTROLADO_CODIGO = "5000";
        public const string ERROR_NO_CONTROLADO_MENSAJE = "ERROR NO CONTROLADO";

        public const string ERROR_CABECERA_AUTHORIZATION_NULO_CODIGO = "5001";
        public const string ERROR_CABECERA_AUTHORIZATION_NULO_MENSAJE = "CABECERA AUTHORIZATION NULO O VACIO";

        public const string ERROR_TOKEN_NULO_CODIGO = "5002";
        public const string ERROR_TOKEN_NULO_MENSAJE = "TOKEN ES NULL O VACIO";

        public const string ERROR_TOKEN_FORMATO_INCORRECTO_CODIGO = "5003";
        public const string ERROR_TOKEN_FORMATO_INCORRECTO_MENSAJE = "FORMATO DE TOKEN INCORRECTO";

        public const string ERROR_USUARIO_NO_AUTORIZADO_CODIGO = "5004";
        public const string ERROR_USUARIO_NO_AUTORIZADO_MENSAJE = "NO AUTORIZADO";

        public const string ERROR_FALLA_INICIO_SESION_CODIGO = "5005";
        public const string ERROR_FALLA_INICIO_SESION_MENSAJE = "NO SE PUDO INICIAR SESION";

        public const string ERROR_NO_AUTENTICADO_EN_AD_CODIGO = "5006";
        public const string ERROR_NO_AUTENTICADO_EN_AD_MENSAJE = "NO AUTENTICADO EN EL DIRECTORIO ACTIVO";

        public const string ERROR_USUARIO_NO_EXISTE_CODIGO = "5007";
        public const string ERROR_USUARIO_NO_EXISTE_MENSAJE = "USUARIO NO EXISTE";

        public const string ERROR_CONTRASENA_INCORRECTO_CODIGO = "5008";
        public const string ERROR_CONTRASENA_INCORRECTO_MENSAJE = "CONTRASEÑA ACTUAL NO ES CORRECTA";

        public const string ERROR_PARAMETRO_CABECERA_REQUIREDO_CODIGO = "5011";
        public const string ERROR_PARAMETRO_CABECERA_REQUIREDO_MENSAJE = "PARAMETRO EN CABECERA ES REQUERIDO";

        public const string ERROR_APLICACION_NO_EXISTE_CODIGO = "5012";
        public const string ERROR_APLICACION_NO_EXISTE_MENSAJE = "APLICACION NO EXISTE";

        public const string ERROR_INVOCAR_AD_SERVICIO_CODIGO = "5013";
        public const string ERROR_INVOCAR_AD_SERVICIO_MENSAJE = "ERROR AL INVOCAR AL API REST VALIDACION ACTIVE DIRECTORY";

        public const string ERROR_AD_USUARIO_CONTRASENA_INVALIDO_CODIGO = "5014";
        public const string ERROR_AD_USUARIO_CONTRASENA_INVALIDO_MENSAJE = "USUARIO O CLAVE INVALIDOS EN ACTIVE DIRECTORY";

        public const string ERROR_AD_USUARIO_NO_ACTIVO_CODIGO = "5015";
        public const string ERROR_AD_USUARIO_NO_ACTIVO_MENSAJE = "USUARIO NO ACTIVO EN ACTIVE DIRECTORY";

        public const string ERROR_TOKEN_EXPIRADO_CODIGO = "5016";
        public const string ERROR_TOKEN_EXPIRADO_MENSAJE = "TOKEN EXPIRADO";

        public const string ERROR_VALOR_NULO_CODIGO = "5017";
        public const string ERROR_VALOR_NULO_MENSAJE = "VALOR NULO";

        public const string ERROR_CODIGO_VERIFICACION_EXPIRADO_CODIGO = "5019";
        public const string ERROR_CODIGO_VERIFICACION_EXPIRADO_MENSAJE = "ERROR DE CODIGO, EXPIRADO";

        public const string ERROR_USUARIO_NO_ACTIVO_CODIGO = "5021";
        public const string ERROR_USUARIO_NO_ACTIVO_MENSAJE = "USUARIO INACTIVO";

        public const string ERROR_CONTRASENA_NO_VALIDO_CODIGO = "5022";
        public const string ERROR_CONTRASENA_NO_VALIDO_MENSAJE = "ERROR INGRESANDO LA CONTRASEÑA";

        public const string ERROR_MODULO_ENTIDAD_REGISTRAR_FALLA_CODIGO = "5023";
        public const string ERROR_MODULO_ENTIDAD_REGISTRAR_FALLA_MENSAJE = "ERROR MODULO {0}, ERROR AL INSERTAR NUEVO";

        public const string ERROR_MODULO_ENTIDAD_ACTUALIZAR_FALLA_CODIGO = "5024";
        public const string ERROR_MODULO_ENTIDAD_ACTUALIZAR_FALLA_MENSAJE = "ERROR MODULO {0}, ERROR AL ACTUALIZAR";

        public const string ERROR_INVOCAR_SERVICIO_CODIGO = "5025";
        public const string ERROR_INVOCAR_SERVICIO_MENSAJE = "ERROR AL INVOCAR AL SERVICIO API REST";

        public const string ERROR_INVOCAR_SERVICIO_RESULTADO_NULO_CODIGO = "5026";
        public const string ERROR_INVOCAR_SERVICIO_RESULTADO_NULO_MENSAJE = "ERROR EL RESULTADO DEL SERVICIO ES NULO";

        public const string ERROR_ENTIDAD_NO_EXISTE_ID_CODIGO = "5027";
        public const string ERROR_ENTIDAD_NO_EXISTE_ID_MENSAJE = "NO SE ENCONTRO DATOS CON ID";

        public const string ERROR_ENTIDAD_CAMPO_REQUERIDO_CODIGO = "5028";
        public const string ERROR_ENTIDAD_CAMPO_REQUERIDO_MENSAJE = "EL CAMPO ES REQUERIDO O NO ES VALIDO, VALIDAR DATOS ENVIADOS.";

        public const string ERROR_ENTIDAD_VALORES_REPETIDOS_CODIGO = "5029";
        public const string ERROR_ENTIDAD_VALORES_REPETIDOS_MENSAJE = "LOS VALORES DE LOGIN (NUMERO DE DOCUMENTO) O CORREO YA EXISTEN.";

        public const string ERROR_MODULO_ENTIDAD_ELIMINAR_FALLA_CODIGO = "5030";
        public const string ERROR_MODULO_ENTIDAD_ELIMINAR_FALLA_MENSAJE = "ERROR MODULO {0}, ERROR AL ELIMINAR";
    }
}
