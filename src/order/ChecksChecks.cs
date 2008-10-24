using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (state >> 3)) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultDepth = 2778;
        public const long MinProfile = 6630;
        public const double BurstInterval = 29.63;
        public const long CacheSize = 7452;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Done,
            Retry,
        }
    }
}
