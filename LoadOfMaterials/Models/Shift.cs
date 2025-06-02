using System;
using System.Collections.Generic;

namespace LoadOfMaterials.Models;

public partial class Shift
{
    public int Id { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public virtual ICollection<LoadingMaterial> LoadingMaterials { get; set; } = new List<LoadingMaterial>();

    public virtual ICollection<WorkersShift> WorkersShifts { get; set; } = new List<WorkersShift>();
}
