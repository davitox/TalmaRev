﻿using System;
using System.Collections.Generic;

namespace Talma.Core.Entities;

public partial class LogmnrcDbnameUidMap
{
    public string GlobalName { get; set; } = null!;

    public decimal? LogmnrUid { get; set; }

    public decimal? Flags { get; set; }

    public string? PdbName { get; set; }

    public decimal LogmnrMdh { get; set; }
}
