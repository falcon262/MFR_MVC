using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Client
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsSecRegistrant { get; set; }

    public bool IsListedOnStockExchange { get; set; }

    public bool  IsListedOnGhanaAlternativeMarket { get; set; }

    public RotationLaw RotationLaw { get; set; }

    public string PredecessorAuditor { get; set; }

    public string GlobalGroupAuditor { get; set; }

    public string ParentCompanyCountry { get; set; }

    public DateTime ExpectedRotationYear{get; set;}

    public string ContactName { get; set; }

    public string ContactPhone { get; set; }

    public string ContactEmail { get; set; }

    public bool IsContactAlumni { get; set; }

    public string CeoName { get; set; }

    public string BoardChairName { get; set; }

    public string CfoName { get; set; }

    public string AltContactName { get; set; }
#nullable enable
    public string? AltContactPhone { get; set; }

    public string? AltContactEmail { get; set; }
#nullable disable

    public bool IsAltContactAlumni{ get; set; }

    public bool IsClientSalesforce { get; set; }

    public Industry Industry { get; set; }

    public Industry SubIndustry { get; set; }

    public ICollection<Service> Services{ get; set; }
    
}