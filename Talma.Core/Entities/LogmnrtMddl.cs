﻿using System;
using System.Collections.Generic;

namespace Talma.Core.Entities;

public partial class LogmnrtMddl
{
    public decimal SourceObj { get; set; }

    public string SourceRowid { get; set; } = null!;

    public string DestRowid { get; set; } = null!;
}
