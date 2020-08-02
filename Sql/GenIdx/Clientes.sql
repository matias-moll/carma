/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
//----------------------------------------------------------------------------
// Fecha              : 25/07/2020 18:48
// Base de Datos      : TNGS_Carm
// Tabla              : Clientes
//----------------------------------------------------------------------------
// � 1999-2020 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
/  **************************************************************************/

/*-----------------------------------------------------*/
/* Selecciono la base en la que se crearan los indices */
/*-----------------------------------------------------*/

use TNGS_Carm
go

/*-----------------------------------------------
// Crea el indice: is1
//-----------------------------------------------*/

print 'Indice: Clientes_is1'

print '    - Creando el nuevo indice'

create index Clientes_is1 on Clientes
   (
       cli_cd6_codvend
   )
go

print '  '
go

/*-----------------------------------------------
// Crea el indice: is2
//-----------------------------------------------*/

print 'Indice: Clientes_is2'

print '    - Creando el nuevo indice'

create index Clientes_is2 on Clientes
   (
       cli_fec_ffinres
   )
go

print '  '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los indices de la tabla: Clientes
//--------------------------------------------------------------------------*/