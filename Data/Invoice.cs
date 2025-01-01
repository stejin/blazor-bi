﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public int CustomerId { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string? BillingAddress { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingState { get; set; }

    public string? BillingCountry { get; set; }

    public string? BillingPostalCode { get; set; }

    public double Total { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

    public string ItemList() {
        StringBuilder result = new StringBuilder();
        InvoiceItems.ToList().ForEach(i => result.Append(i.Track.Name).Append(", "));
        if (result.Length > 2)
            result.Remove(result.Length - 2, 2);
        return result.ToString();
    }
}
