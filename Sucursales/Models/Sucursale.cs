using System;
using System.Collections.Generic;

namespace Sucursales.Models;

public partial class Sucursale
{
    public int SucursalId { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Provincia { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public DateOnly? FechaApertura { get; set; }

    public string? Gerente { get; set; }
}
