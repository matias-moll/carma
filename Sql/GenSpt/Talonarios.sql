/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 06/01/2023 01:01
// Sistema     : Carm
// Tabla       : Talonarios
//----------------------------------------------------------------------------
// � 1999-2023 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Carm
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Carm..Talonarios.instante,
                TNGS_Carm..Talonarios.deleted,
                TNGS_Carm..Talonarios.usuario,
                TNGS_Carm..Talonarios.version
           from TNGS_Carm..Talonarios
          where deleted = 0
          order by tal_xcd_codigo
      end
   else
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Carm..Talonarios.instante,
                TNGS_Carm..Talonarios.deleted,
                TNGS_Carm..Talonarios.usuario,
                TNGS_Carm..Talonarios.version
           from TNGS_Carm..Talonarios
          order by tal_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_CHKVERSION
(
@tal_xcd_codigo tngs_codigo_x,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..Talonarios
    where tal_xcd_codigo = @tal_xcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_SEARCH
(
@tal_xcd_codigo tngs_codigo_x,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Carm..Talonarios.instante,
                TNGS_Carm..Talonarios.deleted,
                TNGS_Carm..Talonarios.usuario,
                TNGS_Carm..Talonarios.version
           from TNGS_Carm..Talonarios with (XLOCK)
          where tal_xcd_codigo = @tal_xcd_codigo
            and deleted = 0
      end
   else
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Carm..Talonarios.instante,
                TNGS_Carm..Talonarios.deleted,
                TNGS_Carm..Talonarios.usuario,
                TNGS_Carm..Talonarios.version
           from TNGS_Carm..Talonarios with (XLOCK)
          where tal_xcd_codigo = @tal_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@tal_des_descripcion">Descripci�n</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">N�mero</param>
--- <param name="@tal_fyh_referencia">Referencia</param>
--- <param name="@tal_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_INSERT
(
@tal_xcd_codigo tngs_codigo_x,
@tal_des_descripcion tngs_descripcion,
@tal_cd1_tipo tngs_codigo_1,
@tal_nro_valor tngs_numero,
@tal_fyh_referencia tngs_fecyhor,
@tal_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..Talonarios
   values (
           @tal_xcd_codigo,
           @tal_des_descripcion,
           @tal_cd1_tipo,
           @tal_nro_valor,
           @tal_fyh_referencia,
           @tal_rob_detalle,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@tal_des_descripcion">Descripci�n</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">N�mero</param>
--- <param name="@tal_fyh_referencia">Referencia</param>
--- <param name="@tal_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_UPDATE
(
@tal_xcd_codigo tngs_codigo_x,
@tal_des_descripcion tngs_descripcion,
@tal_cd1_tipo tngs_codigo_1,
@tal_nro_valor tngs_numero,
@tal_fyh_referencia tngs_fecyhor,
@tal_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Talonarios
      set tal_des_descripcion= @tal_des_descripcion,
          tal_cd1_tipo= @tal_cd1_tipo,
          tal_nro_valor= @tal_nro_valor,
          tal_fyh_referencia= @tal_fyh_referencia,
          tal_rob_detalle= @tal_rob_detalle,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_DELETE
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Talonarios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_RECALL
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..Talonarios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_DROP
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..Talonarios
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente los registros borrados l�gicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..Talonarios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Talonarios
//--------------------------------------------------------------------------*/
