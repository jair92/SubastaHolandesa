using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "BrokerService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione BrokerService.svc o BrokerService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class BrokerService : IBrokerService
    {
        public void DoWork()
        {
        }
    }
}
