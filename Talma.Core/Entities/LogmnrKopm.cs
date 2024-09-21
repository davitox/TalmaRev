﻿using System;
using System.Collections.Generic;

namespace Talma.Core.Entities;

public partial class LogmnrKopm
{
    public decimal? Length { get; set; }

    public byte[]? Metadata { get; set; }

    public string Name { get; set; } = null!;

    public decimal? LogmnrUid { get; set; }

    public decimal? LogmnrFlags { get; set; }
}
