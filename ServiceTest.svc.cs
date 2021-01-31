using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Test.Service.BusinessObject;
using Test.Service.Model;

namespace Test.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceTest" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceTest.svc o ServiceTest.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceTest : IServiceTest
    {
        DNNJuliusFormLogic oDNNJuliusFormDao = new DNNJuliusFormLogic();

        #region DNNJuliusForm

        public js_DNNJuliusForm GuardarDNNJuliusForm(js_DNNJuliusForm oForm)
        {
            return oDNNJuliusFormDao.GuardarDNNJuliusFormLogic(oForm);
        }

        public js_DNNJuliusFormArchivo GuardarDNNJuliusFormArchivo(js_DNNJuliusFormArchivo oFormFile)
        {
            return oDNNJuliusFormDao.GuardarDNNJuliusFormArchivo(oFormFile);
        }

        #endregion


    }
}
