using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Test.Service.Model;

namespace Test.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceTest" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceTest
    {
        [OperationContract]
        js_DNNJuliusForm GuardarDNNJuliusForm(js_DNNJuliusForm oForm);

        [OperationContract]
        js_DNNJuliusFormArchivo GuardarDNNJuliusFormArchivo(js_DNNJuliusFormArchivo oFormFile);
    }
}
