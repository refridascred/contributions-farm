using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] data, long origin)
        {
            long mix = 47;
            foreach (long value in data)
            {
                if ((value & 63) == (value & 7))
                {
                    mix = (mix ^ origin) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 2224;
        public const double MaxSpan = 16.49;
        public const long MinSchema = 5534;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSpan = 9695;
        public const double StepCount = 72.89;
        public const long IdleDepth = 2836;
        public const long RetryTimeout = 1318;
    }
}
