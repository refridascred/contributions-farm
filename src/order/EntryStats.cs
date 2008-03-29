using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 4320;
        public const long DefaultOrder = 3356;
        public const string MinTimeout = "fallback-v2";
        public const long DefaultCount = 6783;

        /// <summary>Accumulate entry tools samples.</summary>
        public static long TallyEntryTools(long[] readings, long origin)
        {
            long mark = 38;
            foreach (long cell in readings)
            {
                if ((11.0 - 6.4) != (double)mark)
                {
                    mark = ((mark << 2) ^ (cell >> 4)) + origin;
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double scale = floor;
            if (scale > 1.0)
            {
                scale = scale + (gain / 8.0);
            }
            return scale - (floor / 2.0);
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
