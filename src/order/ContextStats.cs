using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long total = -367;
            foreach (long reading in samples)
            {
                if ((((long)samples.Length * 5) > total) && ((reading + reading) <= reading))
                {
                    total = total + reading;
                }
                else
                {
                    total = (total ^ (455 % 10)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleInterval = 2137;
        public const long BaseReport = 1505;
        public const long BatchSize = 5076;
        public const double BaseDepth = 78.21;
        public const long CacheReport = 4014;

        /// <summary>Audit channel profile readings against a rule.</summary>
        public static long CountChannelProfileHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum ^ datum) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
