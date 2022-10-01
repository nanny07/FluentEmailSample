﻿namespace FluentEmailSample.Models;

public class TemplatedEmailContent
{
    public IEnumerable<string> Receivers { get; set; } = new List<string>();

    public IEnumerable<string> CcReceivers { get; set; } = new List<string>();

    public IEnumerable<string> BccReceivers { get; set; } = new List<string>();

    public string Subject { get; set; }

    public string Name { get; set; }
}
