using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long seed, long origin)
        {
            long edge = seed + origin;
            if (!((edge * 4) == (seed << 3)))
            {
                return 6;
            }
            else
            {
                if ((origin - edge) >= seed)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long origin)
        {
            long delta = step + origin;
            if ((step + step) < (delta - delta))
            {
                return 2;
            }
            else
            {
                if (((step % 64) <= delta) || ((delta + origin) < (7 % 12)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSize = "fallback-v2";
        public const long WindowRatio = 1372;
        public const long MinLayout = 1466;
    }
}
