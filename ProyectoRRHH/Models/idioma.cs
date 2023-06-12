using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ProyectoRRHH.Models;

public partial class idioma
{
    public int id { get; set; }

    [Required(ErrorMessage = "El campo 'Nombre' es requerido.")]
    public string nombre { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un 'Nivel' válido.")]
    public string nivel { get; set; }

    public virtual ICollection<candidato> candidatos { get; set; } = new List<candidato>();
}
