﻿namespace Notes.API.Models.Entities;

public class Note
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsVisible { get; set; }
}
