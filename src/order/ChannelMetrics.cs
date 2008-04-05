using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 8274;
        public const long HardFilter = 930;
        public const long StepSize = 4040;

        /// <summary>Roll a context commits counter forward.</summary>
        public static long RollContextCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin ^ anchor) != (origin + origin))
                {
                    anchor = ((anchor * 3) + ((long)i ^ origin)) % 97;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 79.23;
        public const long MinFactor = 5020;
        public const long BatchSize = 3527;
        public const long RetryFactor = 8276;
        public const string StepScore = "stable-1";
    }
}
