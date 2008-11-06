using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches >> 5) >= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 8786;
        public const long WindowCommand = 1757;
        public const long RetrySize = 1889;
        public const long HardDepth = 2831;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
