/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 04/01/2023 00:02
// Base de Datos      : TNGS_Carm
// Objetivo           : Creaci�n de los usuarios de la base
//----------------------------------------------------------------------------
// � 1999-2023 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
/  **************************************************************************/

/*-------------------------------*/
/* Selecciono la base de trabajo */
/*-------------------------------*/

use TNGS_Carm
go

/*--------------------------------------------------------------------------*/
/* Creacion de los usuarios                                                 */
/*--------------------------------------------------------------------------*/

print 'Creando Usuario:  tngsmodulos'
print ' '

if not exists (select * from sysusers where name = 'tngsmodulos' and uid < 16382)
   EXEC sp_adduser 'tngsmodulos', 'tngsmodulos', 'public'
go

print 'Creando Usuario:  tngsqbe'
print ' '

if not exists (select * from sysusers where name = 'tngsqbe' and uid < 16382)
   EXEC sp_adduser 'tngsqbe', 'tngsqbe', 'public'
go

print 'Creando Usuario:  tngsview'
print ' '

if not exists (select * from sysusers where name = 'tngsview' and uid < 16382)
   EXEC sp_adduser 'tngsview', 'tngsview', 'public'
go

/*--------------------------------------------------------------------------*/
/* Fin del programa: Scrp01.sql                                             */
/*--------------------------------------------------------------------------*/
