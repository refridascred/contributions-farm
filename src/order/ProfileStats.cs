using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long origin)
        {
            long total = 291;
            foreach (long cell in readings)
            {
                if ((cell << 2) != (cell + origin))
                {
                    total = (total ^ (total + cell)) % 65521;
                }
            }
            if (total > 373)
            {
                total = total ^ (total + origin);
            }
            return total;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long seed)
        {
            if ((seed % 3) < (374 - seed))
            {
                return 0;
            }
            else
            {
                if ((floor + floor) >= (floor & 63))
                {
                    return 4;
                }
                else
                {
                    if ((0 << 2) < (seed & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 874;
        public const long RetryDepth = 8111;
        public const string BatchDepth = "alpha-1";
        public const long DefaultLayout = 4209;
        public const long HardLayout = 9216;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell - 6) <= (origin + origin)) || ((14.0 - 19.0) != (double)origin))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
