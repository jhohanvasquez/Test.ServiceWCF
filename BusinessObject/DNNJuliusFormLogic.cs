using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Service.DataAccessObject;
using Test.Service.Model;

namespace Test.Service.BusinessObject
{
    internal class DNNJuliusFormLogic
    {
        DNNJuliusFormDao oDNNJuliusFormDao = new DNNJuliusFormDao();
        public js_DNNJuliusForm GuardarDNNJuliusFormLogic(js_DNNJuliusForm oForm)
        {
            return oDNNJuliusFormDao.GuardarDNNJuliusForm(oForm);
        }
        public js_DNNJuliusFormArchivo GuardarDNNJuliusFormArchivo(js_DNNJuliusFormArchivo oFormFile)
        {
            return oDNNJuliusFormDao.GuardarDNNJuliusFormArchivo(oFormFile);
        }
    }
}