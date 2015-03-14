using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SubastaHolandesa
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IBroker
    {
        [OperationContract]
        string registro(int id_grupo);

        [OperationContract]
        string consultar(int id_grupo);

        [OperationContract]
        string comprar(int id_grupo, int id_producto);
    }
    
}
