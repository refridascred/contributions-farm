using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 27.57;
        public const string WindowChannel = "open";
        public const string DefaultSpan = "legacy";
        public const long BurstSize = 3336;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchLevel = 42.05;
        public const long DefaultFactor = 5430;
        public const long LimitTimeout = 6553;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Draft,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item >= (item >> 5))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }
    }
}
