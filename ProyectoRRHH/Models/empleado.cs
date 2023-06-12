using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoRRHH.Models;

public partial class empleado
{
    public int id { get; set; }

    [Required(ErrorMessage = "Debe ingresar una cédula válida")]
    public string cedula { get; set; }


    [Required(ErrorMessage = "Debe ingresar un nombre válida")]
    public string nombre { get; set; }


    [Required(ErrorMessage = "Debe ingresar una fecha válida")]
    public DateOnly? fechaingreso { get; set; }


    [Required(ErrorMessage = "Debe ingresar un departamento válida")]
    public string departamento { get; set; }


    [Required(ErrorMessage = "Debe ingresar un puesto válida")]
    public string puesto { get; set; }


    [Required(ErrorMessage = "Debe ingresar un Rango Salarial válido")]

    public string salariomensual { get; set; }


    [Required(ErrorMessage = "Debe seleccionar un estado")]

    public string estado { get; set; }

    public virtual candidato cedulaNavigation { get; set; }

    public virtual departamento departamentoNavigation { get; set; }

    public virtual puesto puestoNavigation { get; set; }
}
