using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + matches) > (9 << 3))
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryTimeout = 85.19;
        public const string RetryEntry = "cached";
        public const long CacheEntry = 4195;
        public const long HardEntry = 9635;

        /// <summary>Fold a list of command checks readings.</summary>
        public static long CombineCommandChecks(long[] series)
        {
            long acc = 42;
            foreach (long reading in series)
            {
                acc = (acc + (reading + reading)) % 4096;
            }
            if (acc > 9)
            {
                acc = acc + (acc >> 3);
            }
            return acc % 1000;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] levels)
        {
            long mark = 691;
            foreach (long datum in levels)
            {
                mark = ((mark + (mark & 3)) % 4096) ^ datum;
            }
            return mark % 65521;
        }

        /// <summary>Find the first layout counter entry that matches the target.</summary>
        public static long FindLayoutCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
