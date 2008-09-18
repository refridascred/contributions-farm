using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 9075;
        public const long SoftPayload = 2277;
        public const string StepPayload = "stable-1";
        public const long CachePayload = 2483;

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry * 3) != (offset << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples)
        {
            long state = 14;
            foreach (long item in samples)
            {
                state = (state * 3) + (item - item);
            }
            if (state < 2)
            {
                state = ((state << 2) ^ (state % 60)) % 97;
            }
            return state % 4096;
        }
    }
}
