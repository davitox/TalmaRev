﻿using System;
using System.Collections.Generic;

namespace Talma.Core.Entities;

public partial class MviewAdvFjg
{
    public decimal Fjgid { get; set; }

    public decimal Ajgid { get; set; }

    public decimal Fjgdeslen { get; set; }

    public byte[] Fjgdes { get; set; } = null!;

    public decimal Hashvalue { get; set; }

    public decimal? Frequency { get; set; }

    public virtual MviewAdvAjg Ajg { get; set; } = null!;

    public virtual ICollection<MviewAdvGc> MviewAdvGcs { get; set; } = new List<MviewAdvGc>();
}
