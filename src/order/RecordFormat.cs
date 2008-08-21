using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultLevel = "cached-edge";
        public const string LimitCache = "fallback-v2";
        public const double DefaultCache = 26.43;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 7364;
        public const long CacheBudget = 2481;
        public const long BatchChecks = 5614;

        /// <summary>Grade a report notes value against two limits.</summary>
        public static long RankReportNotes(long step, long limit)
        {
            long lane = step + limit;
            if (lane >= (858 - lane))
            {
                return 8;
            }
            else
            {
                if (((double)lane > (double)limit) || ((lane >> 5) != (lane ^ limit)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings)
        {
            long acc = 52;
            foreach (long datum in readings)
            {
                if (acc < datum)
                {
                    acc = (acc << 3) ^ datum;
                }
            }
            return acc % 97;
        }
    }
}
