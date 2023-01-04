#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Carm;
using Carm.Bel;
#endregion

namespace Carm.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 04/01/2023 00:04
    // Sistema                  : Carm
    // Clase para Administrar   : Tablas
    //----------------------------------------------------------------------------
    // � 1996-2023 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Tablas
    /// </summary>
    public static partial class Tablas
    {
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        #region Metodos publicos de la clase
        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: CategoriasLlamada
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoriaLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlSave_f(DBConn p_dbcAccess,
                                       ref ECategoriaLlamada p_entCategoriaLlamada,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: CategoriasLlamada
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: CategoriasLlamada
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: CategoriaLlamada
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoriaLlamada">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtlTInt_f(DBConn p_dbcAccess,
                                       ECategoriaLlamada p_entCategoriaLlamada,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: ConversionColores
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entConversionColor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConSave_f(DBConn p_dbcAccess,
                                       ref EConversionColor p_entConversionColor,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: ConversionColores
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: ConversionColores
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: ConversionColor
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entConversionColor">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ConTInt_f(DBConn p_dbcAccess,
                                       EConversionColor p_entConversionColor,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Franquicias
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entFranquicia">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqSave_f(DBConn p_dbcAccess,
                                       ref EFranquicia p_entFranquicia,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Franquicias
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Franquicias
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Franquicia
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entFranquicia">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void FrqTInt_f(DBConn p_dbcAccess,
                                       EFranquicia p_entFranquicia,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: ListasDePrecios
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entListaDePrecios">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprSave_f(DBConn p_dbcAccess,
                                       ref EListaDePrecios p_entListaDePrecios,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: ListasDePrecios
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: ListasDePrecios
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: ListaDePrecios
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entListaDePrecios">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LprTInt_f(DBConn p_dbcAccess,
                                       EListaDePrecios p_entListaDePrecios,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Localidades
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLocalidad">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocSave_f(DBConn p_dbcAccess,
                                       ref ELocalidad p_entLocalidad,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Localidades
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodpost">C�digo postal</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCodpost,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Localidades
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodpost">C�digo postal</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocRemove_f(DBConn p_dbcAccess,
                                         string p_strCodpost,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Localidad
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLocalidad">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LocTInt_f(DBConn p_dbcAccess,
                                       ELocalidad p_entLocalidad,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: LogClientes
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLogCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcSave_f(DBConn p_dbcAccess,
                                       ref ELogCliente p_entLogCliente,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: LogClientes
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNro,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: LogClientes
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcRemove_f(DBConn p_dbcAccess,
                                         int p_iNro,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: LogCliente
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entLogCliente">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void LgcTInt_f(DBConn p_dbcAccess,
                                       ELogCliente p_entLogCliente,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Marcas
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcSave_f(DBConn p_dbcAccess,
                                       ref EMarca p_entMarca,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Marcas
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Marcas
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Marca
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcTInt_f(DBConn p_dbcAccess,
                                       EMarca p_entMarca,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MotivosLlamada
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivosLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlSave_f(DBConn p_dbcAccess,
                                       ref EMotivosLlamada p_entMotivosLlamada,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MotivosLlamada
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: MotivosLlamada
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MotivosLlamada
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivosLlamada">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtlTInt_f(DBConn p_dbcAccess,
                                       EMotivosLlamada p_entMotivosLlamada,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Parentescos
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entParentesco">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtSave_f(DBConn p_dbcAccess,
                                       ref EParentesco p_entParentesco,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Parentescos
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Parentescos
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Parentesco
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entParentesco">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrtTInt_f(DBConn p_dbcAccess,
                                       EParentesco p_entParentesco,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: PreciosServicios
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPrecioServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsSave_f(DBConn p_dbcAccess,
                                       ref EPrecioServicio p_entPrecioServicio,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: PreciosServicios
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strColor,
                                          DateTime p_dtFecha,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: PreciosServicios
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsRemove_f(DBConn p_dbcAccess,
                                         string p_strColor,
                                         DateTime p_dtFecha,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: PrecioServicio
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entPrecioServicio">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void PrsTInt_f(DBConn p_dbcAccess,
                                       EPrecioServicio p_entPrecioServicio,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: ResEntrevista
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entResEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenSave_f(DBConn p_dbcAccess,
                                       ref EResEntrevista p_entResEntrevista,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: ResEntrevista
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: ResEntrevista
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: ResEntrevista
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entResEntrevista">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RenTInt_f(DBConn p_dbcAccess,
                                       EResEntrevista p_entResEntrevista,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Rubros
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entRubro">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrSave_f(DBConn p_dbcAccess,
                                       ref ERubro p_entRubro,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Rubros
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Rubros
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Rubro
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entRubro">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RbrTInt_f(DBConn p_dbcAccess,
                                       ERubro p_entRubro,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: SituacionesIVA
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSituacionIVA">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivSave_f(DBConn p_dbcAccess,
                                       ref ESituacionIVA p_entSituacionIVA,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: SituacionesIVA
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCodigo,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: SituacionesIVA
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivRemove_f(DBConn p_dbcAccess,
                                         string p_strCodigo,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: SituacionIVA
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSituacionIVA">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SivTInt_f(DBConn p_dbcAccess,
                                       ESituacionIVA p_entSituacionIVA,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoVend
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdSave_f(DBConn p_dbcAccess,
                                       ref ETipoVendedor p_entTipoVendedor,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: TipoVend
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: TipoVend
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: TipoVendedor
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoVendedor">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TvdTInt_f(DBConn p_dbcAccess,
                                       ETipoVendedor p_entTipoVendedor,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoCont
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoCont">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnSave_f(DBConn p_dbcAccess,
                                       ref ETipoCont p_entTipoCont,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: TipoCont
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: TipoCont
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: TipoCont
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoCont">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TcnTInt_f(DBConn p_dbcAccess,
                                       ETipoCont p_entTipoCont,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TipoInst
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoInst">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinSave_f(DBConn p_dbcAccess,
                                       ref ETipoInst p_entTipoInst,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: TipoInst
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: TipoInst
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: TipoInst
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTipoInst">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TinTInt_f(DBConn p_dbcAccess,
                                       ETipoInst p_entTipoInst,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Zonas
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entZona">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsSave_f(DBConn p_dbcAccess,
                                       ref EZona p_entZona,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Zonas
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Zonas
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar ac� los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Zona
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entZona">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ZnsTInt_f(DBConn p_dbcAccess,
                                       EZona p_entZona,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar ac� las validaciones adicionales
            // *********
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
}
