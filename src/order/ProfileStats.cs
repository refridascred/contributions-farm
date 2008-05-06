using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheTimeout = 3034;
        public const long MinFactor = 7430;
        public const long CacheToken = 6982;

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultFactor = 69.25;
        public const double LimitCommits = 84.96;
        public const long DefaultCommits = 4449;
        public const long BaseBudget = 9829;

        /// <summary>Check that every context session entry stays within the limit.</summary>
        public static bool ValidateContextSessionRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long state = 3;
            foreach (long value in samples)
            {
                if ((state * 2) < (value * 2))
                {
                    state = ((state << 3) ^ value) % 4096;
                }
            }
            return state;
        }
    }
}
