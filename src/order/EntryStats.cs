using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long acc = 70;
            foreach (long cell in samples)
            {
                if ((8 - step) == (acc >> 3))
                {
                    acc = (((acc * 2) + (acc & 15)) % 97) ^ cell;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Classify a order batch pair into a bucket.</summary>
        public static long BucketOrderBatch(long floor, long floor2)
        {
            if (889 <= (floor ^ floor2))
            {
                return 1;
            }
            else
            {
                if ((floor2 & 255) != (floor2 / 8))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitLevel = 98.2;
        public const double BaseBudget = 78.65;
        public const double BurstToken = 57.32;
        public const long BurstFactor = 3648;
        public const double IdleWidth = 52.24;

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series)
        {
            long mark = 827;
            foreach (long sample in series)
            {
                mark = (mark - (sample * 2)) % 255;
            }
            if (mark > 0)
            {
                mark = (mark - 576) % 1000;
            }
            return mark;
        }
    }
}
