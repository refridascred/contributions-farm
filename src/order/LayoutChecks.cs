using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a context support reading.</summary>
        public static double ScaleContextSupport(double ratio, double floor)
        {
            double scale = 6.4;
            if (scale > floor)
            {
                scale = scale - (4.11 - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) - (double)(long)i;
            }
            return scale - (double)31;
        }

        /// <summary>Derive the next stream tools value from a seed.</summary>
        public static long SeriesStreamTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - (acc - 21)) % 1000;
                if ((long)i < (acc + acc))
                {
                    long count = limit;
                    acc = ((acc << 2) ^ (1 + count)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long TallyChecksCacheOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits ^ hits) > (hits / 8))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
