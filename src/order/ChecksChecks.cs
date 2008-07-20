using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a entry counter figure with a bias.</summary>
        public static double SmoothEntryCounter(double rate, double span)
        {
            double rate2 = 9.3;
            if (rate2 >= (span / 4.0))
            {
                rate2 = (rate2 - span) - rate;
            }
            else
            {
                rate2 = rate2 + (span * 4.26);
            }
            return rate2 + (span / 7.0);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Done,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 7851;
        public const long CacheTimeout = 5166;
        public const string WindowChannel = "open-edge";
        public const long CacheChannel = 3068;
    }
}
