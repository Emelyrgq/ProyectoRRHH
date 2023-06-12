using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoRRHH.Models;

public partial class empleado
{
    public int id { get; set; }

    public string cedula { get; set; }

    public string nombre { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateOnly? fechaingreso { get; set; }

    public string departamento { get; set; }

    public string puesto { get; set; }

    public string salariomensual { get; set; }

    public string estado { get; set; }

    public virtual candidato cedulaNavigation { get; set; }

    public virtual departamento departamentoNavigation { get; set; }

    public virtual puesto puestoNavigation { get; set; }
}
