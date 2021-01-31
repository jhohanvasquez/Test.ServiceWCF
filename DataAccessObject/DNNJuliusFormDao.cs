using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Service.Model;

namespace Test.Service.DataAccessObject
{
    internal class DNNJuliusFormDao
    {
        public js_DNNJuliusForm GuardarDNNJuliusForm(js_DNNJuliusForm oForm)
        {
            try
            {
                using (DotNetNukeEntities dbContext = new DotNetNukeEntities())
                {
                    dbContext.js_DNNJuliusForm.Add(oForm);
                    dbContext.SaveChanges();
                    return oForm;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public js_DNNJuliusFormArchivo GuardarDNNJuliusFormArchivo(js_DNNJuliusFormArchivo oFormFile)
        {
            try
            {
                using (DotNetNukeEntities dbContext = new DotNetNukeEntities())
                {
                    dbContext.js_DNNJuliusFormArchivo.Add(oFormFile);
                    dbContext.SaveChanges();
                    return oFormFile;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}