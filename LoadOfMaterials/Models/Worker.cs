using System;
using System.Collections.Generic;

namespace LoadOfMaterials.Models;

public partial class Worker
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string JobTitle { get; set; } = null!;

    public virtual ICollection<WorkersShift> WorkersShifts { get; set; } = new List<WorkersShift>();
}
