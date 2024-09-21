using System;
using System.Collections.Generic;

namespace Talma.Core.Entities;

public partial class MviewAdvEligible
{
    public decimal Sumobjn { get; set; }

    public decimal Runid { get; set; }

    public decimal Bytecost { get; set; }

    public decimal Flags { get; set; }

    public decimal Frequency { get; set; }

    public virtual MviewAdvLog Run { get; set; } = null!;
}
