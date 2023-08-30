using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataType = System.ComponentModel.DataAnnotations.DataType;
using Xunit.Sdk;

namespace ProyectoRRHH.Models;

public partial class candidato
{
    public int id { get; set; }

    [Required(ErrorMessage = "Debe ingresar una cédula válida")]
    [RegularExpression(@"^\d{3}-\d{7}-\d{1}$", ErrorMessage = "El formato de la cédula es inválido.")]
    public string cedula { get; set; }

    [Required(ErrorMessage = "El campo 'Nombre' es requerido.")]
    public string nombre { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un puesto disponible")]
    public string puestoaspira { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un departamento válida")]
    public string departamento { get; set; }


    [Required(ErrorMessage = "Debe ingresar un salario aspiracional válido")]
    public string salarioaspira { get; set; }


    [Required(ErrorMessage = "Debe ingresar una explaboral válida")]
    public string explaboral { get; set; }

    [Required(ErrorMessage = "El campo 'Empresa' es requerido.")]
    public string empresa { get; set; }

    [Required(ErrorMessage = "El campo 'Puesto Ocupado' es requerido.")]
    public string puestoocupado { get; set; }

    [Display(Name = "Fecha Desde")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "El campo {0} es requerido")]
    [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? fechadesde { get; set; }

    [Display(Name = "Fecha Hasta")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "El campo {0} es requerido")]
    [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? fechahasta { get; set; }
    [Required(ErrorMessage = "Debe ingresar una cédula válida")]

    public string salario { get; set; }

    [Required(ErrorMessage = "El campo 'Recomendado por' es requerido.")]
    public string recomendadopor { get; set; }

    public virtual ICollection<capacitacione> capacitaciones { get; set; } = new List<capacitacione>();

    public virtual departamento departamentoNavigation { get; set; }

    public virtual empleado empleado { get; set; }

    public virtual puesto puestoaspiraNavigation { get; set; }

    public virtual ICollection<competencia> competencia { get; set; } = new List<competencia>();

    public virtual ICollection<idioma> idiomas { get; set; } = new List<idioma>();
}
