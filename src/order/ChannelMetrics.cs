using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleInterval = 6194;
        public const string BatchContributi = "stable";
        public const long MinLevel = 8912;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
