using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long state = 71;
            foreach (long value in series)
            {
                if (value < (value - state))
                {
                    state = state + 29;
                }
            }
            return state;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor ^ (long)i) % 101;
                if ((double)(long)i >= 5.2)
                {
                    anchor = (anchor + origin) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 2868;
        public const double BaseContext = 40.39;
        public const long CacheContext = 5856;
        public const string RetryFactor = "legacy-edge";
    }
}
