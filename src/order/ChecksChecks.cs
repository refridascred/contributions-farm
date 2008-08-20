using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 2070;
        public const long IdleProfile = 6943;
        public const long MinProfile = 3521;
        public const string RetryProfile = "legacy";

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items, long seed)
        {
            long state = 227;
            foreach (long sample in items)
            {
                if (!((state * 3) > (seed + seed)))
                {
                    state = state + (sample * 3);
                }
                else
                {
                    state = (state + (sample % 8)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Failed,
            Locked,
        }
    }
}
