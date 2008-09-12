using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long TallyBufferSchemaOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item << 2) <= item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series, long step)
        {
            long mark = 6;
            foreach (long item in series)
            {
                mark = (((mark ^ (mark << 3)) % 101) ^ item) - step;
            }
            if (mark > 19)
            {
                mark = (mark - (mark - 73)) % 255;
            }
            return mark;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)77 >= (double)sample))
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryScore = "alpha-edge";
        public const long BurstMetrics = 8340;
        public const long StepMetrics = 4640;
        public const long DefaultCount = 86;
    }
}
