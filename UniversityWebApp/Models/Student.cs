using System;
using System.Collections.Generic;

namespace UniversityWebApp.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? StudentName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }
}
