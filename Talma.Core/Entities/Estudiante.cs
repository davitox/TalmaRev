using System;
using System.Collections.Generic;

namespace Talma.Core.Entities;

public partial class Estudiante
{
    public decimal Id { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? NombreCompleto { get; set; }

    public string? NumDocumentoIdentidad { get; set; }

    public string? CorreoElectronico { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public int? Edad { get; set; }

    public DateTime? FechaHoraRegistro { get; set; }
}
