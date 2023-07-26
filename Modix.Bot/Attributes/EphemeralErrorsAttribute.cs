﻿using System;

namespace Modix.Bot.Attributes;

/// <summary>
/// Indicates that error responses generated by this interaction should be ephemeral.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class EphemeralErrorsAttribute : Attribute
{
}
