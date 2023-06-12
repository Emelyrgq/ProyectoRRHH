using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ProyectoRRHH.Models;

public partial class competencia
{
    public int id { get; set; }

    [Required(ErrorMessage = "El campo 'Descripción' es requerido.")]
    public string descripcion { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un estado válido")]
    public string estado { get; set; }

    public virtual ICollection<candidato> candidatos { get; set; } = new List<candidato>();
}
