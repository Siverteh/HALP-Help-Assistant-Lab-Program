﻿using Microsoft.Build.Framework;

namespace OperationCHAN.Models;

public class CourseLinksModel
{
    public CourseLinksModel()
    {
    }
    public CourseLinksModel(string courseLinks)
    {
        CourseLinks = courseLinks;
    }

    public int Id { get; set; }

    [Required]
    public string CourseLinks { get; set; } = String.Empty;

}