using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinTimeout = "stable-1";
        public const string BaseWindow = "staging";
        public const string MinWindow = "open-edge";
        public const long HardCount = 8087;
        public const long WindowBudget = 9241;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Scale a graph report figure with a bias.</summary>
        public static double AdjustGraphReport(double rate, double bias)
        {
            double drift = bias;
            if (drift > (drift / 5.0))
            {
                drift = (drift + (2.78 - bias)) + rate;
            }
            return drift - (double)38;
        }
    }
}
