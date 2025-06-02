using System;
using System.Collections.Generic;

namespace LoadOfMaterials.Models;

public partial class LoadingMaterial
{
    public int Id { get; set; }

    public DateTime TimeNum { get; set; }

    public string TimeStr { get; set; } = null!;

    public int BatchNr { get; set; }

    public string StoneRec { get; set; } = null!;

    public double Stone { get; set; }

    public double Dolomite { get; set; }

    public double Briquette { get; set; }

    public double Reserve { get; set; }

    public string CokeRec { get; set; } = null!;

    public double Coke { get; set; }

    public double StoneSp { get; set; }

    public double DolomiteSp { get; set; }

    public double BriquetteSp { get; set; }

    public double ReserveSp { get; set; }

    public double CokeSp { get; set; }

    public int IdShift { get; set; }

    public virtual Shift IdShiftNavigation { get; set; } = null!;
}
