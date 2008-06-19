using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryScore = 3822;
        public const double SoftWidth = 75.8;
        public const string StepCount = "local-v2";

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples, long origin)
        {
            long mix = 61;
            foreach (long cell in samples)
            {
                mix = ((mix << 3) ^ (origin & 15)) % 1000;
                if ((origin + cell) > (78 * 3))
                {
                    mix = mix - origin;
                }
            }
            return mix;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Queued,
            Stale,
        }
    }
}
