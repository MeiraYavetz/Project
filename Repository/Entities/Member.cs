using System;
using System.Collections.Generic;

namespace Repository.Entities;

public partial class Member
{
    public string? Id { get; set; }

    public string? FullName { get; set; }

    public string? Adress { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Telephone { get; set; }

    public string? MobilePhone { get; set; }

    public DateTime? DateOfPositiveResult { get; set; }

    public DateTime? DateOfRecovery { get; set; }
}
