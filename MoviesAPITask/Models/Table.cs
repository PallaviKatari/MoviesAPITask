using System;
using System.Collections.Generic;

namespace MoviesAPITask.Models;

public partial class Table
{
    public int MovieId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? Genre { get; set; }
}
