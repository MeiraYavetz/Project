using System;
using System.Collections.Generic;

namespace Repository.Entities;

public partial class Vaccine
{
    public int IdVaccine { get; set; }

    public DateTime? DateOfVaccine { get; set; }

    public string? VaccineManuFacturer { get; set; }

    public string? IdMember { get; set; }
}
