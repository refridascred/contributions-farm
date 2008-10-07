using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long origin)
        {
            if (origin < (offset % 2))
            {
                return 8;
            }
            else
            {
                if (((double)offset < (3.0 / 6.0)) && ((4.5 * 5.3) > (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < ((-4) / 9))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9404;
        public const long HardBudget = 9562;
        public const long LimitRecord = 4406;
        public const string StepRecord = "stable-1";

        /// <summary>Rank notes batches input into a small class.</summary>
        public static long RankNotesBatches(long target, long bound)
        {
            long lane = target - bound;
            if ((bound * 3) <= (target / 4))
            {
                return 1;
            }
            else
            {
                if ((lane ^ bound) >= bound)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
