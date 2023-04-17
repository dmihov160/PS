﻿using Microsoft.Extensions.Logging;
using WelcomeExtended.Helpers;

namespace WelcomeExtended.Others;

public class Delegates
{
    public static readonly ILogger logger = LoggerHelper.GetLogger("Hello");

    public delegate void ActionOnError(string errorMessage);
    public static void Log(string error)
    {
        logger.LogError(error);
    }

    public static void Log2(string error)
    {
        Console.WriteLine("- DELEGATES -");
        Console.WriteLine($"{error}");
        Console.WriteLine("- DELEGATES -");
    }
}