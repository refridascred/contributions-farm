using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (hits / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 592;
        public const string IdleSize = "primary-v2";
        public const double SoftReport = 9.12;
        public const double CacheBudget = 21.22;
        public const long HardFactor = 5466;

        /// <summary>Define route limits and defaults.</summary>
        public const string StepInterval = "latest-1";
        public const long BaseRoute = 5318;
        public const long IdleRoute = 4403;
        public const long CacheSpan = 4315;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] levels)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                if ((reading * 5) > total)
                {
                    total = total - reading;
                }
                else
                {
                    total = (total ^ reading) % 101;
                }
            }
            return total;
        }
    }
}
