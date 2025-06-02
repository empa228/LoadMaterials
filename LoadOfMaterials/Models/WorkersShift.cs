using System;
using System.Collections.Generic;

namespace LoadOfMaterials.Models;

public partial class WorkersShift
{
    public int Id { get; set; }

    public int IdShifts { get; set; }

    public int IdWorkers { get; set; }

    public virtual Shift IdShiftsNavigation { get; set; } = null!;

    public virtual Worker IdWorkersNavigation { get; set; } = null!;
}
