﻿namespace FootballApp.Models;

public class Player
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public int Number { get; set; }
    public string? Position { get; set; }
}
