using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SubastaHolandesa
{    
    public class Broker : IBroker
    {
        public string registro(int id_grupo)
        {
            return construirMensaje(0, "Registro no implementado", "");
        }

        public string consultar(int id_grupo)
        {
            return construirMensaje(0, "Consulta no implementado", "");
        }

        public string comprar(int id_grupo, int id_producto)
        {
            return construirMensaje(0, "Comprar no implementado", "");
        }

        private string construirMensaje(int codigo, string descripcion, string valor)
        {
            return "<header><codigo>"+codigo+"</codigo><descripcion>\""+descripcion+"\"</descripcion><valor>"+valor+"</valor></header>";
        }
    }
}
