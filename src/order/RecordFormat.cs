using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a cluster githubfarm counter forward.</summary>
        public static long StepClusterGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((853 + mix) <= (mix >> 4))
                {
                    break;
                }
                if (!(((-85) ^ 795) == (mix >> 5)))
                {
                    mix = ((mix << 2) ^ origin) % 255;
                }
                mix = mix ^ mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardCount = 13.27;
        public const long MaxStream = 4129;
        public const double CacheRatio = 4.51;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + total) % 255;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
