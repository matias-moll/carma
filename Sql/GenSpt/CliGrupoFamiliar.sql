/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 01/12/2020 21:33
// Sistema     : Carm
// Tabla       : CliGrupoFamiliar
//----------------------------------------------------------------------------
// � 1999-2020 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_UP'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numfamiliar,
                cgf_des_nombre,
                cgf_des_apellido,
                cgf_d20_dni,
                cgf_fec_fecnacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
          where deleted = 0
          order by cgf_nro_numcliente,
                cgf_nro_numfamiliar
      end
   else
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numfamiliar,
                cgf_des_nombre,
                cgf_des_apellido,
                cgf_d20_dni,
                cgf_fec_fecnacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
          order by cgf_nro_numcliente,
                cgf_nro_numfamiliar
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@cgf_nro_numfamiliar">Num Familiar</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_CHKVERSION
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numfamiliar tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Carm..CliGrupoFamiliar
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numfamiliar = @cgf_nro_numfamiliar
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@cgf_nro_numfamiliar">Num Familiar</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_SEARCH
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numfamiliar tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numfamiliar,
                cgf_des_nombre,
                cgf_des_apellido,
                cgf_d20_dni,
                cgf_fec_fecnacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
          where cgf_nro_numcliente = @cgf_nro_numcliente
            and cgf_nro_numfamiliar = @cgf_nro_numfamiliar
            and deleted = 0
      end
   else
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numfamiliar,
                cgf_des_nombre,
                cgf_des_apellido,
                cgf_d20_dni,
                cgf_fec_fecnacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
          where cgf_nro_numcliente = @cgf_nro_numcliente
            and cgf_nro_numfamiliar = @cgf_nro_numfamiliar
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FSEARCH
(
@cgf_nro_numcliente tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numfamiliar,
                cgf_des_nombre,
                cgf_des_apellido,
                cgf_d20_dni,
                cgf_fec_fecnacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
          where cgf_nro_numcliente = @cgf_nro_numcliente
            and deleted = 0
          order by cgf_nro_numfamiliar
      end
   else
      begin
         Select cgf_nro_numcliente,
                cgf_nro_numfamiliar,
                cgf_des_nombre,
                cgf_des_apellido,
                cgf_d20_dni,
                cgf_fec_fecnacimiento,
                cgf_ede_obrasocial,
                TNGS_Carm..CliGrupoFamiliar.instante,
                TNGS_Carm..CliGrupoFamiliar.deleted,
                TNGS_Carm..CliGrupoFamiliar.usuario,
                TNGS_Carm..CliGrupoFamiliar.version
           from TNGS_Carm..CliGrupoFamiliar
          where cgf_nro_numcliente = @cgf_nro_numcliente
          order by cgf_nro_numfamiliar
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@cgf_nro_numfamiliar">Num Familiar</param>
--- <param name="@cgf_des_nombre">Nombre</param>
--- <param name="@cgf_des_apellido">Apellido</param>
--- <param name="@cgf_d20_dni">DNI</param>
--- <param name="@cgf_fec_fecnacimiento">Fecha Nacimiento</param>
--- <param name="@cgf_ede_obrasocial">Obra Social</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_INSERT
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numfamiliar tngs_numero,
@cgf_des_nombre tngs_descripcion,
@cgf_des_apellido tngs_descripcion,
@cgf_d20_dni tngs_descripcion_20,
@cgf_fec_fecnacimiento tngs_fecha,
@cgf_ede_obrasocial tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Carm..CliGrupoFamiliar
   values (
           @cgf_nro_numcliente,
           @cgf_nro_numfamiliar,
           @cgf_des_nombre,
           @cgf_des_apellido,
           @cgf_d20_dni,
           @cgf_fec_fecnacimiento,
           @cgf_ede_obrasocial,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@cgf_nro_numfamiliar">Num Familiar</param>
--- <param name="@cgf_des_nombre">Nombre</param>
--- <param name="@cgf_des_apellido">Apellido</param>
--- <param name="@cgf_d20_dni">DNI</param>
--- <param name="@cgf_fec_fecnacimiento">Fecha Nacimiento</param>
--- <param name="@cgf_ede_obrasocial">Obra Social</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_UPDATE
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numfamiliar tngs_numero,
@cgf_des_nombre tngs_descripcion,
@cgf_des_apellido tngs_descripcion,
@cgf_d20_dni tngs_descripcion_20,
@cgf_fec_fecnacimiento tngs_fecha,
@cgf_ede_obrasocial tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliGrupoFamiliar
      set cgf_des_nombre= @cgf_des_nombre,
          cgf_des_apellido= @cgf_des_apellido,
          cgf_d20_dni= @cgf_d20_dni,
          cgf_fec_fecnacimiento= @cgf_fec_fecnacimiento,
          cgf_ede_obrasocial= @cgf_ede_obrasocial,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numfamiliar = @cgf_nro_numfamiliar

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@cgf_nro_numfamiliar">Num Familiar</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_DELETE
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numfamiliar tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliGrupoFamiliar
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numfamiliar = @cgf_nro_numfamiliar

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro por clave foranea
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FDELETE
(
@cgf_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Carm..CliGrupoFamiliar
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where cgf_nro_numcliente = @cgf_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@cgf_nro_numfamiliar">Num Familiar</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_RECALL
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numfamiliar tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Carm..CliGrupoFamiliar
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numfamiliar = @cgf_nro_numfamiliar

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera l�gicamente los registros de una clave foranea
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FRECALL
(
@cgf_nro_numcliente tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Carm..CliGrupoFamiliar
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cgf_nro_numcliente = @cgf_nro_numcliente
      end
   else
      begin
         Update TNGS_Carm..CliGrupoFamiliar
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where cgf_nro_numcliente = @cgf_nro_numcliente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@cgf_nro_numfamiliar">Num Familiar</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_DROP
(
@cgf_nro_numcliente tngs_numero,
@cgf_nro_numfamiliar tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliGrupoFamiliar
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and cgf_nro_numfamiliar = @cgf_nro_numfamiliar

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro por clave for�nea
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FDROP
(
@cgf_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliGrupoFamiliar
    where cgf_nro_numcliente = @cgf_nro_numcliente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Carm..CliGrupoFamiliar
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente los registro borrados l�gicamente por clave for�nea
--- </summary>
--- <param name="@cgf_nro_numcliente">Num Cliente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CLIGRUPOFAMILIAR_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CLIGRUPOFAMILIAR_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CLIGRUPOFAMILIAR_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CLIGRUPOFAMILIAR_FPACK
(
@cgf_nro_numcliente tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Carm..CliGrupoFamiliar
    where cgf_nro_numcliente = @cgf_nro_numcliente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CLIGRUPOFAMILIAR_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: CliGrupoFamiliar
//--------------------------------------------------------------------------*/