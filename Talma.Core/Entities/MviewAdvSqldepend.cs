﻿using System;
using System.Collections.Generic;

namespace Talma.Core.Entities;

public partial class MviewAdvSqldepend
{
    public decimal? Collectionid { get; set; }

    public decimal? InstId { get; set; }

    public Guid? FromAddress { get; set; }

    public decimal? FromHash { get; set; }

    public string? ToOwner { get; set; }

    public string? ToName { get; set; }

    public decimal? ToType { get; set; }

    public decimal? Cardinality { get; set; }
}
