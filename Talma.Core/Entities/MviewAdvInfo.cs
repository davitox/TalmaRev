﻿using System;
using System.Collections.Generic;

namespace Talma.Core.Entities;

public partial class MviewAdvInfo
{
    public decimal Runid { get; set; }

    public decimal Seq { get; set; }

    public decimal Type { get; set; }

    public decimal Infolen { get; set; }

    public byte[]? Info { get; set; }

    public decimal? Status { get; set; }

    public decimal? Flag { get; set; }

    public virtual MviewAdvLog Run { get; set; } = null!;
}
