﻿namespace Api.Calls.LogTo.SqlServer.ColumnStore.Domain;

public sealed record LogUserInfo
{
    public string UserId { get; set; }
    public string IdentityName { get; set; }
}