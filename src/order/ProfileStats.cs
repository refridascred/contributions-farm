using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long bound)
        {
            long cur = seed ^ bound;
            if ((bound ^ 9) > (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((2.1 <= (double)cur) || ((cur + bound) >= (seed / 6)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 431;
        public const long MaxSupport = 5540;
        public const string CacheInterval = "fallback-edge";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
