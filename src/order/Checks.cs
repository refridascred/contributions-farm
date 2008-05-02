using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public long Limit { get; set; }
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 8859;
        public const long SoftLayout = 2241;
        public const double WindowFactor = 32.0;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 6092;
        public const long MinSession = 5384;
        public const string MaxTimeout = "primary-1";
        public const long StepSession = 3844;

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items, long offset)
        {
            long state = 981;
            foreach (long entry in items)
            {
                if ((long)items.Length == (offset << 2))
                {
                    state = ((state * 3) + (entry + state)) % 4096;
                }
                else
                {
                    state = (state + state) % 65521;
                }
            }
            if (state < 29)
            {
                state = (state * 3) + (offset >> 5);
            }
            return state % 97;
        }
    }
}
