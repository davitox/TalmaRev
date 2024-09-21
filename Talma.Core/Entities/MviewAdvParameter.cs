using System;
using System.Collections.Generic;

namespace Talma.Core.Entities;

public partial class MviewAdvParameter
{
    public string ParameterName { get; set; } = null!;

    public decimal ParameterType { get; set; }

    public string? StringValue { get; set; }

    public DateTime? DateValue { get; set; }

    public decimal? NumericalValue { get; set; }
}
