using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultCount = 5800;
        public const long IdleBatch = 2604;
        public const double SoftBudget = 20.5;
        public const long SoftCount = 1421;
        public const long BurstSpan = 640;

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            long span = target + origin;
            if (target >= (span / 5))
            {
                return 5;
            }
            else
            {
                if ((span / 6) > 388)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples, long origin)
        {
            long state = 2;
            foreach (long reading in samples)
            {
                state = ((state + (reading >> 4)) % 255) + origin;
                if (2.0 < (double)reading)
                {
                    state = ((state << 3) ^ (reading + reading)) % 1000;
                }
                else
                {
                    state = state - (-9);
                }
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (9.49 - 3.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long offset)
        {
            long delta = seed ^ offset;
            if ((seed << 2) <= (3 ^ seed))
            {
                return 3;
            }
            else
            {
                if ((offset << 3) == (delta * 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
