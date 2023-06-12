using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataType = System.ComponentModel.DataAnnotations.DataType;
using Xunit.Sdk;

namespace ProyectoRRHH.Models;

public partial class capacitacione
{
    public int id { get; set; }

    [Required(ErrorMessage = "Debe ingresar una cédula válida")]
    public int? candidato_id { get; set; }

    [Required(ErrorMessage = "El campo 'Descripción' es requerido.")]
    public string descripcion { get; set; }

    [Required(ErrorMessage = "Debe selecconar un 'Nivel' válido")]
    public string nivel { get; set; }


    [Display(Name = "Fecha Desde")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "El campo {0} es requerido")]
    [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? fechadesde { get; set; }

    
    [Display(Name = "Fecha Desde")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "El campo {0} es requerido")]
    [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? fechahasta { get; set; }

    [Required(ErrorMessage = "El campo 'Institución' es requerido.")] 
    public string institucion { get; set; }

    public virtual candidato candidato { get; set; }
}
