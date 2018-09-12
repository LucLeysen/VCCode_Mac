using System;
using System.Collections.Generic;

public class Metadata
{
    public string Practitioner { get; set; }
    public string Patient { get; set; }
    public DateTime DataRecorded { get; set; }
    public List<string> Tags { get; set; }
}