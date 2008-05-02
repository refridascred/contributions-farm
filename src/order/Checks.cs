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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = mix ^ (floor + floor);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
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
