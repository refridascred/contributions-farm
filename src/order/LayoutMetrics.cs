using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepFactor = "latest-edge";
        public const long DefaultCount = 1937;
        public const long DefaultBuffer = 6718;
        public const double MaxBuffer = 17.32;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark << 2) ^ (target >> 4);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Paused,
            Closed,
            Retry,
        }
    }
}
