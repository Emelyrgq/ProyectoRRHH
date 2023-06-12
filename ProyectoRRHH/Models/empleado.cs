using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace ProyectoRRHH.Models;

public partial class empleado
{
    public int id { get; set; }

    [Required(ErrorMessage = "Debe ingresar una cédula válida")]
    public string cedula { get; set; }


    [Required(ErrorMessage = "El campo 'Nombre' es requerido.")]
    public string nombre { get; set; }


    [Display(Name = "Fecha Ingreso")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "El campo {0} es requerido")]
    [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? fechaingreso { get; set; }


    [Required(ErrorMessage = "Debe seleccionar un departamento válido")]
    public string departamento { get; set; }


    [Required(ErrorMessage = "Debe seleccionar un puesto válido")]
    public string puesto { get; set; }


    [Required(ErrorMessage = "Debe ingresar un Rango Salarial válido")]

    public string salariomensual { get; set; }


    [Required(ErrorMessage = "Debe seleccionar un estado válido")]

    public string estado { get; set; }

    public virtual candidato cedulaNavigation { get; set; }

    public virtual departamento departamentoNavigation { get; set; }

    public virtual puesto puestoNavigation { get; set; }
}
