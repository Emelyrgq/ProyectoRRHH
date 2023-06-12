using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace ProyectoRRHH.Models;

public partial class departamento
{
    public int id { get; set; }

    [Required(ErrorMessage = "El campo 'Departamento' es requerido.")]
    public string departamento1 { get; set; }

    public virtual ICollection<candidato> candidatos { get; set; } = new List<candidato>();

    public virtual ICollection<empleado> empleados { get; set; } = new List<empleado>();
}
