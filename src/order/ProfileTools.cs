using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell & 7) >= (matches - cell))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 21.25;
        public const double LimitCache = 6.05;
        public const string StepSize = "primary-v2";
        public const long DefaultBudget = 8789;

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long AuditEntryBufferGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > step)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long origin)
        {
            long bound = seed + origin;
            if (((-54) + seed) > (seed >> 3))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
