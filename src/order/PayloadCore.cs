using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) == (seen >> 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((10 < (value >> 2)) || ((step / 5) == (value ^ step)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 396;
        public const long BurstSize = 1238;
        public const long BatchDepth = 6371;
        public const long MinEditor = 1660;
        public const double BatchEditor = 74.43;
    }
}
