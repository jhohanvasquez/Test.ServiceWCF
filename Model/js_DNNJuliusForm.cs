//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Service.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class js_DNNJuliusForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public js_DNNJuliusForm()
        {
            this.js_DNNJuliusFormArchivo = new HashSet<js_DNNJuliusFormArchivo>();
        }

        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string CodigoNiu { get; set; }

        [DataMember]
        public string Factibilidad { get; set; }

        [DataMember]
        public string NombreRazonSocial { get; set; }

        [DataMember]
        public string TipoDocumentoSolicitante { get; set; }

        [DataMember]
        public string DocumentoIdentidadSolicitante { get; set; }

        [DataMember]
        public string DireccionSolicitante { get; set; }

        [DataMember]
        public string DepartamentoSolicitante { get; set; }

        [DataMember]
        public string MunicipioSolicitante { get; set; }

        [DataMember]
        public string TelefonoSolicitante { get; set; }

        [DataMember]
        public string CelularSolicitante { get; set; }

        [DataMember]
        public string EmailSolicitante { get; set; }

        [DataMember]
        public string NombrePropietario { get; set; }

        [DataMember]
        public string TipoDocumentoPropietario { get; set; }

        [DataMember]
        public string DocumentoIdentidadPropietario { get; set; }

        [DataMember]
        public string DireccionPropietario { get; set; }

        [DataMember]
        public string DepartamentoPropietario { get; set; }

        [DataMember]
        public string MunicipioPropietario { get; set; }

        [DataMember]
        public string TelefonoPropietario { get; set; }

        [DataMember]
        public string CelularPropietario { get; set; }

        [DataMember]
        public string EmailPropietario { get; set; }

        [DataMember]
        public string NombreObra { get; set; }

        [DataMember]
        public string DireccionObra { get; set; }

        [DataMember]
        public Nullable<int> EstratoObra { get; set; }

        [DataMember]
        public string NombreIngeniero { get; set; }

        [DataMember]
        public string DocumentoIdentidadIngeniero { get; set; }

        [DataMember]
        public string MatriculaProfesionalIngeniero { get; set; }

        [DataMember]
        public Nullable<bool> Respuesta { get; set; }

        [DataMember]
        public string Observaciones { get; set; }

        [DataMember]
        public System.DateTime FechaCreacion { get; set; }

        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<js_DNNJuliusFormArchivo> js_DNNJuliusFormArchivo { get; set; }
    }
}
