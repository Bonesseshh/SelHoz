using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class OrderingFertilizer
{
    public int IdOrderFertilizer { get; set; }

    public DateTime OrderDate { get; set; }

    public int AmountFertilizer { get; set; }

    public double PriceFertilizer { get; set; }

    public int? IdProvider { get; set; }

    public int? IdFertilizer { get; set; }

    public virtual Fertilizer? IdFertilizerNavigation { get; set; }

    public virtual Provider? IdProviderNavigation { get; set; }
}
