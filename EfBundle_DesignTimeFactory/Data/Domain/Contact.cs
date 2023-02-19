﻿namespace EfBundle_DesignTimeFactory.Data.Domain;

#pragma warning disable CS8618
public sealed class Contact
{
  public int Id { get; set; }

  public string Name { get; set; }

  public string? Number { get; set; }

  public string? Email { get; set; }
}
