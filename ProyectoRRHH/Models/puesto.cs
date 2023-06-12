using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace ProyectoRRHH.Models;

public partial class puesto
{
    public int id { get; set; }

    [Required(ErrorMessage = "El campo 'Nombre' es requerido.")]
    public string nombre { get; set; }


    [Required(ErrorMessage = "Debe seleccionar un nivel de riesgo válido")]
    public string nivelriesgo { get; set; }


    [Required(ErrorMessage = "El campo 'Salario minimo' es requerido.")]
    public string salariomin { get; set; }


    [Required(ErrorMessage = "El campo 'Salario máximo' es requerido.")]
    public string salariomax { get; set; }


    [Required(ErrorMessage = "Debe seleccionar un estado válido")]
    public string estado { get; set; }

    public virtual ICollection<candidato> candidatos { get; set; } = new List<candidato>();

    public virtual ICollection<empleado> empleados { get; set; } = new List<empleado>();
}
