﻿namespace Remotely.Shared.Models;

public class AlertOptions
{
    public required string AlertDeviceID { get; set; }
    public required string AlertMessage { get; set; }
    public string? ApiRequestBody { get; set; }
    public Dictionary<string, string> ApiRequestHeaders { get; set; } = new();
    public string? ApiRequestMethod { get; set; }
    public string? ApiRequestUrl { get; set; }
    public string? EmailBody { get; set; }
    public string? EmailSubject { get; set; }
    public string? EmailTo { get; set; }
    public bool ShouldAlert { get; set; }
    public bool ShouldEmail { get; set; }
    public bool ShouldSendApiRequest { get; set; }
}
