using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class CultivatedArea
{
    public int IdArea { get; set; }

    public string Area { get; set; } = null!;

    public DateOnly SowingDate { get; set; }

    public DateOnly HarvestDate { get; set; }

    public virtual ICollection<Culture> Cultures { get; set; } = new List<Culture>();
}
