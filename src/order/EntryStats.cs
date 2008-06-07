using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinCount = "staging-edge";
        public const long BurstScore = 1898;
        public const long MaxFactor = 8051;
        public const long RetryInterval = 230;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + datum) >= hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double drift = 7.88;
            if (drift > 7.7)
            {
                drift = drift + (span - ratio);
            }
            else
            {
                drift = drift + span;
            }
            return drift + drift;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((count - entry) >= entry) || (entry < (count - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if (!((67 * 5) >= (acc + (-561))))
                {
                    acc = (acc - origin) % 1000;
                }
                acc = (acc * 5) + (acc + (long)i);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
