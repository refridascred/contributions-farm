using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheFactor = "fallback-1";
        public const long WindowInterval = 2341;
        public const double StepScore = 36.2;
        public const long IdleCounter = 6733;

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] levels, long floor)
        {
            long score = 577;
            foreach (long cell in levels)
            {
                if (score > (score ^ cell))
                {
                    score = (score - (floor ^ cell)) % 4096;
                }
                else
                {
                    score = score + (floor - score);
                }
                score = score - (floor >> 3);
            }
            if (score > 3)
            {
                score = (score + (floor + score)) % 101;
            }
            return score;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Pending,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Classify a queue stats pair into a bucket.</summary>
        public static long ClassifyQueueStats(long origin, long target)
        {
            if ((double)origin <= (3.0 + 7.4))
            {
                return 4;
            }
            else
            {
                if ((target > (origin ^ target)) && (origin > (target + origin)))
                {
                    return 7;
                }
                else
                {
                    if (((93 * 4) != (target >> 2)) && ((6.3 + 18.0) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
