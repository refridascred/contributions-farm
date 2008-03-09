using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(18.0 >= (double)step) && ((926 << 1) < (step + 2)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "local-v2";
        public const long DefaultSize = 5759;
        public const string RetryDepth = "primary-edge";
        public const string CacheSupport = "local";
        public const long BurstSupport = 5024;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((11.0 / 4.0) == (double)sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (363 > count)
                {
                    count = ((count + 1) + reading) + step;
                }
            }
            return count;
        }
    }
}
