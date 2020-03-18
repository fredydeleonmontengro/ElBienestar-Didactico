using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Odbc;
namespace CapaLogica
{
    public class Logica
    {
        Sentencias sn = new Sentencias();
        public OdbcDataReader verificacionJornada(string numero)
        {
            return sn.consultaJornada(numero);
        }

        //------------------------------------------------------------------------------------------------------INSERTS-------------------------------------------------------//
        public OdbcDataReader Insertarconcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            return sn.Insertarconcepto(sCodigo, sNombre, sTipoconcepto, ssaldo, stipoaccion, sestado);
            
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarConcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            return sn.modificarconcepto(sCodigo, sNombre, sTipoconcepto, ssaldo, stipoaccion, sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminarconcepto(string sCodigo)
        {
            return sn.eliminarconcepto(sCodigo);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
    }
}

