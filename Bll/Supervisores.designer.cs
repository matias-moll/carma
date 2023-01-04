#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Carm;
using Carm.Bel;
#endregion

namespace Carm.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 03/01/2023 23:43
    // Sistema                  : Carm
    // Clase para Administrar   : Supervisores
    //----------------------------------------------------------------------------
    // � 1996-2023 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma autom�tica. Cualquier
    //    modificaci�n que se realize sobre ella se perder� en la pr�xima
    //    regeneraci�n.
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Supervisores
    /// </summary>
    public static partial class Supervisores
    {

        //**********************************************************
        //
        // Funciones para la Tabla: Supervisores
        // Usando ClaseDal        : Supervisores
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Supervisores
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LESupervisores</returns>
        public static LESupervisores UpFull(bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return Upfl(l_dbcAccess, p_bOnlyActive, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Devuelve una entidad: ESupervisor
        /// </summary>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ESupervisor</returns>
        public static ESupervisor Get(string p_strCod,
                                      bool p_bOnlyActive,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ESupervisor
                return Srch(l_dbcAccess,
                            p_strCod,
                            p_bOnlyActive,
                            p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Supervisores
        /// </summary>
        /// <param name="p_entSupervisor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Save(ESupervisor p_entSupervisor,
                                StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ESupervisor
                SSav(l_dbcAccess, p_entSupervisor, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Supervisores
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Enabled(bool p_bEnable,
                                   string p_strCod,
                                   int p_iFxdVersion,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Enabled_f(l_dbcAccess,
                          p_bEnable,
                          p_strCod,
                          ref p_iFxdVersion,
                          p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                VKey(l_dbcAccess,
                     p_strCod,
                     p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Supervisor) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                VVer(l_dbcAccess, 
                     p_strCod,
                     p_iFxdVersion,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Supervisores.Recall(l_dbcAccess,
                                            p_strCod,
                                            p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Supervisores.Delete(l_dbcAccess,
                                            p_strCod,
                                            p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Supervisores
        /// </summary>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Remove(string p_strCod,
                                  int p_iFxdVersion,
                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Remove_f(l_dbcAccess,
                         p_strCod,
                         p_iFxdVersion,
                         p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                Drop(l_dbcAccess,
                     p_strCod,
                     p_iFxdVersion,
                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Purge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                Pack(l_dbcAccess,
                     p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: Supervisor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSupervisor">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt(DBConn p_dbcAccess,
                                  ESupervisor p_entSupervisor,
                                  StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entSupervisor.Cod.Trim() == "") {
                // El campo [C�digo] no puede ser vac�o
                p_smResult.BllWarning("El dato [C�digo] no puede ser vac�o","");
                return;
            }

            if (p_entSupervisor.Apellido.Trim() == "") {
                // El campo [Apellido] no puede ser vac�o
                p_smResult.BllWarning("El dato [Apellido] no puede ser vac�o","");
                return;
            }

            if (p_entSupervisor.Nombre.Trim() == "") {
                // El campo [Nombre] no puede ser vac�o
                p_smResult.BllWarning("El dato [Nombre] no puede ser vac�o","");
                return;
            }

            if (p_entSupervisor.Usuario.Trim() == "") {
                // El campo [Usuario del Sistema] no puede ser vac�o
                p_smResult.BllWarning("El dato [Usuario del Sistema] no puede ser vac�o","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            TInt_f(p_dbcAccess, p_entSupervisor, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VVer(DBConn p_dbcAccess,
                                  string p_strCod,
                                  int p_iFxdVersion,
                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.Supervisores.ChkVersion(p_dbcAccess,
                                        p_strCod,
                                        p_iFxdVersion,
                                        ref l_dsTemp,
                                        "Temporal",
                                        p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
            StreamWriter l_swErrorFile= null;
            string l_strErrFName= String.Format("C:\\V{0:ddMMyyyyHHmmss}.Err",
                                                DateTime.Now);
            try {
                // Creamos el archivo del error
                l_swErrorFile= new StreamWriter(File.Create(l_strErrFName),
                                                System.Text.Encoding.ASCII);

                // Grabamos los datos del error
                l_swErrorFile.WriteLine("Instante    : {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
                l_swErrorFile.WriteLine("Metodo      : {0}", p_smResult.Method);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.Message;
            }
            finally {
                // Si llegamos a abrir el archivo -> lo cerramos
                if (l_swErrorFile != null) {
                    l_swErrorFile.Close();
                    l_swErrorFile.Dispose();
                }
            }

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (Supervisor) no coincide.\r\nOperaci�n cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ESupervisor
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VKey(DBConn p_dbcAccess,
                                  string p_strCod,
                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Supervisores.Search(p_dbcAccess,
                                    p_strCod,
                                    false,
                                    ref l_dsTemp,
                                    "Temporal",
                                    p_smResult);
            if (p_smResult.NOk) return;

            try {
                // Verificamos si vino algun registro
                p_smResult.BllICode(BllCodes.KeyDsntFound);
                if (l_dsTemp.Tables["Temporal"].Rows.Count == 0) return;

                // Verificamos si el registro que vino esta habilitado
                p_smResult.BllICode(BllCodes.KeyDisabled);
                if ((decimal) l_dsTemp.Tables["Temporal"].Rows[0]["deleted"] == 1) return;

                // La clave existia y estaba habilitada
                p_smResult.BllICode(BllCodes.KeyExists);
            }
            finally {
                // Terminamos
                l_dsTemp.Dispose();
            }
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LESupervisores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LESupervisores</returns>
        internal static LESupervisores Upfl(DBConn p_dbcAccess,
                                                bool p_bOnlyActive,
                                                StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Supervisores
                DataSet l_dsTemp= new DataSet();

                Dal.Supervisores.Up(p_dbcAccess, 
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Supervisores.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LESupervisores l_lentRet= new LESupervisores(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve una entidad: ESupervisor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ESupervisor</returns>
        internal static ESupervisor Srch(DBConn p_dbcAccess,
                                         string p_strCod,
                                         bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Supervisores
                DataSet l_dsTemp= new DataSet();

                Dal.Supervisores.Search(p_dbcAccess, 
                                        p_strCod,
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ESupervisor l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ESupervisor(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData);
                return null;
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Supervisores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSupervisor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SSav(DBConn p_dbcAccess,
                                  ESupervisor p_entSupervisor,
                                  StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                Save_f(p_dbcAccess, ref p_entSupervisor, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                VKey(p_dbcAccess, 
                     p_entSupervisor.Cod,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entSupervisor.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (Supervisor) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    Insr(p_dbcAccess, p_entSupervisor, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (Supervisor) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                VVer(p_dbcAccess, 
                     p_entSupervisor.Cod,
                     p_entSupervisor.FxdVersion,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                Updt(p_dbcAccess, p_entSupervisor, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ESupervisor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSupervisor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Insr(DBConn p_dbcAccess,
                                  ESupervisor p_entSupervisor,
                                  StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entSupervisor, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Supervisores
                Dal.Supervisores.Insert(p_dbcAccess,
                                        p_entSupervisor.Cod,
                                        p_entSupervisor.Apellido,
                                        p_entSupervisor.Nombre,
                                        p_entSupervisor.Usuario,
                                        p_entSupervisor.Tel,
                                        p_entSupervisor.Cel,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ESupervisor
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entSupervisor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Updt(DBConn p_dbcAccess,
                                  ESupervisor p_entSupervisor,
                                  StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entSupervisor, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Supervisores
                Dal.Supervisores.Update(p_dbcAccess,
                                        p_entSupervisor.Cod,
                                        p_entSupervisor.Apellido,
                                        p_entSupervisor.Nombre,
                                        p_entSupervisor.Usuario,
                                        p_entSupervisor.Tel,
                                        p_entSupervisor.Cel,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: Supervisores
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Drop(DBConn p_dbcAccess,
                                  string p_strCod,
                                  int p_iFxdVersion,
                                  StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                VKey(p_dbcAccess,
                     p_strCod,
                     p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Supervisor) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                VVer(p_dbcAccess, 
                     p_strCod,
                     p_iFxdVersion,
                     p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.Supervisores.Drop(p_dbcAccess,
                                      p_strCod,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Pack(DBConn p_dbcAccess,
                                  StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.Supervisores.Pack(p_dbcAccess,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion
    }
}
