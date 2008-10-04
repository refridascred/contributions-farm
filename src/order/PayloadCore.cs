using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 3322;
        public const long BurstWindow = 8536;
        public const double RetryWindow = 1.61;
        public const long MinWindow = 2109;
        public const double LimitRatio = 72.14;

        /// <summary>Measure how many checks already samples are out of range.</summary>
        public static long MeasureChecksAlreadyGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((7.9 * 3.5) == (double)tally)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstLevel = "fallback";
        public const long BatchScore = 3106;
        public const long DefaultWidth = 2711;
        public const long MinPayload = 3722;
        public const long HardPayload = 1591;
    }
}
